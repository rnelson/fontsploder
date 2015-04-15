using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FontLib;

namespace FontSploder
{
    public partial class MainForm : Form
    {
        private FontResourceManager fontManager;

        public MainForm()
        {
            InitializeComponent();

            // Create the font resource manager
            this.fontManager = new FontResourceManager();
        }

        private void addFontButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = this.fontManager.SupportedTypesFileFilter;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    // Add the font to the system table
                    int res = this.fontManager.Add(file);

                    if (res > 0)
                    {
                        // Create a Font object
                        FontLib.Font font = new FontLib.Font(file);

                        // Create the ListViewItem to go in the list
                        string[] values = new string[2];
                        values[0] = font.Name;
                        values[1] = font.Filename;
                        ListViewItem lvi = new ListViewItem(values);
                        this.fontsListView.Items.Add(lvi);
                    }
                }
            }
        }

        private void removeFontButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.fontsListView.SelectedItems)
            {
                bool success = this.fontManager.Remove(item.SubItems[1].Text);

                if (success)
                {
                    this.fontsListView.Items.Remove(item);
                }
            }
        }
    }
}
