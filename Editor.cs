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
        // Define public variables
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

        // When the load button is clicked...
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Craete a new OpenFileDialog
            Main.ofd = new OpenFileDialog();

            // Set the file filter to ".kt"
            Main.ofd.Filter = "KT|*.kt";

            // Set the window title to "Open Script"
            Main.ofd.Title = "Open Script";

            // Show the dilog and if all goes ok...
            if (Main.ofd.ShowDialog() == DialogResult.OK)
            {
                // Set the public fileName variable
                Main.fileName = Main.ofd.FileName;

                // Read the file and store it as text and as lines (to run faster)
                Main.importedLines = File.ReadAllLines(Main.ofd.FileName).ToList();
                Main.LoadedFileContents = File.ReadAllText(Main.fileName);

                // Set the text in the editor field to the text of the loaded file
                EditorField.Text = Main.LoadedFileContents;
            }
        }

        // When the return at end option is changed update the variable
        private void enterAtEndToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnAtEnd = enterAtEndToolStripMenuItem.Checked;
        }

        // When the tab at end option is changed update the variable
        private void tabAtEndToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabAtEnd = tabAtEndToolStripMenuItem.Checked;
        }

        // When the save button is clicked...
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new SaveFileDialog
            Main.sfd = new SaveFileDialog();

            // Set the file extensions to ".kt"
            Main.sfd.Filter = "KT (*.kt)|*.kt";

            // Set the title of the window to "Save Script"
            Main.sfd.Title = "Save Script";

            // If the file does not exist...
            if(Main.fileName == null)
            {
                // Show the save file dialog and if that goes well
                if (Main.sfd.ShowDialog() == DialogResult.OK)
                {
                    // Create the file to be saved
                    Main.StreamWriter = new StreamWriter(File.Create(Main.sfd.FileName));

                    // Write the data to the file
                    Main.StreamWriter.Write(EditorField.Text);

                    // Close the file and dispose of the StreamWriter (Memory Management)
                    Main.StreamWriter.Dispose();
                }
            } 
            // Otherwise...
            else
            {
                // Create a StreamWriter
                Main.StreamWriter = new StreamWriter(File.Create(Main.fileName));

                // Write over the old file
                Main.StreamWriter.Write(EditorField.Text);

                // Close the file and dispose of the StreamWriter (Memory Management)
                Main.StreamWriter.Dispose();
            }
        }

        // When the saveAs button is clicked
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new SaveFileDialog
            Main.sfd = new SaveFileDialog();

            // Set the file extension to ".kt"
            Main.sfd.Filter = "KT (*.kt)|*.kt";

            // Set the window title to "Save Script"
            Main.sfd.Title = "Save Script";

            // Show the saveFileDialog and if that goes OK...
            if (Main.sfd.ShowDialog() == DialogResult.OK)
            {
                // Create a new file
                Main.StreamWriter = new StreamWriter(File.Create(Main.sfd.FileName));

                // write the data to the file
                Main.StreamWriter.Write(EditorField.Text);

                // Close the file and dispose of the StreamWriter (Memory Management)
                Main.StreamWriter.Dispose();
            }
        }

        // When the Editor window loads...
        private void Editor_Load(object sender, EventArgs e)
        {
            // If the a file has already been opened in another window...
            if (Main.fileName != null && Main.fileLoaded == true)
            {
                // Read the file and store it as text and as lines (to run faster)
                Main.importedLines = File.ReadAllLines(Main.ofd.FileName).ToList();
                Main.LoadedFileContents = File.ReadAllText(Main.fileName);

                // Set the text in the editor field to the text of the loaded file
                EditorField.Text = Main.LoadedFileContents;
            }
        }

        private void EditorField_TextChanged(object sender, EventArgs e)
        {
            Main.LoadedFileContents = EditorField.Text;
        }

        // When the delay button is clicked
        private void delayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Make a variable with the command to be inserted
            string insertText = "\\D";

            // Find where the command should be inserted
            int selectionIndex = EditorField.SelectionStart;

            // Insert the command
            EditorField.Text = EditorField.Text.Insert(selectionIndex, insertText);

            // Set th cursor to the correct position
            EditorField.SelectionStart = selectionIndex + insertText.Length;
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Make a variable with the command to be inserted
            string insertText = "\\R";

            // Find where the command should be inserted
            int selectionIndex = EditorField.SelectionStart;

            // Insert the command
            EditorField.Text = EditorField.Text.Insert(selectionIndex, insertText);

            // Set th cursor to the correct position
            EditorField.SelectionStart = selectionIndex + insertText.Length;
        }

        private void tabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Make a variable with the command to be inserted
            string insertText = "\\T";

            // Find where the command should be inserted
            int selectionIndex = EditorField.SelectionStart;

            // Insert the command
            EditorField.Text = EditorField.Text.Insert(selectionIndex, insertText);

            // Set th cursor to the correct position
            EditorField.SelectionStart = selectionIndex + insertText.Length;
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Make a variable with the command to be inserted
            string insertText = "\\DEL";

            // Find where the command should be inserted
            int selectionIndex = EditorField.SelectionStart;

            // Insert the command
            EditorField.Text = EditorField.Text.Insert(selectionIndex, insertText);

            // Set th cursor to the correct position
            EditorField.SelectionStart = selectionIndex + insertText.Length;
        }

        private void backspaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Make a variable with the command to be inserted
            string insertText = "\\b";

            // Find where the command should be inserted
            int selectionIndex = EditorField.SelectionStart;

            // Insert the command
            EditorField.Text = EditorField.Text.Insert(selectionIndex, insertText);

            // Set th cursor to the correct position
            EditorField.SelectionStart = selectionIndex + insertText.Length;
        }

        private void upToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Make a variable with the command to be inserted
            string insertText = "\\UP";

            // Find where the command should be inserted
            int selectionIndex = EditorField.SelectionStart;

            // Insert the command
            EditorField.Text = EditorField.Text.Insert(selectionIndex, insertText);

            // Set th cursor to the correct position
            EditorField.SelectionStart = selectionIndex + insertText.Length;
        }

        private void downToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Make a variable with the command to be inserted
            string insertText = "\\DOWN";

            // Find where the command should be inserted
            int selectionIndex = EditorField.SelectionStart;

            // Insert the command
            EditorField.Text = EditorField.Text.Insert(selectionIndex, insertText);

            // Set th cursor to the correct position
            EditorField.SelectionStart = selectionIndex + insertText.Length;
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Make a variable with the command to be inserted
            string insertText = "\\LEFT";

            // Find where the command should be inserted
            int selectionIndex = EditorField.SelectionStart;

            // Insert the command
            EditorField.Text = EditorField.Text.Insert(selectionIndex, insertText);

            // Set th cursor to the correct position
            EditorField.SelectionStart = selectionIndex + insertText.Length;
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Make a variable with the command to be inserted
            string insertText = "\\RIGHT";

            // Find where the command should be inserted
            int selectionIndex = EditorField.SelectionStart;

            // Insert the command
            EditorField.Text = EditorField.Text.Insert(selectionIndex, insertText);

            // Set th cursor to the correct position
            EditorField.SelectionStart = selectionIndex + insertText.Length;
        }

        private void volumeUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Make a variable with the command to be inserted
            string insertText = "\\VU";

            // Find where the command should be inserted
            int selectionIndex = EditorField.SelectionStart;

            // Insert the command
            EditorField.Text = EditorField.Text.Insert(selectionIndex, insertText);

            // Set th cursor to the correct position
            EditorField.SelectionStart = selectionIndex + insertText.Length;
        }

        private void volumeDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Make a variable with the command to be inserted
            string insertText = "\\VD";

            // Find where the command should be inserted
            int selectionIndex = EditorField.SelectionStart;

            // Insert the command
            EditorField.Text = EditorField.Text.Insert(selectionIndex, insertText);

            // Set th cursor to the correct position
            EditorField.SelectionStart = selectionIndex + insertText.Length;
        }
    }
}
