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

            Main.ofd.Title = "Open Script";

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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main.sfd = new SaveFileDialog();
            Main.sfd.Filter = "KT (*.kt)|*.kt";
            Main.sfd.Title = "Save Script";

            if (Main.sfd.ShowDialog() == DialogResult.OK)
            {
                Main.StreamWriter = new StreamWriter(File.Create(Main.sfd.FileName));

                Main.StreamWriter.Write(EditorField.Text);
                Main.StreamWriter.Dispose();
            }
        }

        private void delayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string insertText = "\\D";
            int selectionIndex = EditorField.SelectionStart;
            EditorField.Text = EditorField.Text.Insert(selectionIndex, insertText);
            EditorField.SelectionStart = selectionIndex + insertText.Length;
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string insertText = "\\R";
            int selectionIndex = EditorField.SelectionStart;
            EditorField.Text = EditorField.Text.Insert(selectionIndex, insertText);
            EditorField.SelectionStart = selectionIndex + insertText.Length;
        }

        private void tabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string insertText = "\\T";
            int selectionIndex = EditorField.SelectionStart;
            EditorField.Text = EditorField.Text.Insert(selectionIndex, insertText);
            EditorField.SelectionStart = selectionIndex + insertText.Length;
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string insertText = "\\DEL";
            int selectionIndex = EditorField.SelectionStart;
            EditorField.Text = EditorField.Text.Insert(selectionIndex, insertText);
            EditorField.SelectionStart = selectionIndex + insertText.Length;
        }

        private void backspaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string insertText = "\\b";
            int selectionIndex = EditorField.SelectionStart;
            EditorField.Text = EditorField.Text.Insert(selectionIndex, insertText);
            EditorField.SelectionStart = selectionIndex + insertText.Length;
        }

        private void upToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string insertText = "\\UP";
            int selectionIndex = EditorField.SelectionStart;
            EditorField.Text = EditorField.Text.Insert(selectionIndex, insertText);
            EditorField.SelectionStart = selectionIndex + insertText.Length;
        }

        private void downToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string insertText = "\\DOWN";
            int selectionIndex = EditorField.SelectionStart;
            EditorField.Text = EditorField.Text.Insert(selectionIndex, insertText);
            EditorField.SelectionStart = selectionIndex + insertText.Length;
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string insertText = "\\LEFT";
            int selectionIndex = EditorField.SelectionStart;
            EditorField.Text = EditorField.Text.Insert(selectionIndex, insertText);
            EditorField.SelectionStart = selectionIndex + insertText.Length;
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string insertText = "\\RIGHT";
            int selectionIndex = EditorField.SelectionStart;
            EditorField.Text = EditorField.Text.Insert(selectionIndex, insertText);
            EditorField.SelectionStart = selectionIndex + insertText.Length;
        }

        private void EditorField_TextChanged(object sender, EventArgs e)
        {
            Main.LoadedFileContents = EditorField.Text;
        }

        private void volumeUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string insertText = "\\VU";
            int selectionIndex = EditorField.SelectionStart;
            EditorField.Text = EditorField.Text.Insert(selectionIndex, insertText);
            EditorField.SelectionStart = selectionIndex + insertText.Length;
        }

        private void volumeDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string insertText = "\\VD";
            int selectionIndex = EditorField.SelectionStart;
            EditorField.Text = EditorField.Text.Insert(selectionIndex, insertText);
            EditorField.SelectionStart = selectionIndex + insertText.Length;
        }
    }
}
