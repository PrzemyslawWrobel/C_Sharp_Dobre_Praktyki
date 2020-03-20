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

        [TestMethod()]
        public void NazwaProduktu_ZaKrotkaTest()
        {
            // Arange

            var produkt = new Produkt();
            produkt.NazwaProduktu = "Krz";
            string oczekiwana = null;
            string oczekiwanaWiadomość = "Zbyt krótka nazwa produktu";
            //ACT wykonaj test
            var aktualna = produkt.NazwaProduktu;
            var aktualnaWiadomość = produkt.Wiadomowsc;

            // Assert
            Assert.AreEqual(oczekiwana, aktualna);
            Assert.AreEqual(oczekiwanaWiadomość, aktualnaWiadomość);
        }

        [TestMethod()]
        public void NazwaProduktu_ZaDlugaTest()
        {
            // Arange

            var produkt = new Produkt();
            produkt.NazwaProduktu= "  Krzesło Obrotowe zbyt długaa nazwa produktu  ";
            string oczekiwana = null;
            string oczekiwanaWiadomość = "Za długa nazwa, musi mieć mniej niż 30 znaków";
            //ACT wykonaj test
            var aktualna = produkt.NazwaProduktu;
            var aktualnaWiadomość = produkt.Wiadomowsc;

            // Assert
            Assert.AreEqual(oczekiwana, aktualna);
            Assert.AreEqual(oczekiwanaWiadomość, aktualnaWiadomość);
        }

        [TestMethod()]
        public void NazwaProduktu_PrawidłowaTest()
        {
            // Arange

            var produkt = new Produkt();
            produkt.NazwaProduktu = "Krzesło Obrotowe";
            string oczekiwana = "Krzesło Obrotowe";
            string oczekiwanaWiadomość =null;
            //ACT wykonaj test
            var aktualna = produkt.NazwaProduktu;
            var aktualnaWiadomość = produkt.Wiadomowsc;

            // Assert
            Assert.AreEqual(oczekiwana, aktualna);
            Assert.AreEqual(oczekiwanaWiadomość, aktualnaWiadomość);

        }
        [TestMethod()]
        public void Kategori_WarośćDomyślnaTest()
        {
            // Arange

            var produkt = new Produkt();
           // produkt.NazwaProduktu = "Krzesło Obrotowe";
            string oczekiwana = "Informatyka";
           // string oczekiwanaWiadomość = null

            //ACT wykonaj test
            var aktualna = produkt.Kategoria;
//var aktualnaWiadomość = produkt.Wiadomowsc;

            // Assert
            Assert.AreEqual(oczekiwana, aktualna);
            //Assert.AreEqual(oczekiwanaWiadomość, aktualnaWiadomość);

        }

        [TestMethod()]
        public void Kategori_NowaWartośćTest()
        {
            // Arange

            var produkt = new Produkt();
            produkt.Kategoria = "Geografia";
            string oczekiwana = "Geografia";
            // string oczekiwanaWiadomość = null

            //ACT wykonaj test
            var aktualna = produkt.Kategoria;
            //var aktualnaWiadomość = produkt.Wiadomowsc;

            // Assert
            Assert.AreEqual(oczekiwana, aktualna);
            //Assert.AreEqual(oczekiwanaWiadomość, aktualnaWiadomość);

        }
        [TestMethod()]
        public void Numer_WarośćDomyślnaTest()
        {
            // Arange

            var produkt = new Produkt();
           
            var oczekiwana = 1;
            // string oczekiwanaWiadomość = null

            //ACT wykonaj test
            var aktualna = produkt.Numer;
            //var aktualnaWiadomość = produkt.Wiadomowsc;

            // Assert
            Assert.AreEqual(oczekiwana, aktualna);
            //Assert.AreEqual(oczekiwanaWiadomość, aktualnaWiadomość);

        }

        [TestMethod()]
        public void Numer_NowaWartośćTest()
        {
            // Arange

            var produkt = new Produkt();
            produkt.Numer = 2;
            var oczekiwana = 2;
            // string oczekiwanaWiadomość = null

            //ACT wykonaj test
            var aktualna = produkt.Numer;
            //var aktualnaWiadomość = produkt.Wiadomowsc;

            // Assert
            Assert.AreEqual(oczekiwana, aktualna);
            //Assert.AreEqual(oczekiwanaWiadomość, aktualnaWiadomość);

        }
    }
}
// Arange
//ACT wykonaj test
// Assert