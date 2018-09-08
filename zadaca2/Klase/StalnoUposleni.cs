using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Zadaca1
{
    public class StalnoUposleni17562 : Uposleni17562, IToString
    {
        string pozicija;
        string strucnaSprema;
        string titula;
        string neNastavno;
        double plata;

        public string NeNastavno
        {
            get { return neNastavno; }
            set { neNastavno = value; }
        }
        public string Pozicija
        {
            get { return pozicija;}
            set { pozicija = value;}
        }
        public string StrucnaSprema
        {
            get { return strucnaSprema;}
            set { strucnaSprema = value;}
        }
        public string Titula
        {
            get { return titula;}
            set { titula = value;}
        }

        public double Plata
        {
            get {return plata;}

            set {plata = value;}
        }

        public StalnoUposleni17562(string nime, string nprezime, DateTime dR, string mB, string poz, string ss, string tit, string neNast, Image slika) : 
        base(nime, nprezime, dR, mB, slika) {
            pozicija = poz;
            strucnaSprema = ss;
            titula = tit;
            neNastavno = neNast;
          //  int i = 2;
         //   if (NeNastavno == "nastavno") plata = ObracunPlate.ObracunNastavnog(i);
           // else if (NeNastavno=="nenastavno") plata = ObracunPlate.ObracunNenastavnog(dR.Year);
        }
        
        
        public override string ToString()
        {
            return string.Format("Ime i prezime: {0} {1} Datum rođenja: {2} Matični broj: {3} Šifra radnika: {4} Stručna sprema: {5} Pozicija: {6} Titula: {7} Plata: {8}", Ime, Prezime, DatumRodjenja.ToString("dd/MM/yyyy."), MaticniBroj, Sifra, StrucnaSprema, Pozicija, Titula, Plata);
        }
        
    }
}
