namespace Dorothy.UI
{
  partial class ItemDlg
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.uiDescription = new System.Windows.Forms.TextBox();
      this.uiName = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.uiPromoteChild = new System.Windows.Forms.Button();
      this.uiDemoteChild = new System.Windows.Forms.Button();
      this.uiRemoveChild = new System.Windows.Forms.Button();
      this.uiAddChild = new System.Windows.Forms.Button();
      this.uiChildren = new System.Windows.Forms.ListBox();
      this.uiSelectParent = new System.Windows.Forms.Button();
      this.uiParent = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.uiRemoveTag = new System.Windows.Forms.Button();
      this.uiAddTag = new System.Windows.Forms.Button();
      this.uiTags = new System.Windows.Forms.ListBox();
      this.uiClose = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.uiDescription);
      this.groupBox1.Controls.Add(this.uiName);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(323, 131);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "General:";
      // 
      // uiDescription
      // 
      this.uiDescription.Location = new System.Drawing.Point(99, 52);
      this.uiDescription.Multiline = true;
      this.uiDescription.Name = "uiDescription";
      this.uiDescription.Size = new System.Drawing.Size(207, 61);
      this.uiDescription.TabIndex = 1;
      // 
      // uiName
      // 
      this.uiName.Location = new System.Drawing.Point(99, 27);
      this.uiName.Name = "uiName";
      this.uiName.Size = new System.Drawing.Size(207, 20);
      this.uiName.TabIndex = 0;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(18, 55);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(63, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Description:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(18, 30);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(38, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Name:";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.uiPromoteChild);
      this.groupBox2.Controls.Add(this.uiDemoteChild);
      this.groupBox2.Controls.Add(this.uiRemoveChild);
      this.groupBox2.Controls.Add(this.uiAddChild);
      this.groupBox2.Controls.Add(this.uiChildren);
      this.groupBox2.Controls.Add(this.uiSelectParent);
      this.groupBox2.Controls.Add(this.uiParent);
      this.groupBox2.Controls.Add(this.label4);
      this.groupBox2.Controls.Add(this.label3);
      this.groupBox2.Location = new System.Drawing.Point(12, 149);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(323, 169);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Relations:";
      // 
      // uiPromoteChild
      // 
      this.uiPromoteChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.uiPromoteChild.Location = new System.Drawing.Point(269, 107);
      this.uiPromoteChild.Name = "uiPromoteChild";
      this.uiPromoteChild.Size = new System.Drawing.Size(37, 20);
      this.uiPromoteChild.TabIndex = 6;
      this.uiPromoteChild.Text = "^";
      this.uiPromoteChild.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.uiPromoteChild.UseVisualStyleBackColor = true;
      // 
      // uiDemoteChild
      // 
      this.uiDemoteChild.Location = new System.Drawing.Point(269, 130);
      this.uiDemoteChild.Name = "uiDemoteChild";
      this.uiDemoteChild.Size = new System.Drawing.Size(37, 20);
      this.uiDemoteChild.TabIndex = 7;
      this.uiDemoteChild.Text = "v";
      this.uiDemoteChild.UseVisualStyleBackColor = true;
      // 
      // uiRemoveChild
      // 
      this.uiRemoveChild.Enabled = false;
      this.uiRemoveChild.Location = new System.Drawing.Point(269, 79);
      this.uiRemoveChild.Name = "uiRemoveChild";
      this.uiRemoveChild.Size = new System.Drawing.Size(37, 20);
      this.uiRemoveChild.TabIndex = 5;
      this.uiRemoveChild.Text = "-";
      this.uiRemoveChild.UseVisualStyleBackColor = true;
      // 
      // uiAddChild
      // 
      this.uiAddChild.Enabled = false;
      this.uiAddChild.Location = new System.Drawing.Point(269, 55);
      this.uiAddChild.Name = "uiAddChild";
      this.uiAddChild.Size = new System.Drawing.Size(37, 20);
      this.uiAddChild.TabIndex = 4;
      this.uiAddChild.Text = "+";
      this.uiAddChild.UseVisualStyleBackColor = true;
      // 
      // uiChildren
      // 
      this.uiChildren.FormattingEnabled = true;
      this.uiChildren.Location = new System.Drawing.Point(99, 55);
      this.uiChildren.Name = "uiChildren";
      this.uiChildren.Size = new System.Drawing.Size(165, 95);
      this.uiChildren.TabIndex = 3;
      // 
      // uiSelectParent
      // 
      this.uiSelectParent.Location = new System.Drawing.Point(270, 27);
      this.uiSelectParent.Name = "uiSelectParent";
      this.uiSelectParent.Size = new System.Drawing.Size(37, 20);
      this.uiSelectParent.TabIndex = 2;
      this.uiSelectParent.Text = "...";
      this.uiSelectParent.UseVisualStyleBackColor = true;
      this.uiSelectParent.Click += new System.EventHandler(this.uiSelectParent_Click);
      // 
      // uiParent
      // 
      this.uiParent.Location = new System.Drawing.Point(99, 27);
      this.uiParent.Name = "uiParent";
      this.uiParent.ReadOnly = true;
      this.uiParent.Size = new System.Drawing.Size(165, 20);
      this.uiParent.TabIndex = 3;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(18, 55);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(48, 13);
      this.label4.TabIndex = 2;
      this.label4.Text = "Children:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(18, 30);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(41, 13);
      this.label3.TabIndex = 1;
      this.label3.Text = "Parent:";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.uiRemoveTag);
      this.groupBox3.Controls.Add(this.uiAddTag);
      this.groupBox3.Controls.Add(this.uiTags);
      this.groupBox3.Location = new System.Drawing.Point(14, 324);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(323, 145);
      this.groupBox3.TabIndex = 2;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Tags:";
      // 
      // uiRemoveTag
      // 
      this.uiRemoveTag.Location = new System.Drawing.Point(268, 54);
      this.uiRemoveTag.Name = "uiRemoveTag";
      this.uiRemoveTag.Size = new System.Drawing.Size(37, 20);
      this.uiRemoveTag.TabIndex = 10;
      this.uiRemoveTag.Text = "-";
      this.uiRemoveTag.UseVisualStyleBackColor = true;
      this.uiRemoveTag.Click += new System.EventHandler(this.uiRemoveTag_Click);
      // 
      // uiAddTag
      // 
      this.uiAddTag.Location = new System.Drawing.Point(268, 30);
      this.uiAddTag.Name = "uiAddTag";
      this.uiAddTag.Size = new System.Drawing.Size(37, 20);
      this.uiAddTag.TabIndex = 9;
      this.uiAddTag.Text = "+";
      this.uiAddTag.UseVisualStyleBackColor = true;
      this.uiAddTag.Click += new System.EventHandler(this.uiAddTag_Click);
      // 
      // uiTags
      // 
      this.uiTags.FormattingEnabled = true;
      this.uiTags.Location = new System.Drawing.Point(19, 30);
      this.uiTags.Name = "uiTags";
      this.uiTags.Size = new System.Drawing.Size(243, 95);
      this.uiTags.TabIndex = 8;
      // 
      // uiClose
      // 
      this.uiClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.uiClose.Location = new System.Drawing.Point(262, 487);
      this.uiClose.Name = "uiClose";
      this.uiClose.Size = new System.Drawing.Size(75, 23);
      this.uiClose.TabIndex = 11;
      this.uiClose.Text = "Close";
      this.uiClose.UseVisualStyleBackColor = true;
      this.uiClose.Click += new System.EventHandler(this.uiClose_Click);
      // 
      // ItemDlg
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.uiClose;
      this.ClientSize = new System.Drawing.Size(349, 523);
      this.ControlBox = false;
      this.Controls.Add(this.uiClose);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "ItemDlg";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Item Properties";
      this.Load += new System.EventHandler(this.ItemDlg_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox uiDescription;
    private System.Windows.Forms.TextBox uiName;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button uiSelectParent;
    private System.Windows.Forms.TextBox uiParent;
    private System.Windows.Forms.Button uiPromoteChild;
    private System.Windows.Forms.Button uiDemoteChild;
    private System.Windows.Forms.Button uiRemoveChild;
    private System.Windows.Forms.Button uiAddChild;
    private System.Windows.Forms.ListBox uiChildren;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Button uiRemoveTag;
    private System.Windows.Forms.Button uiAddTag;
    private System.Windows.Forms.ListBox uiTags;
    private System.Windows.Forms.Button uiClose;
  }
}