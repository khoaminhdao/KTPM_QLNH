using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLNH
{
    public class Check
    {
      
        public static Boolean Alpha(string s)
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

        public static Boolean Num(string s)
        {
            if (s.Length == 0)
                return false;
            foreach (char i in s)
                if (!char.IsDigit(i))
                    return false;
            return true;
        }

        public static Boolean GioHopLe(DateTime a, DateTime b)
        {
            //Trả về true khi a, b cách nhau hơn 3 tiếng
            //-1 -> a < b
            //0 -> a = b
            //1 -> a > b

            if (a.CompareTo(b) == 0)
                return false;
            if (a.CompareTo(b) == -1 && b.CompareTo(a.AddHours(3)) == -1)
                return false;
            if (b.CompareTo(a) == -1 && a.CompareTo(b.AddHours(3)) == -1)
                return false;
            return true;
        }

        public static Boolean SDT(string s, int max)
        {
            if (s.Length != max)
                return false;
            if (s[0] != '0')
                return false;
            if (!Num(s))
                return false;
            return true;
        }

        public static Boolean Ban(String maban, DateTime time)
        {
            DataTable dsd = Data.Load("DatBan", "MaBan, ThoiGian");

            foreach (DataRow ds in dsd.Rows)
                if (ds.ItemArray[0].ToString() == maban && !GioHopLe(DateTime.Parse(ds.ItemArray[1].ToString()), time))
                    return false;
            return true;
        }
    }
}
