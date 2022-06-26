using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    public partial class tools : Form
    {
        public tools()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void EmailPicShowPassword_Click(object sender, EventArgs e)
        {

        }

        private void Email_picHidePassword_Click(object sender, EventArgs e)
        {

        }

        private void textboxAppCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void gmailRadioButton_CheckedChanged(object sender, EventArgs e)      // Gmail Radio Button 
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void PicBox_font_Click(object sender, EventArgs e)
        {

            fontDialog1.ShowColor = true;
            fontDialog1.Font = this.Txt_Message.Font;
            DialogResult result = fontDialog1.ShowDialog();

            if (result == DialogResult.OK)

            {

                Font font = fontDialog1.Font;
                Color color = fontDialog1.Color;

                this.Txt_Message.SelectionFont = font;
                this.Txt_Message.SelectionColor = color;

            }

        }

        //Send Email From c#
        private void SendEmail(string sMTP_Gmail)
        {
            try
            {
                string password = Txt_AppCode.Text;
                NetworkCredential login = new NetworkCredential(Txt_from.Text, password);
                string stmp = "smtp.gmail.com";
                SmtpClient client = new SmtpClient(stmp)
                {
                    EnableSsl = true,
                    UseDefaultCredentials = false,
                    Credentials = login,
                    Port = 587
                };
                MailMessage msg = new MailMessage
                {
                    From = new MailAddress(Txt_from.Text, Txt_Displayname.Text.Trim(), Encoding.UTF8)
                };
                msg.To.Add(new MailAddress(Txt_ToEmail.Text.Trim()));


                msg.Subject = Txt_Subject.Text.Trim();
                msg.Body = Txt_Message.Text;
                msg.BodyEncoding = Encoding.UTF8;
                msg.IsBodyHtml = true;


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
           //  throw new NotImplementedException();

            if (e.Cancelled)
                MessageBox.Show(string.Format("{0} send Cancelled.", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (e.Error != null)
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                //if (mailCount == listBox2.Items.Count)
                MessageBox.Show("The extracted emails has been successfully sent.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
        }

        //  Check internet in c#
        // Check Internet Connection 
        [System.Runtime.InteropServices.DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);


        public static bool CheckNet()
        {
            int desc;
            return InternetGetConnectedState(out desc, 0);
        }



        private void Btn_SendEmail_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txt_from.Text != string.Empty && Txt_Subject.Text != string.Empty && Txt_Displayname.Text != "" && Txt_Subject.Text != string.Empty && Txt_ToEmail.Text != String.Empty)
                {

                    if (CheckNet())
                    {
                        if (Rdo_Gmail.Checked)
                            SendEmail(Properties.Settings.Default.SMTP_Gmail);
                        else if (Rdo_Live.Checked)
                            SendEmail(Properties.Settings.Default.SMTP_Hotmail);
                        else if (Rdo_Outlook.Checked)
                            SendEmail(Properties.Settings.Default.SMTP_OutLook);
                        else if (Rdo_Yahoo.Checked)
                            SendEmail(Properties.Settings.Default.SMTP_Yahoo);
                    }
                    else
                    {
                        MessageBox.Show("Please check your internet", "No Network", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

                else
                {
                   // tabControl1.SelectTab(0);
                    MessageBox.Show("Following Field are Required " 
                        + Environment.NewLine + "1. Form Email " 
                        + Environment.NewLine + "2. App Code " 
                        + Environment.NewLine + "3. Display Name "
                        + Environment.NewLine + "4. Subject "
                        + Environment.NewLine + "5. To Email "
                        , "Field Required ", MessageBoxButtons.OK , MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.ToString());
                
            }
        }

        private void Txt_ServerUrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tools_Load(object sender, EventArgs e)
        {
            Txt_from.Text = Properties.Settings.Default.FromEmail;
            Txt_AppCode.Text = Properties.Settings.Default.FromPassword;
            Txt_ToEmail.Text = Properties.Settings.Default.TOEmail;

        }

        private void Txt_from_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
