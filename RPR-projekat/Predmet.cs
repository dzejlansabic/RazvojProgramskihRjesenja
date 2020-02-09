using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Zadaca1
{
    [Serializable]
    public sealed class Predmet
    {
        private int sifraPredmeta;
        private string nazivPredmeta;
        private string studijPredmeta;
        private int brojPredavanja;
        private int brojVjezbi;
        private int maxStudenata;
        private int ectsBodovi;
        private string nastavniAnsamblPredmeta;
        private string opisPredmeta;

        public Predmet() { }
        public Predmet (int psifra,string pnaziv,string pstudij,int pbrojPredavanja,int pbrojVjezbi, int pmaxStudenata, int pectsBodovi,string ansambl,string opis)
        {
            SifraPredmeta = psifra;
            NazivPredmeta = pnaziv;
            StudijPredmeta = pstudij;
            BrojPredavanja = pbrojPredavanja;
            BrojVjezbi = pbrojVjezbi;
            MaxStudenata = pmaxStudenata;
            EctsBodovi = pectsBodovi;
            NastavniAnsamblPredmeta = ansambl;
            OpisPredmeta = opis;
        }

        public string StudijPredmeta
        {
            get
            {
                return studijPredmeta;
            }
            set
            {
                studijPredmeta = value;
            }
        }
        public int BrojPredavanja
        {
            get
            {
                return brojPredavanja;
            }
            set
            {
                brojPredavanja = value;
            }
        }
        public int BrojVjezbi
        {
            get
            {
                return brojVjezbi;
            }
            set
            {
                brojVjezbi = value;
            }
        }
        public int MaxStudenata
        {
            get
            {
                return maxStudenata;
            }
            set
            {
                maxStudenata = value;
            }
        }
        public int EctsBodovi
        {
            get
            {
                return ectsBodovi;
            }
            set
            {
                ectsBodovi = value;
            }
        }
        public string NastavniAnsamblPredmeta
        {
            get
            {
                return nastavniAnsamblPredmeta;
            }
            set
            {
                nastavniAnsamblPredmeta = value;
            }
        }
        public string OpisPredmeta
        {
            get
            {
                return opisPredmeta;
            }
            set
            {
                opisPredmeta = value;
            }
        }
        public int SifraPredmeta
        {
            get
            {
                return sifraPredmeta;
            }
            set
            {
                sifraPredmeta = value;
            }
        }
        public string NazivPredmeta
        {
            get
            {
                return nazivPredmeta;
            }
            set
            {
                nazivPredmeta = value;
            }
        }

        public  string generalneInformacijePredmeta()                                       
        {
            return String.Format("Naziv predmeta: {0}\n Šifra: {1}\n Studij: {2} ", NazivPredmeta, SifraPredmeta, StudijPredmeta);
        }
        public string nastavniAnsambl()
        {
            return NastavniAnsamblPredmeta;
        }
        public int ECTSuSate()
        {
            return EctsBodovi * BrojPredavanja;
        }
        public override string ToString()
        {
            return string.Format("Naziv predmeta: { 0}\nŠifra: { 1}\nStudij: { 2}\nBroj predavanja: {3}\nBroj vjezbi: {4}\nECTS: {5}\nMax broj studenata: {6}\nOpis predmeta: {7}", NazivPredmeta, SifraPredmeta, StudijPredmeta,BrojPredavanja,BrojVjezbi,EctsBodovi,MaxStudenata,OpisPredmeta);
        }
    }
}
