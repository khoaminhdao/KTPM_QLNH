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
            try 
            {
                if (s.Length == 0)
                    throw new FormatException("Vui lòng nhập!");
                if (char.IsWhiteSpace(s[0]))
                    throw new FormatException("Kí tự đầu tiên phải là chữ!");
                foreach (char i in s)
                    if (!char.IsLetter(i) && !char.IsWhiteSpace(i))
                        throw new FormatException("Vui lòng nhập chính xác");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static int GioHopLe(DateTime a, DateTime b)
        {
            //CompareTo(a, b) trả về
            //-1 -> a < b
            //0 -> a = b
            //1 -> a > b

            //GioHopLe (a, b) trả về
            //1 khi a và b là cùng 1 thời điểm hoặc khi a là thời điểm sau b trong khoảng 3 tiếng
            //0 khi a và b cách nhau hơn 3 tiếng
            //-1 khi b là thời điểm sau a trong khoảng 3 tiếng

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
            try
            {
                if (s.Length == 0)
                    throw new FormatException("Vui lòng nhập số điện thoại!");
                if (s[0] != '0')
                    throw new Exception("Vui lòng nhập chính xác số điện thoại");
                if (s.Length != max)
                    throw new Exception("Vui lòng kiểm tra số lượng chữ số đã nhập!");
               
                foreach (char i in s)
                    if (!char.IsDigit(i))
                        throw new FormatException("Vui lòng nhập chính xác số điện thoại");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

    }
}
