using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Dorothy.Data;

namespace Dorothy.UI
{
  public partial class ItemDlg : Form
  {
    //-------------------------------------------------------------------------

    private Item _item;

    //-------------------------------------------------------------------------

    public ItemDlg( Item item )
    {
      _item = item;

      InitializeComponent();
    }

    //-------------------------------------------------------------------------

    private void ItemDlg_Load( object sender, EventArgs e )
    {
      uiName.Text = _item.Name;
      uiDescription.Text = _item.Description;

      if( _item.Parent != null )
      {
        uiParent.Text = _item.Parent.Name;
      }

      foreach( Item child in _item.Children )
      {
        uiChildren.Items.Add( child );
      }

      foreach( Tag tag in _item.Tags )
      {
        uiTags.Items.Add( tag );
      }
    }

    //-------------------------------------------------------------------------

    private void uiSelectParent_Click( object sender, EventArgs e )
    {
      List<Item> items = new List<Item>( Item.Items );
      items.Remove( _item );

      List<Item> selectedItems = new List<Item>();
      if( _item.Parent != null )
      {
        selectedItems.Add( _item.Parent );
      }

      SelectItemDlg dlg =
        new SelectItemDlg(
          items,
          selectedItems,
          false,
          "Select the Parent Item" );

      dlg.ShowDialog( this );

      if( dlg.DialogResult == DialogResult.Cancel )
      {
        dlg.Dispose();
        return;
      }

      _item.SetParent( dlg.FirstSelectedItem );
      
      dlg.Dispose();

      if( _item.Parent != null )
      {
        uiParent.Text = _item.Parent.Name;
      }
      else
      {
        uiParent.Text = "";
      }
    }

    //-------------------------------------------------------------------------

    private void uiClose_Click( object sender, EventArgs e )
    {
      // Validate.
      if( uiName.Text.Length == 0 )
      {
        MessageBox.Show(
          "Please enter a name.",
          "Name",
          MessageBoxButtons.OK,
          MessageBoxIcon.Information );
        return;
      }

      // Update the item.
      _item.Name = uiName.Text;
      _item.Description = uiDescription.Text;
    }

    //-------------------------------------------------------------------------
  }
}
