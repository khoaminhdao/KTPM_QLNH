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

        public bool Check_Input()
        {
            if (!Check.Alpha(txtTenNv.Text))
            {
                MessageBox.Show("Vui lòng nhập chính xác tên nhân viên");
                return false;
            }
            if (!Check.Alpha(txtQuocTich.Text))
            {
                MessageBox.Show("Vui lòng nhập chính xác quốc tịch");
                return false;
            }
            return true;
        }

        public static string RemoveUnicode(string text)
        {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ", "đ", "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
            "í","ì","ỉ","ĩ","ị", "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ", "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự", "ý","ỳ","ỷ","ỹ","ỵ",};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "d", "e","e","e","e","e","e","e","e","e","e","e",
            "i","i","i","i","i", "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o", "u","u","u","u","u","u","u","u","u","u","u", "y","y","y","y","y",};
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                //text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return text;
        }

        private void Add()
        {
            if (Check_Input())
            {
                int vt = txtTenNv.Text.LastIndexOf(" ");
                string ho = txtTenNv.Text.Substring(0, vt);
                string ten = txtTenNv.Text.Substring(vt + 1);
                
                string s = string.Format("{0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}'", txtMaNv.Text, ho, ten, datetime.Value.ToShortDateString(), cbChucVu.Text, cbTrinhDo.Text, cbGioiTinh.Text, txtQuocTich.Text, DateTime.Now.ToShortDateString());
                string s1 = string.Format("{0}, '{1}', '123'", txtMaNv.Text, RemoveUnicode(ten.ToLower()));

                Data.Add("NhanVien", "MaNV, Ho, Ten, NgaySinh, ChucVu, TrinhDo, GioiTinh, QuocTich, NgayVaoLam", s);
                Data.Add("TaiKhoan", "MaNV, TaiKhoan, MatKhau", s1);

                Set_Ma();
            }
            
        }

        public void Set_Ma ()
        {
            dataGridView1.DataSource = Data.Load("NhanVien", "*");
            dataGridView1.Sort(dataGridView1.Columns["MaNV"], ListSortDirection.Ascending);

            int count = 1;

            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                if (int.Parse(dr.Cells[0].Value.ToString()) != count)
                {
                    txtMaNv.Text = count.ToString();
                    return;
                }
                else
                    count++;
            }

            txtMaNv.Text = (dataGridView1.Rows.Count + 1).ToString();
            txtTenNv.Text = txtQuocTich.Text = "";
        }

        private void BtThem_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void QuanLiNhanVien_Load(object sender, EventArgs e)
        {
            Set_Ma();
            cbChucVu.SelectedIndex = cbGioiTinh.SelectedIndex = cbTrinhDo.SelectedIndex = 0;
            dataGridView1.Columns[0].HeaderText = "Mã NV";
            dataGridView1.Columns[1].HeaderText = "Họ";
            dataGridView1.Columns[2].HeaderText = "Tên";
            dataGridView1.Columns[3].HeaderText = "Ngày Sinh";
            dataGridView1.Columns[4].HeaderText = "Chức Vụ";
            dataGridView1.Columns[5].HeaderText = "Trình Độ";
            dataGridView1.Columns[6].HeaderText = "Giới Tính";
            dataGridView1.Columns[7].HeaderText = "Quốc Tịch";
            dataGridView1.Columns[8].HeaderText = "Ngày Vào Làm";
        }

        private void BtXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa.", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            else
            {
                Data.Delete("NhanVien", "MaNV = " + dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Set_Ma();
            }
        }

        private void BtSua_Click(object sender, EventArgs e)
        {
            if (Check_Input())
            {
                int vt = txtTenNv.Text.LastIndexOf(" ");
                string ho = txtTenNv.Text.Substring(0, vt);
                string ten = txtTenNv.Text.Substring(vt + 1);

                string s = string.Format("Ho = '{0}', Ten = '{1}', NgaySinh = '{2}', ChucVu = '{3}', TrinhDo = '{4}', GioiTinh = '{5}', QuocTich = '{6}'", ho, ten, datetime.Value, cbChucVu.Text, cbTrinhDo.Text, cbGioiTinh.Text, txtQuocTich.Text);

                Data.Update("NhanVien", s, "MaNV = " + txtMaNv.Text);
                Set_Ma();

                btThem.Enabled = true;
            }
        }

        private void BtThoat_Click(object sender, EventArgs e)
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

            btThem.Enabled = false;
        }
    }
}
