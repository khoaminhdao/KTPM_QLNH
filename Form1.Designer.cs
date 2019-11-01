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
            this.btKH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btNV = new System.Windows.Forms.Button();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btDN
            // 
            this.btDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDN.Location = new System.Drawing.Point(588, 334);
            this.btDN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btDN.Name = "btDN";
            this.btDN.Size = new System.Drawing.Size(141, 44);
            this.btDN.TabIndex = 0;
            this.btDN.Text = "Đăng nhập";
            this.btDN.UseVisualStyleBackColor = true;
            this.btDN.Visible = false;
            this.btDN.Click += new System.EventHandler(this.BtDN_Click);
            // 
            // txtTK
            // 
            this.txtTK.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTK.Location = new System.Drawing.Point(520, 175);
            this.txtTK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(263, 32);
            this.txtTK.TabIndex = 1;
            this.txtTK.Visible = false;
            // 
            // txtMK
            // 
            this.txtMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Location = new System.Drawing.Point(520, 249);
            this.txtMK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(265, 32);
            this.txtMK.TabIndex = 2;
            this.txtMK.UseSystemPasswordChar = true;
            this.txtMK.Visible = false;
            // 
            // btKH
            // 
            this.btKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKH.Location = new System.Drawing.Point(144, 85);
            this.btKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btKH.Name = "btKH";
            this.btKH.Size = new System.Drawing.Size(179, 59);
            this.btKH.TabIndex = 3;
            this.btKH.Text = "Khách Hàng";
            this.btKH.UseVisualStyleBackColor = true;
            this.btKH.Click += new System.EventHandler(this.BtKH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bạn là:";
            // 
            // btNV
            // 
            this.btNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNV.Location = new System.Drawing.Point(563, 86);
            this.btNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btNV.Name = "btNV";
            this.btNV.Size = new System.Drawing.Size(179, 58);
            this.btNV.TabIndex = 5;
            this.btNV.Text = "Nhân Viên";
            this.btNV.UseVisualStyleBackColor = true;
            this.btNV.Click += new System.EventHandler(this.BtNV_Click);
            // 
            // lbTK
            // 
            this.lbTK.AutoSize = true;
            this.lbTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTK.Location = new System.Drawing.Point(388, 175);
            this.lbTK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTK.Name = "lbTK";
            this.lbTK.Size = new System.Drawing.Size(110, 26);
            this.lbTK.TabIndex = 6;
            this.lbTK.Text = "Tài Khoản";
            this.lbTK.Visible = false;
            // 
            // lbMK
            // 
            this.lbMK.AutoSize = true;
            this.lbMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMK.Location = new System.Drawing.Point(388, 252);
            this.lbMK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMK.Name = "lbMK";
            this.lbMK.Size = new System.Drawing.Size(105, 26);
            this.lbMK.TabIndex = 7;
            this.lbMK.Text = "Mật Khẩu";
            this.lbMK.Visible = false;
            // 
            // btDatBan
            // 
            this.btDatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDatBan.Location = new System.Drawing.Point(173, 486);
            this.btDatBan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btDatBan.Name = "btDatBan";
            this.btDatBan.Size = new System.Drawing.Size(112, 53);
            this.btDatBan.TabIndex = 18;
            this.btDatBan.Text = "Đặt bàn";
            this.btDatBan.UseVisualStyleBackColor = true;
            this.btDatBan.Visible = false;
            this.btDatBan.Click += new System.EventHandler(this.BtDatBan_Click);
            // 
            // timePk
            // 
            this.timePk.CustomFormat = "HH:mm dd/MM/yyyy";
            this.timePk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePk.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.timePk.Location = new System.Drawing.Point(127, 338);
            this.timePk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timePk.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.timePk.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.timePk.Name = "timePk";
            this.timePk.Size = new System.Drawing.Size(227, 32);
            this.timePk.TabIndex = 17;
            this.timePk.Visible = false;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(127, 246);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(227, 32);
            this.txtSDT.TabIndex = 16;
            this.txtSDT.Visible = false;
            // 
            // txtSN
            // 
            this.txtSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSN.Location = new System.Drawing.Point(127, 407);
            this.txtSN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(227, 32);
            this.txtSN.TabIndex = 15;
            this.txtSN.Visible = false;
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDT.Location = new System.Drawing.Point(8, 252);
            this.lbSDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(55, 26);
            this.lbSDT.TabIndex = 14;
            this.lbSDT.Text = "SĐT";
            this.lbSDT.Visible = false;
            // 
            // lbTG
            // 
            this.lbTG.AutoSize = true;
            this.lbTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTG.Location = new System.Drawing.Point(5, 343);
            this.lbTG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTG.Name = "lbTG";
            this.lbTG.Size = new System.Drawing.Size(100, 26);
            this.lbTG.TabIndex = 13;
            this.lbTG.Text = "Thời gian";
            this.lbTG.Visible = false;
            // 
            // lbSN
            // 
            this.lbSN.AutoSize = true;
            this.lbSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSN.Location = new System.Drawing.Point(5, 407);
            this.lbSN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSN.Name = "lbSN";
            this.lbSN.Size = new System.Drawing.Size(98, 26);
            this.lbSN.TabIndex = 12;
            this.lbSN.Text = "Số người";
            this.lbSN.Visible = false;
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(8, 178);
            this.lbTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(48, 26);
            this.lbTen.TabIndex = 11;
            this.lbTen.Text = "Tên";
            this.lbTen.Visible = false;
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(127, 175);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(227, 32);
            this.txtTen.TabIndex = 10;
            this.txtTen.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBan);
            this.groupBox1.Controls.Add(this.rdDD);
            this.groupBox1.Location = new System.Drawing.Point(37, 287);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(345, 46);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Định dạng";
            this.groupBox1.Visible = false;
            // 
            // rdBan
            // 
            this.rdBan.AutoSize = true;
            this.rdBan.Location = new System.Drawing.Point(157, 23);
            this.rdBan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdBan.Name = "rdBan";
            this.rdBan.Size = new System.Drawing.Size(177, 21);
            this.rdBan.TabIndex = 1;
            this.rdBan.TabStop = true;
            this.rdBan.Text = "Bàn (8 số + 3 mã vùng)";
            this.rdBan.UseVisualStyleBackColor = true;
            // 
            // rdDD
            // 
            this.rdDD.AutoSize = true;
            this.rdDD.Checked = true;
            this.rdDD.Location = new System.Drawing.Point(11, 23);
            this.rdDD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdDD.Name = "rdDD";
            this.rdDD.Size = new System.Drawing.Size(129, 21);
            this.rdDD.TabIndex = 0;
            this.rdDD.TabStop = true;
            this.rdDD.Text = "Di Động (10 số)";
            this.rdDD.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(844, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btDatBan);
            this.Controls.Add(this.timePk);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtSN);
            this.Controls.Add(this.lbSDT);
            this.Controls.Add(this.lbTG);
            this.Controls.Add(this.lbSN);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lbMK);
            this.Controls.Add(this.lbTK);
            this.Controls.Add(this.btNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btKH);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.btDN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLNH";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDN;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Button btKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btNV;
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
    }
}

