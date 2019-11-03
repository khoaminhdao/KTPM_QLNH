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
    public partial class QuanLiBan : Form
    {
        public QuanLiBan()
        {
            InitializeComponent();
        }

        public bool Check_Input()
        {
            if (txtSucChua.Text == "")
            {
                MessageBox.Show("Vui lòng nhập sức chứa của bàn!");
                return false;
            }
            return true;
        }

        private void ADD_VALUE()
        {

            if (Check_Input())
            {
                String maBan = txtMaBan.Text;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == maBan)
                    {
                        MessageBox.Show("Mã bàn đã tồn tại, nhấn sửa để cập nhật thông tin!");
                        return;
                    }

                String sucChua = txtSucChua.Text;
                String tinhTrang = cbTT.Text;

                Form1.Add_Data("Ban", "MaBan, SucChua, TinhTrang, Dat", "'" + maBan + "','" + sucChua + "','" + tinhTrang + "',False");

                Set_Ma();
            }

        }


        public void Set_Ma()
        {
            dataGridView1.DataSource = Form1.Load_Data("Ban", "MaBan, SucChua, TinhTrang");
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                if (int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()) != i + 1)
                {
                    txtMaBan.Text = (i + 1).ToString();
                    return;
                }
            txtMaBan.Text = (dataGridView1.Rows.Count + 1).ToString();
            txtSucChua.Text = "";
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            ADD_VALUE();
        }

        private void QuanLiBan_Load(object sender, EventArgs e)
        {
            Set_Ma();
            cbTT.SelectedIndex = 0;
        }


        private void btSua_Click(object sender, EventArgs e)
        {
            if (Check_Input())
            {

                String sucChua = txtSucChua.Text;
                String maBan = txtMaBan.Text;
                String tinhTrang = cbTT.Text;

                Form1.Update_Data("Ban", "sucChua = '" + sucChua + "', TinhTrang = '" + tinhTrang + "'", "MaBan = " + maBan);
                Set_Ma();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa.", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                else
                {
                    Form1.Delete_Data("Ban", "MaBan = " + dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    Set_Ma();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.CurrentRow;
            txtMaBan.Text = dr.Cells[0].Value.ToString();
            txtSucChua.Text = dr.Cells[1].Value.ToString();
            cbTT.Text = dr.Cells[2].Value.ToString();

            DataTable dsd = Form1.Load_Data("DatBan", "MaBan, Ten, SDT, ThoiGian, SoNguoi");
            DataTable temp = new DataTable();
            temp.Columns.Add("MaBan", typeof(Int32));
            temp.Columns.Add("Ten", typeof(string));
            temp.Columns.Add("SDT", typeof(string));
            temp.Columns.Add("ThoiGian", typeof(DateTime));
            temp.Columns.Add("SoNguoi", typeof(Int32));
            for (int i = 0; i < dsd.Rows.Count; i++)
                if (dsd.Rows[i].ItemArray[0].ToString() == txtMaBan.Text)
                    temp.ImportRow(dsd.Rows[i]);
            dataGridView2.DataSource = temp;
        }
    }
}
