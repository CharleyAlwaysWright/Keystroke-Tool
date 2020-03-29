using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keystroke_Tool_V2
{
    public partial class Popout_Editor : Form
    {
        public Popout_Editor()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            // TODO Add try catch loop
            Main.cmdDelay = Convert.ToDouble(ScriptDelay.Text);
            Main.startDelay = Convert.ToDouble(StartDelay.Text);

            Close();
        }

        private void Popout_Editor_Load(object sender, EventArgs e)
        {
            Input.Text = Main.inputText;
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {
            Main.inputText = Input.Text;
        }
    }
}
