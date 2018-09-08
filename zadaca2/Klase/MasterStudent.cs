using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Zadaca1
{
    public class MasterStudent17562: BachelorStudent17562, IToString
    {
        static int novi = 100;
        string noviIndex;
        string mjesto;
        public string NoviIndex
        {
            get { return noviIndex; }
            set { noviIndex = value; }
        }
        public string Mjesto
        {
            get { return mjesto; }
            set { mjesto = value; }
        }
        public MasterStudent17562(string nime, string nprezime, DateTime ndatumRodjenja, string nmaticniBroj, DateTime nzavrsenoObrazovanje, DateTime pocObrazovanja, List<Predmeti17562> pPredmeti, string mjeesto, Image slika) :
            base (nime, nprezime, ndatumRodjenja, nmaticniBroj,nzavrsenoObrazovanje ,pocObrazovanja , pPredmeti, slika)
        {
            mjesto = mjeesto;
            if (mjeesto == "Sarajevo")
            {
                noviIndex = novi + "/" + brojIndexa;
            }
            else
            {
                noviIndex = novi + "/" + ind;
                ind++;
            }
            novi++;
        }
        public override int MjestoZ()
        {
            if (Mjesto != "Sarajevo") {
                return 1;
            }
            return 0;
        }
        public override string ToString()
        {
            return string.Format("Ime i prezime: {0} {1}, datum rođenja: {2}, matični broj: {3}, broj indexa: {4}, završio prethodno obrazovanje: {5}, upisan na fakultet: {6}\n", Ime, Prezime, DatumRodjenja.ToString("dd/MM/yyyy"), MaticniBroj, NoviIndex, ZavrsenoObrazovanje.ToString("dd/MM/yyyy"), PocetakObrazovanja.ToString("dd/MM/yyyy"));
        }
    }
}
