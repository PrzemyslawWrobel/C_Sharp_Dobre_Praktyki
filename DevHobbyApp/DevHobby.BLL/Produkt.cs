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
            ProduktId = produktId;
            NazwaProduktu = nazwaProduktu;
            Opis = opis;
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
            return "Witaj " + NazwaProduktu + " (" + ProduktId + "): " + Opis;
        }
    }
}
