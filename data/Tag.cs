using System;
using System.Collections.Generic;
using System.Xml;
using Dorothy.Utils;

namespace Dorothy.Data
{
  public class Tag
  {
    //-------------------------------------------------------------------------

    // Statics.
    private static int _nextId = 0;
    public static List<Tag> Tags = new List<Tag>();

    // Instance properties.
    public int Id { get; private set; }
    public string Name { get; set; }
    public string Description { get; set; }

    // STATIC METHODS =========================================================

    public static Tag CreateTag(
      string name,
      string description )
    {
      Tag tag = new Tag();

      tag.Id = _nextId++;
      tag.Name = name;
      tag.Description = description;

      Tags.Add( tag );

      return tag;
    }

    //-------------------------------------------------------------------------

    public static Tag CreateTag( XmlElement tagElement )
    {
      Tag tag = new Tag();
      
      if( tag.SetFromXml( tagElement ) )
      {
        if( _nextId <= tag.Id )
        {
          _nextId = tag.Id + 1;
        }

        Tags.Add( tag );
        return tag;
      }

      return null;
    }

    //-------------------------------------------------------------------------

    public static void RemoveTag( Tag tag )
    {
      Tags.Remove( tag );
    }

    //-------------------------------------------------------------------------

    public static void RemoveAllTags()
    {
      Tags.Clear();
    }

    //-------------------------------------------------------------------------

    // Adds the tag collection (with all tags' xml) to the passed root element.

    public static void AddItemCollectionXml( XmlElement rootElement )
    {
      // Create the collection element.
      XmlElement tagCollection =
        rootElement.OwnerDocument.CreateElement( "TagCollection" );

      rootElement.AppendChild( tagCollection );

      // Add the tags' xml.
      foreach( Tag tag in Tags )
      {
        tag.AddXml( tagCollection );
      }
    }

    //-------------------------------------------------------------------------

    public static void CreateTagsFromCollectionXml( XmlElement tagCollection )
    {
      RemoveAllTags();

      foreach( XmlElement tagElement in tagCollection.GetElementsByTagName( "Tag" ) )
      {
        CreateTag( tagElement );
      }
    }

    //-------------------------------------------------------------------------

    public static Tag FindTag( int id )
    {
      foreach( Tag tag in Tags )
      {
        if( tag.Id == id )
        {
          return tag;
        }
      }

      return null;
    }

    // INSTANCE METHODS =======================================================

    // Instantiate using the static CreateTag() method.

    private Tag()
    {

    }

    //-------------------------------------------------------------------------

    public void AddXml( XmlElement rootElement )
    {
      try
      {
        XmlDocument doc = rootElement.OwnerDocument;

        // Create item's xml element.
        XmlElement tagElement = doc.CreateElement( "Tag" );
        rootElement.AppendChild( tagElement );

        // Item id.
        tagElement.Attributes.Append( doc.CreateAttribute( "id" ) );
        tagElement.Attributes[ "id" ].Value = Id.ToString();
      
        // Item name.
        tagElement.AppendChild(
          Xml.CreateElementWithValue(
            doc, "Name", Name ) );

        // Item description.
        tagElement.AppendChild(
          Xml.CreateElementWithValue(
            doc, "Description", Description ) );
      }
      catch( Exception ex )
      {
        Program.Log.AddError(
          "Error while adding xml for tag '" + Name + "': " + ex.Message );
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
      }
      catch( Exception ex )
      {
        Program.Log.AddError(
          "Error while creating tag '" + Name + "': " + ex.Message );
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
  }
}
