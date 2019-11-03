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

        DataTable dsd = Form1.Load_Data("HoaDon", "MaHD, MaBan, MaNV, NgayLap");

        private void QuanLiHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dsd;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable temp = new DataTable();
            temp.Columns.Add("MaHD", typeof(Int32));
            temp.Columns.Add("MaMA", typeof(Int32));
            temp.Columns.Add("SoLuong", typeof(Int32));
            for (int i = 0; i < dsd.Rows.Count; i++)
                if (dsd.Rows[i].ItemArray[0].ToString() == dataGridView1.CurrentRow.Cells[0].Value.ToString())
                    temp.ImportRow(dsd.Rows[i]);
            dataGridView2.DataSource = temp;
        }
    }
}
