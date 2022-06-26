namespace WindowsFormsApp2
{
    partial class loginForm
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.username_texbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.userlabel = new System.Windows.Forms.Label();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.forget_textbox = new System.Windows.Forms.TextBox();
            this.PicShowPassword = new System.Windows.Forms.PictureBox();
            this.picHidePassword = new System.Windows.Forms.PictureBox();
            this.loginPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicShowPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHidePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLogin.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(306, 460);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(290, 66);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // username_texbox
            // 
            this.username_texbox.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_texbox.Location = new System.Drawing.Point(306, 275);
            this.username_texbox.Name = "username_texbox";
            this.username_texbox.Size = new System.Drawing.Size(290, 38);
            this.username_texbox.TabIndex = 1;
            this.username_texbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.username_texbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.username_texbox_KeyDown);
            // 
            // password_textbox
            // 
            this.password_textbox.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textbox.Location = new System.Drawing.Point(306, 351);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.Size = new System.Drawing.Size(290, 35);
            this.password_textbox.TabIndex = 2;
            this.password_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_textbox_KeyDown);
            // 
            // userlabel
            // 
            this.userlabel.AutoSize = true;
            this.userlabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlabel.Location = new System.Drawing.Point(67, 281);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(146, 23);
            this.userlabel.TabIndex = 3;
            this.userlabel.Text = "User Name    :";
            this.userlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlabel.Location = new System.Drawing.Point(67, 358);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(147, 23);
            this.passwordlabel.TabIndex = 4;
            this.passwordlabel.Text = "Password       :";
            // 
            // forget_textbox
            // 
            this.forget_textbox.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forget_textbox.ForeColor = System.Drawing.Color.Red;
            this.forget_textbox.Location = new System.Drawing.Point(494, 397);
            this.forget_textbox.Name = "forget_textbox";
            this.forget_textbox.Size = new System.Drawing.Size(102, 21);
            this.forget_textbox.TabIndex = 5;
            this.forget_textbox.Text = "Forget Password";
            // 
            // PicShowPassword
            // 
            this.PicShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicShowPassword.Image = global::WindowsFormsApp2.Properties.Resources.show_hide_password_03_512;
            this.PicShowPassword.Location = new System.Drawing.Point(548, 357);
            this.PicShowPassword.Name = "PicShowPassword";
            this.PicShowPassword.Size = new System.Drawing.Size(36, 24);
            this.PicShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicShowPassword.TabIndex = 7;
            this.PicShowPassword.TabStop = false;
            this.PicShowPassword.Click += new System.EventHandler(this.PicShowPassword_Click);
            // 
            // picHidePassword
            // 
            this.picHidePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHidePassword.Image = global::WindowsFormsApp2.Properties.Resources.show_hide_password_10_512;
            this.picHidePassword.Location = new System.Drawing.Point(549, 357);
            this.picHidePassword.Name = "picHidePassword";
            this.picHidePassword.Size = new System.Drawing.Size(35, 24);
            this.picHidePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHidePassword.TabIndex = 8;
            this.picHidePassword.TabStop = false;
            this.picHidePassword.Click += new System.EventHandler(this.picHidePassword_Click);
            // 
            // loginPicture
            // 
            this.loginPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginPicture.Image = global::WindowsFormsApp2.Properties.Resources.nnnn;
            this.loginPicture.Location = new System.Drawing.Point(0, 0);
            this.loginPicture.Name = "loginPicture";
            this.loginPicture.Size = new System.Drawing.Size(920, 208);
            this.loginPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginPicture.TabIndex = 6;
            this.loginPicture.TabStop = false;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 577);
            this.Controls.Add(this.PicShowPassword);
            this.Controls.Add(this.picHidePassword);
            this.Controls.Add(this.loginPicture);
            this.Controls.Add(this.forget_textbox);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.userlabel);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.username_texbox);
            this.Controls.Add(this.btnLogin);
            this.Name = "loginForm";
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.loginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicShowPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHidePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox username_texbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Label userlabel;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.TextBox forget_textbox;
        private System.Windows.Forms.PictureBox loginPicture;
        private System.Windows.Forms.PictureBox PicShowPassword;
        private System.Windows.Forms.PictureBox picHidePassword;
    }
}

