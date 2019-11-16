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

        private void QuanLiHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Data.Load("HoaDon", "*"); ;
            dataGridView1.Columns[0].HeaderText = "Mã Hóa Đơn";
            dataGridView1.Columns[1].HeaderText = "Mã Bàn";
            dataGridView1.Columns[2].HeaderText = "Mã Nhân Viên";
            dataGridView1.Columns[3].HeaderText = "Thời Gian Tạo";
            dataGridView1.Columns[4].HeaderText = "Thời Gian Thanh Toán";
            dataGridView1.Columns[5].HeaderText = "Tổng Tiền";
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            DataTable temp = new DataTable();
            temp.Columns.Add("TenMA", typeof(string));
            temp.Columns.Add("SoLuong", typeof(Int32));
            temp.Columns.Add("DonGia", typeof(double));
            temp.Columns.Add("ThanhTien", typeof(double));

            DataTable ds = Data.Load("CTHD", "TenMA, SoLuong, DonGia, ThanhTien", "MaHD =" + dataGridView1.CurrentRow.Cells[0].Value.ToString());
            foreach (DataRow dr in ds.Rows)
              temp.ImportRow(dr);

            dataGridView2.DataSource = temp;
            dataGridView2.Columns[0].HeaderText = "Tên Món Ăn";
            dataGridView2.Columns[1].HeaderText = "Số Lượng";
            dataGridView2.Columns[2].HeaderText = "Đơn Giá";
            dataGridView2.Columns[3].HeaderText = "Thành Tiền";
        }
    }
}
