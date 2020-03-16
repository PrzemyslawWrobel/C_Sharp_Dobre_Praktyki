using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevHobby.Common
{
    /// <summary>
    /// Zapewnia Logowanie
    /// </summary>
    public static class LogowanieService
    {
        /// <summary>
        /// Loguje akcje
        /// </summary>
        /// <param name="akcja">Akcja do zalogowania</param>
        /// <returns></returns>
        public static string Logowanie(string akcja)
        {
            var tekstDoZalogowania = "Akcja: " + akcja;
            Console.WriteLine(tekstDoZalogowania);

            return tekstDoZalogowania;
        }
    }
}
