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
            if (!Check.Alpha(txtTenMa.Text))
            {
                MessageBox.Show("Vui lòng nhập chính xác tên món ăn");
                return false;
            }
            return true;
        }

        private void Add()
        {
            if (Check_Input())
            {
                String maMA = txtMaMa.Text;
                String tenMA = txtTenMa.Text;
                decimal donGia = numDonGia.Value * 1000;

                if (Data.Load("ThucDon", "*", "tenMA ='" + tenMA + "'").Rows.Count == 0)
                {
                    string s = string.Format(" {0}, '{1}', {2}", maMA, tenMA, donGia);
                    Data.Add("ThucDon", "MaMA, TenMA, DonGia", s);
                    Set_Ma();
                }
                MessageBox.Show("Món ăn đã tồn tại trong thực đơn!");
            }

        }

        public void Set_Ma()
        {
            dataGridView1.DataSource = Data.Load("ThucDon", "MaMA, TenMA, DonGia");
            dataGridView1.Sort(dataGridView1.Columns["MaMA"], ListSortDirection.Ascending);
            txtTenMa.Text = "";
            numDonGia.Value = 1;

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
        }

        private void BtThem_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void QuanLiThucDon_Load(object sender, EventArgs e)
        {
            Set_Ma();
            dataGridView1.Columns[0].HeaderText = "Mã Món Ăn";
            dataGridView1.Columns[1].HeaderText = "Tên Món Ăn";
            dataGridView1.Columns[2].HeaderText = "Đơn Giá";
        }

        private void BtSua_Click(object sender, EventArgs e)
        {
            if (Check_Input())
            {

                String tenMA = txtTenMa.Text;
                String maMA = txtMaMa.Text;
                decimal donGia = numDonGia.Value;

                Data.Update("ThucDon", "TenMA ='" + tenMA + "', DonGia =" + donGia*1000, "MaMA =" + maMA);
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
            
            if (MessageBox.Show("Bạn chắc chắn muốn xóa.", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            else
            {
                Data.Delete("ThucDon", "MaMA =" + dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Set_Ma();
            }
           
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.CurrentRow;
            if (dr != null)
            {
                btLuu.Enabled = false;
                dr.Selected = true;
                txtMaMa.Text = dr.Cells[0].Value.ToString();
                txtTenMa.Text = dr.Cells[1].Value.ToString();
                numDonGia.Value = decimal.Parse(dr.Cells[2].Value.ToString()) / 1000;
            }
        }
    }
    
}
