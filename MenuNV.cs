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

        bool QL = false; 

        private void MenuNV_Load(object sender, EventArgs e)
        {
            DataSet dsnv = Form1.Load_Data("NhanVien", "MaNV, Ten, ChucVu");
            String ten = "";
            for (int i = 0; i < dsnv.Tables[0].Rows.Count; i++)
                if (dsnv.Tables[0].Rows[i].ItemArray[0].ToString() == Form1.MSNV)
                {
                    ten = dsnv.Tables[0].Rows[i].ItemArray[1].ToString();
                    if (dsnv.Tables[0].Rows[i].ItemArray[2].ToString() == "Quản lí")
                        QL = true;
                    break;
                }
            chàoToolStripMenuItem.Text += ten;
        }

        private void ĐăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtQLNV_Click(object sender, EventArgs e)
        {
            if (QL == true)
            {
                QuanLiNhanVien qlnv = new QuanLiNhanVien();
                Hide();
                qlnv.ShowDialog();
                Show();
            }
            else
                MessageBox.Show("Chỉ quản lí mới truy cập được chức năng này!");
        }
    }
}
