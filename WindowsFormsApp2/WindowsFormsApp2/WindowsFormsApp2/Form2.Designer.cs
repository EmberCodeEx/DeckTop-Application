namespace WindowsFormsApp2
{
    partial class StudentManagment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_section = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCellno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_session = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_rollno = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.DgpRecoeds = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Session = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Roll_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cell_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.DgpRecoeds)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(226, 56);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(423, 37);
            this.txt_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Section :";
            // 
            // txt_section
            // 
            this.txt_section.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_section.Location = new System.Drawing.Point(226, 116);
            this.txt_section.Margin = new System.Windows.Forms.Padding(4);
            this.txt_section.Name = "txt_section";
            this.txt_section.Size = new System.Drawing.Size(423, 37);
            this.txt_section.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 307);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cell No :";
            // 
            // txtCellno
            // 
            this.txtCellno.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCellno.Location = new System.Drawing.Point(226, 297);
            this.txtCellno.Margin = new System.Windows.Forms.Padding(4);
            this.txtCellno.Name = "txtCellno";
            this.txtCellno.Size = new System.Drawing.Size(423, 37);
            this.txtCellno.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 186);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Session :";
            // 
            // txt_session
            // 
            this.txt_session.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_session.Location = new System.Drawing.Point(226, 176);
            this.txt_session.Margin = new System.Windows.Forms.Padding(4);
            this.txt_session.Name = "txt_session";
            this.txt_session.Size = new System.Drawing.Size(423, 37);
            this.txt_session.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 246);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Roll No :";
            // 
            // txt_rollno
            // 
            this.txt_rollno.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rollno.Location = new System.Drawing.Point(226, 237);
            this.txt_rollno.Margin = new System.Windows.Forms.Padding(4);
            this.txt_rollno.Name = "txt_rollno";
            this.txt_rollno.Size = new System.Drawing.Size(423, 37);
            this.txt_rollno.TabIndex = 10;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Yellow;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(226, 494);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(191, 70);
            this.btn_update.TabIndex = 12;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Lime;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(226, 394);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(424, 92);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(461, 494);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(189, 70);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.button2_Click);
            // 
            // DgpRecoeds
            // 
            this.DgpRecoeds.AllowUserToAddRows = false;
            this.DgpRecoeds.AllowUserToResizeColumns = false;
            this.DgpRecoeds.AllowUserToResizeRows = false;
            this.DgpRecoeds.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DgpRecoeds.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgpRecoeds.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgpRecoeds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgpRecoeds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Section,
            this.Session,
            this.Roll_no,
            this.Cell_no});
            this.DgpRecoeds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DgpRecoeds.Location = new System.Drawing.Point(657, 56);
            this.DgpRecoeds.Margin = new System.Windows.Forms.Padding(4);
            this.DgpRecoeds.Name = "DgpRecoeds";
            this.DgpRecoeds.ReadOnly = true;
            this.DgpRecoeds.RowHeadersVisible = false;
            this.DgpRecoeds.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DgpRecoeds.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Red;
            this.DgpRecoeds.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgpRecoeds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgpRecoeds.Size = new System.Drawing.Size(775, 508);
            this.DgpRecoeds.TabIndex = 15;
            this.DgpRecoeds.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgpRecoeds_CellClick);
            this.DgpRecoeds.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgpRecoeds_CellContentClick);
            this.DgpRecoeds.Click += new System.EventHandler(this.DgpRecoeds_Click);
            // 
            // Name
            // 
            this.Name.HeaderText = "Name ";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 130;
            // 
            // Section
            // 
            this.Section.HeaderText = "Section";
            this.Section.Name = "Section";
            this.Section.ReadOnly = true;
            this.Section.Width = 120;
            // 
            // Session
            // 
            this.Session.HeaderText = "Session";
            this.Session.Name = "Session";
            this.Session.ReadOnly = true;
            this.Session.Width = 120;
            // 
            // Roll_no
            // 
            this.Roll_no.HeaderText = "Roll_no";
            this.Roll_no.Name = "Roll_no";
            this.Roll_no.ReadOnly = true;
            this.Roll_no.Width = 120;
            // 
            // Cell_no
            // 
            this.Cell_no.HeaderText = "Cell_no";
            this.Cell_no.Name = "Cell_no";
            this.Cell_no.ReadOnly = true;
            this.Cell_no.Width = 120;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // StudentManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1511, 753);
            this.Controls.Add(this.DgpRecoeds);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_rollno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_session);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCellno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_section);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_name);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentManagment";
            this.Text = "StudentManagment";
            this.Load += new System.EventHandler(this.StudentManagment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgpRecoeds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_section;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCellno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_session;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_rollno;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView DgpRecoeds;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Section;
        private System.Windows.Forms.DataGridViewTextBoxColumn Session;
        private System.Windows.Forms.DataGridViewTextBoxColumn Roll_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cell_no;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}