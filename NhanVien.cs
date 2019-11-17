using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static bool CheckLogin(string id, string pass)
        {
            try
            {
                if (id == "")
                    throw new Exception("Vui lòng nhập tên tài khoản!");
                if (pass == "")
                    throw new Exception("Vui lòng nhập mật khẩu!");

                DataTable dsnv = Data.Load("TaiKhoan", "MaNV, MatKhau", "TaiKhoan ='" + id +"'");

                if (dsnv.Rows.Count == 0)
                    throw new Exception("Tài khoản không tồn tại! Vui lòng nhập lại.");
                else if (pass == dsnv.Rows[0]["MatKhau"].ToString())
                {
                    new NhanVien(dsnv.Rows[0]["MaNV"].ToString());
                    return true;
                }
                else
                    throw new Exception("Mật khẩu không tồn tại vui lòng nhập lại!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
