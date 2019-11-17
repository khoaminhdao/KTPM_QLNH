using System;
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
            Assert.IsFalse(Check.Alpha(""), "Vui lòng nhập!");
            Assert.IsFalse(Check.Alpha("QL123"), "Vui lòng nhập chính xác");
            Assert.IsFalse(Check.Alpha(" QLNH"), "Kí tự đầu tiên phải là chữ!");
        }

        [TestMethod]
        public void TestSDT()
        {
            Assert.IsTrue(Check.SDT("0582301023", 10));
            Assert.IsTrue(Check.SDT("02835173511", 11));

            Assert.IsFalse(Check.SDT("", 10), "Vui lòng nhập số điện thoại!");
            Assert.IsFalse(Check.SDT("abcdefghij", 10), "Vui lòng nhập chính xác số điện thoại");
            Assert.IsFalse(Check.SDT("", 11), "Vui lòng nhập số điện thoại!");
            Assert.IsFalse(Check.SDT("abcdefghijk", 11), "Vui lòng nhập chính xác số điện thoại");
        }

        [TestMethod]
        public void TestGio()
        {
            //DateTime(year, month, day, hour, minute, second)
            Assert.AreEqual(Check.GioHopLe(new DateTime(2019, 11, 13, 15, 30, 00), new DateTime(2019, 11, 13, 19, 30, 00)), 0);
            Assert.AreEqual(Check.GioHopLe(new DateTime(2019, 11, 13, 15, 30, 00), new DateTime(2019, 11, 13, 16, 30, 00)), -1);
            Assert.AreEqual(Check.GioHopLe(new DateTime(2019, 11, 13, 16, 30, 00), new DateTime(2019, 11, 13, 15, 30, 00)), 1);
            Assert.AreEqual(Check.GioHopLe(new DateTime(2019, 11, 13, 16, 30, 00), new DateTime(2019, 11, 13, 16, 30, 00)), 1);
        }
    }
}
