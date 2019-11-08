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
        public static double delay;
        public static double startDelay;
        public static int repetitions;

        public KeystrokeTool()
        {
            InitializeComponent();
        }

        private void KeystrokeTool_Load(object sender, EventArgs e)
        {
            
        }

        private void GoBtn_Click(object sender, EventArgs e)
        {
            Simulator = new InputSimulator();

            try { input = InputField.Text; }
            catch (NullReferenceException) { input = ""; }
            try { delay = Convert.ToDouble(waitTimeField.Text); }
            catch (FormatException) { delay = 0; }
            catch (NullReferenceException) { delay = 0; }
            startDelay = Convert.ToDouble(startDelayField.Text);
            repetitions = Convert.ToInt32(repetitionsField.Text);
            enter = EnterCheckBox.Checked;
            tab = TabCheckBox.Checked;


            Simulator.Keyboard.Sleep(Convert.ToInt32(startDelay * 1000));
            for (int i = 0; i < repetitions; i++)
            {
                Simulator.Keyboard.TextEntry(input);
                if (enter == true) { Simulator.Keyboard.KeyPress(VirtualKeyCode.RETURN); }
                if (tab == true) { Simulator.Keyboard.KeyPress(VirtualKeyCode.TAB); }
                Simulator.Keyboard.Sleep(Convert.ToInt32(delay * 1000));
            }
        }
    }
}
