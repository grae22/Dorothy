/*
  NOTE: The parent/child dependency is inverted - parent items 'depend' on their children.
*/

using System;
using System.Collections.Generic;
using System.Xml;
using Dorothy.Utils;

namespace Dorothy.Data
{
  public class Item
  {
    //-------------------------------------------------------------------------

    //-- Statics.
    private static int _nextId = 0;
    public static List<Item> Items = new List<Item>();

    //-- Instance properties.
    public int Id { get; private set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Item Parent { get; private set; }
    public List<Item> Children { get; private set; }
    public List<Tag> Tags { get; set; }

    // Instance vars used when loading from xml.
    private int _parentId = -1;
    private List<int> _tagsId;

    // STATIC METHODS =========================================================

    public static Item CreateItem(
      string name,
      string description,
      Item parent,
      List<Tag> tags )
    {
      Item item = new Item();

      item.Id = _nextId++;
      item.Name = name;
      item.Description = description;
      item.Parent = parent;
      item.Tags = tags;

      Items.Add( item );

      return item;
    }

    //-------------------------------------------------------------------------

    // The ResolveItemReferences() method must be called after loading
    // all items from xml or items will not have references to their parents,
    // children and tags.

    private static Item CreateItem( XmlElement itemElement )
    {
      Item item = new Item();
      
      if( item.SetFromXml( itemElement ) )
      {
        if( _nextId <= item.Id )
        {
          _nextId = item.Id + 1;
        }

        Items.Add( item );
        return item;
      }

      return null;
    }

    //-------------------------------------------------------------------------

    public static void RemoveItem( Item item )
    {
      Items.Remove( item );
    }

    //-------------------------------------------------------------------------

    public static void RemoveAllItems()
    {
      Items.Clear();
    }

    //-------------------------------------------------------------------------

    // Adds the item collection (with all items' xml) to the passed root element.

    public static void AddItemCollectionXml( XmlElement rootElement )
    {
      // Create the collection element.
      XmlElement itemCollection =
        rootElement.OwnerDocument.CreateElement( "ItemCollection" );

      rootElement.AppendChild( itemCollection );

      // Add the items' xml.
      foreach( Item item in Items )
      {
        item.AddXml( itemCollection );
      }
    }

    //-------------------------------------------------------------------------

    // Tags must be created before this is called.

    public static void CreateItemsFromCollectionXml( XmlElement itemCollection )
    {
      RemoveAllItems();

      foreach( XmlElement itemElement in itemCollection.GetElementsByTagName( "Item" ) )
      {
        CreateItem( itemElement );
      }

      ResolveItemReferences();
    }

    //-------------------------------------------------------------------------

    // Must be called after loading items from xml. Updates all items to have
    // references to their parents, children and tags.

    private static void ResolveItemReferences()
    {
      foreach( Item current in Items )
      {
        // Find the current item's parent.
        if( current._parentId > -1 )
        {
          foreach( Item item in Items )
          {
            if( item.Id == current._parentId )
            {
              current.SetParent( item );
              break;
            }
          }

          // Not found?
          if( current.Parent == null )
          {
            Program.Log.AddError(
              "Failed to resolve parent reference for item '" + current.Name + "." );
          }
        }

        // Find the current item's tags.
        foreach( int tagId in current._tagsId )
        {
          Tag tag = Tag.FindTag( tagId );

          if( tag == null )
          {
            Program.Log.AddError(
              "Failed to resolve tag with id '" + tagId.ToString() + "' for item '" + current.Name + "'." );
            continue;
          }

          current.Tags.Add( tag );
        }
      }
    }

    // INSTANCE METHODS =======================================================

    // Instantiate with the static CreateItem() method.

    private Item()
    {
      Children = new List<Item>();
      Tags = new List<Tag>();
    }

    //-------------------------------------------------------------------------

    public void AddXml( XmlElement rootElement )
    {
      try
      {
        XmlDocument doc = rootElement.OwnerDocument;

        // Create item's xml element.
        XmlElement itemElement = doc.CreateElement( "Item" );
        rootElement.AppendChild( itemElement );

        // Item id.
        itemElement.Attributes.Append( doc.CreateAttribute( "id" ) );
        itemElement.Attributes[ "id" ].Value = Id.ToString();
      
        // Item name.
        itemElement.AppendChild(
          Xml.CreateElementWithValue(
            doc, "Name", Name ) );

        // Item description.
        itemElement.AppendChild(
          Xml.CreateElementWithValue(
            doc, "Description", Description ) );

        // Parent.
        if( Parent != null )
        {
          itemElement.AppendChild(
            Xml.CreateElementWithValue(
              doc, "ParentId", Parent.Id.ToString() ) );
        }
        else
        {
          itemElement.AppendChild(
            Xml.CreateElementWithValue(
              doc, "ParentId", "-1" ) );
        }

        // Tags.
        XmlElement tagCollection = doc.CreateElement( "TagCollection" );
        itemElement.AppendChild( tagCollection );

        foreach( Tag tag in Tags )
        {
          tagCollection.AppendChild(
            Xml.CreateElementWithValue(
              doc, "TagId", tag.Id.ToString() ) );
        }
      }
      catch( Exception ex )
      {
        Program.Log.AddError(
          "Error while adding xml for item '" + Name + "': " + ex.Message );
      }
    }

    //-------------------------------------------------------------------------

    private bool SetFromXml( XmlElement itemElement )
    {
      try
      {
        Id = int.Parse( itemElement.Attributes[ "id" ].Value );
        Name = Xml.GetChildElementValue( itemElement, "Name" );
        Description = Xml.GetChildElementValue( itemElement, "Description" );
        _parentId = int.Parse( Xml.GetChildElementValue( itemElement, "ParentId" ) );

        XmlElement tagCollection = itemElement.SelectSingleNode( "TagCollection" ) as XmlElement;
        if( tagCollection != null )
        {
          _tagsId = new List<int>();

          foreach( XmlElement tagIdElement in tagCollection.ChildNodes )
          {
            _tagsId.Add( int.Parse( tagIdElement.InnerText ) );
          }
        }
      }
      catch( Exception ex )
      {
        Program.Log.AddError(
          "Error while creating item '" + Name + "': " + ex.Message );
        return false;
      }

      return true;
    }

    //-------------------------------------------------------------------------

    public override string ToString()
    {
      return Name;
    }

    //-------------------------------------------------------------------------

    // Populates the list with items which are dependent

    public void GetDependents( List<Item> dependents )
    {
      GetDependentsRecursive( dependents );
      dependents.Remove( this );
    }

    //-------------------------------------------------------------------------

    private void GetDependentsRecursive( List<Item> dependents )
    {
      dependents.Add( this );

      foreach( Item child in Children )
      {
        child.GetDependents( dependents );
      }
    }

    //-------------------------------------------------------------------------

    public void SetParent( Item parent )
    {
      // Unlink the old parent.
      if( Parent != null )
      {
        Parent.Children.Remove( this );
      }

      // Store ref to the new parent.
      Parent = parent;

      // Link new parent (if one) to this item.
      if( parent != null )
      {
        parent.Children.Add( this );
      }
    }

    //-------------------------------------------------------------------------
  }
}
