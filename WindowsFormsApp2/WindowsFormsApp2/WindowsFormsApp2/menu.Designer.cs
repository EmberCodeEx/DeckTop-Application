namespace WindowsFormsApp2
{
    partial class Homepage
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
            this.components = new System.ComponentModel.Container();
            this.menu_label = new System.Windows.Forms.Label();
            this.pickSignout = new System.Windows.Forms.PictureBox();
            this.PickLogout = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lableDateTIme = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pickSignout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PickLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_label
            // 
            this.menu_label.AutoSize = true;
            this.menu_label.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_label.Location = new System.Drawing.Point(237, 229);
            this.menu_label.Name = "menu_label";
            this.menu_label.Size = new System.Drawing.Size(378, 31);
            this.menu_label.TabIndex = 3;
            this.menu_label.Text = "Welcome to FAST_NUCES";
            // 
            // pickSignout
            // 
            this.pickSignout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pickSignout.Image = global::WindowsFormsApp2.Properties.Resources.logout;
            this.pickSignout.Location = new System.Drawing.Point(766, 129);
            this.pickSignout.Name = "pickSignout";
            this.pickSignout.Size = new System.Drawing.Size(46, 32);
            this.pickSignout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pickSignout.TabIndex = 7;
            this.pickSignout.TabStop = false;
            this.pickSignout.Click += new System.EventHandler(this.pickSignout_Click);
            // 
            // PickLogout
            // 
            this.PickLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PickLogout.Image = global::WindowsFormsApp2.Properties.Resources.icons8_logout_rounded_up_96;
            this.PickLogout.Location = new System.Drawing.Point(766, 67);
            this.PickLogout.Name = "PickLogout";
            this.PickLogout.Size = new System.Drawing.Size(46, 32);
            this.PickLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PickLogout.TabIndex = 6;
            this.PickLogout.TabStop = false;
            this.PickLogout.Click += new System.EventHandler(this.PickLogout_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp2.Properties.Resources.seeting;
            this.pictureBox2.Location = new System.Drawing.Point(323, 388);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(207, 153);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.nnnn;
            this.pictureBox1.Location = new System.Drawing.Point(146, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(530, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(389, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(407, 27);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(389, 20);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // lableDateTIme
            // 
            this.lableDateTIme.AutoSize = true;
            this.lableDateTIme.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableDateTIme.Location = new System.Drawing.Point(246, 304);
            this.lableDateTIme.Name = "lableDateTIme";
            this.lableDateTIme.Size = new System.Drawing.Size(233, 31);
            this.lableDateTIme.TabIndex = 10;
            this.lableDateTIme.Text = "Date and Time :";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 553);
            this.Controls.Add(this.lableDateTIme);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pickSignout);
            this.Controls.Add(this.PickLogout);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menu_label);
            this.Name = "Homepage";
            this.Text = "menu";
            this.Load += new System.EventHandler(this.Homepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pickSignout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PickLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label menu_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox PickLogout;
        private System.Windows.Forms.PictureBox pickSignout;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lableDateTIme;
        private System.Windows.Forms.Timer timer1;
    }
}