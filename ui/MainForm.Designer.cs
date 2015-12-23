namespace Dorothy.UI
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose( bool disposing )
    {
      if( disposing && ( components != null ) )
      {
        components.Dispose();
      }
      base.Dispose( disposing );
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.manageTagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.uiItemTree = new System.Windows.Forms.TreeView();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1031, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // optionsToolStripMenuItem
      // 
      this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageTagsToolStripMenuItem,
            this.addItemToolStripMenuItem});
      this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
      this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
      this.optionsToolStripMenuItem.Text = "&Options";
      // 
      // manageTagsToolStripMenuItem
      // 
      this.manageTagsToolStripMenuItem.Name = "manageTagsToolStripMenuItem";
      this.manageTagsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
      this.manageTagsToolStripMenuItem.Text = "&Manage Tags";
      this.manageTagsToolStripMenuItem.Click += new System.EventHandler(this.manageTagsToolStripMenuItem_Click);
      // 
      // addItemToolStripMenuItem
      // 
      this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
      this.addItemToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
      this.addItemToolStripMenuItem.Text = "&Add Item";
      this.addItemToolStripMenuItem.Click += new System.EventHandler(this.addItemToolStripMenuItem_Click);
      // 
      // uiItemTree
      // 
      this.uiItemTree.Dock = System.Windows.Forms.DockStyle.Fill;
      this.uiItemTree.Location = new System.Drawing.Point(0, 24);
      this.uiItemTree.Name = "uiItemTree";
      this.uiItemTree.Size = new System.Drawing.Size(1031, 594);
      this.uiItemTree.TabIndex = 1;
      this.uiItemTree.DoubleClick += new System.EventHandler(this.uiItemTree_DoubleClick);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1031, 618);
      this.Controls.Add(this.uiItemTree);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "MainForm";
      this.Text = "Dorothy";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem manageTagsToolStripMenuItem;
    private System.Windows.Forms.TreeView uiItemTree;
    private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem;
  }
}

