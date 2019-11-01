namespace QLNH
{
    partial class MenuNV
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chàoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btQLNV = new System.Windows.Forms.Button();
            this.btQLTD = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chàoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(832, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chàoToolStripMenuItem
            // 
            this.chàoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem});
            this.chàoToolStripMenuItem.Name = "chàoToolStripMenuItem";
            this.chàoToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.chàoToolStripMenuItem.Text = "Chào, ";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.ĐăngXuấtToolStripMenuItem_Click);
            // 
            // btQLNV
            // 
            this.btQLNV.Location = new System.Drawing.Point(117, 119);
            this.btQLNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btQLNV.Name = "btQLNV";
            this.btQLNV.Size = new System.Drawing.Size(237, 82);
            this.btQLNV.TabIndex = 1;
            this.btQLNV.Text = "Quản lý nhân viên";
            this.btQLNV.UseVisualStyleBackColor = true;
            this.btQLNV.Click += new System.EventHandler(this.BtQLNV_Click);
            // 
            // btQLTD
            // 
            this.btQLTD.Location = new System.Drawing.Point(449, 119);
            this.btQLTD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btQLTD.Name = "btQLTD";
            this.btQLTD.Size = new System.Drawing.Size(237, 82);
            this.btQLTD.TabIndex = 2;
            this.btQLTD.Text = "Quản lý thực đơn";
            this.btQLTD.UseVisualStyleBackColor = true;
            this.btQLTD.Click += new System.EventHandler(this.BtQLTD_Click);
            // 
            // MenuNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 554);
            this.Controls.Add(this.btQLTD);
            this.Controls.Add(this.btQLNV);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MenuNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuNV";
            this.Load += new System.EventHandler(this.MenuNV_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chàoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Button btQLNV;
        private System.Windows.Forms.Button btQLTD;
    }
}