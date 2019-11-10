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
    public partial class Main : Form
    {
        public static OpenFileDialog ofd;

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

            // Show dialog and put file name into OutputLabel
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                OutputLabel.Text = "Loaded File: " + ofd.SafeFileName;
            }
        }
    }
}
