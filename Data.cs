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
        static readonly string s = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= Data\Data.mdb";

        public static void Open_DataAccess()
        {
            strcon.ConnectionString = s;

            strcon.Open();
        }

        public static DataTable Load(string bang, string danhsachthamso)
        {
            DataSet dsHienThi = new DataSet();

            string l = "select " + danhsachthamso + " from " + bang;

            Open_DataAccess();

            OleDbDataAdapter daShowData = new OleDbDataAdapter(l, strcon);

            daShowData.Fill(dsHienThi, bang);

            daShowData.Dispose();

            strcon.Close();

            return dsHienThi.Tables[0];
        }

        public static DataTable Load(string bang, string danhsachthamso, string dk)
        {
            DataSet dsHienThi = new DataSet();

            string l = "select " + danhsachthamso + " from " + bang + " where " + dk;

            Open_DataAccess();

            OleDbDataAdapter daShowData = new OleDbDataAdapter(l, strcon);

            daShowData.Fill(dsHienThi, bang);

            daShowData.Dispose();

            strcon.Close();

            return dsHienThi.Tables[0];
        }

        public static void Add(string bang, string danhsachcot, string danhsachthamso)
        {

            string l = "insert into " + bang + "(" + danhsachcot + ") values(" + danhsachthamso + ")";

            OleDbCommand command = strcon.CreateCommand();
            Open_DataAccess();
            command.CommandText = l;
            command.Connection = strcon;
            command.ExecuteNonQuery();
            strcon.Close();
        }

        public static void Update(string bang, string danhsach, string dk)
        {

            string l = "update " + bang + " set " + danhsach + " where " + dk;

            OleDbCommand command = strcon.CreateCommand();
            Open_DataAccess();
            command.CommandText = l;
            command.Connection = strcon;
            command.ExecuteNonQuery();
            strcon.Close();
        }

        public static void Delete(string bang, string dk)
        {
            string l = "delete from " + bang + " where " + dk;

            OleDbCommand command = strcon.CreateCommand();
            Open_DataAccess();
            command.CommandText = l;
            command.Connection = strcon;
            command.ExecuteNonQuery();
            strcon.Close();
        }
    }
}
