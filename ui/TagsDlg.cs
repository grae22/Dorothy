using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using Dorothy.Data;

namespace Dorothy.UI
{
  public partial class TagsDlg : Form
  {
    //-------------------------------------------------------------------------

    public TagsDlg()
    {
      InitializeComponent();
    }

    //-------------------------------------------------------------------------

    private void TagsDlg_Load( object sender, EventArgs e )
    {
      PopulateTagsList();
    }

    //-------------------------------------------------------------------------

    private void PopulateTagsList()
    {
      uiTags.Items.Clear();

      foreach( Tag tag in Dorothy.Data.Tag.Tags )
      {
        uiTags.Items.Add( tag );
      }
    }

    //-------------------------------------------------------------------------

    private void uiAdd_Click( object sender, EventArgs e )
    {
      uiTags.SelectedItem = null;

      uiName.Text = "NewTag";
      uiDescription.Text = "Describe this tag...";

      uiName.Focus();
    }

    //-------------------------------------------------------------------------

    private void uiName_Enter( object sender, EventArgs e )
    {
      uiName.SelectAll();
    }

    //-------------------------------------------------------------------------

    private void uiDescription_Enter( object sender, EventArgs e )
    {
      uiDescription.SelectAll();
    }

    //-------------------------------------------------------------------------

    private void uiRemove_Click( object sender, EventArgs e )
    {
      if( uiTags.SelectedItem == null )
      {
        return;
      }

      // Check if items are using this tag.
      bool inUse = false;

      foreach( Item item in Item.Items )
      {
        foreach( Tag tag in item.Tags )
        {
          if( tag == uiTags.SelectedItem )
          {
            inUse = true;
            break;
          }
        }

        if( inUse )
        {
          break;
        }
      }

      if( inUse )
      {
        MessageBox.Show(
          "This tag is used by some items and cannot be removed.",
          "Remove Tag",
          MessageBoxButtons.OK,
          MessageBoxIcon.Information );

        return;
      }

      // Remove the tag & refresh the list.
      Dorothy.Data.Tag.RemoveTag( uiTags.SelectedItem as Tag );

      PopulateTagsList();
    }

    //-------------------------------------------------------------------------

    private void uiUpdate_Click( object sender, EventArgs e )
    {
      Tag selectedTag = uiTags.SelectedItem as Tag;

      // Validate.
      if( uiName.Text.Length == 0 )
      {
        return;
      }

      if( new Regex( "^[a-zA-Z][a-zA-Z0-9]*$" ).IsMatch( uiName.Text ) == false )
      {
        MessageBox.Show(
          "Tag name must be alphanumeric without spaces.",
          "Tag Name",
          MessageBoxButtons.OK,
          MessageBoxIcon.Information );

        uiName.Focus();
        return;
      }

      // Already exists? This doesn't apply if we're updating the selected tag.
      if( selectedTag == null )
      {
        foreach( Tag tag in Dorothy.Data.Tag.Tags )
        {
          if( tag.Name.ToLower() == uiName.Text.ToLower() )
          {
            MessageBox.Show(
              "Tag name already exists.",
              "Tag Name",
              MessageBoxButtons.OK,
              MessageBoxIcon.Information );

            uiName.Focus();
            return;
          }
        }
      }

      // If there's a tag selecting then we're updating, otherwise we're adding.
      if( selectedTag != null )
      {
        selectedTag.Name = uiName.Text;
        selectedTag.Description = uiDescription.Text;
      }
      else
      {
        Dorothy.Data.Tag.CreateTag( uiName.Text, uiDescription.Text );
      }

      // Refresh the list.
      PopulateTagsList();

      // Find the tag in the list and select it.
      foreach( Tag tag in uiTags.Items )
      {
        if( tag.Name == uiName.Text )
        {
          uiTags.SelectedItem = tag;
          break;
        }
      }
    }

    //-------------------------------------------------------------------------

    private void uiTags_SelectedIndexChanged( object sender, EventArgs e )
    {
      Tag tag = uiTags.SelectedItem as Tag;

      if( tag == null )
      {
        uiName.Text = "";
        uiDescription.Text = "";
      }
      else
      {
        uiName.Text = tag.Name;
        uiDescription.Text = tag.Description;
      }
    }

    //-------------------------------------------------------------------------
  }
}
