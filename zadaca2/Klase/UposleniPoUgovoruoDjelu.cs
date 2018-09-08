using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Zadaca1
{
    public class UposleniPoUgovoruoDjelu17562 : Uposleni17562
    {
        DateTime pocetakUgovora;
        DateTime krajUgovora;
        public UposleniPoUgovoruoDjelu17562(string nime, string nprezime, DateTime ndatumR, string mB, DateTime pocUgovora, DateTime krUgovora, Image slika_) :
            base (nime, nprezime, ndatumR, mB, slika_)
        {
            pocetakUgovora = pocUgovora;
            krajUgovora = krUgovora;
        }
        public DateTime PocetakUgovora
        {
            get { return pocetakUgovora; }
            set { pocetakUgovora = value; }
        }
        public DateTime KrajUgovora
        {
            get { return krajUgovora; }
            set { krajUgovora = value; }
        }
        public override string ToString()
        {
            return string.Format("Ime: {0} Prezime: {1} Datum rođenja: {2} Matični broj: {3} Šifra radnika: {4} Ugovor vrijedi od : {5} do {6}", Ime, Prezime, DatumRodjenja.ToString("dd/MM/yyyy."), MaticniBroj, Sifra, PocetakUgovora.ToString("dd/MM/yyyy"), KrajUgovora.ToString("dd/MM/yyyy"));
        }
    }
}
