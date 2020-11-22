using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoRentalProject;

namespace Testing
{
    [TestClass]
    
    public class DBTestClass
    {
        Database Database = new Database();

        [TestMethod]
        public void FirstTest()
        {
            ConnectionState dbstat = Database.DBStatus();

            Assert.AreEqual(ConnectionState.Closed, dbstat);
        }

        [TestMethod]
        public void SecondTest()
        {
            ConnectionState dbstat = Database.DBStatus();

            Assert.AreNotEqual(ConnectionState.Open, dbstat);
        }
    }
}
    
