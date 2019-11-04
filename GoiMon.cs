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

        DataTable ThucDon = Form1.Load_Data("ThucDon", "MaMA, TenMA, DonGia");

        public void Set_Ma()
        {
            DataView hd = Form1.Load_Data("HoaDon", "MaHD").DefaultView;
            hd.Sort = "MaHD";
            DataTable hd1 = hd.ToTable();
            
            for (int i = 0; i < hd1.Rows.Count; i++)
                if (int.Parse(hd1.Rows[i].ItemArray[0].ToString()) != i + 1)
                {
                    txtMaHD.Text = (i + 1).ToString();
                    return;
                }
            txtMaHD.Text = (hd1.Rows.Count + 1).ToString();

            Check_Trong();
        }

        public void Check_Trong()
        {
            DataTable ban = Form1.Load_Data("Ban", "MaBan, TinhTrang");
            cbMB.Items.Clear();
            for (int i = 0; i < ban.Rows.Count; i++)
            {
                DataRow dr = ban.Rows[i];

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
            DataTable dt = Form1.Load_Data("CTHD", "MaMA, SoLuong, DonGia, ThanhTien");
            DataTable temp = new DataTable();
            temp.Columns.Add("MaHD", typeof(Int32));
            temp.Columns.Add("MaMA", typeof(Int32));
            temp.Columns.Add("SoLuong", typeof(Int32));
            temp.Columns.Add("DonGia", typeof(Int32));
            temp.Columns.Add("ThanhTien", typeof(Int32));
            temp.Columns.Add("TenMA", typeof(string));

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                if (dr.ItemArray[0].ToString() == maHD)
                {
                    dr.ItemArray[5] = ThucDon.Rows[int.Parse(dr.ItemArray[1].ToString()) - 1].ItemArray[1].ToString();
                    temp.ImportRow(dr);
                }
            }
            return temp;
        }
        private void GoiMon_Load(object sender, EventArgs e)
        {
            Set_Ma();

            for (int i = 0; i < ThucDon.Rows.Count; i++)
                cbMA.Items.Add(ThucDon.Rows[i].ItemArray[1]);
            cbMA.SelectedIndex = 0;
        }

        private void BtTao_Click(object sender, EventArgs e)
        {
            String MB = cbMB.Text;
            
            tabControl1.TabPages.Add(MB, "Bàn " + MB);

            DataGrid dt = new DataGrid();
            dt.Size = tabControl1.TabPages[MB].Size;
            dt.ReadOnly = true;

            tabControl1.TabPages[MB].Controls.Add(dt);

            Form1.Add_Data("HoaDon", "MaHD, MaBan, MaNV, NgayLap", "'" + txtMaHD.Text + "','" + cbMB.Text + "','" + Form1.MSNV + "','" + DateTime.Now + "'");
            Form1.Update_Data("Ban", "TinhTrang = 'Đang Sử Dụng'", "MaBan =" + MB);
            dt.DataSource = CTHD(MB);

            Set_Ma();
            btThem.Enabled = true;
        }

        private void BtThem_Click(object sender, EventArgs e)
        {
            if (Form1.checkNum(txtSoLuong.Text))
            {
                TabPage tc = tabControl1.SelectedTab;
                DataGrid dt = (DataGrid)tc.Controls[0];

                String maHD = txtMaHD.Text;
                int stt = cbMA.SelectedIndex;
                int DonGia = int.Parse(ThucDon.Rows[stt].ItemArray[2].ToString());
                int SoLuong = int.Parse(txtSoLuong.Text);

                Form1.Add_Data("CTHD", "MaHD, MaMA, SoLuong, DonGia, ThanhTien", "'" + txtMaHD.Text + "','" + (stt + 1) + "','" + txtSoLuong.Text + "','" + DonGia + "','" + DonGia * SoLuong +"'");
                txtTT.Text  = (int.Parse(txtTT.Text) + (DonGia * SoLuong)).ToString();
                Form1.Update_Data("HoaDon", "TongTien ='" + txtTT.Text + "'", "MaHD =" + maHD);
                
                dt.DataSource = CTHD(maHD);
            }
        }
    } 
}
