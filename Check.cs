using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace QLNH
{
    public class Check
    {
        public static bool Alpha(string s)
        {
            if (s.Length == 0)
                return false;
            if (char.IsWhiteSpace(s[0]))
                return false;
            foreach (char i in s)
                if (!char.IsLetter(i) && !char.IsWhiteSpace(i))
                    return false;
            return true;
        }

        public static bool Num(string s)
        {
            if (s.Length == 0)
                return false;
            foreach (char i in s)
                if (!char.IsDigit(i))
                    return false;
            return true;
        }

        public static int GioHopLe(DateTime a, DateTime b)
        {
            //Trả về true khi a, b cách nhau hơn 3 tiếng
            //-1 -> a < b
            //0 -> a = b
            //1 -> a > b

            if (a.CompareTo(b) == 0)
                return 1;
            if (a.CompareTo(b) == -1 && b.CompareTo(a.AddHours(3)) == -1)
                return -1;
            if (b.CompareTo(a) == -1 && a.CompareTo(b.AddHours(3)) == -1)
                return 1;
            return 0;
        }

        public static bool SDT(string s, int max)
        {
            if (s.Length != max)
                return false;
            if (s[0] != '0')
                return false;
            if (!Num(s))
                return false;
            return true;
        }

        public static bool Ban(String maban, DateTime time)
        {
            DataTable dsd = Data.Load("DatBan", "MaBan, ThoiGian");

            foreach (DataRow ds in dsd.Rows)
                if (ds.ItemArray[0].ToString() == maban && GioHopLe(DateTime.Parse(ds.ItemArray[1].ToString()), time) != 2)
                    return false;
            return true;
        }

        public static bool Login(string id, string pass)
        {
            if (id == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!");
                return false;
            }
            if (pass == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return false;
            }

            DataTable dsnv = Data.Load("TaiKhoan", "MaNV, TaiKhoan, MatKhau");
            foreach (DataRow dr in dsnv.Rows)
            {
                if (id == dr.ItemArray[1].ToString())
                {
                    if (pass == dr.ItemArray[2].ToString())
                    {
                        new NhanVien(dr.ItemArray[0].ToString());
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Sai mật khẩu");
                        return false; 
                    }
                }
            }
            MessageBox.Show("Sai tài khoản");
            return false;
        }
    }
}
