using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace QLNH
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void SetTime()
        {
            timePk.Value = timePk.MinDate;
            int gio = DateTime.Now.Hour;
            int phut = DateTime.Now.Minute;

            if (gio > 5 && gio < 19)
            {
                String s = gio + 3 + ":";

                if (phut < 30)
                    s += "00";
                else
                    s += "30";

                while (cbTime.Items[0].ToString() != s)
                {
                    cbTime.Items.RemoveAt(0);
                }
            }
            else if (gio >= 19)
                timePk.MinDate = DateTime.Now.Date.AddDays(1);

            cbTime.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timePk.MinDate = DateTime.Now.Date;
            timePk.MaxDate = DateTime.Now.Date.AddMonths(1);

            SetTime();
        }

        private void BtDN_Click(object sender, EventArgs e)
        {
            if (NhanVien.CheckLogin(txtTK.Text, txtMK.Text))
            {
                MenuNV menu = new MenuNV();
                Hide();
                menu.ShowDialog();
                Show();
                txtMK.Text = "";
            }
        }

        private void BtDatBan_Click(object sender, EventArgs e)
        {
            int maxSDT = 10;
            if (rdBan.Checked)
                maxSDT = 11;

            int gio = int.Parse(cbTime.Text.Substring(0, 2));
            int phut = int.Parse(cbTime.Text.Substring(3));

            KhachHang kh = new KhachHang(txtTen.Text, txtSDT.Text, numSoNg.Value.ToString(), timePk.Value.AddHours(gio).AddMinutes(phut));
            if (kh.CheckInput(maxSDT)) 
            {
                kh.Add();
            }

            txtTen.Text = txtSDT.Text = "";
            numSoNg.Value = 1;
            rdDD.PerformClick();
            SetTime();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void TimePk_ValueChanged(object sender, EventArgs e)
        {
            if (timePk.Value.CompareTo(DateTime.Now.Date) == 0)
                SetTime();
        }

        private void TxtMK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btDN.PerformClick();
        }
    }
}
