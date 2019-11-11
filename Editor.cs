using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Keystroke_Tool_V2
{
    public partial class Editor : Form
    {
        public static bool ReturnAtEnd;
        public static bool TabAtEnd;

        public Editor()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main.ofd = new OpenFileDialog();

            Main.ofd.Filter = "KT|*.kt";

            // Show dialog and put file name into OutputLabel
            if (Main.ofd.ShowDialog() == DialogResult.OK)
            {
                Main.importedLines = File.ReadAllLines(Main.ofd.FileName).ToList();
                Main.LoadedFileContents = File.ReadAllText(Main.ofd.FileName);

                EditorField.Text = Main.LoadedFileContents;
            }
        }

        private void enterAtEndToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnAtEnd = enterAtEndToolStripMenuItem.Checked;
        }

        private void tabAtEndToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabAtEnd = tabAtEndToolStripMenuItem.Checked;
        }
    }
}
