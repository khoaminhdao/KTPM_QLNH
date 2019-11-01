namespace QLNH
{
    partial class QuanLiThucDon
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btThoat = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.buThoat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTenMa = new System.Windows.Forms.TextBox();
            this.txtMaMa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbttnv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbttnv
            // 
            this.grbttnv.Controls.Add(this.dataGridView1);
            this.grbttnv.Controls.Add(this.btThoat);
            this.grbttnv.Controls.Add(this.btSua);
            this.grbttnv.Controls.Add(this.buThoat);
            this.grbttnv.Controls.Add(this.btXoa);
            this.grbttnv.Controls.Add(this.btLuu);
            this.grbttnv.Controls.Add(this.label4);
            this.grbttnv.Controls.Add(this.txtDonGia);
            this.grbttnv.Controls.Add(this.label10);
            this.grbttnv.Controls.Add(this.txtTenMa);
            this.grbttnv.Controls.Add(this.txtMaMa);
            this.grbttnv.Controls.Add(this.label2);
            this.grbttnv.Controls.Add(this.label1);
            this.grbttnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbttnv.Location = new System.Drawing.Point(2, 1);
            this.grbttnv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbttnv.Name = "grbttnv";
            this.grbttnv.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbttnv.Size = new System.Drawing.Size(858, 494);
            this.grbttnv.TabIndex = 2;
            this.grbttnv.TabStop = false;
            this.grbttnv.Text = "Thông tin món ăn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(852, 256);
            this.dataGridView1.TabIndex = 89;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(755, 246);
            this.btThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(79, 47);
            this.btThoat.TabIndex = 88;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(538, 182);
            this.btSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 47);
            this.btSua.TabIndex = 88;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // buThoat
            // 
            this.buThoat.Location = new System.Drawing.Point(692, 182);
            this.buThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buThoat.Name = "buThoat";
            this.buThoat.Size = new System.Drawing.Size(90, 47);
            this.buThoat.TabIndex = 88;
            this.buThoat.Text = "Thoát";
            this.buThoat.UseVisualStyleBackColor = true;
            this.buThoat.Click += new System.EventHandler(this.buThoat_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(367, 184);
            this.btXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 47);
            this.btXoa.TabIndex = 88;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(201, 184);
            this.btLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(75, 47);
            this.btLuu.TabIndex = 88;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 86;
            this.label4.Text = "Chức Năng";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(201, 140);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(196, 30);
            this.txtDonGia.TabIndex = 85;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 140);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 25);
            this.label10.TabIndex = 84;
            this.label10.Text = "Đơn Giá";
            // 
            // txtTenMa
            // 
            this.txtTenMa.Location = new System.Drawing.Point(201, 89);
            this.txtTenMa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenMa.Name = "txtTenMa";
            this.txtTenMa.Size = new System.Drawing.Size(196, 30);
            this.txtTenMa.TabIndex = 79;
            // 
            // txtMaMa
            // 
            this.txtMaMa.Location = new System.Drawing.Point(201, 41);
            this.txtMaMa.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaMa.Name = "txtMaMa";
            this.txtMaMa.ReadOnly = true;
            this.txtMaMa.Size = new System.Drawing.Size(196, 30);
            this.txtMaMa.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 74;
            this.label2.Text = "Tên Món Ăn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 73;
            this.label1.Text = "Mã Món Ăn";
            // 
            // QuanLiThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 495);
            this.Controls.Add(this.grbttnv);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLiThucDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLiThucDon";
            this.Load += new System.EventHandler(this.QuanLiThucDon_Load);
            this.grbttnv.ResumeLayout(false);
            this.grbttnv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbttnv;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTenMa;
        private System.Windows.Forms.TextBox txtMaMa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buThoat;
    }
}