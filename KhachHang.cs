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
                return false;
            }
            if (!Check.SDT(soDT, maxSDT))
            {
                return false;
            }
            return true;
        }

        public string CheckMaBan()
        {
            DataTable dsb = Data.Load("Ban", "*");

            foreach (DataRow dr in dsb.Rows)
            {
                string maban = dr["MaBan"].ToString();
                if (Check.Ban(maban, time))
                {
                    return maban;
                }
            }
            return "";
        }

        public void Add()
        {
            this.maBan = CheckMaBan();

            if (maBan != "")
            {
                string s = string.Format("{0}, '{1}', '{2}', '{3}', {4}", this.maBan, this.ten, this.soDT, this.time, this.soNg);
                Data.Add("DatBan", "MaBan, Ten, SDT, ThoiGian, SoNguoi", s);
                MessageBox.Show("Đặt bàn thành công!");
            }
            else
                MessageBox.Show("Không có bàn phù hợp yêu cầu!");
        }
    }
}
