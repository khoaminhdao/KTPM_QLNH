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
            if (!Check.Num(txtSucChua.Text) || (int.Parse(txtSucChua.Text) <= 0))
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
                string maBan = txtMaBan.Text;
                string sucChua = txtSucChua.Text;

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

        private void BtLuu_Click(object sender, EventArgs e)
        {
            ADD_VALUE();
        }

        private void QuanLiBan_Load(object sender, EventArgs e)
        {
            Set_Ma();

            dataGridView1.Columns[0].HeaderText = "Mã Bàn";
            dataGridView1.Columns[1].HeaderText = "Sức Chứa";
            dataGridView1.Columns[2].HeaderText = "Tình Trạng";

        }

        private void BtSua_Click(object sender, EventArgs e)
        {
            if (Check_Input())
            {

                String sucChua = txtSucChua.Text;
                String maBan = txtMaBan.Text;

                Data.Update("Ban", "SucChua = " + sucChua, "MaBan = " + maBan);
                Set_Ma();
                btLuu.Enabled = true;
            }
        }

        private void BtThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtXoa_Click(object sender, EventArgs e)
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

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.CurrentRow;
            txtMaBan.Text = dr.Cells[0].Value.ToString();
            txtSucChua.Text = dr.Cells[1].Value.ToString();
            
            if (dr.Cells[2].Value.ToString() == "Đang Sử Dụng")
                btSua.Enabled = btXoa.Enabled = false;
            else
                btSua.Enabled = btXoa.Enabled = true;

            dataGridView2.DataSource = Ban.Ctdb(txtMaBan.Text);
            dataGridView2.Columns[0].HeaderText = "Tên";
            dataGridView2.Columns[1].HeaderText = "Số Điện Thoại";
            dataGridView2.Columns[2].HeaderText = "Thời Gian";
            dataGridView2.Columns[3].HeaderText = "Số Người";

            btLuu.Enabled = false;
        }

    }
}
