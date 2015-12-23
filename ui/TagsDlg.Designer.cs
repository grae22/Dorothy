namespace Dorothy.UI
{
  partial class TagsDlg
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
      this.uiUpdate = new System.Windows.Forms.Button();
      this.uiRemove = new System.Windows.Forms.Button();
      this.uiAdd = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.uiTags = new System.Windows.Forms.ListBox();
      this.uiClose = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.uiDescription);
      this.groupBox1.Controls.Add(this.uiName);
      this.groupBox1.Controls.Add(this.uiUpdate);
      this.groupBox1.Controls.Add(this.uiRemove);
      this.groupBox1.Controls.Add(this.uiAdd);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.uiTags);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(10, 10, 100, 40);
      this.groupBox1.Size = new System.Drawing.Size(605, 194);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Add, Remove or Update Tags:";
      // 
      // uiDescription
      // 
      this.uiDescription.Location = new System.Drawing.Point(208, 163);
      this.uiDescription.Name = "uiDescription";
      this.uiDescription.Size = new System.Drawing.Size(297, 20);
      this.uiDescription.TabIndex = 4;
      this.uiDescription.Enter += new System.EventHandler(this.uiDescription_Enter);
      // 
      // uiName
      // 
      this.uiName.Location = new System.Drawing.Point(51, 163);
      this.uiName.Name = "uiName";
      this.uiName.Size = new System.Drawing.Size(66, 20);
      this.uiName.TabIndex = 3;
      this.uiName.Enter += new System.EventHandler(this.uiName_Enter);
      // 
      // uiUpdate
      // 
      this.uiUpdate.Location = new System.Drawing.Point(516, 161);
      this.uiUpdate.Name = "uiUpdate";
      this.uiUpdate.Size = new System.Drawing.Size(75, 23);
      this.uiUpdate.TabIndex = 5;
      this.uiUpdate.Text = "Update";
      this.uiUpdate.UseVisualStyleBackColor = true;
      this.uiUpdate.Click += new System.EventHandler(this.uiUpdate_Click);
      // 
      // uiRemove
      // 
      this.uiRemove.Location = new System.Drawing.Point(516, 52);
      this.uiRemove.Name = "uiRemove";
      this.uiRemove.Size = new System.Drawing.Size(75, 23);
      this.uiRemove.TabIndex = 2;
      this.uiRemove.Text = "Remove";
      this.uiRemove.UseVisualStyleBackColor = true;
      this.uiRemove.Click += new System.EventHandler(this.uiRemove_Click);
      // 
      // uiAdd
      // 
      this.uiAdd.Location = new System.Drawing.Point(516, 23);
      this.uiAdd.Name = "uiAdd";
      this.uiAdd.Size = new System.Drawing.Size(75, 23);
      this.uiAdd.TabIndex = 1;
      this.uiAdd.Text = "Add";
      this.uiAdd.UseVisualStyleBackColor = true;
      this.uiAdd.Click += new System.EventHandler(this.uiAdd_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(139, 166);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(63, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Description:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(7, 166);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(38, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Name:";
      // 
      // uiTags
      // 
      this.uiTags.Dock = System.Windows.Forms.DockStyle.Fill;
      this.uiTags.FormattingEnabled = true;
      this.uiTags.HorizontalScrollbar = true;
      this.uiTags.Location = new System.Drawing.Point(10, 23);
      this.uiTags.MultiColumn = true;
      this.uiTags.Name = "uiTags";
      this.uiTags.Size = new System.Drawing.Size(495, 131);
      this.uiTags.TabIndex = 0;
      this.uiTags.SelectedIndexChanged += new System.EventHandler(this.uiTags_SelectedIndexChanged);
      // 
      // uiClose
      // 
      this.uiClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.uiClose.Location = new System.Drawing.Point(542, 221);
      this.uiClose.Name = "uiClose";
      this.uiClose.Size = new System.Drawing.Size(75, 28);
      this.uiClose.TabIndex = 6;
      this.uiClose.Text = "Close";
      this.uiClose.UseVisualStyleBackColor = true;
      // 
      // TagsDlg
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.uiClose;
      this.ClientSize = new System.Drawing.Size(629, 261);
      this.ControlBox = false;
      this.Controls.Add(this.uiClose);
      this.Controls.Add(this.groupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "TagsDlg";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Tag Manager";
      this.Load += new System.EventHandler(this.TagsDlg_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.ListBox uiTags;
    private System.Windows.Forms.Button uiUpdate;
    private System.Windows.Forms.Button uiRemove;
    private System.Windows.Forms.Button uiAdd;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox uiDescription;
    private System.Windows.Forms.TextBox uiName;
    private System.Windows.Forms.Button uiClose;
  }
}