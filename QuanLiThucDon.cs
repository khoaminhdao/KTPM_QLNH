﻿using System;
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
    public partial class QuanLiThucDon : Form
    {
        public QuanLiThucDon()
        {
            InitializeComponent();
        }

        public bool check_input()
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

            if (check_input())
            {
                String maMA = txtMaMa.Text;
                String tenMA = txtTenMa.Text;
                String donGia = txtDonGia.Text;

                Form1.Add_Data("ThucDon", "MaMA, TenMA, DonGia", maMA + "','" + tenMA + "','" + donGia);

                set_Ma();
            }

        }


        public void set_Ma()
        {
            dataGridView1.DataSource = Form1.Load_Data("ThucDon", "MaMA, TenMA, DonGia");
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                if (int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()) != i + 1)
                {
                    txtMaMa.Text = (i + 1).ToString();
                    return;
                }
            txtMaMa.Text = (dataGridView1.Rows.Count).ToString();
            txtTenMa.Text = txtDonGia.Text = "";
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            ADD_VALUE();
        }

        private void QuanLiThucDon_Load(object sender, EventArgs e)
        {
            set_Ma();
        }


        private void btSua_Click(object sender, EventArgs e)
        {
            if (check_input())
            {

                String tenMA = txtTenMa.Text;
                String maMA = txtMaMa.Text;
                String donGia = txtDonGia.Text;
                
                Form1.Update_Data("ThucDon", "'MaMA = '" + maMA + "', TenMA = '" + tenMA , "DonGia = '" + donGia);
                set_Ma();
            }
        }

        private void buThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    set_Ma();
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
