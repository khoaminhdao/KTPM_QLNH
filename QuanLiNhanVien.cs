using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace QLNH
{
    public partial class QuanLiNhanVien : Form
    {
        public QuanLiNhanVien()
        {
            InitializeComponent();
        }

        //private void ADD_VALUE()
        //{
        //    dataGridView1.Rows.Add(1);
        //    int indexRow = dataGridView1.Rows.Count - 1;
        //    dataGridView1[0, indexRow].Value = txtMaNv.Text;
        //    dataGridView1[1, indexRow].Value = txtTenNv.Text;
        //    dataGridView1[2, indexRow].Value = datetime.Text;
        //    dataGridView1[3, indexRow].Value = cbGioiTinh.Text;
        //    dataGridView1[4, indexRow].Value = cbTrinhDo.Text;
        //    dataGridView1[5, indexRow].Value = txtQuocTich.Text;
        //    dataGridView1[6, indexRow].Value = cbChucVu.Text;
        //    txtMaNv.Text = "";
        //    txtQuocTich.Text = "";
        //    txtTenNv.Text = "";
        //    cbChucVu.Text = "";
        //    datetime.Text = DateTime.Today.ToString();
        //    cbGioiTinh.Text = "";
        //    cbTrinhDo.Text = "";
        //}




        //private void btLuu_Click(object sender, EventArgs e)
        //{
        //    dataGridView1.AllowUserToAddRows = false;
        //    ADD_VALUE();
        //}

        //private void QuanLiNhanVien_Load(object sender, EventArgs e)
        //{


        //}

        //private void btXoa_Click(object sender, EventArgs e)
        //{ 
        //    if (MessageBox.Show("Bạn chắc chắn muốn xóa.", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
        //        return;
        //    try
        //    {
        //        int RowIndex = dataGridView1.CurrentRow.Index;
        //        dataGridView1.Rows.RemoveAt(RowIndex);
        //    }
        //    catch (Exception )
        //    { 
        //        MessageBox.Show("Không có dữ liệu","Thông báo");
        //    }

        //}

        //private void btSua_Click(object sender, EventArgs e)
        //{
        //    string MaNV = txtMaNv.Text;
        //    string HoTen = txtTenNv.Text;
        //    DateTime NgaySinh = DateTime.Parse(datetime.Text, System.Globalization.CultureInfo.CreateSpecificCulture("en-AU"));
        //    string GioiTinh = cbGioiTinh.Text;
        //    string TenChucDanh = cbChucVu.Text;
        //    string QuocTich = txtQuocTich.Text;
        //    string TrinhDo = cbTrinhDo.Text;
        //    dataGridView1.Rows.Add(1);
        //    int indexRow = dataGridView1.Rows.Count - 1;
        //    //dataGridView1["Mã NV]", indexRow].Value = txtMaNv.Text;


        //}

        //private void btThoat_Click(object sender, EventArgs e)
        //{
        //    Close();
        //    Dispose();


        //}

        public bool check_input()
        {
            if (txtTenNv.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên");
                return false;
            }
            return true;
        }

        private void ADD_VALUE()
        {
            
            if (check_input())
            {
                int vt = txtTenNv.Text.LastIndexOf(" ");
                String maNV = txtMaNv.Text;
                String ho = txtTenNv.Text.Substring(0, vt);
                String ten = txtTenNv.Text.Substring(vt + 1);
                String nS = datetime.Value.ToShortDateString();
                String gT = cbGioiTinh.Text;
                String tD = cbTrinhDo.Text;
                String qT = txtQuocTich.Text;
                String cV = cbChucVu.Text;


                Form1.Add_Data("NhanVien", "MaNV, Ho, Ten, NgaySinh, ChucVu, TrinhDo, GioiTinh, QuocTich", maNV + "','" + ho + "','" + ten + "','" + nS + "','" + cV + "','" + tD + "','" + gT + "','" + qT);
                Form1.Add_Data("TaiKhoan", "MaNV, TaiKhoan, MatKhau", maNV + "','" + ten.ToLower() + maNV + "','" + "123");

                set_Ma();
            }
            
        }


        public void set_Ma ()
        {
            dataGridView1.DataSource = Form1.Load_Data("NhanVien", "MaNV, Ho, Ten, NgaySinh, ChucVu, TrinhDo, GioiTinh, QuocTich");
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                if (int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()) != i)
                {
                    txtMaNv.Text = i.ToString();
                    return;
                }
            txtMaNv.Text = (dataGridView1.Rows.Count).ToString();
            txtTenNv.Text = txtQuocTich.Text = "";
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            ADD_VALUE();
        }

        private void QuanLiNhanVien_Load(object sender, EventArgs e)
        {
            set_Ma();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa.", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            else
            {
                Form1.Delete_Data("NhanVien", "MaNV = " + dataGridView1.CurrentRow.Cells[0].Value.ToString());
                set_Ma();
            }
            //catch (Exception)
            //{
            //    MessageBox.Show("Không có dữ liệu", "Thông báo");
            //}

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (check_input())
            {
                int vt = txtTenNv.Text.LastIndexOf(" ");
                String maNV = txtMaNv.Text;
                String ho = txtTenNv.Text.Substring(0, vt);
                String ten = txtTenNv.Text.Substring(vt + 1);
                String nS = datetime.Value.ToShortDateString();
                String gT = cbGioiTinh.Text;
                String tD = cbTrinhDo.Text;
                String qT = txtQuocTich.Text;
                String cV = cbChucVu.Text;


                Form1.Update_Data("NhanVien", "Ho = '" + ho + "', Ten = '" + ten + "', NgaySinh = '" + nS + "', ChucVu = '" + cV + "', TrinhDo = '" + tD + "', GioiTinh = '" + gT + "', QuocTich = '" + qT + "'", "MaNV =" + maNV);
                set_Ma();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.CurrentRow;
            datetime.Value = DateTime.Parse(dr.Cells[3].Value.ToString());
            txtMaNv.Text = dr.Cells[0].Value.ToString();
            txtTenNv.Text = dr.Cells[1].Value + " " + dr.Cells[2].Value;
            cbChucVu.Text = dr.Cells[4].Value.ToString();
            cbTrinhDo.Text = dr.Cells[5].Value.ToString();
            cbGioiTinh.Text = dr.Cells[6].Value.ToString();
            txtQuocTich.Text = dr.Cells[7].Value.ToString();
            
        }
    }
}
