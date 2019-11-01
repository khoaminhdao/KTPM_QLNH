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

            string l = "insert into " + table + "(" + danhsachcot + ") values('" + danhsachthamso + "')";

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

        private void Form1_Load(object sender, EventArgs e)
        {
            timePk.MinDate = DateTime.Now.Date;
            timePk.MaxDate = DateTime.Now.Date.AddMonths(1);
        }

        private void BtDN_Click(object sender, EventArgs e)
        {
            Check_Login(txtTK.Text, txtMK.Text);
        }

        private void BtKH_Click(object sender, EventArgs e)
        {
            txtTK.Visible = txtMK.Visible = lbTK.Visible = lbMK.Visible = btDN.Visible = false;
            txtTen.Visible = txtSDT.Visible = timePk.Visible = txtSN.Visible = lbTen.Visible = lbSDT.Visible = lbTG.Visible = lbSN.Visible = groupBox1.Visible = btDatBan.Visible = true;

        }

        private void BtNV_Click(object sender, EventArgs e)
        {
            txtTen.Visible = txtSDT.Visible = timePk.Visible = txtSN.Visible = lbTen.Visible = lbSDT.Visible = lbTG.Visible = lbSN.Visible = groupBox1.Visible = btDatBan.Visible = false;
            txtTK.Visible = txtMK.Visible = lbTK.Visible = lbMK.Visible = btDN.Visible = true;
        }

        private void BtDatBan_Click(object sender, EventArgs e)
        {
            String maban = "";
            String ten = txtTen.Text;
            String soDT = txtSDT.Text;
            String soNg = txtSN.Text;
            if (timePk.Value.CompareTo(DateTime.Now.AddHours(3)) != 1) //-1 -> t1 < t2 //1 -> t1 > t2
               MessageBox.Show("Bạn phải đặt trước ít nhất 3 tiếng!");
            else if (!checkAlpha(ten))
                MessageBox.Show("Vui lòng nhập tên chính xác");
            else if (!checkSDT(soDT))
                MessageBox.Show("Vui lòng nhập đúng số điện thoại");
            else if (!checkNum(soNg))
                MessageBox.Show("Vui lòng nhập số người chính xác");
            else
            {
                DataTable dsb = Load_Data("Ban", "MaBan, SoNguoi, TinhTrang, Dat");
                int i, j;
                for (i = 0; i < dsb.Rows.Count; i++)
                {
                    if (int.Parse(dsb.Rows[i].ItemArray[1].ToString()) >= int.Parse(soNg))
                        if (dsb.Rows[i].ItemArray[3].ToString() == "False")
                        {
                            maban = dsb.Rows[i].ItemArray[0].ToString();
                            Update_Data("Ban", "Dat = True", "MaBan = " + (i + 1));
                            break;
                        }
                        else
                        {
                            DataTable dsd = Load_Data("DatBan", "MaBan, ThoiGian");
                            for (j = 0; j < dsd.Rows.Count; j++)
                                if (dsd.Rows[j].ItemArray[0].ToString() == dsb.Rows[i].ItemArray[0].ToString() && (timePk.Value.CompareTo(DateTime.Parse(dsd.Rows[j].ItemArray[1].ToString()).AddHours(3)) == -1 || DateTime.Parse(dsd.Rows[j].ItemArray[1].ToString()).CompareTo(timePk.Value.AddHours(3)) == -1))
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
                    Add_Data("DatBan", "MaBan, Ten, SDT, ThoiGian, SoNguoi", maban + "','" + ten + "','" + soDT + "','" + timePk.Value.ToString() + "','" + soNg);
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
    }
}
