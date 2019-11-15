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
    public partial class GoiMon : Form
    {
        public GoiMon()
        {
            InitializeComponent();
        }

        DataTable ThucDon = Data.Load("ThucDon", "MaMA, TenMA, DonGia");
        List<HoaDon> hd = new List<HoaDon>();

        public void DSBanTrong()
        {
            DataView ban = Data.Load("Ban", "MaBan, TinhTrang").DefaultView;
            ban.Sort = "MaBan";
            DataTable ban1 = ban.ToTable();
            cbMB.Items.Clear();

            foreach (DataRow dr in ban1.Rows)
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

        public void CreatePage(string maHD, string maBan)
        {
            tabControl1.TabPages.Add(maBan, "Bàn " + maBan);
            DataGrid dt = new DataGrid();
            dt.Size = tabControl1.TabPages[maBan].Size;
            dt.ReadOnly = true;

            tabControl1.TabPages[maBan].Tag = maBan;
            tabControl1.TabPages[maBan].Controls.Add(dt);
            dt.DataSource = hd[hd.Count - 1].ChiTiet();

            txtMaHD.Text = HoaDon.Set_Ma();
            DSBanTrong();
            btThem.Enabled = true;
        }

        private void GoiMon_Load(object sender, EventArgs e)
        {
            txtMaHD.Text = HoaDon.Set_Ma();
            DSBanTrong();

            foreach (DataRow dr in ThucDon.Rows)
                cbMA.Items.Add(dr.ItemArray[0] + "." + dr.ItemArray[1]);
            cbMA.SelectedIndex = 0;

            DataTable dt = Data.Load("HoaDon", "MaHD, MaBan, MaNV, TongTien, ThanhToan");

            foreach (DataRow dr in dt.Rows)
            {
                if (dr.ItemArray[4].ToString() == "False")
                {
                    hd.Add(new HoaDon(dr.ItemArray[0].ToString(), dr.ItemArray[1].ToString(), dr.ItemArray[2].ToString(), double.Parse(dr.ItemArray[3].ToString())));
                    CreatePage(dr.ItemArray[0].ToString(), dr.ItemArray[1].ToString());
                }
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

            hd.Add(new HoaDon(maHD, maBan, DangNhap.MSNV, 0));
            Data.Add("HoaDon", "MaHD, MaBan, MaNV, NgayLap", "'" + maHD + "','" + maBan + "','" + DangNhap.MSNV + "','" + DateTime.Now + "'");
            Data.Update("Ban", "TinhTrang = 'Đang Sử Dụng'", "MaBan =" + maBan);
            CreatePage(maHD, maBan);
        }

        private void BtThem_Click(object sender, EventArgs e)
        {
            if (Check.Num(txtSoLuong.Text))
            {
                int stt = tabControl1.SelectedIndex;
                
                string maMA = cbMA.Text.Substring(0, cbMA.Text.IndexOf("."));
                
                hd[stt].ThemMA(maMA, int.Parse(txtSoLuong.Text));

                DataGrid dt = (DataGrid)(tabControl1.TabPages[stt].Controls[0]);
                dt.DataSource = hd[stt].ChiTiet();
                
                txtTT.Text  = hd[stt].getTT().ToString();
                
                btTT.Enabled = true;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (tabControl1.TabPages.Count != 0) //điều kiện để không bị lỗi
            {   
                txtTT.Text = hd[tabControl1.SelectedIndex].getTT().ToString();
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
                hd.RemoveAt(tabControl1.SelectedIndex);
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
                MessageBox.Show("Thanh toán thành công");
                DSBanTrong();
                if (tabControl1.TabPages.Count == 0)
                {
                    btTT.Enabled = false;
                    btThem.Enabled = false;
                }
            }
        }
    } 
}
