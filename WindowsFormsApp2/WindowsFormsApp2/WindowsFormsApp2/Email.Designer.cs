namespace WindowsFormsApp2
{
    partial class Email
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.passwordlabel = new System.Windows.Forms.Label();
            this.userlabel = new System.Windows.Forms.Label();
            this.textboxAppCode = new System.Windows.Forms.TextBox();
            this.textfromboxemal = new System.Windows.Forms.TextBox();
            this.subject1 = new System.Windows.Forms.Label();
            this.textboxSubject = new System.Windows.Forms.TextBox();
            this.textboxmessage = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxDisplayName = new System.Windows.Forms.TextBox();
            this.buttonSenEmail = new System.Windows.Forms.Button();
            this.GroupBox_from = new System.Windows.Forms.GroupBox();
            this.TogroupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textbomtoemail = new System.Windows.Forms.TextBox();
            this.EmailPicShowPassword = new System.Windows.Forms.PictureBox();
            this.Email_picHidePassword = new System.Windows.Forms.PictureBox();
            this.GroupBox_from.SuspendLayout();
            this.TogroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmailPicShowPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Email_picHidePassword)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlabel.Location = new System.Drawing.Point(51, 135);
            this.passwordlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(117, 23);
            this.passwordlabel.TabIndex = 12;
            this.passwordlabel.Text = "App Code :";
            this.passwordlabel.Click += new System.EventHandler(this.passwordlabel_Click);
            // 
            // userlabel
            // 
            this.userlabel.AutoSize = true;
            this.userlabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlabel.Location = new System.Drawing.Point(51, 38);
            this.userlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(80, 23);
            this.userlabel.TabIndex = 11;
            this.userlabel.Text = "Email :";
            // 
            // textboxAppCode
            // 
            this.textboxAppCode.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxAppCode.Location = new System.Drawing.Point(234, 120);
            this.textboxAppCode.Margin = new System.Windows.Forms.Padding(4);
            this.textboxAppCode.Name = "textboxAppCode";
            this.textboxAppCode.PasswordChar = '*';
            this.textboxAppCode.Size = new System.Drawing.Size(337, 44);
            this.textboxAppCode.TabIndex = 10;
            this.textboxAppCode.Text = "xxazpozjqlbbxdvs";
            this.textboxAppCode.TextChanged += new System.EventHandler(this.textboxAppCode_TextChanged);
            // 
            // textfromboxemal
            // 
            this.textfromboxemal.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textfromboxemal.Location = new System.Drawing.Point(234, 23);
            this.textfromboxemal.Margin = new System.Windows.Forms.Padding(4);
            this.textfromboxemal.Name = "textfromboxemal";
            this.textfromboxemal.Size = new System.Drawing.Size(337, 44);
            this.textfromboxemal.TabIndex = 9;
            // 
            // subject1
            // 
            this.subject1.AccessibleName = "subject ";
            this.subject1.AutoSize = true;
            this.subject1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject1.Location = new System.Drawing.Point(325, 298);
            this.subject1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subject1.Name = "subject1";
            this.subject1.Size = new System.Drawing.Size(95, 23);
            this.subject1.TabIndex = 17;
            this.subject1.Text = "Subject :";
            this.subject1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textboxSubject
            // 
            this.textboxSubject.AccessibleName = "subject";
            this.textboxSubject.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxSubject.Location = new System.Drawing.Point(329, 339);
            this.textboxSubject.Margin = new System.Windows.Forms.Padding(4);
            this.textboxSubject.Name = "textboxSubject";
            this.textboxSubject.Size = new System.Drawing.Size(617, 38);
            this.textboxSubject.TabIndex = 16;
            this.textboxSubject.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textboxmessage
            // 
            this.textboxmessage.AccessibleName = "description";
            this.textboxmessage.AutoSize = true;
            this.textboxmessage.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxmessage.Location = new System.Drawing.Point(325, 396);
            this.textboxmessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textboxmessage.Name = "textboxmessage";
            this.textboxmessage.Size = new System.Drawing.Size(105, 23);
            this.textboxmessage.TabIndex = 19;
            this.textboxmessage.Text = "Message :";
            this.textboxmessage.Click += new System.EventHandler(this.desclabel_Click);
            // 
            // textBox2
            // 
            this.textBox2.AccessibleName = "subject";
            this.textBox2.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(329, 439);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(617, 138);
            this.textBox2.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 207);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Display Name :";
            // 
            // textboxDisplayName
            // 
            this.textboxDisplayName.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxDisplayName.Location = new System.Drawing.Point(329, 244);
            this.textboxDisplayName.Margin = new System.Windows.Forms.Padding(4);
            this.textboxDisplayName.Name = "textboxDisplayName";
            this.textboxDisplayName.Size = new System.Drawing.Size(617, 38);
            this.textboxDisplayName.TabIndex = 20;
            // 
            // buttonSenEmail
            // 
            this.buttonSenEmail.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSenEmail.Location = new System.Drawing.Point(534, 596);
            this.buttonSenEmail.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSenEmail.Name = "buttonSenEmail";
            this.buttonSenEmail.Size = new System.Drawing.Size(240, 52);
            this.buttonSenEmail.TabIndex = 22;
            this.buttonSenEmail.Text = "Send Email";
            this.buttonSenEmail.UseVisualStyleBackColor = true;
            this.buttonSenEmail.Click += new System.EventHandler(this.buttonSenEmail_Click);
            // 
            // GroupBox_from
            // 
            this.GroupBox_from.BackColor = System.Drawing.Color.Gainsboro;
            this.GroupBox_from.Controls.Add(this.EmailPicShowPassword);
            this.GroupBox_from.Controls.Add(this.Email_picHidePassword);
            this.GroupBox_from.Controls.Add(this.passwordlabel);
            this.GroupBox_from.Controls.Add(this.userlabel);
            this.GroupBox_from.Controls.Add(this.textboxAppCode);
            this.GroupBox_from.Controls.Add(this.textfromboxemal);
            this.GroupBox_from.Location = new System.Drawing.Point(13, 15);
            this.GroupBox_from.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox_from.Name = "GroupBox_from";
            this.GroupBox_from.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox_from.Size = new System.Drawing.Size(581, 178);
            this.GroupBox_from.TabIndex = 23;
            this.GroupBox_from.TabStop = false;
            this.GroupBox_from.Text = "From";
            // 
            // TogroupBox1
            // 
            this.TogroupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.TogroupBox1.Controls.Add(this.label3);
            this.TogroupBox1.Controls.Add(this.textbomtoemail);
            this.TogroupBox1.Location = new System.Drawing.Point(625, 15);
            this.TogroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.TogroupBox1.Name = "TogroupBox1";
            this.TogroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.TogroupBox1.Size = new System.Drawing.Size(555, 178);
            this.TogroupBox1.TabIndex = 24;
            this.TogroupBox1.TabStop = false;
            this.TogroupBox1.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Email :";
            // 
            // textbomtoemail
            // 
            this.textbomtoemail.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbomtoemail.Location = new System.Drawing.Point(191, 21);
            this.textbomtoemail.Margin = new System.Windows.Forms.Padding(4);
            this.textbomtoemail.Name = "textbomtoemail";
            this.textbomtoemail.Size = new System.Drawing.Size(337, 44);
            this.textbomtoemail.TabIndex = 9;
            // 
            // EmailPicShowPassword
            // 
            this.EmailPicShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmailPicShowPassword.Image = global::WindowsFormsApp2.Properties.Resources.show_hide_password_03_512;
            this.EmailPicShowPassword.Location = new System.Drawing.Point(517, 132);
            this.EmailPicShowPassword.Margin = new System.Windows.Forms.Padding(4);
            this.EmailPicShowPassword.Name = "EmailPicShowPassword";
            this.EmailPicShowPassword.Size = new System.Drawing.Size(42, 26);
            this.EmailPicShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmailPicShowPassword.TabIndex = 14;
            this.EmailPicShowPassword.TabStop = false;
            this.EmailPicShowPassword.Click += new System.EventHandler(this.EmailPicShowPassword_Click);
            // 
            // Email_picHidePassword
            // 
            this.Email_picHidePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Email_picHidePassword.Image = global::WindowsFormsApp2.Properties.Resources.show_hide_password_10_512;
            this.Email_picHidePassword.Location = new System.Drawing.Point(521, 132);
            this.Email_picHidePassword.Margin = new System.Windows.Forms.Padding(4);
            this.Email_picHidePassword.Name = "Email_picHidePassword";
            this.Email_picHidePassword.Size = new System.Drawing.Size(38, 26);
            this.Email_picHidePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Email_picHidePassword.TabIndex = 15;
            this.Email_picHidePassword.TabStop = false;
            this.Email_picHidePassword.Click += new System.EventHandler(this.Email_picHidePassword_Click);
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 694);
            this.Controls.Add(this.TogroupBox1);
            this.Controls.Add(this.GroupBox_from);
            this.Controls.Add(this.buttonSenEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxDisplayName);
            this.Controls.Add(this.textboxmessage);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.subject1);
            this.Controls.Add(this.textboxSubject);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Email";
            this.Text = "Email";
            this.Load += new System.EventHandler(this.Email_Load);
            this.GroupBox_from.ResumeLayout(false);
            this.GroupBox_from.PerformLayout();
            this.TogroupBox1.ResumeLayout(false);
            this.TogroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmailPicShowPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Email_picHidePassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox EmailPicShowPassword;
        private System.Windows.Forms.PictureBox Email_picHidePassword;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.Label userlabel;
        private System.Windows.Forms.TextBox textboxAppCode;
        private System.Windows.Forms.TextBox textfromboxemal;
        private System.Windows.Forms.Label subject1;
        private System.Windows.Forms.TextBox textboxSubject;
        private System.Windows.Forms.Label textboxmessage;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxDisplayName;
        private System.Windows.Forms.Button buttonSenEmail;
        private System.Windows.Forms.GroupBox GroupBox_from;
        private System.Windows.Forms.GroupBox TogroupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbomtoemail;
    }
}