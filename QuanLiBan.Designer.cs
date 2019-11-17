namespace QLNH
{
    partial class QuanLiBan
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
            this.grbttnv = new System.Windows.Forms.GroupBox();
            this.numSucChua = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btThoat = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.buThoat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaBan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.grbttnv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSucChua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // grbttnv
            // 
            this.grbttnv.Controls.Add(this.numSucChua);
            this.grbttnv.Controls.Add(this.dataGridView1);
            this.grbttnv.Controls.Add(this.btThoat);
            this.grbttnv.Controls.Add(this.btSua);
            this.grbttnv.Controls.Add(this.buThoat);
            this.grbttnv.Controls.Add(this.btXoa);
            this.grbttnv.Controls.Add(this.btThem);
            this.grbttnv.Controls.Add(this.label4);
            this.grbttnv.Controls.Add(this.txtMaBan);
            this.grbttnv.Controls.Add(this.label2);
            this.grbttnv.Controls.Add(this.label1);
            this.grbttnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbttnv.Location = new System.Drawing.Point(11, 13);
            this.grbttnv.Margin = new System.Windows.Forms.Padding(2);
            this.grbttnv.Name = "grbttnv";
            this.grbttnv.Padding = new System.Windows.Forms.Padding(2);
            this.grbttnv.Size = new System.Drawing.Size(644, 295);
            this.grbttnv.TabIndex = 3;
            this.grbttnv.TabStop = false;
            this.grbttnv.Text = "Thông tin bàn";
            // 
            // numSucChua
            // 
            this.numSucChua.Location = new System.Drawing.Point(294, 32);
            this.numSucChua.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numSucChua.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numSucChua.Name = "numSucChua";
            this.numSucChua.Size = new System.Drawing.Size(42, 26);
            this.numSucChua.TabIndex = 90;
            this.numSucChua.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 104);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(639, 187);
            this.dataGridView1.TabIndex = 89;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(566, 200);
            this.btThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(59, 38);
            this.btThoat.TabIndex = 88;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(380, 65);
            this.btSua.Margin = new System.Windows.Forms.Padding(2);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(56, 38);
            this.btSua.TabIndex = 5;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.BtSua_Click);
            // 
            // buThoat
            // 
            this.buThoat.Location = new System.Drawing.Point(515, 65);
            this.buThoat.Margin = new System.Windows.Forms.Padding(2);
            this.buThoat.Name = "buThoat";
            this.buThoat.Size = new System.Drawing.Size(68, 38);
            this.buThoat.TabIndex = 6;
            this.buThoat.Text = "Thoát";
            this.buThoat.UseVisualStyleBackColor = true;
            this.buThoat.Click += new System.EventHandler(this.BtThoat_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(247, 65);
            this.btXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(56, 38);
            this.btXoa.TabIndex = 4;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.BtXoa_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(110, 63);
            this.btThem.Margin = new System.Windows.Forms.Padding(2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(64, 38);
            this.btThem.TabIndex = 3;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.BtThem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 86;
            this.label4.Text = "Chức Năng";
            // 
            // txtMaBan
            // 
            this.txtMaBan.Location = new System.Drawing.Point(79, 31);
            this.txtMaBan.Name = "txtMaBan";
            this.txtMaBan.ReadOnly = true;
            this.txtMaBan.Size = new System.Drawing.Size(96, 26);
            this.txtMaBan.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 74;
            this.label2.Text = "Sức chứa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 73;
            this.label1.Text = "Mã Bàn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 312);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(644, 134);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đặt bàn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 30);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(639, 96);
            this.dataGridView2.TabIndex = 89;
            // 
            // QuanLiBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 449);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbttnv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "QuanLiBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLiBan";
            this.Load += new System.EventHandler(this.QuanLiBan_Load);
            this.grbttnv.ResumeLayout(false);
            this.grbttnv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSucChua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbttnv;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button buThoat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.NumericUpDown numSucChua;
    }
}