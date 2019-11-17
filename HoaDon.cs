using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH
{
    class MonAn
    {
        private string ma;
        private string ten;
        private int soLuong;
        private int donGia;

        public MonAn(string ma, int soLuong)
        {
            this.ma = ma;
            this.soLuong = soLuong;

            DataTable ThucDon = Data.Load("ThucDon", "TenMA, DonGia", "MaMA =" + ma);
            foreach (DataRow dr in ThucDon.Rows)
            {
                this.ten = dr["TenMA"].ToString();
                this.donGia = int.Parse(dr["DonGia"].ToString());
            }
        }

        public string GetMa()
        {
            return this.ma;
        }

        public string GetTen()
        {
            return this.ten;
        }

        public int GetSL()
        {
            return this.soLuong;
        }

        public int GetDonGia()
        {
            return this.donGia;
        }

        public int GetThanhTien()
        {
            return soLuong * donGia;
        }

        public void TangSL(int soLuong)
        {
            this.soLuong += soLuong;
        }

    }

    public class HoaDon
    {
        private string maHD;
        private string maBan;
        private double tongTien;
        private List<MonAn> cthd = new List<MonAn>();

        public HoaDon(string maHD, string maBan, double tongtien)
        {
            this.maHD = maHD;
            this.maBan = maBan;
            this.tongTien = tongtien;

            DataTable dt = Data.Load("CTHD", "MaHD, MaMA, SoLuong", "MaHD =" + this.maHD);
            foreach (DataRow dr in dt.Rows)
            {
                this.cthd.Add(new MonAn(dr["MaMA"].ToString(), int.Parse(dr["SoLuong"].ToString())));
            }
        }

        public string GetMaBan()
        {
            return this.maBan;
        }

        public static string Set_Ma()
        {
            DataView hd = Data.Load("HoaDon", "MaHD").DefaultView;
            hd.Sort = "MaHD";
            DataTable hd1 = hd.ToTable();
            int count = 1;

            foreach (DataRow dr in hd1.Rows)
            {
                if (int.Parse(dr.ItemArray[0].ToString()) != count)
                {
                    return count.ToString();
                }
                else
                    count++;
            }
            return (hd1.Rows.Count + 1).ToString();
        }

        public DataTable ChiTiet()
        {  
            DataTable temp = new DataTable();
            temp.Columns.Add("MaMA", typeof(string));
            temp.Columns.Add("TenMA", typeof(string));
            temp.Columns.Add("SoLuong", typeof(int));
            temp.Columns.Add("DonGia", typeof(double));
            temp.Columns.Add("ThanhTien", typeof(double));

            DataTable dt = Data.Load("CTHD", "MaMA, TenMA, SoLuong, DonGia, ThanhTien", "MaHD =" + this.maHD);

            foreach (DataRow dr in dt.Rows)
            {
                temp.ImportRow(dr);
            }

            temp.Columns[0].ColumnName = "Mã Món Ăn";
            temp.Columns[1].ColumnName = "Tên Món Ăn";
            temp.Columns[2].ColumnName = "Số Lượng";
            temp.Columns[3].ColumnName = "Đơn Giá";
            temp.Columns[4].ColumnName = "Thành Tiền";

            return temp;
        }

        public void ThemMA(string maMA, int soLuong)
        {
            MonAn i = cthd.Find(x => x.GetMa().Equals(maMA));
            if (i != null)
            {
                i.TangSL(soLuong);
                tongTien += (i.GetDonGia() * soLuong);
                Data.Update("CTHD", "SoLuong =" + i.GetSL() + ", ThanhTien =" + i.GetThanhTien(), "MaHD = " + maHD + " and MaMA =" + maMA);
                Data.Update("HoaDon", "TongTien =" + tongTien, "MaHD =" + this.maHD);
                return;
            }
            else
            {
                this.cthd.Add(new MonAn(maMA, soLuong));
                MonAn ma = cthd[cthd.Count() - 1];
                double thanhtien = ma.GetDonGia() * soLuong;
                tongTien += thanhtien;
                Data.Add("CTHD", "MaHD, MaMA, TenMA, SoLuong, DonGia, ThanhTien", "'" + maHD + "','" + maMA + "','" + ma.GetTen() + "','" + soLuong + "','" + ma.GetDonGia() + "','" + thanhtien + "'");
                Data.Update("HoaDon", "TongTien =" + tongTien, "MaHD =" + this.maHD);
            }
        }

        public void XoaMA(string maMA)
        {
            Data.Delete("CTHD", "MaHD =" + this.maHD + " and MaMA = " + maMA);
            Data.Update("HoaDon", "TongTien =" + tongTien, "MaHD =" + this.maHD);

            MonAn ma = cthd.Find(x => x.GetMa().Equals(maMA));
                
            tongTien -= (ma.GetDonGia() * ma.GetSL());
            cthd.Remove(ma);
        }

        public double GetTT()
        {
            return tongTien;
        }

        public void ThanhToan()
        {
            Data.Update("Ban", "TinhTrang = 'Trống'", "MaBan =" + maBan);

            if (this.tongTien != 0)
                Data.Update("HoaDon", "ThoiGianThanhToan ='" + DateTime.Now + "'", "MaHD =" + maHD);
            else
                Data.Delete("HoaDon", "MaHD =" + maHD);
        }
    }
}
