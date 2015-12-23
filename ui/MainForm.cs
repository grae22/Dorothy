using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Dorothy.Data;

namespace Dorothy.UI
{
  public partial class MainForm : Form
  {
    //-------------------------------------------------------------------------



    //-------------------------------------------------------------------------

    public MainForm()
    {
      InitializeComponent();
    }

    //-------------------------------------------------------------------------

    private void MainForm_Load( object sender, EventArgs e )
    {
      PopulateItemTree();
    }

    //-------------------------------------------------------------------------

    private void manageTagsToolStripMenuItem_Click( object sender, EventArgs e )
    {
      TagsDlg dlg = new TagsDlg();
      dlg.ShowDialog( this );
      dlg.Dispose();

      Program.Project.SaveToFile();
    }

    //-------------------------------------------------------------------------

    private void PopulateItemTree()
    {
      uiItemTree.Nodes.Clear();

      // Find all items without parents.
      foreach( Item item in Item.Items )
      {
        if( item.Parent == null )
        {
          AddItemAndChildrenToTree( item, null );
        }
      }

      uiItemTree.ExpandAll();
    }

    //-------------------------------------------------------------------------

    private void AddItemAndChildrenToTree(
      Item item,
      TreeNode parentNode )
    {
      // If the parent node is null, create a new top-level node.
      if( parentNode == null )
      {
        parentNode = new TreeNode( item.Name );
        parentNode.Tag = item;
        uiItemTree.Nodes.Add( parentNode );
      }
      else  // There is a parent node, so add a new node to it.
      {
        TreeNode node = new TreeNode( item.Name );
        node.Tag = item;
        parentNode.Nodes.Add( node );
        parentNode = node;
      }

      // Recursively add child items.
      foreach( Item child in item.Children )
      {
        AddItemAndChildrenToTree(
          child,
          parentNode );
      }
    }

    //-------------------------------------------------------------------------

    private void addItemToolStripMenuItem_Click( object sender, EventArgs e )
    {
      Item item =
        Item.CreateItem(
          "New Item",
          "",
          null,
          new List<Tag>() );

      ItemDlg dlg = new ItemDlg( item );
      dlg.ShowDialog( this );
      dlg.Dispose();

      PopulateItemTree();

      Program.Project.SaveToFile();
    }

    //-------------------------------------------------------------------------

    private void uiItemTree_DoubleClick( object sender, EventArgs e )
    {
      if( uiItemTree.SelectedNode == null )
      {
        return;
      }

      Item item = uiItemTree.SelectedNode.Tag as Item;

      if( item == null )
      {
        return;
      }

      ItemDlg dlg = new ItemDlg( item );
      dlg.ShowDialog( this );
      dlg.Dispose();

      PopulateItemTree();

      Program.Project.SaveToFile();
    }

    //-------------------------------------------------------------------------
  }
}
