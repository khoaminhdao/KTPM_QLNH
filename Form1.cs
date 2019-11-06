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
        public static String MSNV;

        public static void Open_DataAccess()
        {

            strcon.ConnectionString = s;

            strcon.Open();

        }

        public static DataTable Load_Data(string table, string danhsachthamso)
        {
            DataSet dsHienThi = new DataSet();

            string s = "select " + danhsachthamso + " from " + table;

            Open_DataAccess();

            OleDbDataAdapter daShowData = new OleDbDataAdapter(s, strcon);

            daShowData.Fill(dsHienThi, table);

            strcon.Close();
            return dsHienThi.Tables[0];

        }

        public static void Add_Data(string table, string danhsachcot, string danhsachthamso)
        {

            string l = "insert into " + table + "(" + danhsachcot + ") values(" + danhsachthamso + ")";

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

        public static void Delete_Data (string table, string dk)
        {
            string l = "delete from " + table + " where " + dk;

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

        public static Boolean checkAlpha (string s)
        {
            if (s.Length == 0)
                return false;
            for (int i = 0; i < s.Length; i++)
                if (!char.IsLetter(s[i]))
                    return false;
            return true;
        }

        public static Boolean checkNum(string s)
        {
            if (s.Length == 0)
                return false;
            for (int i = 0; i < s.Length; i++)
                if (!char.IsDigit(s[i]))
                    return false;
            return true;
        }

        public Boolean CheckGioHopLe (DateTime a, DateTime b)
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

        public Boolean checkSDT (string s)
        {
            int maxNum = 10;
            if (rdBan.Checked)
                maxNum = 11;
            if (s.Length != maxNum)
                return false;
            if (s[0] != '0')
                return false;
            if (!checkNum(s))
                return false;
            return true;
        }
        private void Check_Login(string id, string pass)
        {
            DataTable dsnv = Load_Data("TaiKhoan", "MaNV, TaiKhoan, MatKhau");
            if (id == "")
            { MessageBox.Show("Vui lòng nhập tên tài khoản!"); }
            else if (pass == "")
            { MessageBox.Show("Vui lòng nhập mật khẩu!"); return; }
            else
            {
                for (int i = 0; i < dsnv.Rows.Count; i++)
                    if (id == dsnv.Rows[i].ItemArray[1].ToString())
                        if (pass == dsnv.Rows[i].ItemArray[2].ToString())
                        {
                            MSNV = dsnv.Rows[i].ItemArray[0].ToString();
                            MenuNV menu = new MenuNV();
                            Hide();
                            menu.ShowDialog();
                            Show();
                            return;
                        }
                        else
                        { MessageBox.Show("Sai mật khẩu"); return; }
                MessageBox.Show("Sai tài khoản");
            }
        }

        private void setTime ()
        {
            int gio = DateTime.Now.Hour;
            int phut = DateTime.Now.Minute;

            if (gio < 19)
            {
                String s = gio + 3 + ":";

                if (phut < 30)
                    s += "00";
                else
                    s += "30";

                while (cbTime.Items[0].ToString() != s)
                {
                    cbTime.Items.RemoveAt(0);
                }

                cbTime.SelectedIndex = 0;

            }
            else
                timePk.MinDate = DateTime.Now.Date.AddDays(1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timePk.MinDate = DateTime.Now.Date;
            timePk.MaxDate = DateTime.Now.Date.AddMonths(1);

            setTime();
        }

        private void BtDN_Click(object sender, EventArgs e)
        {
            Check_Login(txtTK.Text, txtMK.Text);
        }

        private void BtDatBan_Click(object sender, EventArgs e)
        {
            String maban = "";
            String ten = txtTen.Text;
            String soDT = txtSDT.Text;
            String soNg = txtSN.Text;
            int gio = int.Parse(cbTime.Text.Substring(0, 2));
            int phut = int.Parse(cbTime.Text.Substring(3));
            DateTime time = timePk.Value.AddHours(gio).AddMinutes(phut);

            if (!checkAlpha(ten))
                MessageBox.Show("Vui lòng nhập tên chính xác");
            else if (!checkSDT(soDT))
                MessageBox.Show("Vui lòng nhập đúng số điện thoại");
            else if (!checkNum(soNg))
                MessageBox.Show("Vui lòng nhập số người chính xác");
            else
            {
                DataTable dsb = Load_Data("Ban", "MaBan, SucChua, TinhTrang");
                DataTable dsd = Load_Data("DatBan", "MaBan, ThoiGian");
                int i, j;
                for (i = 0; i < dsb.Rows.Count; i++)
                {
                    if (int.Parse(dsb.Rows[i].ItemArray[1].ToString()) >= int.Parse(soNg))
                    {
                        for (j = 0; j < dsd.Rows.Count; j++)
                            if (dsd.Rows[j].ItemArray[0].ToString() == dsb.Rows[i].ItemArray[0].ToString() && !CheckGioHopLe(DateTime.Parse(dsd.Rows[j].ItemArray[1].ToString()), time))
                                break;
                        if (j == dsd.Rows.Count)
                        {
                            maban = dsb.Rows[i].ItemArray[0].ToString();
                            break;
                        }
                    }
                }
                if (i != dsb.Rows.Count)
                {
                    Add_Data("DatBan", "MaBan, Ten, SDT, ThoiGian, SoNguoi","'" + maban + "','" + ten + "','" + soDT + "','" + time + "','" + soNg + "'");
                    MessageBox.Show("Đặt bàn thành công!");
                }
                else MessageBox.Show("Không có bàn phù hợp yêu cầu!");

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void TimePk_ValueChanged(object sender, EventArgs e)
        {
            if (timePk.Value.CompareTo(DateTime.Now.Date) == 0)
                setTime();
        }
    }
}
