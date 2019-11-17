using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNH;
using System.Data.OleDb;
using System.Data;

namespace Test
{
    
    [TestClass]
    public class TestHoaDon
    {
        private HoaDon hd;
        OleDbConnection strcon;

        [TestInitialize]
        public void SetUp()
        {
            hd = new HoaDon("1", "1", 0);
            strcon = new OleDbConnection();
            string s = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= Data\Data.mdb";
            strcon.ConnectionString = s;
        }

        [TestMethod]
        public void TestGetMaBan()
        {
            Assert.AreEqual("1", hd.GetMaBan());
        }

        [TestMethod]
        public void TestSetMa()
        {
            DataSet dsHienThi = new DataSet();

            string l = "select * from HoaDon";

            strcon.Open();

            OleDbDataAdapter daShowData = new OleDbDataAdapter(l, strcon);

            daShowData.Fill(dsHienThi);

            daShowData.Dispose();

            strcon.Close();

            DataView dv = dsHienThi.Tables[0].DefaultView;

            dv.Sort = "MaHD";

            int expected = 1;

            foreach (DataRow dr in dv.ToTable().Rows)
            {
                if (int.Parse(dr["MaHD"].ToString()) != expected)
                    break;
                else
                    expected++;
             }

            int actual = int.Parse(HoaDon.Set_Ma());

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestChiTiet()
        {
            DataSet dsHienThi = new DataSet();

            string l = "select * from CTHD where MaHD =" + 1;

            strcon.Open();

            OleDbDataAdapter daShowData = new OleDbDataAdapter(l, strcon);

            daShowData.Fill(dsHienThi);

            daShowData.Dispose();

            strcon.Close();

            int expected = dsHienThi.Tables[0].Rows.Count;

            int actual = hd.ChiTiet().Rows.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetTT()
        {
            Assert.AreEqual(0, hd.GetTT());
        }
    }
}
