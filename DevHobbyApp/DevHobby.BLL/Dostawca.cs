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
            var temat = "Witaj " + this.NazwaFirmy;
            var potwierdzenie = emailService.WyslijWiadomosc(temat, wiadomosc, this.Email);

            return potwierdzenie;
        }

    }
}
