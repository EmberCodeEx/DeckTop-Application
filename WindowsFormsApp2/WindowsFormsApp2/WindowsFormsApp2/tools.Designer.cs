namespace WindowsFormsApp2
{
    partial class tools
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
            this.browserButton = new System.Windows.Forms.Button();
            this.inputTab = new System.Windows.Forms.TabControl();
            this.DataGrid = new System.Windows.Forms.TabPage();
            this.Txt_Message = new System.Windows.Forms.RichTextBox();
            this.Dgb_Attachments = new System.Windows.Forms.DataGridView();
            this.sr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PicBox_font = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Txt_Subject = new System.Windows.Forms.TextBox();
            this.Btn_Attachfile = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Ssl_CheckBox = new System.Windows.Forms.CheckBox();
            this.Txt_Port = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_ToEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_AppCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_from = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Rdo_Other = new System.Windows.Forms.RadioButton();
            this.Rdo_Live = new System.Windows.Forms.RadioButton();
            this.Rdo_Yahoo = new System.Windows.Forms.RadioButton();
            this.Rdo_Outlook = new System.Windows.Forms.RadioButton();
            this.Rdo_Gmail = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.Txt_Displayname = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.FileName = new System.Windows.Forms.Label();
            this.Btn_SendEmail = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.inputTab.SuspendLayout();
            this.DataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgb_Attachments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_font)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // browserButton
            // 
            this.browserButton.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browserButton.Location = new System.Drawing.Point(133, 15);
            this.browserButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.browserButton.Name = "browserButton";
            this.browserButton.Size = new System.Drawing.Size(1429, 42);
            this.browserButton.TabIndex = 0;
            this.browserButton.Text = "Broswer";
            this.browserButton.UseVisualStyleBackColor = true;
            // 
            // inputTab
            // 
            this.inputTab.AccessibleName = "";
            this.inputTab.Controls.Add(this.DataGrid);
            this.inputTab.Controls.Add(this.tabPage2);
            this.inputTab.Controls.Add(this.tabPage3);
            this.inputTab.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTab.Location = new System.Drawing.Point(77, 95);
            this.inputTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputTab.Name = "inputTab";
            this.inputTab.SelectedIndex = 0;
            this.inputTab.Size = new System.Drawing.Size(1435, 682);
            this.inputTab.TabIndex = 1;
            // 
            // DataGrid
            // 
            this.DataGrid.Controls.Add(this.Txt_Message);
            this.DataGrid.Controls.Add(this.Dgb_Attachments);
            this.DataGrid.Controls.Add(this.PicBox_font);
            this.DataGrid.Controls.Add(this.label16);
            this.DataGrid.Controls.Add(this.label15);
            this.DataGrid.Controls.Add(this.Txt_Subject);
            this.DataGrid.Controls.Add(this.Btn_Attachfile);
            this.DataGrid.Controls.Add(this.label11);
            this.DataGrid.Controls.Add(this.groupBox);
            this.DataGrid.Controls.Add(this.label12);
            this.DataGrid.Controls.Add(this.Txt_Displayname);
            this.DataGrid.Controls.Add(this.label14);
            this.DataGrid.Controls.Add(this.label13);
            this.DataGrid.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGrid.Location = new System.Drawing.Point(4, 39);
            this.DataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGrid.Size = new System.Drawing.Size(1427, 639);
            this.DataGrid.TabIndex = 0;
            this.DataGrid.Text = "               Mail Information                 ";
            this.DataGrid.UseVisualStyleBackColor = true;
            // 
            // Txt_Message
            // 
            this.Txt_Message.Location = new System.Drawing.Point(253, 393);
            this.Txt_Message.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Message.Name = "Txt_Message";
            this.Txt_Message.Size = new System.Drawing.Size(644, 219);
            this.Txt_Message.TabIndex = 33;
            this.Txt_Message.Text = "";
            // 
            // Dgb_Attachments
            // 
            this.Dgb_Attachments.AllowUserToAddRows = false;
            this.Dgb_Attachments.BackgroundColor = System.Drawing.Color.White;
            this.Dgb_Attachments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgb_Attachments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sr,
            this.Location,
            this.xColumn});
            this.Dgb_Attachments.Location = new System.Drawing.Point(916, 325);
            this.Dgb_Attachments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dgb_Attachments.Name = "Dgb_Attachments";
            this.Dgb_Attachments.RowHeadersVisible = false;
            this.Dgb_Attachments.Size = new System.Drawing.Size(452, 281);
            this.Dgb_Attachments.TabIndex = 32;
            // 
            // sr
            // 
            this.sr.FillWeight = 80F;
            this.sr.HeaderText = "Sr   ";
            this.sr.Name = "sr";
            this.sr.Width = 50;
            // 
            // Location
            // 
            this.Location.FillWeight = 80F;
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            this.Location.Width = 250;
            // 
            // xColumn
            // 
            this.xColumn.FillWeight = 80F;
            this.xColumn.HeaderText = "x";
            this.xColumn.Name = "xColumn";
            this.xColumn.Width = 50;
            // 
            // PicBox_font
            // 
            this.PicBox_font.Image = global::WindowsFormsApp2.Properties.Resources.font;
            this.PicBox_font.Location = new System.Drawing.Point(193, 393);
            this.PicBox_font.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PicBox_font.Name = "PicBox_font";
            this.PicBox_font.Size = new System.Drawing.Size(52, 36);
            this.PicBox_font.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBox_font.TabIndex = 31;
            this.PicBox_font.TabStop = false;
            this.PicBox_font.Click += new System.EventHandler(this.PicBox_font_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(33, 393);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(117, 29);
            this.label16.TabIndex = 29;
            this.label16.Text = "Message :";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(977, 270);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(172, 29);
            this.label15.TabIndex = 28;
            this.label15.Text = "Attached files :";
            // 
            // Txt_Subject
            // 
            this.Txt_Subject.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Subject.Location = new System.Drawing.Point(253, 325);
            this.Txt_Subject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Subject.Name = "Txt_Subject";
            this.Txt_Subject.Size = new System.Drawing.Size(644, 34);
            this.Txt_Subject.TabIndex = 27;
            // 
            // Btn_Attachfile
            // 
            this.Btn_Attachfile.BackColor = System.Drawing.Color.White;
            this.Btn_Attachfile.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Attachfile.Location = new System.Drawing.Point(1192, 270);
            this.Btn_Attachfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Attachfile.Name = "Btn_Attachfile";
            this.Btn_Attachfile.Size = new System.Drawing.Size(176, 32);
            this.Btn_Attachfile.TabIndex = 2;
            this.Btn_Attachfile.Text = "Broswer";
            this.Btn_Attachfile.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label11.Location = new System.Drawing.Point(145, 329);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 29);
            this.label11.TabIndex = 26;
            this.label11.Text = "*";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label10);
            this.groupBox.Controls.Add(this.Ssl_CheckBox);
            this.groupBox.Controls.Add(this.Txt_Port);
            this.groupBox.Controls.Add(this.label8);
            this.groupBox.Controls.Add(this.label9);
            this.groupBox.Controls.Add(this.Txt_ToEmail);
            this.groupBox.Controls.Add(this.label6);
            this.groupBox.Controls.Add(this.pictureBox1);
            this.groupBox.Controls.Add(this.pictureBox2);
            this.groupBox.Controls.Add(this.label7);
            this.groupBox.Controls.Add(this.Txt_AppCode);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.Txt_from);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.Rdo_Other);
            this.groupBox.Controls.Add(this.Rdo_Live);
            this.groupBox.Controls.Add(this.Rdo_Yahoo);
            this.groupBox.Controls.Add(this.Rdo_Outlook);
            this.groupBox.Controls.Add(this.Rdo_Gmail);
            this.groupBox.Location = new System.Drawing.Point(20, 16);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox.Size = new System.Drawing.Size(1348, 233);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Mail Cardinality";
            this.groupBox.Enter += new System.EventHandler(this.groupBox_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label10.Location = new System.Drawing.Point(1187, 153);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 29);
            this.label10.TabIndex = 21;
            this.label10.Text = "*";
            // 
            // Ssl_CheckBox
            // 
            this.Ssl_CheckBox.AutoSize = true;
            this.Ssl_CheckBox.Location = new System.Drawing.Point(1220, 151);
            this.Ssl_CheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ssl_CheckBox.Name = "Ssl_CheckBox";
            this.Ssl_CheckBox.Size = new System.Drawing.Size(75, 33);
            this.Ssl_CheckBox.TabIndex = 20;
            this.Ssl_CheckBox.Text = "SSL";
            this.Ssl_CheckBox.UseVisualStyleBackColor = true;
            // 
            // Txt_Port
            // 
            this.Txt_Port.Location = new System.Drawing.Point(939, 149);
            this.Txt_Port.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Port.Name = "Txt_Port";
            this.Txt_Port.Size = new System.Drawing.Size(200, 34);
            this.Txt_Port.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(865, 153);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 29);
            this.label8.TabIndex = 18;
            this.label8.Text = "*";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(779, 156);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 29);
            this.label9.TabIndex = 17;
            this.label9.Text = "Port :";
            // 
            // Txt_ToEmail
            // 
            this.Txt_ToEmail.Location = new System.Drawing.Point(939, 94);
            this.Txt_ToEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_ToEmail.Name = "Txt_ToEmail";
            this.Txt_ToEmail.Size = new System.Drawing.Size(363, 34);
            this.Txt_ToEmail.TabIndex = 16;
            this.Txt_ToEmail.TextChanged += new System.EventHandler(this.Txt_ServerUrl_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(905, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "*";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.show_hide_password_03_512;
            this.pictureBox1.Location = new System.Drawing.Point(697, 156);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp2.Properties.Resources.show_hide_password_10_512;
            this.pictureBox2.Location = new System.Drawing.Point(701, 156);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(779, 101);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "To Email  :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Txt_AppCode
            // 
            this.Txt_AppCode.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_AppCode.Location = new System.Drawing.Point(233, 156);
            this.Txt_AppCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_AppCode.Name = "Txt_AppCode";
            this.Txt_AppCode.Size = new System.Drawing.Size(468, 34);
            this.Txt_AppCode.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(147, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 156);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "App Code :";
            // 
            // Txt_from
            // 
            this.Txt_from.Location = new System.Drawing.Point(233, 94);
            this.Txt_from.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_from.Name = "Txt_from";
            this.Txt_from.Size = new System.Drawing.Size(508, 34);
            this.Txt_from.TabIndex = 8;
            this.Txt_from.TextChanged += new System.EventHandler(this.Txt_from_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(168, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "*";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "From Email :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 5;
            // 
            // Rdo_Other
            // 
            this.Rdo_Other.AutoSize = true;
            this.Rdo_Other.Location = new System.Drawing.Point(1152, 33);
            this.Rdo_Other.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Rdo_Other.Name = "Rdo_Other";
            this.Rdo_Other.Size = new System.Drawing.Size(96, 33);
            this.Rdo_Other.TabIndex = 4;
            this.Rdo_Other.TabStop = true;
            this.Rdo_Other.Text = "Other";
            this.Rdo_Other.UseVisualStyleBackColor = true;
            // 
            // Rdo_Live
            // 
            this.Rdo_Live.AutoSize = true;
            this.Rdo_Live.Location = new System.Drawing.Point(939, 33);
            this.Rdo_Live.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Rdo_Live.Name = "Rdo_Live";
            this.Rdo_Live.Size = new System.Drawing.Size(122, 33);
            this.Rdo_Live.TabIndex = 3;
            this.Rdo_Live.TabStop = true;
            this.Rdo_Live.Text = "Hotmail";
            this.Rdo_Live.UseVisualStyleBackColor = true;
            // 
            // Rdo_Yahoo
            // 
            this.Rdo_Yahoo.AutoSize = true;
            this.Rdo_Yahoo.Location = new System.Drawing.Point(492, 33);
            this.Rdo_Yahoo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Rdo_Yahoo.Name = "Rdo_Yahoo";
            this.Rdo_Yahoo.Size = new System.Drawing.Size(101, 33);
            this.Rdo_Yahoo.TabIndex = 2;
            this.Rdo_Yahoo.TabStop = true;
            this.Rdo_Yahoo.Text = "Yahoo";
            this.Rdo_Yahoo.UseVisualStyleBackColor = true;
            // 
            // Rdo_Outlook
            // 
            this.Rdo_Outlook.AutoSize = true;
            this.Rdo_Outlook.Location = new System.Drawing.Point(711, 33);
            this.Rdo_Outlook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Rdo_Outlook.Name = "Rdo_Outlook";
            this.Rdo_Outlook.Size = new System.Drawing.Size(120, 33);
            this.Rdo_Outlook.TabIndex = 1;
            this.Rdo_Outlook.TabStop = true;
            this.Rdo_Outlook.Text = "Outlook";
            this.Rdo_Outlook.UseVisualStyleBackColor = true;
            // 
            // Rdo_Gmail
            // 
            this.Rdo_Gmail.AutoSize = true;
            this.Rdo_Gmail.Location = new System.Drawing.Point(281, 33);
            this.Rdo_Gmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Rdo_Gmail.Name = "Rdo_Gmail";
            this.Rdo_Gmail.Size = new System.Drawing.Size(98, 33);
            this.Rdo_Gmail.TabIndex = 0;
            this.Rdo_Gmail.TabStop = true;
            this.Rdo_Gmail.Text = "Gmail";
            this.Rdo_Gmail.UseVisualStyleBackColor = true;
            this.Rdo_Gmail.CheckedChanged += new System.EventHandler(this.gmailRadioButton_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 329);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 29);
            this.label12.TabIndex = 25;
            this.label12.Text = "Subject :";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // Txt_Displayname
            // 
            this.Txt_Displayname.Location = new System.Drawing.Point(253, 266);
            this.Txt_Displayname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Displayname.Name = "Txt_Displayname";
            this.Txt_Displayname.Size = new System.Drawing.Size(644, 34);
            this.Txt_Displayname.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 266);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(181, 29);
            this.label14.TabIndex = 22;
            this.label14.Text = "Desplay Name :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label13.Location = new System.Drawing.Point(220, 266);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 29);
            this.label13.TabIndex = 23;
            this.label13.Text = "*";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1427, 639);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "                  Input Urls & All Email             ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1427, 639);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "                 Copy past                ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // FileName
            // 
            this.FileName.AutoSize = true;
            this.FileName.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileName.Location = new System.Drawing.Point(79, 55);
            this.FileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(186, 23);
            this.FileName.TabIndex = 0;
            this.FileName.Text = "File Location : None ";
            // 
            // Btn_SendEmail
            // 
            this.Btn_SendEmail.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SendEmail.Location = new System.Drawing.Point(77, 784);
            this.Btn_SendEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_SendEmail.Name = "Btn_SendEmail";
            this.Btn_SendEmail.Size = new System.Drawing.Size(1429, 60);
            this.Btn_SendEmail.TabIndex = 2;
            this.Btn_SendEmail.Text = "Send Email";
            this.Btn_SendEmail.UseVisualStyleBackColor = true;
            this.Btn_SendEmail.Click += new System.EventHandler(this.Btn_SendEmail_Click);
            // 
            // tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1606, 859);
            this.Controls.Add(this.Btn_SendEmail);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.inputTab);
            this.Controls.Add(this.browserButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "tools";
            this.Text = "tools";
            this.Load += new System.EventHandler(this.tools_Load);
            this.inputTab.ResumeLayout(false);
            this.DataGrid.ResumeLayout(false);
            this.DataGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgb_Attachments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_font)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browserButton;
        private System.Windows.Forms.TabControl inputTab;
        private System.Windows.Forms.TabPage DataGrid;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Rdo_Other;
        private System.Windows.Forms.RadioButton Rdo_Live;
        private System.Windows.Forms.RadioButton Rdo_Yahoo;
        private System.Windows.Forms.RadioButton Rdo_Outlook;
        private System.Windows.Forms.RadioButton Rdo_Gmail;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label FileName;
        private System.Windows.Forms.TextBox Txt_AppCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_from;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Txt_ToEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_Port;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Btn_Attachfile;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox Ssl_CheckBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Txt_Subject;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Txt_Displayname;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox PicBox_font;
        private System.Windows.Forms.RichTextBox Txt_Message;
        private System.Windows.Forms.DataGridView Dgb_Attachments;
        private System.Windows.Forms.DataGridViewTextBoxColumn sr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn xColumn;
        private System.Windows.Forms.Button Btn_SendEmail;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}