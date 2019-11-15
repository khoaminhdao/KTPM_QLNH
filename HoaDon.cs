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
        private double donGia;

        public MonAn(string ma, int soLuong)
        {
            this.ma = ma;
            this.soLuong = soLuong;

            DataTable ThucDon = Data.Load("ThucDon", "MaMA, TenMA, DonGia");
            foreach (DataRow dr in ThucDon.Rows)
            {
                if (dr.ItemArray[0].ToString() == ma)
                {
                    ten = dr.ItemArray[1].ToString();
                    donGia = int.Parse(dr.ItemArray[2].ToString());
                }
            }

        }
        public string getMa()
        {
            return ma;
        }

        public string getTen()
        {
            return ten;
        }

        public int getsl()
        {
            return soLuong;
        }

        public double getDonGia()
        {
            return donGia;
        }

        public void tangSL(int soLuong)
        {
            this.soLuong += soLuong;
        }
    }

    public class HoaDon
    {
        private string maHD;
        private string maBan;
        private string maNV;
        private double tongTien;
        private List<MonAn> cthd = new List<MonAn>();

        public HoaDon(string maHD, string maBan, string maNV, double tongtien)
        {
            this.maHD = maHD;
            this.maBan = maBan;
            this.maNV = maNV;
            this.tongTien = tongtien;
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
            DataTable dt = Data.Load("CTHD", "MaHD, TenMA, SoLuong, DonGia, ThanhTien");
            
            DataTable temp = new DataTable();
            temp.Columns.Add("MaHD", typeof(Int32));
            temp.Columns.Add("TenMA", typeof(string));
            temp.Columns.Add("SoLuong", typeof(Int32));
            temp.Columns.Add("DonGia", typeof(double));
            temp.Columns.Add("ThanhTien", typeof(double));

            foreach (DataRow dr in dt.Rows)
            {
                if (dr.ItemArray[0].ToString() == this.maHD)
                {
                    temp.ImportRow(dr);
                }
            }

            temp.Columns[0].ColumnName = "Mã Hóa Đơn";
            temp.Columns[1].ColumnName = "Tên Món Ăn";
            temp.Columns[2].ColumnName = "Số Lượng";
            temp.Columns[3].ColumnName = "Đơn Giá";
            temp.Columns[4].ColumnName = "Thành Tiền";

            return temp;
        }

        public void ThemMA(string maMA, int soLuong)
        {
            double thanhtien;
            if (this.cthd.Count() > 0)
            {
                foreach (MonAn i in this.cthd)
                {
                    if (i.getMa() == maMA)
                    {
                        i.tangSL(soLuong);
                        thanhtien = i.getDonGia() * i.getsl();
                        tongTien += thanhtien;
                        Data.Update("CTHD", "SoLuong =" + i.getsl() + ", ThanhTien =" + thanhtien, "MaHD = " + maHD + " and MaMA =" + maMA);
                        return;
                    }
                }
            }
            this.cthd.Add(new MonAn(maMA, soLuong));
            MonAn ma = cthd[cthd.Count() - 1];
            thanhtien = ma.getDonGia() * soLuong;
            tongTien += thanhtien;
            Data.Add("CTHD", "MaHD, MaMA, TenMA, SoLuong, DonGia, ThanhTien", "'" + maHD + "','" + maMA + "','" + ma.getTen() + "','" + soLuong + "','" + ma.getDonGia() + "','" + thanhtien + "'");
            
        }

        public double getTT()
        {
            return tongTien;
        }
    }
}
