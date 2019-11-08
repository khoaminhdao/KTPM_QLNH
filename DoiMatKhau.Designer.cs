namespace QLNH
{
    partial class DoiMatKhau
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtnMK = new System.Windows.Forms.TextBox();
            this.txtaMK = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btXN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu hiện tại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Xác nhận mật khẩu mới";
            // 
            // txtMK
            // 
            this.txtMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Location = new System.Drawing.Point(256, 37);
            this.txtMK.MaxLength = 12;
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(169, 23);
            this.txtMK.TabIndex = 3;
            this.txtMK.UseSystemPasswordChar = true;
            // 
            // txtnMK
            // 
            this.txtnMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnMK.Location = new System.Drawing.Point(256, 83);
            this.txtnMK.MaxLength = 12;
            this.txtnMK.Name = "txtnMK";
            this.txtnMK.Size = new System.Drawing.Size(169, 23);
            this.txtnMK.TabIndex = 4;
            this.txtnMK.UseSystemPasswordChar = true;
            this.txtnMK.TextChanged += new System.EventHandler(this.TxtaMK_TextChanged);
            // 
            // txtaMK
            // 
            this.txtaMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaMK.Location = new System.Drawing.Point(256, 126);
            this.txtaMK.MaxLength = 12;
            this.txtaMK.Name = "txtaMK";
            this.txtaMK.Size = new System.Drawing.Size(169, 23);
            this.txtaMK.TabIndex = 5;
            this.txtaMK.UseSystemPasswordChar = true;
            this.txtaMK.TextChanged += new System.EventHandler(this.TxtaMK_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btXN
            // 
            this.btXN.Enabled = false;
            this.btXN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXN.Location = new System.Drawing.Point(175, 169);
            this.btXN.Name = "btXN";
            this.btXN.Size = new System.Drawing.Size(102, 34);
            this.btXN.TabIndex = 6;
            this.btXN.Text = "Xác Nhận";
            this.btXN.UseVisualStyleBackColor = true;
            this.btXN.Click += new System.EventHandler(this.BtXN_Click);
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 215);
            this.Controls.Add(this.btXN);
            this.Controls.Add(this.txtaMK);
            this.Controls.Add(this.txtnMK);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DoiMatKhau";
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.DoiMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtnMK;
        private System.Windows.Forms.TextBox txtaMK;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btXN;
    }
}