namespace QLNH
{
    partial class Form1
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
            this.btDN = new System.Windows.Forms.Button();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTK = new System.Windows.Forms.Label();
            this.lbMK = new System.Windows.Forms.Label();
            this.btDatBan = new System.Windows.Forms.Button();
            this.timePk = new System.Windows.Forms.DateTimePicker();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbTG = new System.Windows.Forms.Label();
            this.lbSN = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBan = new System.Windows.Forms.RadioButton();
            this.rdDD = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btDN
            // 
            this.btDN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDN.Location = new System.Drawing.Point(3, 310);
            this.btDN.Name = "btDN";
            this.btDN.Size = new System.Drawing.Size(349, 36);
            this.btDN.TabIndex = 2;
            this.btDN.Text = "Đăng nhập";
            this.btDN.UseVisualStyleBackColor = true;
            this.btDN.Click += new System.EventHandler(this.BtDN_Click);
            // 
            // txtTK
            // 
            this.txtTK.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtTK.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTK.HideSelection = false;
            this.txtTK.Location = new System.Drawing.Point(29, 65);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(198, 27);
            this.txtTK.TabIndex = 0;
            // 
            // txtMK
            // 
            this.txtMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Location = new System.Drawing.Point(29, 178);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(198, 27);
            this.txtMK.TabIndex = 1;
            this.txtMK.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bạn là:";
            // 
            // lbTK
            // 
            this.lbTK.AutoSize = true;
            this.lbTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTK.Location = new System.Drawing.Point(18, 40);
            this.lbTK.Name = "lbTK";
            this.lbTK.Size = new System.Drawing.Size(93, 22);
            this.lbTK.TabIndex = 0;
            this.lbTK.Text = "Tài Khoản";
            // 
            // lbMK
            // 
            this.lbMK.AutoSize = true;
            this.lbMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMK.Location = new System.Drawing.Point(18, 153);
            this.lbMK.Name = "lbMK";
            this.lbMK.Size = new System.Drawing.Size(86, 22);
            this.lbMK.TabIndex = 7;
            this.lbMK.Text = "Mật Khẩu";
            // 
            // btDatBan
            // 
            this.btDatBan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btDatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDatBan.Location = new System.Drawing.Point(3, 303);
            this.btDatBan.Name = "btDatBan";
            this.btDatBan.Size = new System.Drawing.Size(349, 43);
            this.btDatBan.TabIndex = 7;
            this.btDatBan.Text = "Đặt bàn";
            this.btDatBan.UseVisualStyleBackColor = true;
            this.btDatBan.Click += new System.EventHandler(this.BtDatBan_Click);
            // 
            // timePk
            // 
            this.timePk.CustomFormat = "dd/MM/yyyy";
            this.timePk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePk.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.timePk.Location = new System.Drawing.Point(195, 177);
            this.timePk.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.timePk.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.timePk.Name = "timePk";
            this.timePk.Size = new System.Drawing.Size(124, 27);
            this.timePk.TabIndex = 5;
            this.timePk.Value = new System.DateTime(2019, 11, 4, 0, 0, 0, 0);
            this.timePk.ValueChanged += new System.EventHandler(this.TimePk_ValueChanged);
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(115, 87);
            this.txtSDT.MaxLength = 11;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(171, 27);
            this.txtSDT.TabIndex = 2;
            // 
            // txtSN
            // 
            this.txtSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSN.Location = new System.Drawing.Point(115, 228);
            this.txtSN.MaxLength = 2;
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(171, 27);
            this.txtSN.TabIndex = 6;
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDT.Location = new System.Drawing.Point(24, 92);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(47, 22);
            this.lbSDT.TabIndex = 0;
            this.lbSDT.Text = "SĐT";
            // 
            // lbTG
            // 
            this.lbTG.AutoSize = true;
            this.lbTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTG.Location = new System.Drawing.Point(24, 177);
            this.lbTG.Name = "lbTG";
            this.lbTG.Size = new System.Drawing.Size(85, 22);
            this.lbTG.TabIndex = 1;
            this.lbTG.Text = "Thời gian";
            // 
            // lbSN
            // 
            this.lbSN.AutoSize = true;
            this.lbSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSN.Location = new System.Drawing.Point(24, 228);
            this.lbSN.Name = "lbSN";
            this.lbSN.Size = new System.Drawing.Size(81, 22);
            this.lbSN.TabIndex = 2;
            this.lbSN.Text = "Số người";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(24, 34);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(42, 22);
            this.lbTen.TabIndex = 0;
            this.lbTen.Text = "Tên";
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(115, 34);
            this.txtTen.MaxLength = 20;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(171, 27);
            this.txtTen.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBan);
            this.groupBox1.Controls.Add(this.rdDD);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(43, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 37);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Định dạng";
            // 
            // rdBan
            // 
            this.rdBan.AutoSize = true;
            this.rdBan.Location = new System.Drawing.Point(118, 19);
            this.rdBan.Name = "rdBan";
            this.rdBan.Size = new System.Drawing.Size(135, 17);
            this.rdBan.TabIndex = 1;
            this.rdBan.TabStop = true;
            this.rdBan.Text = "Bàn (8 số + 3 mã vùng)";
            this.rdBan.UseVisualStyleBackColor = true;
            // 
            // rdDD
            // 
            this.rdDD.AutoSize = true;
            this.rdDD.Checked = true;
            this.rdDD.Location = new System.Drawing.Point(8, 19);
            this.rdDD.Name = "rdDD";
            this.rdDD.Size = new System.Drawing.Size(99, 17);
            this.rdDD.TabIndex = 0;
            this.rdDD.TabStop = true;
            this.rdDD.Text = "Di Động (10 số)";
            this.rdDD.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(5, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(363, 382);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbTime);
            this.tabPage1.Controls.Add(this.lbTen);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.txtTen);
            this.tabPage1.Controls.Add(this.btDatBan);
            this.tabPage1.Controls.Add(this.lbSN);
            this.tabPage1.Controls.Add(this.timePk);
            this.tabPage1.Controls.Add(this.lbTG);
            this.tabPage1.Controls.Add(this.txtSDT);
            this.tabPage1.Controls.Add(this.lbSDT);
            this.tabPage1.Controls.Add(this.txtSN);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(355, 349);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Khách Hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbTime
            // 
            this.cbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Items.AddRange(new object[] {
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30"});
            this.cbTime.Location = new System.Drawing.Point(120, 180);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(69, 24);
            this.cbTime.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbTK);
            this.tabPage2.Controls.Add(this.lbMK);
            this.tabPage2.Controls.Add(this.btDN);
            this.tabPage2.Controls.Add(this.txtTK);
            this.tabPage2.Controls.Add(this.txtMK);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(355, 349);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nhân Viên";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(374, 423);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDN;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTK;
        private System.Windows.Forms.Label lbMK;
        private System.Windows.Forms.Button btDatBan;
        private System.Windows.Forms.DateTimePicker timePk;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbTG;
        private System.Windows.Forms.Label lbSN;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdBan;
        private System.Windows.Forms.RadioButton rdDD;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbTime;
    }
}

