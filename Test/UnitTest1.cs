﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLNH;

namespace Test
{

    [TestClass]
    public class TestCheck
    {
        
        [TestMethod]
        public void TestAlpha()
        {
            Assert.IsTrue(Check.Alpha("Quan Ly Nha Hang"));
            Assert.IsFalse(Check.Alpha(""));
            Assert.IsFalse(Check.Alpha("QL123"));
        }

       [TestMethod]
       public void TestNum()
        {
            Assert.IsTrue(Check.Num("00"));
            Assert.IsFalse(Check.Num(""));
            Assert.IsFalse(Check.Num("QL123"));
        }

        [TestMethod]
        public void TestSDT()
        {
            Assert.IsTrue(Check.SDT("0582301023", 10));
            Assert.IsFalse(Check.SDT("", 10));
            Assert.IsFalse(Check.SDT("abcdefghij", 10));
            Assert.IsTrue(Check.SDT("02835173511", 11));
            Assert.IsFalse(Check.SDT("", 11));
            Assert.IsFalse(Check.SDT("abcdefghijk", 11));
        }

        [TestMethod]
        public void TestGio()
        {
            //DateTime(year, month, day, hour, minute, second)
            Assert.IsTrue(Check.GioHopLe(new DateTime(2019, 11, 13, 15, 30, 00), new DateTime(2019, 11, 13, 19, 30, 00)));
            Assert.IsFalse(Check.GioHopLe(new DateTime(2019, 11, 13, 15, 30, 00), new DateTime(2019, 11, 13, 16, 30, 00)));
        }


    }

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
