using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace QLNH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection strcon = new OleDbConnection();
        DataSet dsnv = new DataSet();

        public void Open_DataAccess()

        {

            string s = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\DATA\Data.mdb";

            strcon.ConnectionString = s;

            strcon.Open();

        }

        public DataSet Load_Data()

        {
            DataSet dsHienThi = new DataSet();

            string s = "select MaNV, TenNV, TaiKhoan, MatKhau from NhanVien";

            Open_DataAccess();

            OleDbDataAdapter daShowData = new OleDbDataAdapter(s, strcon);

            daShowData.Fill(dsHienThi, "NhanVien");

            strcon.Close();
            return dsHienThi;

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            
            dsnv = Load_Data();

            //dataGridView1.DataSource = ds.Tables[0];
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (iDBox.Text == "")
            { MessageBox.Show("Vui lòng nhập tên tài khoản!");}
            else if (passBox.Text == "")
                { MessageBox.Show("Vui lòng nhập mật khẩu!"); return; }
            else
            {
                for (int i = 0; i < dsnv.Tables[0].Rows.Count; i++)
                    if (iDBox.Text == dsnv.Tables[0].Rows[i].ItemArray[2].ToString())
                       if (passBox.Text == dsnv.Tables[0].Rows[i].ItemArray[3].ToString())
                          { MessageBox.Show("Đăng nhập thành công"); return; }
                       else
                          { MessageBox.Show("Sai mật khẩu"); return; }
                MessageBox.Show("Sai tài khoản");
            }
        }
    }
}
