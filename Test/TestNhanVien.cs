using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLNH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class TestNhanVien
    {

        [TestInitialize]
        public void SetUp()
        {
            new NhanVien("1");
        }

        [TestMethod]
        public void TestGetMa()
        {
            Assert.AreEqual("1", NhanVien.GetMaNV());
        }

        public void TestGetTen()
        {
            Assert.AreEqual("Bắc", NhanVien.GetTen());
        }

        public void TestGetCV()
        {
            Assert.AreEqual("Cửa hàng trưởng", NhanVien.GetCV());
        }

        public void TestLogin()
        {
            Assert.IsTrue(NhanVien.CheckLogin("bac1", "123"));
            Assert.IsFalse(NhanVien.CheckLogin("", "123"), "Vui lòng nhập tên tài khoản!");
            Assert.IsFalse(NhanVien.CheckLogin("bac1", ""), "Vui lòng nhập mật khẩu!");
            Assert.IsFalse(NhanVien.CheckLogin("bac", "123"), "Tài khoản không tồn tại! Vui lòng nhập lại.");
            Assert.IsFalse(NhanVien.CheckLogin("bac1", "1234"), "Mật khẩu không tồn tại vui lòng nhập lại!");

        }
    }
}
