using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNH;


namespace Test
{
    [TestClass]
    public class TestBan
    {
        OleDbConnection strcon;

        [TestInitialize]
        public void SetUp()
        {
            strcon = new OleDbConnection();
            string s = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= Data\Data.mdb";
            strcon.ConnectionString = s;
        }

        [TestMethod]
        public void TestDSTrong() 
        {
            DataSet dsHienThi = new DataSet();

            string l = "select * from Ban where TinhTrang = 'Trống'";

            strcon.Open();
            
            OleDbDataAdapter daShowData = new OleDbDataAdapter(l, strcon);

            daShowData.Fill(dsHienThi);

            daShowData.Dispose();

            strcon.Close();

            int expected = dsHienThi.Tables[0].Rows.Count;

            int actual = Ban.DSTrong().Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCtdb()
        {
            string maban = "1";
            DataSet dsHienThi = new DataSet();

            string l = "select * from DatBan where MaBan = " + maban;

            strcon.Open();

            OleDbDataAdapter daShowData = new OleDbDataAdapter(l, strcon);

            daShowData.Fill(dsHienThi);

            daShowData.Dispose();

            strcon.Close();

            int expected = dsHienThi.Tables[0].Rows.Count;

            int actual = Ban.Ctdb(maban).Rows.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCheckHopLe()
        {
            string maban = "1";
            DateTime thoigian = DateTime.Now;

            DataSet dsHienThi = new DataSet();

            string l = "select * from DatBan where MaBan = " + maban;

            strcon.Open();

            OleDbDataAdapter daShowData = new OleDbDataAdapter(l, strcon);

            daShowData.Fill(dsHienThi);

            daShowData.Dispose();

            strcon.Close();

            bool expected = true;

            foreach (DataRow ds in dsHienThi.Tables[0].Rows)
                if (Check.GioHopLe(DateTime.Parse(ds["ThoiGian"].ToString()), thoigian) != 0)
                    expected = false;
                   
            bool actual = Ban.CheckHopLe(maban, thoigian);

            Assert.AreEqual(expected, actual);
        }
    }
}
