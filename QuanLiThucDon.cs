using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNH
{
    public partial class QuanLiThucDon : Form
    {
        public QuanLiThucDon()
        {
            InitializeComponent();
        }

        public bool Check_Input()
        {
            if (txtTenMa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên món ăn");
                return false;
            }
            return true;
        }

        private void ADD_VALUE()
        {

            if (Check_Input())
            {
                String maMA = txtMaMa.Text;
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    if (dr.Cells[0].Value.ToString() == maMA)
                    {
                        MessageBox.Show("Mã món ăn đã tồn tại, nhấn sửa để cập nhật thông tin!");
                        return;
                    }
                }

                String tenMA = txtTenMa.Text;
                String donGia = txtDonGia.Text;

                Form1.Add_Data("ThucDon", "MaMA, TenMA, DonGia", "'" + maMA + "','" + tenMA + "','" + donGia + "'");

                Set_Ma();
            }

        }


        public void Set_Ma()
        {
            dataGridView1.DataSource = Form1.Load_Data("ThucDon", "MaMA, TenMA, DonGia");
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);

            int count = 1;
            
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                if (int.Parse(dr.Cells[0].Value.ToString()) != count)
                {
                    txtMaMa.Text = count.ToString();
                    return;
                }
                else
                    count++;
            }

            txtMaMa.Text = (dataGridView1.Rows.Count + 1).ToString();
            txtTenMa.Text = txtDonGia.Text = "";
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            ADD_VALUE();
        }

        private void QuanLiThucDon_Load(object sender, EventArgs e)
        {
            Set_Ma();
        }


        private void btSua_Click(object sender, EventArgs e)
        {
            if (Check_Input())
            {

                String tenMA = txtTenMa.Text;
                String maMA = txtMaMa.Text;
                String donGia = txtDonGia.Text;
                
                Form1.Update_Data("ThucDon", "TenMA = '" + tenMA + "', DonGia = '" + donGia + "'", "MaMA = " + maMA);
                Set_Ma();
            }
        }

        private void buThoat_Click(object sender, EventArgs e)
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
                    Form1.Delete_Data("ThucDon", "MaMA = " + dataGridView1.CurrentRow.Cells[0].Value.ToString());
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
            txtMaMa.Text = dr.Cells[0].Value.ToString();
            txtTenMa.Text = dr.Cells[1].Value.ToString();
            txtDonGia.Text = dr.Cells[2].Value.ToString();
        }
    }
    
}
