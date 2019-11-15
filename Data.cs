using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace QLNH
{
    public class Data
    {
        static readonly OleDbConnection strcon = new OleDbConnection();
        static readonly string s = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\DATA\Data.mdb";

        public static void Open_DataAccess()
        {
            strcon.ConnectionString = s;

            strcon.Open();
        }

        public static DataTable Load(string bang, string danhsachthamso)
        {
            DataSet dsHienThi = new DataSet();

            string s = "select " + danhsachthamso + " from " + bang;

            Open_DataAccess();

            OleDbDataAdapter daShowData = new OleDbDataAdapter(s, strcon);

            daShowData.Fill(dsHienThi, bang);

            strcon.Close();

            return dsHienThi.Tables[0];
        }

        public static DataTable Load(string bang, string danhsachthamso, string dk)
        {
            DataSet dsHienThi = new DataSet();

            string s = "select " + danhsachthamso + " from " + bang + " where " + dk;

            Open_DataAccess();

            OleDbDataAdapter daShowData = new OleDbDataAdapter(s, strcon);

            daShowData.Fill(dsHienThi, bang);

            strcon.Close();

            return dsHienThi.Tables[0];
        }

        public static void Add(string bang, string danhsachcot, string danhsachthamso)
        {

            string l = "insert into " + bang + "(" + danhsachcot + ") values(" + danhsachthamso + ")";

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

        public static void Update(string bang, string danhsach, string dk)
        {

            string l = "update " + bang + " set " + danhsach + " where " + dk;

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

        public static void Delete(string bang, string dk)
        {
            string l = "delete from " + bang + " where " + dk;

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
    }
}
