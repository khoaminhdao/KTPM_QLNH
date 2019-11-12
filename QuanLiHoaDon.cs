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
    public partial class QuanLiHoaDon : Form
    {
        public QuanLiHoaDon()
        {
            InitializeComponent();
        }

        DataTable dsd = Data.Load("HoaDon", "MaHD, MaBan, MaNV, NgayLap");

        private void QuanLiHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dsd;
            dataGridView1.Columns[0].HeaderText = "Mã Hóa Đơn";
            dataGridView1.Columns[1].HeaderText = "Mã Bàn";
            dataGridView1.Columns[2].HeaderText = "Mã Nhân Viên";
            dataGridView1.Columns[3].HeaderText = "Ngày Tạo";

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable temp = new DataTable();
            temp.Columns.Add("MaHD", typeof(Int32));
            temp.Columns.Add("TenMA", typeof(string));
            temp.Columns.Add("SoLuong", typeof(Int32));
           

            DataTable ds = Data.Load("CTHD", "MaHD, TenMA, SoLuong");
            foreach (DataRow dr in ds.Rows)
                if (dr.ItemArray[0].ToString() == dataGridView1.CurrentRow.Cells[0].Value.ToString())
                    temp.ImportRow(dr);

            dataGridView2.DataSource = temp;
            dataGridView2.Columns[0].HeaderText = "Mã Hóa Đơn";
            dataGridView2.Columns[1].HeaderText = "Tên Món Ăn";
            dataGridView2.Columns[2].HeaderText = "Số Lượng";
        }
    }
}
