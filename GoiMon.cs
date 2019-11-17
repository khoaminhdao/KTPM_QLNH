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

        List<HoaDon> hd = new List<HoaDon>();

        public void DSB()
        {
            cbMB.Items.Clear();

            List<String> ds = Ban.DSTrong();

            if (ds.Count == 0)
            {
                cbMB.Items.Add("Không");
                btTao.Enabled = false;
            }
            else
            {
                foreach (string i in ds)
                {
                    cbMB.Items.Add(i);
                }

                cbMB.SelectedIndex = 0;
            }
        }

        public void CreatePage(string maBan)
        {
            tabControl1.TabPages.Add(maBan, "Bàn " + maBan);

            DataGridView dt = new DataGridView
            {
                Size = tabControl1.SelectedTab.Size,
                ReadOnly = true,
                DataSource = hd.Find(x => x.GetMaBan().Equals(maBan)).ChiTiet(),
                AllowUserToAddRows = false,
                AllowUserToResizeRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToResizeColumns = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
            };

           // dt.CellClick += Dt_CellClick;
            dt.CurrentCellChanged += CurrentCellChanged;
            tabControl1.TabPages[maBan].Controls.Add(dt);
            txtMaHD.Text = HoaDon.Set_Ma();
            DSB();
            btThem.Enabled = true;
            btTT.Enabled = true;
        }

        private void CurrentCellChanged(object sender, EventArgs e)
        {
            DataGridView dt = (DataGridView)tabControl1.SelectedTab.Controls[0];
            if (dt.CurrentRow != null)
            {
                dt.CurrentRow.Selected = true;
                btXoa.Enabled = true;
            }
        }

        private void GoiMon_Load(object sender, EventArgs e)
        {
            txtMaHD.Text = HoaDon.Set_Ma();
            DSB();

            DataTable ThucDon = Data.Load("ThucDon", "*");
            foreach (DataRow dr in ThucDon.Rows)
                cbMA.Items.Add(dr["MaMA"] + "." + dr["TenMA"]);
            cbMA.SelectedIndex = 0;

            DataTable dt = Data.Load("HoaDon", "MaHD, MaBan, TongTien", "(([HoaDon].[ThoiGianLap])=([HoaDon].[ThoiGianThanhToan]))");

            foreach (DataRow dr in dt.Rows)
            {
                hd.Add(new HoaDon(dr["MaHD"].ToString(), dr["MaBan"].ToString(), double.Parse(dr["TongTien"].ToString())));
                CreatePage(dr[1].ToString());
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
                string thoigian = dr["ThoiGian"].ToString();
                if (Check.GioHopLe(DateTime.Parse(thoigian), DateTime.Now) == 1)
                {
                    if (MessageBox.Show("Bàn được đặt vào lúc: " + thoigian + " của khách hàng " + dr["Ten"].ToString() + " bạn có muốn tạo hóa đơn?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;
                    else
                        break;
                }
               
            }

            string maBan = cbMB.Text;
            string maHD = txtMaHD.Text.ToString();

            hd.Add(new HoaDon(maHD, maBan, 0));
            string s = string.Format("{0}, {1}, {2}, '{3}', '{4}'", maHD, maBan, NhanVien.GetMaNV(), DateTime.Now, DateTime.Now);
            Data.Add("HoaDon", "MaHD, MaBan, MaNV, ThoiGianLap, ThoiGianThanhToan", s);
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

            numSL.Value = 1;
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
            
            if (MessageBox.Show("Bạn muốn thanh toán hóa đơn ở bàn " + tabControl1.SelectedTab.Name + "?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int stt = tabControl1.SelectedIndex;
                hd[stt].ThanhToan();
                hd.RemoveAt(stt);
                tabControl1.TabPages.RemoveAt(stt);
                MessageBox.Show("Thanh toán thành công");
                txtMaHD.Text = HoaDon.Set_Ma();
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
