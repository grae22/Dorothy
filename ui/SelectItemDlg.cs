﻿using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Dorothy.Data;

namespace Dorothy.UI
{
  public partial class SelectItemDlg : Form
  {
    //-------------------------------------------------------------------------

    private List<Item> _items;

    //-------------------------------------------------------------------------

    public SelectItemDlg(
      List<Item> items,
      List<Item> selectedItems,
      bool multiSelect,
      string title )
    {
      InitializeComponent();

      _items = items;
      Text = title;
      uiItems.SelectionMode = ( multiSelect ? SelectionMode.MultiExtended : SelectionMode.One );
      
      PopulateItemsList();

      foreach( Item item in selectedItems )
      {
        if( uiItems.Items.Contains( item ) )
        {
          uiItems.SelectedItems.Add( item );
        }
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

    private void uiFilter_TextChanged( object sender, EventArgs e )
    {
      PopulateItemsList();
    }

    //-------------------------------------------------------------------------

    private void PopulateItemsList()
    {
      uiItems.Items.Clear();

      string filter = uiFilter.Text.ToLower();

      foreach( Item item in _items )
      {
        if( filter.Length == 0 ||
            item.ToString().ToLower().Contains( filter ) )
        {
          uiItems.Items.Add( item );
        }
      }
    }

    //-------------------------------------------------------------------------
  }
}
