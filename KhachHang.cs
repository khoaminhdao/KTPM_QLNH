using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNH
{
    public class KhachHang
    {
        string maBan;
        private string ten;
        private string soDT;
        private string soNg;
        private DateTime time;

        public KhachHang(string ten, string soDT, string soNg, DateTime time)
        {
            this.ten = ten;
            this.soDT = soDT;
            this.soNg = soNg;
            this.time = time;
        }

        public bool CheckInput(int maxSDT)
        {
            if (!Check.Alpha(ten))
            {
                MessageBox.Show("Vui lòng nhập tên chính xác");
                return false;
            }
            if (!Check.SDT(soDT, maxSDT))
            {
                MessageBox.Show("Vui lòng nhập đúng số điện thoại");
                return false;
            }
            if (!Check.Num(soNg))
            {
                MessageBox.Show("Vui lòng nhập số người chính xác");
                return false;
            }
            return true;
        }

        public string checkMaBan()
        {
            DataTable dsb = Data.Load("Ban", "MaBan, SucChua, TinhTrang");

            foreach (DataRow dr in dsb.Rows)
            {
                string maban = dr.ItemArray[0].ToString();
                if (Check.Ban(maban, time))
                {
                    return maban;
                }
            }
            return "";
        }

        public void Add()
        {
            this.maBan = checkMaBan();

            if (maBan != "")
            {
                Data.Add("DatBan", "MaBan, Ten, SDT, ThoiGian, SoNguoi", "'" + this.maBan + "','" + this.ten + "','" + this.soDT + "','" + this.time + "','" + this.soNg + "'");
                MessageBox.Show("Đặt bàn thành công!");
            }
            else
                MessageBox.Show("Không có bàn phù hợp yêu cầu!");
        }
    }
}
