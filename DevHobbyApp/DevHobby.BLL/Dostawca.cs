using DevHobby.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevHobby.BLL
{
    public class Dostawca
    {
        public int DostawcaId { get; set; }
        public string NazwaFirmy { get; set; }
        public string Email { get; set; }

        /// <summary>
        /// Wysyła wiadomość email, aby powitać nowego dostawcę
        /// </summary>
        /// <param name="wiadomosc"></param>
        /// <returns></returns>
        public string wyslijEmailWitamy(string wiadomosc)
        {
            var emailService = new EmailService();
            var temat = ("Witaj " + this.NazwaFirmy).Trim();
            var potwierdzenie = emailService.WyslijWiadomosc(temat, wiadomosc, this.Email);

            return potwierdzenie;
        }
        /// <summary>
        /// Metoda wysyła zamowienie do dostawcy
        /// </summary>
        /// <param name="produkt">Produkt do zamowienia</param>
        /// <param name="ilosc">Ilość produktu do zamowienia</param>
        /// <returns></returns>
        public WynikOperacji ZlozZamowienie(Produkt produkt, int ilosc)
        {
            // wywołujemy metodę z największa iloscia parametrów i te których nie potrzebujemy dajemy null
            return ZlozZamowienie(produkt, ilosc, null, null);


            //if (produkt == null)
            //    throw new ArgumentNullException(nameof(produkt));
            //if (ilosc <= 0)
            //    throw new ArgumentOutOfRangeException(nameof(ilosc));

            //var sukces = false;
            //var tekstZamowienia = "Zamowienie z dev-hobby.pl" + Environment.NewLine +
            //    "Produkt: " + produkt.KodProduktu + Environment.NewLine +
            //    "Ilość: " + ilosc;
            //var emailService = new EmailService();
            //var potwierdzenie  = emailService.WyslijWiadomosc("Nowe Zamowienie", tekstZamowienia, this.Email);

            //if (potwierdzenie.StartsWith("Wiadomość wysłana: "))
            //    sukces = true;
            //var wynikiOperacji = new WynikOperacji(sukces, tekstZamowienia);
            //return wynikiOperacji;
        }
        /// <summary>
        /// Metoda wysyła zamowienie do dostawcy
        /// </summary>
        /// <param name="produkt">Produkt do zamowienia</param>
        /// <param name="ilosc">Ilość produktu do zamowienia</param>
        /// <param name="data">Data dostawy zamówienia</param>
        /// <returns></returns>
        public WynikOperacji ZlozZamowienie(Produkt produkt, int ilosc, DateTimeOffset? data)
        {
            //podobnie jak wyżej

            return ZlozZamowienie(produkt, ilosc, data, null);
            
            //if (produkt == null)
            //    throw new ArgumentNullException(nameof(produkt));
            //if (ilosc <= 0)
            //    throw new ArgumentOutOfRangeException(nameof(ilosc));
            //if (data <= DateTimeOffset.Now)
            //    throw new ArgumentOutOfRangeException(nameof(data));

            //var sukces = false;
            //var tekstZamowienia = "Zamowienie z dev-hobby.pl" + Environment.NewLine +
            //    "Produkt: " + produkt.KodProduktu + Environment.NewLine +
            //    "Ilość: " + ilosc;

            //if (data.HasValue)
            //{
            //    tekstZamowienia += Environment.NewLine + "Data dostawy: " + data.Value.ToString("d");
            //}

            //var emailService = new EmailService();
            //var potwierdzenie = emailService.WyslijWiadomosc("Nowe Zamowienie", tekstZamowienia, this.Email);

            //if (potwierdzenie.StartsWith("Wiadomość wysłana: "))
            //    sukces = true;
            //var wynikiOperacji = new WynikOperacji(sukces, tekstZamowienia);
            //return wynikiOperacji;
        }

        /// <summary>
        /// Metoda wysyła zamowienie do dostawcy
        /// </summary>
        /// <param name="produkt">Produkt do zamowienia</param>
        /// <param name="ilosc">Ilość produktu do zamowienia</param>
        /// <param name="data">Data dostawy zamówienia</param>
        /// <param name="instrukcje">Instrukcje dostawy</param>
        /// <returns></returns>
        public WynikOperacji ZlozZamowienie(Produkt produkt, int ilosc, DateTimeOffset? data, string instrukcje)
        {
            if (produkt == null)
                throw new ArgumentNullException(nameof(produkt));
            if (ilosc <= 0)
                throw new ArgumentOutOfRangeException(nameof(ilosc));
            if (data <= DateTimeOffset.Now)
                throw new ArgumentOutOfRangeException(nameof(data));

            var sukces = false;
            var tekstZamowienia = "Zamowienie z dev-hobby.pl" + Environment.NewLine +
                "Produkt: " + produkt.KodProduktu + Environment.NewLine +
                "Ilość: " + ilosc;

            if (data.HasValue)
            {
                tekstZamowienia += Environment.NewLine + "Data dostawy: " + data.Value.ToString("d");
            }

            if (!string.IsNullOrWhiteSpace(instrukcje))
            {
                tekstZamowienia += Environment.NewLine + "Instrukcje: " + instrukcje;
            }

            var emailService = new EmailService();
            var potwierdzenie = emailService.WyslijWiadomosc("Nowe Zamowienie", tekstZamowienia, this.Email);

            if (potwierdzenie.StartsWith("Wiadomość wysłana: "))
                sukces = true;
            var wynikiOperacji = new WynikOperacji(sukces, tekstZamowienia);
            return wynikiOperacji;
        }
    }
}
