using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNH
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private string oldpass = "";

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            oldpass = (Data.Load("TaiKhoan", "MatKhau", "MaNV =" + NhanVien.GetMaNV())).Rows[0]["MatKhau"].ToString();
        }

        private void BtXN_Click(object sender, EventArgs e)
        {
            if (txtMK.Text == oldpass)
            {
                Data.Update("TaiKhoan", "MatKhau ='" + txtnMK.Text + "'", "MaNV = " + NhanVien.GetMaNV());
                MessageBox.Show("Mật khẩu thay đổi thành công");
            }
            else
                MessageBox.Show("Mật khẩu hiện tại không chính xác!");
        }

        private void TxtaMK_TextChanged(object sender, EventArgs e)
        {
            if (txtaMK.Text != txtnMK.Text)
            {
                errorProvider1.SetError(txtaMK, "Không trùng khớp");
                btXN.Enabled = false;
            }
            else if (txtnMK.Text != "")
            {
                errorProvider1.Clear();
                btXN.Enabled = true;
            }
        }
    }
}
