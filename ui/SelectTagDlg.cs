using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Dorothy.Data;

namespace Dorothy.UI
{
  public partial class SelectTagDlg : Form
  {
    //-------------------------------------------------------------------------

    public List<Tag> SelectedTags { get; set; }

    private List<Tag> _tags;

    //-------------------------------------------------------------------------

    public SelectTagDlg(
      List<Tag> tags,
      List<Tag> selectedTags )
    {
      SelectedTags = new List<Data.Tag>();

      InitializeComponent();

      _tags = tags;
      
      PopulateTagsList();

      foreach( Tag tag in selectedTags )
      {
        if( uiTags.Items.Contains( tag ) )
        {
          uiTags.SelectedItems.Add( tag );
        }
      }
    }

    //-------------------------------------------------------------------------

    public Item FirstSelectedItem
    {
      get
      {
        return uiTags.SelectedItem as Item;
      }
    }

    //-------------------------------------------------------------------------

    private void uiOK_Click( object sender, EventArgs e )
    {
      SelectedTags.Clear();

      foreach( Tag tag in uiTags.SelectedItems )
      {
        SelectedTags.Add( tag );
      }

      DialogResult = DialogResult.OK;

      Close();
    }

    //-------------------------------------------------------------------------

    private void uiFilter_TextChanged( object sender, EventArgs e )
    {
      PopulateTagsList();
    }

    //-------------------------------------------------------------------------

    private void PopulateTagsList()
    {
      uiTags.Items.Clear();

      string filter = uiFilter.Text.ToLower();

      foreach( Tag tag in _tags )
      {
        if( filter.Length == 0 ||
            tag.ToString().ToLower().Contains( filter ) )
        {
          uiTags.Items.Add( tag );
        }
      }
    }

    //-------------------------------------------------------------------------
  }
}
