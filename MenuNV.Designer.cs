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
            this.btQLB = new System.Windows.Forms.Button();
            this.btQLHD = new System.Windows.Forms.Button();
            this.btGoiMon = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chàoToolStripMenuItem
            // 
            this.chàoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem});
            this.chàoToolStripMenuItem.Name = "chàoToolStripMenuItem";
            this.chàoToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.chàoToolStripMenuItem.Text = "Chào, ";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.ĐăngXuấtToolStripMenuItem_Click);
            // 
            // btQLNV
            // 
            this.btQLNV.Location = new System.Drawing.Point(88, 97);
            this.btQLNV.Name = "btQLNV";
            this.btQLNV.Size = new System.Drawing.Size(178, 67);
            this.btQLNV.TabIndex = 1;
            this.btQLNV.Text = "Quản lý nhân viên";
            this.btQLNV.UseVisualStyleBackColor = true;
            this.btQLNV.Click += new System.EventHandler(this.BtQLNV_Click);
            // 
            // btQLTD
            // 
            this.btQLTD.Location = new System.Drawing.Point(337, 97);
            this.btQLTD.Name = "btQLTD";
            this.btQLTD.Size = new System.Drawing.Size(178, 67);
            this.btQLTD.TabIndex = 2;
            this.btQLTD.Text = "Quản lý thực đơn";
            this.btQLTD.UseVisualStyleBackColor = true;
            this.btQLTD.Click += new System.EventHandler(this.BtQLTD_Click);
            // 
            // btQLB
            // 
            this.btQLB.Location = new System.Drawing.Point(88, 222);
            this.btQLB.Name = "btQLB";
            this.btQLB.Size = new System.Drawing.Size(178, 67);
            this.btQLB.TabIndex = 3;
            this.btQLB.Text = "Quản lý bàn";
            this.btQLB.UseVisualStyleBackColor = true;
            this.btQLB.Click += new System.EventHandler(this.BtQLB_Click);
            // 
            // btQLHD
            // 
            this.btQLHD.Location = new System.Drawing.Point(337, 222);
            this.btQLHD.Name = "btQLHD";
            this.btQLHD.Size = new System.Drawing.Size(178, 67);
            this.btQLHD.TabIndex = 4;
            this.btQLHD.Text = "Quản lý hóa đơn";
            this.btQLHD.UseVisualStyleBackColor = true;
            this.btQLHD.Click += new System.EventHandler(this.BtQLHD_Click);
            // 
            // btGoiMon
            // 
            this.btGoiMon.Location = new System.Drawing.Point(202, 327);
            this.btGoiMon.Name = "btGoiMon";
            this.btGoiMon.Size = new System.Drawing.Size(178, 67);
            this.btGoiMon.TabIndex = 5;
            this.btGoiMon.Text = "Gọi Món";
            this.btGoiMon.UseVisualStyleBackColor = true;
            this.btGoiMon.Click += new System.EventHandler(this.BtGoiMon_Click);
            // 
            // MenuNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.btGoiMon);
            this.Controls.Add(this.btQLHD);
            this.Controls.Add(this.btQLB);
            this.Controls.Add(this.btQLTD);
            this.Controls.Add(this.btQLNV);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.Button btQLB;
        private System.Windows.Forms.Button btQLHD;
        private System.Windows.Forms.Button btGoiMon;
    }
}