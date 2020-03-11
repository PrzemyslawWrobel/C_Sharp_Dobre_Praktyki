using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevHobby.BLL.Testy
{
    [TestClass]
    public class DostawcaTest
    {
        [TestMethod]
        public void WyslijEmailWitamy_PrawidlowaNazwaFirmy_Sukces()
        {
            // Arange
            var dostawca = new Dostawca();
            dostawca.NazwaFirmy = "DevHobby";
            var oczekiwana = "Wiadomość wysłana: Witaj DevHobby";

            //ACT wykonaj test
            var actualna = dostawca.wyslijEmailWitamy("Wiadomość testowa");

            // Assert

            Assert.AreEqual(oczekiwana, actualna);
        }

        [TestMethod]
        public void WyslijEmailWitamy_PustaNazwaFirmy_Sukces()
        {
            // Arange
            var dostawca = new Dostawca();
            dostawca.NazwaFirmy = "";
            var oczekiwana = "Wiadomość wysłana: Witaj";

            //ACT wykonaj test
            var actualna = dostawca.wyslijEmailWitamy("Wiadomość testowa");

            // Assert

            Assert.AreEqual(oczekiwana, actualna);
        }

        [TestMethod]
        public void WyslijEmailWitamy_NullNazwaFirmy_Sukces()
        {
            // Arange
            var dostawca = new Dostawca();
            dostawca.NazwaFirmy = null;
            var oczekiwana = "Wiadomość wysłana: Witaj";

            //ACT wykonaj test
            var actualna = dostawca.wyslijEmailWitamy("Wiadomość testowa");

            // Assert

            Assert.AreEqual(oczekiwana, actualna);
        }
    }
}
