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
        // konstruktor domyślny
        public Produkt()
        {
            Console.WriteLine("Produkt utworzony");
        }

        public Produkt(int produktId, string nazwaProduktu, string opis) : this()
        {
            this.ProduktId = produktId;
            this.NazwaProduktu = nazwaProduktu;
            this.Opis = opis;

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
            get { return nazwaProduktu; }
            set { nazwaProduktu = value; }
        }
        private string opis;

        public string Opis
        {
            get { return opis; }
            set { opis = value; }
        }
        #endregion

        public string PowiedzWitaj()

        {
            var dostawca = new Dostawca();
            dostawca.wyslijEmailWitamy("wiadomość z produktu");

            var emailServices = new EmailService();
            var potwierdzenie = emailServices.WyslijWiadomosc("Nowy Produkt", this.nazwaProduktu, "marcin@dev-DevHobby.pl");

            var wynik = LogowanieService.Logowanie("Powiedziano Witaj");

            return "Witaj " + NazwaProduktu + " (" + ProduktId + "): " + Opis;
        }
    }
}
