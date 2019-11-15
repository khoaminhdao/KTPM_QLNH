using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH
{
    class Ban
    {
        public static void DSTrong(List<string> ds)
        {
            DataView ban = Data.Load("Ban", "MaBan", "TinhTrang = 'Trống'").DefaultView;
            ban.Sort = "MaBan";
            DataTable ban1 = ban.ToTable();
         
            foreach(DataRow dr in ban1.Rows)
            {
                ds.Add(dr.ItemArray[0].ToString());
            }
        }
    }
}
