namespace WindowsFormsApp2
{
    partial class Advancetool
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
            this.btn_viewpath = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // btn_viewpath
            // 
            this.btn_viewpath.BackColor = System.Drawing.Color.White;
            this.btn_viewpath.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewpath.Location = new System.Drawing.Point(239, 45);
            this.btn_viewpath.Name = "btn_viewpath";
            this.btn_viewpath.Size = new System.Drawing.Size(813, 81);
            this.btn_viewpath.TabIndex = 0;
            this.btn_viewpath.Text = "View Path";
            this.btn_viewpath.UseVisualStyleBackColor = false;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(239, 132);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(813, 391);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Advancetool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 620);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btn_viewpath);
            this.Name = "Advancetool";
            this.Text = "Advancetool";
            this.Load += new System.EventHandler(this.Advancetool_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_viewpath;
        private System.Windows.Forms.TreeView treeView1;
    }
}