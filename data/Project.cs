using System;
using System.Xml;

namespace Dorothy.Data
{
  public class Project
  {
    //-------------------------------------------------------------------------

    private string _fullFilename;

    //-------------------------------------------------------------------------

    public bool LoadFromFile( string fullFilename )
    {
      _fullFilename = fullFilename;

      try
      {
        XmlDocument doc = new XmlDocument();
        doc.Load( fullFilename );

        Tag.CreateTagsFromCollectionXml( doc.SelectSingleNode( "Project/TagCollection" ) as XmlElement );
        Item.CreateItemsFromCollectionXml( doc.SelectSingleNode( "Project/ItemCollection" ) as XmlElement );

        Program.Log.AddInfo( "Project loaded '" + _fullFilename + "'." );
      }
      catch( Exception ex )
      {
        Program.Log.AddError(
          "Error while loading project from '" + fullFilename + "': " + ex.Message );
        return false;
      }

      return true;
    }

    //-------------------------------------------------------------------------

    public bool SaveToFile()
    {
      try
      {
        XmlDocument doc = new XmlDocument();

        XmlElement rootElement = doc.CreateElement( "Project" );
        doc.AppendChild( rootElement );

        Tag.AddItemCollectionXml( rootElement );
        Item.AddItemCollectionXml( rootElement );

        doc.Save( _fullFilename );

        Program.Log.AddInfo( "Project saved '" + _fullFilename + "'." );
      }
      catch( Exception ex )
      {
        Program.Log.AddError(
          "Error while saving project to '" + _fullFilename + "': " + ex.Message );
        return false;
      }

      return true;
    }

    //-------------------------------------------------------------------------
  }
}
