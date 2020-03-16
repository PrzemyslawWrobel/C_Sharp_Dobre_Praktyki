using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevHobby.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevHobby.Common.Tests
{
    [TestClass()]
    public class LogowanieServiceTests
    {
        [TestMethod()]
        public void LogowanieTest()
        {
            // Arange
            //var logowanieservices = new LogowanieService();
            var oczekiwana  = "Akcja: Test Akcja";
            //ACT wykonaj test
            var aktualna = LogowanieService.Logowanie("Test Akcja");

            // Assert
            Assert.AreEqual(oczekiwana, aktualna);
        }
    }
}