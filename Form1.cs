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

        static OleDbConnection strcon = new OleDbConnection();
        static string s = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\DATA\Data.mdb";
        DataSet dsnv = new DataSet();

        public static void Open_DataAccess()
        {

            strcon.ConnectionString = s;

            strcon.Open();

        }

        public static DataSet Load_Data(string table, string danhsachthamso)
        {
            DataSet dsHienThi = new DataSet();

            string s = "select " + danhsachthamso + " from " + table;

            Open_DataAccess();

            OleDbDataAdapter daShowData = new OleDbDataAdapter(s, strcon);

            daShowData.Fill(dsHienThi, table);

            strcon.Close();
            return dsHienThi;

        }

        public static void Add_Data(string table, string danhsachcot, string danhsachthamso)
        {

            string l = "insert into " + table + "(" + danhsachcot + ") values(' " + danhsachthamso + "')";

            Open_DataAccess();

           
            using (OleDbConnection connection = new OleDbConnection(s))
            using (OleDbCommand command = new OleDbCommand(l, strcon))
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                reader.Close();
            }
       
            strcon.Close();
        }

        public static void Update_Data(string table, string danhsach, string dk)
        {

            string l = "update " + table + " set " + danhsach + " where " + dk;

            Open_DataAccess();


            using (OleDbConnection connection = new OleDbConnection(s))
            using (OleDbCommand command = new OleDbCommand(l, strcon))
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                reader.Close();
            }

            strcon.Close();
        }

        private void Check_Login (string id, string pass)
        {
            if (id == "")
            { MessageBox.Show("Vui lòng nhập tên tài khoản!"); }
            else if (pass == "")
            { MessageBox.Show("Vui lòng nhập mật khẩu!"); return; }
            else
            {
                for (int i = 0; i < dsnv.Tables[0].Rows.Count; i++)
                    if (id == dsnv.Tables[0].Rows[i].ItemArray[2].ToString())
                        if (pass == dsnv.Tables[0].Rows[i].ItemArray[3].ToString())
                        { MessageBox.Show("Đăng nhập thành công"); return; }
                        else
                        { MessageBox.Show("Sai mật khẩu"); return; }
                MessageBox.Show("Sai tài khoản");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            dsnv = Load_Data("NhanVien", "MaNV, TenNV, TaiKhoan, MatKhau");

            //dataGridView1.DataSource = ds.Tables[0];
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Check_Login(iDBox.Text, passBox.Text);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Log_KH lgkh = new Log_KH();
            lgkh.Show();
            this.Hide();
        }
    }
}
