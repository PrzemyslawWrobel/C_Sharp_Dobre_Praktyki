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

            var oczekiwana = new WynikOperacji(true, "Zamowienie z dev-hobby.pl\r\nProdukt: Informatyka - 1\r\nIlość: 15");

            //ACT wykonaj test
            var actualna = dostawca.ZlozZamowienie(produkt, 15);

            // Assert

            Assert.AreEqual(oczekiwana.Sukces, actualna.Sukces);
            Assert.AreEqual(oczekiwana.Wiadomosc, actualna.Wiadomosc);
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
        [TestMethod]
        public void ZlozZamowienie_3parametry_Test()
        {
            // Arange
            var dostawca = new Dostawca();
            var produkt = new Produkt(1, "Biurko", "Opis");

            var oczekiwana = new WynikOperacji(true, "Zamowienie z dev-hobby.pl\r\nProdukt: Informatyka - 1\r\nIlość: 15\r\nData dostawy: 05.05.2020");

            //ACT wykonaj test
            var actualna = dostawca.ZlozZamowienie(produkt, 15, new DateTimeOffset(2020,5,5,0,0,0, new TimeSpan(8,0,0)));

            // Assert

            Assert.AreEqual(oczekiwana.Sukces, actualna.Sukces);
            Assert.AreEqual(oczekiwana.Wiadomosc, actualna.Wiadomosc);
        }
        [TestMethod]
        public void ZlozZamowienie_4parametry_Test()
        {
            // Arange
            var dostawca = new Dostawca();
            var produkt = new Produkt(1, "Biurko", "Opis");

            var oczekiwana = new WynikOperacji(true, "Zamowienie z dev-hobby.pl\r\nProdukt: Informatyka - 1\r\nIlość: 15\r\nData dostawy: 05.05.2020\r\nInstrukcje: Testowe Instrukcje");

            //ACT wykonaj test
            var actualna = dostawca.ZlozZamowienie(produkt, 15, new DateTimeOffset(2020, 5, 5, 0, 0, 0, new TimeSpan(8, 0, 0)), "Testowe Instrukcje");

            // Assert

            Assert.AreEqual(oczekiwana.Sukces, actualna.Sukces);
            Assert.AreEqual(oczekiwana.Wiadomosc, actualna.Wiadomosc);
        }
    }
}
