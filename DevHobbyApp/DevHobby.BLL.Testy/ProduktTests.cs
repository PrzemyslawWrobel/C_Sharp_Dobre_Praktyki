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
            produkt.DostawcaProduktu.NazwaFirmy = "Dev-Hobby";


            var oczekiwana = "Witaj Biurko (1): Czerwone biurko Dostępny od: ";
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


            var oczekiwana = "Witaj Biurko (1): Czerwone biurko Dostępny od: ";
            //ACT wykonaj test
            var aktualna = produkt.PowiedzWitaj();

            // Assert
            Assert.AreEqual(oczekiwana, aktualna);
        }
        [TestMethod()]
        public void PowiedzWitajInicjalizatorObiektu_Test()
        {
            // Arange

            var produkt = new Produkt
            {

                NazwaProduktu = "Biurko",
                ProduktId = 1,
                Opis = "Czerwone biurko"
            };
            //(1, "Biurko", "Czerwone biurko");
            //produkt.NazwaProduktu = "Biurko";
            //produkt.ProduktId = 1;
            //produkt.Opis = "Czerwone biurko";


            var oczekiwana = "Witaj Biurko (1): Czerwone biurko Dostępny od: ";
            //ACT wykonaj test
            var aktualna = produkt.PowiedzWitaj();

            // Assert
            Assert.AreEqual(oczekiwana, aktualna);
        }
        [TestMethod()]
        public void Produkt_NULL()
        {
            // Arange

            Produkt produkt = null;

            string oczekiwana = null;
            //ACT wykonaj test
            var aktualna = produkt?.DostawcaProduktu?.NazwaFirmy;

            // Assert
            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod()]
        public void ConwersjaCaliNametr()
        {
            // Arange



            var oczekiwana = 194.35;
            //ACT wykonaj test
            var aktualna = 5 * Produkt.caliNametr;

            // Assert
            Assert.AreEqual(oczekiwana, aktualna);
        }


        [TestMethod()]
        public void MinimalnaCena_DomyślnaTest()
        {
            // Arange

            var produkt = new Produkt();

            var oczekiwana = 10.50m;
            //ACT wykonaj test
            var aktualna = produkt.MinimalnaCena;

            // Assert
            Assert.AreEqual(oczekiwana, aktualna);




        }

        [TestMethod()]
        public void MinimalnaCena_KonstruktorSparametryzowanyTest()
        {
            // Arange

            var produkt = new Produkt(1, "Krzesło obrotowe", "Czerwone krzesło");

            var oczekiwana = 50.66m;
            //ACT wykonaj test
            var aktualna = produkt.MinimalnaCena;

            // Assert
            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod()]
        public void NazwaProduktu_FormatTest()
        {
            // Arange

            var produkt = new Produkt();
            produkt.NazwaProduktu = " Krzesło Obrotowe  ";
            var oczekiwana = "Krzesło Obrotowe";
            //ACT wykonaj test
            var aktualna = produkt.NazwaProduktu;

            // Assert
            Assert.AreEqual(oczekiwana, aktualna);
        }
    }

}
// Arange
//ACT wykonaj test
// Assert