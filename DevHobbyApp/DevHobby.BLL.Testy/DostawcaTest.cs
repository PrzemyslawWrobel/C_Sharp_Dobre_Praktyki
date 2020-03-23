using System;
using DevHobby.Common;
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
        [TestMethod]
        public void ZlozZamowienie_Test()
        {
            // Arange
            var dostawca = new Dostawca();
            var produkt = new Produkt(1, "Biurko", "Opis");

            var oczekiwana = new WynikOperacji(true, ");

            //ACT wykonaj test
            var actualna = dostawca.ZlozZamowienie(produkt, 15);

            // Assert

            Assert.AreEqual(oczekiwana, actualna);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ZlozZamowienie_NullProduktException_Test()
        {
            // Arange
            var dostawca = new Dostawca();

            //ACT wykonaj test
            var actualna = dostawca.ZlozZamowienie(null, 15);

            // Assert

           // Assert.AreEqual(oczekiwana, actualna);
         //  Oczekiwany Wyjątek
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ZlozZamowienie_Ilosc_Exception_Test()
        {
            // Arange
            var dostawca = new Dostawca();
            var produkt = new Produkt(1, "Biurko", "Opis");

            //ACT wykonaj test
            var actualna = dostawca.ZlozZamowienie(produkt, 0);

            // Assert

            // Assert.AreEqual(oczekiwana, actualna);
            //  Oczekiwany Wyjątek
        }
    }
}
