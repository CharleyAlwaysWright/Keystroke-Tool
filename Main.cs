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
        

        public Main()
        {
            InitializeComponent();
        }

        private void EditorBtn_Click(object sender, EventArgs e)
        {
            Editor editor = new Editor();
            editor.Show();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();

            ofd.Filter = "KT|*.kt";
            ofd.Title = "Open Script";

            // Show dialog and put file name into OutputLabel
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                OutputLabel.Text = "Loaded File: " + ofd.SafeFileName;

                importedLines = File.ReadAllLines(ofd.FileName).ToList();
                LoadedFileContents = File.ReadAllText(ofd.FileName);
            }
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            try
            {
                StartDelay = Convert.ToDouble(StartDelayField.Text);
                CmdDelay = Convert.ToDouble(CmdDelayField.Text);
            }
            catch (FormatException) { StartDelay = 0; CmdDelay = 0; }
            catch(ArgumentNullException) { StartDelay = 0; CmdDelay = 0; };

            Simulator.Keyboard.Sleep(Convert.ToInt32(StartDelay));

            for(int i = 0; i < RepeatNo; i++)
            {
                foreach (string line in importedLines)
                {
                    string[] words = line.Split(null);

                    foreach (string word in words)
                    {
                        currWord = word;

                        if (word.Contains("\\d"))
                        {
                            int delayPos = 2 + currWord.IndexOf("\\d");
                            int delayLength = currWord.Length - delayPos;

                            int delay = Convert.ToInt32(currWord.Substring(delayPos, delayLength));


                            Simulator.Keyboard.Sleep(delay);
                        }
                        else
                        {
                            switch (word)
                            {
                                case "\\e":
                                    Simulator.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                                    break;

                                case "\\t":
                                    Simulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
                                    break;

                                default:
                                    Simulator.Keyboard.TextEntry(word);
                                    Simulator.Keyboard.KeyPress(VirtualKeyCode.SPACE);
                                    break;
                            }
                        }
                    }
                }
                Simulator.Keyboard.Sleep(Convert.ToInt32(CmdDelay));
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Simulator = new InputSimulator();
        }

        private void RepeatNoField_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RepeatNo = Convert.ToInt32(RepeatNoField.Text);
            }
            catch (FormatException) { }
            catch (NullReferenceException) { };
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            sfd = new SaveFileDialog();
            sfd.Filter = "KT (*.kt)|*.kt";
            sfd.Title = "Save Script";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter = new StreamWriter(File.Create(sfd.FileName));

                StreamWriter.Write(importedLines);
                StreamWriter.Dispose();

                OutputLabel.Text = "Saved File: " + Path.GetFileName(sfd.FileName);
            }
        }
    }
}
