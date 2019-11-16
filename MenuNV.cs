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
    public partial class MenuNV : Form
    {
        public MenuNV()
        {
            InitializeComponent();
        }

        private void MenuNV_Load(object sender, EventArgs e)
        {
            if (NhanVien.GetCV() == "Phục vụ")
            {
                btQLB.Enabled = btQLTD.Enabled = btQLHD.Enabled = btQLNV.Enabled = false;
            }
            else if(NhanVien.GetCV() == "Quản lí bếp")
            {
                btQLHD.Enabled = false;
                btQLNV.Enabled = false;
            }
            chàoToolStripMenuItem.Text += NhanVien.GetTen();
        }

        private void ĐăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtQLNV_Click(object sender, EventArgs e)
        {
                QuanLiNhanVien qlnv = new QuanLiNhanVien();
                Hide();
                qlnv.ShowDialog();
                Show();  
        }

        private void BtQLTD_Click(object sender, EventArgs e)
        {    
                QuanLiThucDon qltd = new QuanLiThucDon();
                Hide();
                qltd.ShowDialog();
                Show();   
        }

        private void BtQLB_Click(object sender, EventArgs e)
        { 
                QuanLiBan qlb = new QuanLiBan();
                Hide();
                qlb.ShowDialog();
                Show();  
        }

        private void BtQLHD_Click(object sender, EventArgs e)
        {
                QuanLiHoaDon qlhd = new QuanLiHoaDon();
                Hide();
                qlhd.ShowDialog();
                Show();   
        }

        private void BtGoiMon_Click(object sender, EventArgs e)
        {
            GoiMon gm = new GoiMon();
            Hide();
            gm.ShowDialog();
            Show();
        }

        private void ĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhau mk = new DoiMatKhau();
            mk.ShowDialog();
        }
    }
}
