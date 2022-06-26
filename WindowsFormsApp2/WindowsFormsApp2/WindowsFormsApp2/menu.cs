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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void PickLogout_Click(object sender, EventArgs e)
        {
           DialogResult dialogResult = MessageBox.Show(" Do you want to Log out ?", "Logout Confermation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            } 


        }

        private void pickSignout_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show(" Do you want to Sign out ?", "Signout Confermation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lableDateTIme.Text = DateTime.Now.ToString();


        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            lableDateTIme.Text = DateTime.Now.ToString();
        }
    }
}
