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
using WindowsInput.Native;
using WindowsInput;

namespace Keystroke_Tool_V2
{
    public partial class Main : Form
    {
        // Declare a BUNCH of variables that can be accessed from anywhere
        public static OpenFileDialog ofd;
        public string currWord;
        public static List<string> importedLines;
        public static double StartDelay;
        public static double CmdDelay;
        public static string LoadedFileContents;
        public static InputSimulator Simulator;
        public static int RepeatNo;
        public static SaveFileDialog sfd;
        public static StreamWriter StreamWriter;
        public static string fileName;
        public static bool fileLoaded;
        

        public Main()
        {
            InitializeComponent();
        }

        // When the Editor button is clicked create a new instance and show it
        private void EditorBtn_Click(object sender, EventArgs e)
        {
            Editor editor = new Editor();
            editor.Show();
        }

        // when the load buttoon is clicked...
        private void LoadBtn_Click(object sender, EventArgs e)
        {
            // Create a new OpenFileDialog
            ofd = new OpenFileDialog();

            // Set the filter to ".kt"
            ofd.Filter = "KT|*.kt";

            // Set the window title to "Open Script"
            ofd.Title = "Open Script";

            // Show dialog and put file name into OutputLabel
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                // Update the fileName variable
                fileName = ofd.FileName;

                // Declare that a file has been loaded
                fileLoaded = true;

                // Show a file has been loaded on the output label
                OutputLabel.Text = "Loaded File: " + ofd.SafeFileName;

                // Read the file and store it as text and as lines (to run faster)
                importedLines = File.ReadAllLines(ofd.FileName).ToList();
                LoadedFileContents = File.ReadAllText(ofd.FileName);
            }
        }

        // When the start button is clicked
        private void StartBtn_Click(object sender, EventArgs e)
        {
            // Try to convert the entered delays to numbers
            try
            {
                StartDelay = Convert.ToDouble(StartDelayField.Text);
                CmdDelay = Convert.ToDouble(CmdDelayField.Text);
            }
            // If it dosn't work set them to 0
            catch (FormatException) { StartDelay = 0; CmdDelay = 0; }
            catch(ArgumentNullException) { StartDelay = 0; CmdDelay = 0; };

            // Do the start delay
            Simulator.Keyboard.Sleep(Convert.ToInt32(StartDelay));

            // For the amount of repetitions entered...
            for(int i = 0; i < RepeatNo; i++)
            {
                // For every line in the loaded file...
                foreach (string line in importedLines)
                {
                    // Split the line into individual "Words" 
                    string[] words = line.Split(null);

                    // Forever word in each line...
                    foreach (string word in words)
                    {
                        // Set the current word (to be used outside of this scope)
                        currWord = word;

                        /* If the word is a delay (Delays have numbers 
                           after them so can't be in the main switch loop) */
                        if (word.Contains("\\d"))
                        {
                            // Find the start of the actual delay number
                            int delayPos = 2 + currWord.IndexOf("\\d");

                            // Find how many characters the delay takes up
                            int delayLength = currWord.Length - delayPos;

                            // Take a substring using the values above and connvert it to an integer
                            int delay = Convert.ToInt32(currWord.Substring(delayPos, delayLength));

                            // Do the delay
                            Simulator.Keyboard.Sleep(delay);
                        }
                        // If it is not a delay, continue into the main loop
                        else
                        {
                            /*
                             * \\R              = Return
                             * \\T              = Tab
                             * \\DEL            = Delete
                             * \\B              = Backspace
                             * \\UP             = Up arrow key
                             * \\DOWN           = Down arrow key
                             * \\LEFT           = Left arrow key
                             * \\RIGHT          = Right arrow key
                             * \\VU             = Volume Up
                             * \\VD             = Volume Down
                             */



                            switch (word)
                            {
                                case "\\R":
                                    Simulator.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                                    break;

                                case "\\T":
                                    Simulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
                                    break;

                                case "\\DEL":
                                    Simulator.Keyboard.KeyPress(VirtualKeyCode.DELETE);
                                    break;

                                case "\\B":
                                    Simulator.Keyboard.KeyPress(VirtualKeyCode.BACK);
                                    break;

                                case "\\UP":
                                    Simulator.Keyboard.KeyPress(VirtualKeyCode.UP);
                                    break;

                                case "\\DOWN":
                                    Simulator.Keyboard.KeyPress(VirtualKeyCode.DOWN);
                                    break;

                                case "\\LEFT":
                                    Simulator.Keyboard.KeyPress(VirtualKeyCode.LEFT);
                                    break;

                                case "\\RIGHT":
                                    Simulator.Keyboard.KeyPress(VirtualKeyCode.RIGHT);
                                    break;

                                case "\\VU":
                                    Simulator.Keyboard.KeyPress(VirtualKeyCode.VOLUME_UP);
                                    break;

                                case "\\VD":
                                    Simulator.Keyboard.KeyPress(VirtualKeyCode.VOLUME_DOWN);
                                    break;

                                // Otherwise it must be a word
                                default:
                                    // Type the word
                                    Simulator.Keyboard.TextEntry(word);

                                    // Press Space
                                    Simulator.Keyboard.KeyPress(VirtualKeyCode.SPACE);
                                    break;
                            }
                        }
                    }
                }
                // Do the command delay
                Simulator.Keyboard.Sleep(Convert.ToInt32(CmdDelay));
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // When the main window is loaded, reset the variables and initialize a new InputSimulator
            Simulator = new InputSimulator();
            fileName = null;
            fileLoaded = false;
        }

        // When the RepeatNo is changed...
        private void RepeatNoField_TextChanged(object sender, EventArgs e)
        {
            // Try to convert it to an integer
            try
            {
                RepeatNo = Convert.ToInt32(RepeatNoField.Text);
            }
            // Catch any errors
            catch (FormatException) { }
            catch (NullReferenceException) { };
        }

        // When the save button is clicked...
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // Create a new SaveFileDialog
            sfd = new SaveFileDialog();

            // Set the file extension to ".kt"
            sfd.Filter = "KT (*.kt)|*.kt";

            // Set the window title to "Save Script"
            sfd.Title = "Save Script";

            // Show the saveFileDialog and if that goes OK...
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Create a new file
                StreamWriter = new StreamWriter(File.Create(sfd.FileName));

                // Write the data to the file
                StreamWriter.Write(importedLines);

                // Close the file and dispose of the StreamWriter (Memory Management)
                StreamWriter.Dispose();

                // Update the output to show the file was saved
                OutputLabel.Text = "Saved File: " + Path.GetFileName(sfd.FileName);
            }
        }
    }
}
