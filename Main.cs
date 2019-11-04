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

namespace Keystroke_Tool
{
    public partial class KeystrokeTool : Form
    {
        public static string input;
        public static bool enter;
        public static bool tab;
        public static InputSimulator Simulator;
        public static int delay;
        public static int startDelay;

        public KeystrokeTool()
        {
            InitializeComponent();
        }

        private void KeystrokeTool_Load(object sender, EventArgs e)
        {
            Simulator = new InputSimulator();
        }

        private void GoBtn_Click(object sender, EventArgs e)
        {
            try { input = InputField.Text; }
            catch (NullReferenceException) { input = ""; }
            try {delay = Convert.ToInt32(waitTimeField.Text);}
            catch (FormatException) { delay = 0; }
            catch (NullReferenceException) { delay = 0; }
            try { startDelay = Convert.ToInt32(waitTimeField.Text); }
            catch (FormatException) { startDelay = 0; }
            catch (NullReferenceException) { startDelay = 0; }
            enter = EnterCheckBox.Checked;
            tab = TabCheckBox.Checked;

            Simulator.Keyboard.Sleep(startDelay * 1000);
            Simulator.Keyboard.TextEntry(input);
            if (enter == true) { Simulator.Keyboard.KeyPress(VirtualKeyCode.RETURN); }
            if (tab == true) { Simulator.Keyboard.KeyPress(VirtualKeyCode.TAB); }
        }
    }
}
