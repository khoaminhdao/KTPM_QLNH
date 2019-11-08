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
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btQLNV = new System.Windows.Forms.Button();
            this.btQLTD = new System.Windows.Forms.Button();
            this.btQLB = new System.Windows.Forms.Button();
            this.btQLHD = new System.Windows.Forms.Button();
            this.btGoiMon = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chàoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(221, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chàoToolStripMenuItem
            // 
            this.chàoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.toolStripSeparator1,
            this.đăngXuấtToolStripMenuItem});
            this.chàoToolStripMenuItem.Name = "chàoToolStripMenuItem";
            this.chàoToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.chàoToolStripMenuItem.Text = "Chào, ";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi Mật Khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.ĐổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.ĐăngXuấtToolStripMenuItem_Click);
            // 
            // btQLNV
            // 
            this.btQLNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQLNV.Location = new System.Drawing.Point(6, 120);
            this.btQLNV.Name = "btQLNV";
            this.btQLNV.Size = new System.Drawing.Size(178, 29);
            this.btQLNV.TabIndex = 2;
            this.btQLNV.Text = "Quản lý nhân viên";
            this.btQLNV.UseVisualStyleBackColor = true;
            this.btQLNV.Click += new System.EventHandler(this.BtQLNV_Click);
            // 
            // btQLTD
            // 
            this.btQLTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQLTD.Location = new System.Drawing.Point(6, 167);
            this.btQLTD.Name = "btQLTD";
            this.btQLTD.Size = new System.Drawing.Size(178, 29);
            this.btQLTD.TabIndex = 3;
            this.btQLTD.Text = "Quản lý thực đơn";
            this.btQLTD.UseVisualStyleBackColor = true;
            this.btQLTD.Click += new System.EventHandler(this.BtQLTD_Click);
            // 
            // btQLB
            // 
            this.btQLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQLB.Location = new System.Drawing.Point(6, 75);
            this.btQLB.Name = "btQLB";
            this.btQLB.Size = new System.Drawing.Size(178, 29);
            this.btQLB.TabIndex = 1;
            this.btQLB.Text = "Quản lý bàn";
            this.btQLB.UseVisualStyleBackColor = true;
            this.btQLB.Click += new System.EventHandler(this.BtQLB_Click);
            // 
            // btQLHD
            // 
            this.btQLHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQLHD.Location = new System.Drawing.Point(6, 212);
            this.btQLHD.Name = "btQLHD";
            this.btQLHD.Size = new System.Drawing.Size(178, 29);
            this.btQLHD.TabIndex = 4;
            this.btQLHD.Text = "Quản lý hóa đơn";
            this.btQLHD.UseVisualStyleBackColor = true;
            this.btQLHD.Click += new System.EventHandler(this.BtQLHD_Click);
            // 
            // btGoiMon
            // 
            this.btGoiMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGoiMon.Location = new System.Drawing.Point(6, 29);
            this.btGoiMon.Name = "btGoiMon";
            this.btGoiMon.Size = new System.Drawing.Size(178, 29);
            this.btGoiMon.TabIndex = 0;
            this.btGoiMon.Text = "Gọi Món";
            this.btGoiMon.UseVisualStyleBackColor = true;
            this.btGoiMon.Click += new System.EventHandler(this.BtGoiMon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btGoiMon);
            this.groupBox1.Controls.Add(this.btQLHD);
            this.groupBox1.Controls.Add(this.btQLB);
            this.groupBox1.Controls.Add(this.btQLTD);
            this.groupBox1.Controls.Add(this.btQLNV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 255);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // MenuNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 310);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuNV";
            this.Load += new System.EventHandler(this.MenuNV_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}