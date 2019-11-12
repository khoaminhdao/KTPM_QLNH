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

        public static String MSNV;

        private void Check_Login(string id, string pass)
        {
            
            if (id == "")
            { 
                MessageBox.Show("Vui lòng nhập tên tài khoản!");
                return; 
            }
            else if (pass == "")
            { 
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return;
            }
            else
            {
                DataTable dsnv = Data.Load("TaiKhoan", "MaNV, TaiKhoan, MatKhau");
                foreach (DataRow dr in dsnv.Rows)
                {
                    if (id == dr.ItemArray[1].ToString())
                    {
                        if (pass == dr.ItemArray[2].ToString())
                        {
                            MSNV = dr.ItemArray[0].ToString();
                            MenuNV menu = new MenuNV();
                            Hide();
                            menu.ShowDialog();
                            Show();
                            return;
                        }
                        else
                        { MessageBox.Show("Sai mật khẩu"); return; }
                    }
                }
                MessageBox.Show("Sai tài khoản");
            }
        }

        private void SetTime()
        {
            int gio = DateTime.Now.Hour;
            int phut = DateTime.Now.Minute;

            if (gio < 19)
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

                cbTime.SelectedIndex = 0;

            }
            else
                timePk.MinDate = DateTime.Now.Date.AddDays(1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timePk.MinDate = DateTime.Now.Date;
            timePk.MaxDate = DateTime.Now.Date.AddMonths(1);

            SetTime();
        }

        private void BtDN_Click(object sender, EventArgs e)
        {
            Check_Login(txtTK.Text, txtMK.Text);
        }

        private void BtDatBan_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text;
            string soDT = txtSDT.Text;
            string soNg = txtSN.Text;
            int maxSDT = 10;
            if (rdBan.Checked)
                maxSDT = 11;

            int gio = int.Parse(cbTime.Text.Substring(0, 2));
            int phut = int.Parse(cbTime.Text.Substring(3));
            DateTime time = timePk.Value.AddHours(gio).AddMinutes(phut);

            if (!Check.Alpha(ten))
                MessageBox.Show("Vui lòng nhập tên chính xác");
            else if (!Check.SDT(soDT, maxSDT))
                MessageBox.Show("Vui lòng nhập đúng số điện thoại");
            else if (!Check.Num(soNg))
                MessageBox.Show("Vui lòng nhập số người chính xác");
            else
            {
                DataTable dsb = Data.Load("Ban", "MaBan, SucChua, TinhTrang");

                foreach (DataRow dr in dsb.Rows)
                {
                    string maban = dr.ItemArray[0].ToString();
                    if (Check.Ban(maban, time))
                    {
                        Data.Add("DatBan", "MaBan, Ten, SDT, ThoiGian, SoNguoi", "'" + maban + "','" + ten + "','" + soDT + "','" + time + "','" + soNg + "'");
                        MessageBox.Show("Đặt bàn thành công!");
                        return;
                    }
                }
                MessageBox.Show("Không có bàn phù hợp yêu cầu!");
            }
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
    }
}
