using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.button2.BackColor = System.Drawing.SystemColors.WindowFrame;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
        }
    }
}
