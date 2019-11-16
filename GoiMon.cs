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

        List<HoaDon> hd = new List<HoaDon>();

        public void DSB()
        {
            cbMB.Items.Clear();

            List<String> ds = new List<String>();
            Ban.DSTrong(ds);

            foreach (string i in ds)
            {
               cbMB.Items.Add(i);
            }
            if (cbMB.Items.Count == 0)
            {
                cbMB.Items.Add("Không");
                btTao.Enabled = false;
            }
            cbMB.SelectedIndex = 0;
        }

        public void CreatePage(string maBan)
        {
            tabControl1.TabPages.Add(maBan, "Bàn " + maBan);

            DataGridView dt = new DataGridView
            {
                Size = tabControl1.TabPages[maBan].Size,
                ReadOnly = true,
                DataSource = hd[hd.Count - 1].ChiTiet(),
                AllowUserToAddRows = false,
                AllowUserToResizeRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToResizeColumns = false
            };

            dt.CellClick += Dt_CellClick;

            tabControl1.TabPages[maBan].Controls.Add(dt);
            txtMaHD.Text = HoaDon.Set_Ma();
            DSB();
            btThem.Enabled = true;
        }

        private void Dt_CellClick(object sender, EventArgs e)
        {
            btXoa.Enabled = true;
        }

        private void GoiMon_Load(object sender, EventArgs e)
        {
            txtMaHD.Text = HoaDon.Set_Ma();
            DSB();

            DataTable ThucDon = Data.Load("ThucDon", "MaMA, TenMA, DonGia");
            foreach (DataRow dr in ThucDon.Rows)
                cbMA.Items.Add(dr.ItemArray[0] + "." + dr.ItemArray[1]);
            cbMA.SelectedIndex = 0;

            DataTable dt = Data.Load("HoaDon", "MaHD, MaBan, TongTien", "(([HoaDon].[ThoiGianLap])=([HoaDon].[ThoiGianThanhToan]))");

            foreach (DataRow dr in dt.Rows)
            {
                hd.Add(new HoaDon(dr.ItemArray[0].ToString(), dr.ItemArray[1].ToString(), double.Parse(dr.ItemArray[2].ToString())));
                CreatePage(dr.ItemArray[1].ToString());
            }

            if (tabControl1.TabPages.Count == 0)
                btTT.Enabled = false;
            else
                txtTT.Text = hd[0].GetTT().ToString();
        }

        private void BtTao_Click(object sender, EventArgs e)
        {
            DataTable datban = Data.Load("DatBan", "Ten, ThoiGian", "MaBan =" + cbMB.Text);

            foreach (DataRow dr in datban.Rows)
            {
                string thoigian = dr.ItemArray[1].ToString();
                if (!Check.GioHopLe(DateTime.Parse(thoigian), DateTime.Now))
                {
                    if (MessageBox.Show("Bàn được đặt vào lúc: " + thoigian + " của khách hàng " + dr.ItemArray[0].ToString() + " bạn có muốn tạo hóa đơn?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;
                    else
                        break;
                }
                btTT.Enabled = true;
               
            }

            string maBan = cbMB.Text;
            string maHD = txtMaHD.Text.ToString();

            hd.Add(new HoaDon(maHD, maBan, 0));
            Data.Add("HoaDon", "MaHD, MaBan, MaNV, ThoiGianLap, ThoiGianThanhToan", "'" + maHD + "','" + maBan + "','" + NhanVien.GetMaNV() + "','" + DateTime.Now + "','" + DateTime.Now + "'");
            Data.Update("Ban", "TinhTrang = 'Đang Sử Dụng'", "MaBan =" + maBan);
            CreatePage(maBan);
        }

        private void BtThem_Click(object sender, EventArgs e)
        {
           
                int stt = tabControl1.SelectedIndex;
                
                string maMA = cbMA.Text.Substring(0, cbMA.Text.IndexOf("."));
                
                hd[stt].ThemMA(maMA, (int)numSL.Value);

                DataGridView dt = (DataGridView)(tabControl1.TabPages[stt].Controls[0]);
                dt.DataSource = hd[stt].ChiTiet();
                
                txtTT.Text  = hd[stt].GetTT().ToString();
                
                btTT.Enabled = true;
           
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (tabControl1.TabPages.Count != 0) //điều kiện để không bị lỗi khi thanh toán hết hóa đơn
            {   
                txtTT.Text = hd[tabControl1.SelectedIndex].GetTT().ToString();
            }
            //if (txtTT.Text != "0")
            //    btTT.Enabled = true;
            //else
            //    btTT.Enabled = false;
        }

        private void BtTT_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Bạn muốn thanh toán hóa đơn " + tabControl1.SelectedTab.Name + "?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int stt = tabControl1.SelectedIndex;
                hd[stt].ThanhToan();
                hd.RemoveAt(stt);
                tabControl1.TabPages.RemoveAt(stt);
                MessageBox.Show("Thanh toán thành công");
                DSB();
                if (tabControl1.TabPages.Count == 0)
                {
                    btTT.Enabled = false;
                    btThem.Enabled = false;
                    txtTT.Text = "0";
                }
            }
        }

        private void BtXoa_Click(object sender, EventArgs e)
        {
            int stt = tabControl1.SelectedIndex;
            DataGridView dt = (DataGridView)(tabControl1.TabPages[stt].Controls[0]);

            foreach (DataGridViewRow dr in dt.SelectedRows)
            {
                hd[stt].XoaMA(dr.Cells[0].Value.ToString());
            }

            dt.DataSource = hd[stt].ChiTiet();

            txtTT.Text = hd[stt].GetTT().ToString();
            btXoa.Enabled = false;
        }
    } 
}
