using DevHobby.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevHobby.BLL
{

    /// <summary>
    /// Zarządza produktami
    /// </summary>
    public class Produkt
    {

        //Stałę deklaruje się nad konstruktorami

        public const double caliNametr = 38.87;
        public readonly decimal MinimalnaCena;
        // konstruktor domyślny
        public Produkt()
        {
            Console.WriteLine("Produkt utworzony");
            //this.DostawcaProduktu = new Dostawca();
            this.MinimalnaCena = 10.50m;
        }

        public Produkt(int produktId, string nazwaProduktu, string opis) : this()
        {
            this.ProduktId = produktId;
            this.NazwaProduktu = nazwaProduktu;
            this.Opis = opis;
            if (nazwaProduktu.StartsWith("Krzesło"))
            {
                this.MinimalnaCena = 50.66m;
            }

            Console.WriteLine("Produkt ma nazwę: " + nazwaProduktu);
        }


        #region właściwości klasy
        private int produktId;
        public int ProduktId
        {
            get { return produktId; }
            set { produktId = value; }
        }
        private string nazwaProduktu;
        public string NazwaProduktu
        {
            get
            {
                var sformatowanaNazwaProduktu = nazwaProduktu.Trim();
                return sformatowanaNazwaProduktu;
            }
            set { nazwaProduktu = value; }
        }
        private string opis;

        public string Opis
        {
            get { return opis; }
            set { opis = value; }
        }

        private Dostawca dostawcaProduktu;

        public Dostawca DostawcaProduktu
        {
            get
            {
                if (dostawcaProduktu == null)
                {
                    dostawcaProduktu = new Dostawca();
                }
                return dostawcaProduktu;
            }
            set { dostawcaProduktu = value; }
        }

        private DateTime? dataDostepnosci;

        public DateTime? DataDostepnosci
        {
            get { return dataDostepnosci; }
            set { dataDostepnosci = value; }
        }


        #endregion

        public string PowiedzWitaj()

        {
            //var dostawca = new Dostawca();
            //dostawca.wyslijEmailWitamy("wiadomość z produktu");

            var emailServices = new EmailService();
            var potwierdzenie = emailServices.WyslijWiadomosc("Nowy Produkt", this.nazwaProduktu, "marcin@dev-DevHobby.pl");

            var wynik = LogowanieService.Logowanie("Powiedziano Witaj");

            return "Witaj " + NazwaProduktu + " (" + ProduktId + "): " + Opis + " Dostępny od: " + dataDostepnosci?.ToShortDateString();
        }
    }
}
