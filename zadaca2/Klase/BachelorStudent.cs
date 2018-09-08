using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Zadaca1
{
    public class BachelorStudent17562: Student17562, IToString
    {
        protected static int ind = 10000;
        
        public BachelorStudent17562(string nime, string nprezime, DateTime ndatumRodjenja, string nmaticniBroj, DateTime nzavrsenoObrazovanje, DateTime pocObrazovanja , List<Predmeti17562> pPredmeti, Image slika) :
            base (nime, nprezime, ndatumRodjenja, nmaticniBroj, nzavrsenoObrazovanje, pocObrazovanja, pPredmeti, slika)
        {
            brojIndexa = ind++;
        }
        public virtual int MjestoZ()
        {
            return 0;
        }
        public override string ToString()
        {
            return string.Format("Ime i prezime: {0} {1}, datum rođenja: {2}, matični broj: {3}, broj indexa: {4}, završio prethodno obrazovanje: {5}, upisan na fakultet: {6}\n", Ime, Prezime, DatumRodjenja.ToString("dd/MM/yyyy"), MaticniBroj, BrojIndexa, ZavrsenoObrazovanje.ToString("dd/MM/yyyy"), PocetakObrazovanja.ToString("dd/MM/yyyy"));
        }
    }
}
