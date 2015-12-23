using System;
using System.Xml;

namespace Dorothy.Utils
{
  class Xml
  {
    //-------------------------------------------------------------------------

    public static XmlElement CreateElementWithValue(
      XmlDocument doc,
      string elementName,
      string elementValue )
    {
      XmlElement element = doc.CreateElement( elementName );
      element.InnerText = elementValue;
      return element;
    }

    //-------------------------------------------------------------------------

    public static string GetChildElementValue(
      XmlElement parentElement,
      string elementName )
    {
      return parentElement.SelectSingleNode( elementName ).InnerText;
    }

    //-------------------------------------------------------------------------
  }
}
