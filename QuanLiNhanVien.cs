﻿using System;
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
            if (txtTenNv.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên");
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
        private void ADD_VALUE()
        {
            
            if (Check_Input())
            {
                String maNV = txtMaNv.Text;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == maNV)
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại, nhấn sửa để cập nhật thông tin!");
                        return;
                    }
                int vt = txtTenNv.Text.LastIndexOf(" ");
               
                String ho = txtTenNv.Text.Substring(0, vt);
                String ten = txtTenNv.Text.Substring(vt + 1);
                String nS = datetime.Value.ToShortDateString();
                String gT = cbGioiTinh.Text;
                String tD = cbTrinhDo.Text;
                String qT = txtQuocTich.Text;
                String cV = cbChucVu.Text;


                Form1.Add_Data("NhanVien", "MaNV, Ho, Ten, NgaySinh, ChucVu, TrinhDo, GioiTinh, QuocTich, NgayVaoLam", "'" + maNV + "','" + ho + "','" + ten + "','" + nS + "','" + cV + "','" + tD + "','" + gT + "','" + qT + "','" + DateTime.Now.ToShortDateString() + "'");

                if (cV == "Quản lí" || cV == "Phục vụ")
                    Form1.Add_Data("TaiKhoan", "MaNV, TaiKhoan, MatKhau","'" + maNV + "','" + RemoveUnicode(ten.ToLower()) + maNV + "','" + "123'");

                Set_Ma();
            }
            
        }


        public void Set_Ma ()
        {
            dataGridView1.DataSource = Form1.Load_Data("NhanVien", "MaNV, Ho, Ten, NgaySinh, ChucVu, TrinhDo, GioiTinh, QuocTich, NgayVaoLam");
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);

            int count = 1;

            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                if (int.Parse(dr.Cells[0].Value.ToString()) != count)
                {
                    txtMaNv.Text = count.ToString();
                    return;
                }
            }

            txtMaNv.Text = (dataGridView1.Rows.Count + 1).ToString();
            txtTenNv.Text = txtQuocTich.Text = "";
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            ADD_VALUE();
        }

        private void QuanLiNhanVien_Load(object sender, EventArgs e)
        {
            Set_Ma();
            cbChucVu.SelectedIndex = cbGioiTinh.SelectedIndex = cbTrinhDo.SelectedIndex = 0;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa.", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            else
            {
                Form1.Delete_Data("NhanVien", "MaNV = " + dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Set_Ma();
            }
            //catch (Exception)
            //{
            //    MessageBox.Show("Không có dữ liệu", "Thông báo");
            //}

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (Check_Input())
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
                Set_Ma();
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
