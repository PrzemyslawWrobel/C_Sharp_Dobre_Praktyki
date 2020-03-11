using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevHobby.Common
{
    public class EmailService
    {
        /// <summary>
        /// Wysyła wiadomość email
        /// </summary>
        /// <param name="temat"></param>
        /// <param name="wiadomosc"> tekst wiadomośći do klienta</param>
        /// <param name="odbiorca"> adres email odbiorcy wiadomości</param>
        /// <returns></returns>
        public string WyslijWiadomosc(string temat, string wiadomosc, string odbiorca)
        {
            // kod, aby wysłać wiadomość email 

            var potwierdzenie = "Wiadomość wysłana: " + temat;
            var logowanieService = new LogowanieService();
            logowanieService.Logowanie(potwierdzenie);

            return potwierdzenie;
        }
    }
}
