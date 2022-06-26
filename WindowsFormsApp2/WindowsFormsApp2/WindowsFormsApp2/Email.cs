using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace WindowsFormsApp2
{
    public partial class Email : Form
    {
        public string HtmlTextBody { get; private set; }

        public Email()
        {
            InitializeComponent();
        }

        private void EmailPicShowPassword_Click(object sender, EventArgs e)
        {
            EmailPicShowPassword.Hide();
            Email_picHidePassword.Show();
            textboxAppCode.PasswordChar = '\0';

        }

        private void Email_picHidePassword_Click(object sender, EventArgs e)
        {
            EmailPicShowPassword.Show();
            Email_picHidePassword.Hide();
            textboxAppCode.PasswordChar = '*';
        }

        private void passwordlabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void desclabel_Click(object sender, EventArgs e)
        {

        }

        private void buttonSenEmail_Click(object sender, EventArgs e)
        {

            try
            {
                string password = textboxAppCode.Text;
                NetworkCredential login = new NetworkCredential(textfromboxemal.Text, password);
                string stmp = "smtp.gmail.com";                                                         //stm = Simple Mial Transfor Protocole ( just hange this to send as Yahoo, Microsoft ETC

                SmtpClient client = new SmtpClient(stmp)
                {
                    EnableSsl = true,        //ssl secure
                    UseDefaultCredentials = false,
                    Credentials = login,
                    Port = 587
                };
                MailMessage msg = new MailMessage
                {
                    From = new MailAddress(textfromboxemal.Text, textboxDisplayName.Text.Trim(), Encoding.UTF8)       // trim remove spaces at last and in start also 
                };
                msg.To.Add(new MailAddress(textbomtoemail.Text.Trim()));


                msg.Subject = textboxSubject.Text.Trim();
                msg.Body = textBox2.Text;
                msg.BodyEncoding = Encoding.UTF8;    //TUTF8 web server 
                msg.IsBodyHtml = true;   //  not to send 

                msg.Priority = MailPriority.High;
                msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
                string userstate = "Sending...";

                client.SendAsync(msg, userstate);

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

        }

        private void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show(string.Format("{0} send Cancelled.", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (e.Error != null)
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                //if (mailCount == listBox2.Items.Count)
                MessageBox.Show("The extracted emails has been successfully sent.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textboxAppCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_Load(object sender, EventArgs e)
        {

        }
    }
}//namespace 
