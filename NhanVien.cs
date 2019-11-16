using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH
{
    public class NhanVien
    {
        private static string maNV;
        private static string ten;
        private static string chucVu;

        public NhanVien(string MSNV)
        {
            maNV = MSNV;
            DataTable dsnv = Data.Load("NhanVien", "Ten, ChucVu", "MaNV =" + maNV);
            ten = dsnv.Rows[0]["Ten"].ToString();
            chucVu = dsnv.Rows[0]["ChucVu"].ToString();
        }

        public static string GetMaNV()
        {
            return maNV;
        }

        public static string GetTen()
        {
            return ten;
        }

        public static string GetCV()
        {
            return chucVu;
        }
    }
}
