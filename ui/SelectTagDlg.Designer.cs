namespace Dorothy.UI
{
  partial class SelectTagDlg
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
      this.label1 = new System.Windows.Forms.Label();
      this.uiFilter = new System.Windows.Forms.TextBox();
      this.uiTags = new System.Windows.Forms.ListBox();
      this.uiCancel = new System.Windows.Forms.Button();
      this.uiOK = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.uiFilter);
      this.groupBox1.Controls.Add(this.uiTags);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(10, 30, 10, 10);
      this.groupBox1.Size = new System.Drawing.Size(594, 251);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Tags:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(427, 20);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(32, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Filter:";
      // 
      // uiFilter
      // 
      this.uiFilter.Location = new System.Drawing.Point(465, 17);
      this.uiFilter.Name = "uiFilter";
      this.uiFilter.Size = new System.Drawing.Size(119, 20);
      this.uiFilter.TabIndex = 1;
      this.uiFilter.TextChanged += new System.EventHandler(this.uiFilter_TextChanged);
      // 
      // uiTags
      // 
      this.uiTags.Dock = System.Windows.Forms.DockStyle.Fill;
      this.uiTags.FormattingEnabled = true;
      this.uiTags.Location = new System.Drawing.Point(10, 43);
      this.uiTags.Name = "uiTags";
      this.uiTags.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
      this.uiTags.Size = new System.Drawing.Size(574, 198);
      this.uiTags.TabIndex = 0;
      // 
      // uiCancel
      // 
      this.uiCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.uiCancel.Location = new System.Drawing.Point(531, 274);
      this.uiCancel.Name = "uiCancel";
      this.uiCancel.Size = new System.Drawing.Size(75, 23);
      this.uiCancel.TabIndex = 1;
      this.uiCancel.Text = "Cancel";
      this.uiCancel.UseVisualStyleBackColor = true;
      // 
      // uiOK
      // 
      this.uiOK.Location = new System.Drawing.Point(450, 274);
      this.uiOK.Name = "uiOK";
      this.uiOK.Size = new System.Drawing.Size(75, 23);
      this.uiOK.TabIndex = 2;
      this.uiOK.Text = "OK";
      this.uiOK.UseVisualStyleBackColor = true;
      this.uiOK.Click += new System.EventHandler(this.uiOK_Click);
      // 
      // SelectTagDlg
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.uiCancel;
      this.ClientSize = new System.Drawing.Size(618, 309);
      this.ControlBox = false;
      this.Controls.Add(this.uiOK);
      this.Controls.Add(this.uiCancel);
      this.Controls.Add(this.groupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "SelectTagDlg";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Select Tags";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.ListBox uiTags;
    private System.Windows.Forms.Button uiCancel;
    private System.Windows.Forms.Button uiOK;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox uiFilter;
  }
}