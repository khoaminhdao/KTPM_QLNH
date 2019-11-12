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
    public partial class GoiMon : Form
    {
        public GoiMon()
        {
            InitializeComponent();
        }

        DataTable ThucDon = Data.Load("ThucDon", "MaMA, TenMA, DonGia");

        public void Set_Ma()
        {
            DataView hd = Data.Load("HoaDon", "MaHD").DefaultView;
            hd.Sort = "MaHD";
            DataTable hd1 = hd.ToTable();
            int count = 1;

            foreach (DataRow dr in hd1.Rows)
            {
                if (int.Parse(dr.ItemArray[0].ToString()) != count)
                {
                    txtMaHD.Text = count.ToString();
                    return;
                }
                else
                    count++;
            }
            txtMaHD.Text = (hd1.Rows.Count + 1).ToString();

            Check_Trong();
        }

        public void Check_Trong()
        {
            DataTable ban = Data.Load("Ban", "MaBan, TinhTrang");
            cbMB.Items.Clear();

            foreach (DataRow dr in ban.Rows)
            {
                if (dr.ItemArray[1].ToString() == "Trống")
                    cbMB.Items.Add(dr.ItemArray[0]);
            }
            if (cbMB.Items.Count == 0)
            {
                cbMB.Items.Add("Không");
                btTao.Enabled = false;
            }
            cbMB.SelectedIndex = 0;
        }

        public DataTable CTHD(String maHD)
        {
            DataTable dt = Data.Load("CTHD", "MaHD, TenMa, SoLuong, DonGia, ThanhTien");
            DataTable temp = new DataTable();
            temp.Columns.Add("MaHD", typeof(Int32));
            temp.Columns.Add("TenMA", typeof(string));
            temp.Columns.Add("SoLuong", typeof(Int32));
            temp.Columns.Add("DonGia", typeof(Int32));
            temp.Columns.Add("ThanhTien", typeof(Int32));

            temp.Columns[0].ColumnName = "Mã Hóa Đơn";
            temp.Columns[1].ColumnName = "Tên Món Ăn";
            temp.Columns[2].ColumnName = "Số Lượng";
            temp.Columns[3].ColumnName = "Đơn Giá";
            temp.Columns[4].ColumnName = "Thành Tiền";

            foreach (DataRow dr in dt.Rows)
            {
                if (dr.ItemArray[0].ToString() == maHD)
                {
                    temp.ImportRow(dr);
                }
            }
            return temp;
        }

        public int CheckMA(string maHD, string maMA)
        {
            DataTable cthd = Data.Load("CTHD", "MaHD, MaMA, SoLuong");
            foreach (DataRow dr in cthd.Rows)
                if (dr.ItemArray[0].ToString() == maHD && dr.ItemArray[1].ToString() == maMA)
                    return int.Parse(dr.ItemArray[2].ToString());
            return 0;
        }

        public void Show(string maHD, string maBan)
        {
            tabControl1.TabPages.Add(maBan, "Bàn " + maBan);

            DataGrid dt = new DataGrid();
            dt.Size = tabControl1.TabPages[maBan].Size;
            dt.ReadOnly = true;

            tabControl1.TabPages[maBan].Controls.Add(dt);
            tabControl1.TabPages[maBan].Tag = maHD;

            dt.DataSource = CTHD(maHD);

            Set_Ma();
            btThem.Enabled = true;
        }

        private void GoiMon_Load(object sender, EventArgs e)
        {
            Set_Ma();

            foreach (DataRow dr in ThucDon.Rows)
                cbMA.Items.Add(dr.ItemArray[0] + "." + dr.ItemArray[1]);
            cbMA.SelectedIndex = 0;

            DataTable hd = Data.Load("HoaDon", "MaHD, MaBan, ThanhToan");

            foreach (DataRow dr in hd.Rows)
            {
                if (dr.ItemArray[2].ToString() == "False")
                    Show(dr.ItemArray[0].ToString(), dr.ItemArray[1].ToString());
            }

            if (tabControl1.TabPages.Count == 0)
                btTT.Enabled = false;
        }

        private void BtTao_Click(object sender, EventArgs e)
        {
            DataTable datban = Data.Load("DatBan", "MaBan, Ten, ThoiGian");

            foreach (DataRow dr in datban.Rows)
            {
                if (cbMB.Text == dr.ItemArray[0].ToString())
                {
                    string thoigian = dr.ItemArray[2].ToString();
                    if (!Check.GioHopLe(DateTime.Parse(thoigian), DateTime.Now))
                        if (MessageBox.Show("Bàn được đặt vào lúc: " + thoigian + " của khách hàng " + dr.ItemArray[1].ToString() + " bạn có muốn tạo hóa đơn?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.No)
                            return;
                        else
                            break;
                    btTT.Enabled = true;
                }

            }

            String maBan = cbMB.Text;
            String maHD = txtMaHD.Text.ToString();

            Data.Add("HoaDon", "MaHD, MaBan, MaNV, NgayLap", "'" + txtMaHD.Text + "','" + cbMB.Text + "','" + DangNhap.MSNV + "','" + DateTime.Now + "'");
            Data.Update("Ban", "TinhTrang = 'Đang Sử Dụng'", "MaBan =" + maBan);

            Show(maHD, maBan);
        }

        private void BtThem_Click(object sender, EventArgs e)
        {
            if (Check.Num(txtSoLuong.Text))
            {
                TabPage tc = tabControl1.SelectedTab;
                DataGrid dt = (DataGrid)tc.Controls[0];
                
                string maHD = tabControl1.SelectedTab.Tag.ToString();
                string maMA = cbMA.Text.Substring(0, cbMA.Text.IndexOf("."));
                
                int soLuong = int.Parse(txtSoLuong.Text);
                int soLuongCu = CheckMA(maHD, maMA.ToString());

                int donGia = 0;
                string tenMA = "";

                foreach (DataRow dr in ThucDon.Rows)
                {
                    if (dr.ItemArray[0].ToString() == maMA)
                    {
                        tenMA = dr.ItemArray[1].ToString();
                        donGia = int.Parse(dr.ItemArray[2].ToString());
                    }
                }

                if (soLuongCu == 0)
                {
                    Data.Add("CTHD", "MaHD, MaMA, TenMA, SoLuong, DonGia, ThanhTien", "'" + maHD + "','" + maMA + "','" + tenMA + "','" + txtSoLuong.Text + "','" + donGia + "','" + donGia * soLuong + "'");
                }
                else
                    Data.Update("CTHD", "SoLuong =" + (soLuong + soLuongCu) + ", DonGia =" + donGia * (soLuong + soLuongCu), "MaHD = " + maHD + " and MaMA =" + maMA);
                
                txtTT.Text  = (int.Parse(txtTT.Text) + (donGia * soLuong)).ToString();
                
                Data.Update("HoaDon", "TongTien ='" + txtTT.Text + "'", "MaHD =" + maHD);
                
                dt.DataSource = CTHD(maHD);
                btTT.Enabled = true;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable hd = Data.Load("HoaDon", "MaHD, TongTien");
            if (tabControl1.TabPages.Count != 0)
            {
                string maHD = tabControl1.SelectedTab.Tag.ToString();

                foreach (DataRow dr in hd.Rows)
                {
                    if (dr.ItemArray[0].ToString() == maHD)
                        txtTT.Text = dr.ItemArray[1].ToString();
                }
            }
            //if (txtTT.Text != "0")
            //    btTT.Enabled = true;
            //else
            //    btTT.Enabled = false;
        }

        private void btTT_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Bạn muốn thanh toán hóa đơn " + tabControl1.SelectedTab.Name + "?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Data.Update("Ban", "TinhTrang = 'Trống'", "MaBan =" + tabControl1.SelectedTab.Name);
                Data.Update("HoaDon", "ThanhToan = True", "MaHD =" + tabControl1.SelectedTab.Tag.ToString());
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
                MessageBox.Show("Thanh toán thành công");
                if (tabControl1.TabPages.Count == 0)
                {
                    btTT.Enabled = false;
                    btThem.Enabled = false;
                }
            }
        }
    } 
}
