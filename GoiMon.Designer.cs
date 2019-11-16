namespace QLNH
{
    partial class GoiMon
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMB = new System.Windows.Forms.ComboBox();
            this.btTao = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMA = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.btTT = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hóa Đơn";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(91, 35);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.ReadOnly = true;
            this.txtMaHD.Size = new System.Drawing.Size(85, 20);
            this.txtMaHD.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Bàn";
            // 
            // cbMB
            // 
            this.cbMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMB.FormattingEnabled = true;
            this.cbMB.Location = new System.Drawing.Point(345, 34);
            this.cbMB.Name = "cbMB";
            this.cbMB.Size = new System.Drawing.Size(124, 21);
            this.cbMB.TabIndex = 1;
            // 
            // btTao
            // 
            this.btTao.Location = new System.Drawing.Point(205, 63);
            this.btTao.Name = "btTao";
            this.btTao.Size = new System.Drawing.Size(61, 27);
            this.btTao.TabIndex = 2;
            this.btTao.Text = "Tạo";
            this.btTao.UseVisualStyleBackColor = true;
            this.btTao.Click += new System.EventHandler(this.BtTao_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(12, 96);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(487, 301);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Món Ăn";
            // 
            // cbMA
            // 
            this.cbMA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMA.FormattingEnabled = true;
            this.cbMA.Location = new System.Drawing.Point(78, 457);
            this.cbMA.Name = "cbMA";
            this.cbMA.Size = new System.Drawing.Size(124, 21);
            this.cbMA.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số Lượng";
            // 
            // btThem
            // 
            this.btThem.Enabled = false;
            this.btThem.Location = new System.Drawing.Point(438, 458);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(61, 27);
            this.btThem.TabIndex = 5;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.BtThem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tổng Tiền";
            // 
            // txtTT
            // 
            this.txtTT.Location = new System.Drawing.Point(328, 401);
            this.txtTT.Name = "txtTT";
            this.txtTT.ReadOnly = true;
            this.txtTT.Size = new System.Drawing.Size(85, 20);
            this.txtTT.TabIndex = 12;
            this.txtTT.Text = "0";
            // 
            // btTT
            // 
            this.btTT.Location = new System.Drawing.Point(419, 397);
            this.btTT.Name = "btTT";
            this.btTT.Size = new System.Drawing.Size(80, 27);
            this.btTT.TabIndex = 13;
            this.btTT.Text = "Thanh Toán";
            this.btTT.UseVisualStyleBackColor = true;
            this.btTT.Click += new System.EventHandler(this.BtTT_Click);
            // 
            // btXoa
            // 
            this.btXoa.Enabled = false;
            this.btXoa.Location = new System.Drawing.Point(12, 401);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(61, 27);
            this.btXoa.TabIndex = 14;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.BtXoa_Click);
            // 
            // numSL
            // 
            this.numSL.Location = new System.Drawing.Point(328, 463);
            this.numSL.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numSL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(45, 20);
            this.numSL.TabIndex = 15;
            this.numSL.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // GoiMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 487);
            this.Controls.Add(this.numSL);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btTT);
            this.Controls.Add(this.txtTT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbMA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btTao);
            this.Controls.Add(this.cbMB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label1);
            this.Name = "GoiMon";
            this.Text = "GoiMon";
            this.Load += new System.EventHandler(this.GoiMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMB;
        private System.Windows.Forms.Button btTao;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.Button btTT;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.NumericUpDown numSL;
    }
}