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
    public partial class pbox : Form
    {
        public pbox()
        {
            InitializeComponent();
        }

        private void button_bar_Click(object sender, EventArgs e)
        {
            int i;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 200;

            for (i = 0; i < 200; i++)
            {

                progressBar1.Value = i;
                richTextBox1.Text = richTextBox1.Text +Environment.NewLine  +" \n 2 X " + i + " = " + 2 * i + "\n";
            }
        }
    }
}
