using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Dorothy.Data;

namespace Dorothy.UI
{
  public partial class SelectItemDlg : Form
  {
    //-------------------------------------------------------------------------

    public SelectItemDlg(
      List<Item> items,
      List<Item> selectedItems,
      bool multiSelect,
      string title )
    {
      InitializeComponent();

      Text = title;
      uiItems.SelectionMode = ( multiSelect ? SelectionMode.MultiExtended : SelectionMode.One );

      foreach( Item item in items )
      {
        uiItems.Items.Add( item );
      }

      foreach( Item item in selectedItems )
      {
        uiItems.SelectedItems.Add( item );
      }
    }

    //-------------------------------------------------------------------------

    public Item FirstSelectedItem
    {
      get
      {
        return uiItems.SelectedItem as Item;
      }
    }

    //-------------------------------------------------------------------------

    private void uiOK_Click( object sender, EventArgs e )
    {
      DialogResult = DialogResult.OK;
      Close();
    }

    //-------------------------------------------------------------------------
  }
}
