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

        private String oldpass = "";

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            DataTable dsd = Form1.Load_Data("TaiKhoan", "MaNV, MatKhau");

            foreach (DataRow dr in dsd.Rows)
                if (dr.ItemArray[0].ToString() == Form1.MSNV)
                    oldpass = dr.ItemArray[1].ToString();
        }

        private void BtXN_Click(object sender, EventArgs e)
        {
            if (txtMK.Text == oldpass)
                MessageBox.Show("Mật khẩu thay đổi thành công");
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
