using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLNH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class TestKhachHang
    {
        public TestContext TestContext { get; set; }
        private KhachHang kh;

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\KhachHang.csv", "KhachHang#csv", DataAccessMethod.Sequential)]

        [TestMethod]
        public void TestKH()
        {
            string ten = TestContext.DataRow[0].ToString();
            string SDT = "0582301023";
            int maxSDT = int.Parse(TestContext.DataRow[1].ToString());
            string soNg = TestContext.DataRow[2].ToString();

            bool expected = bool.Parse(TestContext.DataRow[3].ToString());
            kh = new KhachHang(ten, SDT, soNg, DateTime.Now);
            bool actual = kh.CheckInput(maxSDT);
            Assert.AreEqual(expected, actual);
        }
    }
}
