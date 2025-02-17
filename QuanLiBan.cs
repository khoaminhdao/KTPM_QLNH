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
    public partial class QuanLiBan : Form
    {
        public QuanLiBan()
        {
            InitializeComponent();
        }

        public void Set_Ma()
        {
            dataGridView1.DataSource = Data.Load("Ban", "*");
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
            numSucChua.Value = 2;
        }

        private void BtThem_Click(object sender, EventArgs e)
        {
            string s = string.Format("{0}, {1}, 'Trống'", txtMaBan.Text, numSucChua.Value);
            Data.Add("Ban", "*", s);
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
            Data.Update("Ban", "SucChua = " + numSucChua.Value, "MaBan = " + txtMaBan.Text);
            Set_Ma();
            btThem.Enabled = true;
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
                Data.Delete("Ban", "MaBan = " + dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Set_Ma();
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.CurrentRow;
            if (dr != null)
            {
                dr.Selected = true;
                txtMaBan.Text = dr.Cells[0].Value.ToString();
                numSucChua.Value = decimal.Parse(dr.Cells[1].Value.ToString());

                if (dr.Cells[2].Value.ToString() == "Đang Sử Dụng")
                    btSua.Enabled = btXoa.Enabled = false;
                else
                    btSua.Enabled = btXoa.Enabled = true;

                dataGridView2.DataSource = Ban.Ctdb(txtMaBan.Text);
                dataGridView2.Columns[0].HeaderText = "Tên";
                dataGridView2.Columns[1].HeaderText = "Số Điện Thoại";
                dataGridView2.Columns[2].HeaderText = "Thời Gian";
                dataGridView2.Columns[3].HeaderText = "Số Người";

                btThem.Enabled = false;
            }
        }

    }
}
