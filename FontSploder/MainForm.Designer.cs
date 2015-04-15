namespace FontSploder
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
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.addFontButton = new System.Windows.Forms.Button();
            this.removeFontButton = new System.Windows.Forms.Button();
            this.fontsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.RestoreDirectory = true;
            this.openFileDialog.SupportMultiDottedExtensions = true;
            this.openFileDialog.Title = "Select Font(s)";
            // 
            // addFontButton
            // 
            this.addFontButton.Location = new System.Drawing.Point(67, 227);
            this.addFontButton.Name = "addFontButton";
            this.addFontButton.Size = new System.Drawing.Size(75, 23);
            this.addFontButton.TabIndex = 0;
            this.addFontButton.Text = "+";
            this.addFontButton.UseVisualStyleBackColor = true;
            this.addFontButton.Click += new System.EventHandler(this.addFontButton_Click);
            // 
            // removeFontButton
            // 
            this.removeFontButton.Location = new System.Drawing.Point(148, 227);
            this.removeFontButton.Name = "removeFontButton";
            this.removeFontButton.Size = new System.Drawing.Size(75, 23);
            this.removeFontButton.TabIndex = 1;
            this.removeFontButton.Text = "-";
            this.removeFontButton.UseVisualStyleBackColor = true;
            this.removeFontButton.Click += new System.EventHandler(this.removeFontButton_Click);
            // 
            // fontsListView
            // 
            this.fontsListView.AllowColumnReorder = true;
            this.fontsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fontsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.fontsListView.FullRowSelect = true;
            this.fontsListView.Location = new System.Drawing.Point(12, 12);
            this.fontsListView.Name = "fontsListView";
            this.fontsListView.Size = new System.Drawing.Size(260, 209);
            this.fontsListView.TabIndex = 2;
            this.fontsListView.UseCompatibleStateImageBehavior = false;
            this.fontsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Font Name";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Filename";
            this.columnHeader2.Width = 500;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.fontsListView);
            this.Controls.Add(this.removeFontButton);
            this.Controls.Add(this.addFontButton);
            this.Name = "MainForm";
            this.Text = "FontSploder";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button addFontButton;
        private System.Windows.Forms.Button removeFontButton;
        private System.Windows.Forms.ListView fontsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;

    }
}

