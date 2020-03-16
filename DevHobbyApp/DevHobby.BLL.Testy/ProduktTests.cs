using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevHobby.BLL.Tests
{
    [TestClass()]
    public class ProduktTests
    {
        [TestMethod()]
        public void PowiedzWitajTest()
        {
            // Arange

            var produkt = new Produkt();
            produkt.NazwaProduktu = "Biurko";
            produkt.ProduktId = 1;
            produkt.Opis = "Czerwone biurko";
            

            var oczekiwana = "Witaj Biurko (1): Czerwone biurko";
            //ACT wykonaj test
            var aktualna = produkt.PowiedzWitaj();

            // Assert
            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod()]
        public void PowiedzWitajKonstruktorParametryzowanyTest()
        {
            // Arange

            var produkt = new Produkt(1, "Biurko", "Czerwone biurko");
            //produkt.NazwaProduktu = "Biurko";
            //produkt.ProduktId = 1;
            //produkt.Opis = "Czerwone biurko";


            var oczekiwana = "Witaj Biurko (1): Czerwone biurko";
            //ACT wykonaj test
            var aktualna = produkt.PowiedzWitaj();

            // Assert
            Assert.AreEqual(oczekiwana, aktualna);
        }
    }
}  

     // Arange
     //ACT wykonaj test
     // Assert