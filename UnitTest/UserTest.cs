using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Delmain_C969;

namespace UnitTest
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void TestUser()
        {
            string username = "user1";
            string pass = "password";
            Login login = new Login();

            login.findUser(username, pass);

            Assert.IsFalse(CurrentUser.currentUser.canDeleteData());
        }

        [TestMethod]
        public void TestAdmin()
        {
            string username = "admin";
            string pass = "adminpass";
            Login login = new Login();

            login.findUser(username, pass);

            Assert.IsTrue(CurrentUser.currentUser.canDeleteData());
        }
    }
}
