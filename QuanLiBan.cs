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
            if (!Check.Num(txtSucChua.Text))
            {
                MessageBox.Show("Vui lòng nhập đúng sức chứa của bàn!");
                return false;
            }
            return true;
        }

        private void ADD_VALUE()
        {
            if (Check_Input())
            {
                String maBan = txtMaBan.Text;
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    if (dr.Cells[0].Value.ToString() == maBan)
                    {
                        MessageBox.Show("Mã bàn đã tồn tại, nhấn sửa để cập nhật thông tin!");
                        return;
                    }
                }

                String sucChua = txtSucChua.Text;

                Data.Add("Ban", "MaBan, SucChua, TinhTrang", "'" + maBan + "','" + sucChua + "','Trống'");

                Set_Ma();
            }

        }


        public void Set_Ma()
        {
            dataGridView1.DataSource = Data.Load("Ban", "MaBan, SucChua, TinhTrang");
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);

            int count = 1;

            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                if (int.Parse(dr.Cells[0].Value.ToString()) != count)
                {
                    txtMaBan.Text = count.ToString();
                    return;
                }
                else
                    count++;
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

            dataGridView1.Columns[0].HeaderText = "Mã Bàn";
            dataGridView1.Columns[1].HeaderText = "Sức Chức";
            dataGridView1.Columns[2].HeaderText = "Tình Trạng";

        }


        private void btSua_Click(object sender, EventArgs e)
        {
            if (Check_Input())
            {

                String sucChua = txtSucChua.Text;
                String maBan = txtMaBan.Text;

                Data.Update("Ban", "SucChua = " + sucChua, "MaBan = " + maBan);
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
                    Data.Delete("Ban", "MaBan = " + dataGridView1.CurrentRow.Cells[0].Value.ToString());
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
            
            if (dr.Cells[2].Value.ToString() == "Đang Sử Dụng")
                btSua.Enabled = btXoa.Enabled = false;
            else
                btSua.Enabled = btXoa.Enabled = true;

            DataTable dsd = Data.Load("DatBan", "MaBan, Ten, SDT, ThoiGian, SoNguoi");
            DataTable temp = new DataTable();
            temp.Columns.Add("MaBan", typeof(Int32));
            temp.Columns.Add("Ten", typeof(string));
            temp.Columns.Add("SDT", typeof(string));
            temp.Columns.Add("ThoiGian", typeof(DateTime));
            temp.Columns.Add("SoNguoi", typeof(Int32));
      
            foreach (DataRow ds in dsd.Rows)
                if (ds.ItemArray[0].ToString() == txtMaBan.Text)
                    temp.ImportRow(ds);
            dataGridView2.DataSource = temp;
        }

    }
}
