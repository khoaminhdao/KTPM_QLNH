using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH
{
    public class Ban
    {
        public static List<string> DSTrong()
        {
            List<string> ds = new List<string>();
            DataView ban = Data.Load("Ban", "MaBan", "TinhTrang = 'Trống'").DefaultView;
            ban.Sort = "MaBan";
            DataTable ban1 = ban.ToTable();
         
            foreach(DataRow dr in ban1.Rows)
            {
                ds.Add(dr.ItemArray[0].ToString());
            }
            return ds;
        }

        public static DataTable Ctdb(string maban)
        {
            DataTable dsd = Data.Load("DatBan", "Ten, SDT, ThoiGian, SoNguoi", "MaBan =" + maban);
            DataTable temp = new DataTable();
            temp.Columns.Add("Ten", typeof(string));
            temp.Columns.Add("SDT", typeof(string));
            temp.Columns.Add("ThoiGian", typeof(DateTime));
            temp.Columns.Add("SoNguoi", typeof(Int32));

            foreach (DataRow ds in dsd.Rows)
                temp.ImportRow(ds);

            return temp;
        }

        public static bool CheckHopLe(String maban, DateTime time)
        {
            DataTable dsd = Data.Load("DatBan", "ThoiGian", "MaBan =" + maban);

            foreach (DataRow ds in dsd.Rows)
                if (Check.GioHopLe(DateTime.Parse(ds["ThoiGian"].ToString()), time) != 0)
                    return false;
            return true;
        }

    }
}
