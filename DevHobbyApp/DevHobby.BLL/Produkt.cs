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
            this.Kategoria = "Informatyka";
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
                var sformatowanaNazwaProduktu = nazwaProduktu?.Trim();
                return sformatowanaNazwaProduktu;
            }
            set
            {
                if (value.Length < 4)
                {
                    Wiadomowsc = "Zbyt krótka nazwa produktu";
                }
                else if (value.Length > 30)
                {
                    Wiadomowsc = "Za długa nazwa, musi mieć mniej niż 30 znaków";
                } else
                {
                    nazwaProduktu = value;
                }
            }
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

        public string Wiadomowsc { get; private set; }
        public int Numer { get; set; } = 1;
        internal string Kategoria {  get;  set; }

        public string KodProduktu => Kategoria + " - " + Numer;

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

        public override string ToString()
        {
            return nazwaProduktu + "(" + this.ProduktId + ")";
        }
    }
}
