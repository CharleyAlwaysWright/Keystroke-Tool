using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput.Native;
using WindowsInput;

namespace Keystroke_Tool_V2
{
    public partial class Main : Form
    {
        public static InputSimulator Simulator;

        public static String inputText;
        public static int repeatNo;
        public static string triggerShortcut;
        public static bool tabAtEnd;
        public static bool returnAtEnd;
        public static double cmdDelay;
        public static double startDelay;

        public Main()
        {
            InitializeComponent();
        }

        private void TriggerBtn_Click(object sender, EventArgs e)
        {

        }

        private void PopOutBtn_Click(object sender, EventArgs e)
        {
            Popout_Editor Popout_Window = new Popout_Editor();
            Popout_Window.Show();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {

        }

        private void InsertReturnBtn_Click(object sender, EventArgs e)
        {

        }

        private void InsertTabBtn_Click(object sender, EventArgs e)
        {

        }

        private void InsertKBSCBtn_Click(object sender, EventArgs e)
        {

        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            inputText = Input.Text;
            returnAtEnd = ReturnCheckBox.Checked;
            tabAtEnd = TabCheckBox.Checked;

            Simulator.Keyboard.Sleep(Convert.ToInt32(startDelay * 1000));
            for (int i = 0; i < repeatNo; i++)
            {
                Simulator.Keyboard.TextEntry(inputText);
                if (returnAtEnd == true) { Simulator.Keyboard.KeyPress(VirtualKeyCode.RETURN); }
                if (tabAtEnd == true) { Simulator.Keyboard.KeyPress(VirtualKeyCode.TAB); }
                Simulator.Keyboard.Sleep(Convert.ToInt32(cmdDelay * 1000));
            }
        }

        private void InstructionsBtn_Click(object sender, EventArgs e)
        {
            Instructions Instructions_Window = new Instructions();
            Instructions_Window.Show();
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {
            inputText = Input.Text;
        }

        private void Form_Activated(object sender, EventArgs e)
        {
            Input.Text = inputText;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Simulator = new InputSimulator();
        }
    }
}
