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
    public partial class loginForm : Form
    {
        string userName = "fast";
        string user_password = "123";

        public loginForm()    // constructor 
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            if (username_texbox.Text == userName && password_textbox.Text == user_password)
            {

                Homepage homepage = new Homepage();

                this.Hide();

                homepage.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Enter Correct user Name or Password", " Invalid Cardanalities", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void picHidePassword_Click(object sender, EventArgs e)
        {
            picHidePassword.Hide();
            PicShowPassword.Show();
            password_textbox.PasswordChar = '*';
        }

        private void PicShowPassword_Click(object sender, EventArgs e)
        {
            PicShowPassword.Hide();
            picHidePassword.Show();
            password_textbox.PasswordChar = '\0';



        }

        private void password_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void username_texbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                password_textbox.Focus(); ;
            }
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
