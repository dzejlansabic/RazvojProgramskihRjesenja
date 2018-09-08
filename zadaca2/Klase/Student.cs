using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Security.Cryptography;

namespace Zadaca1
{
    public abstract class Student17562
    {
        string ime;
        string prezime;
        DateTime datumRodjenja;
        string maticniBroj;
        protected int brojIndexa;
        List<Predmeti17562> polozeniPredmeti;
        DateTime pocetakObrazovanja;
        DateTime zavrsenoObrazovanje;
        string korisnickoIme;
        string lozinka;
        List<Predmeti17562> aktivniPredmeti;
        Image slika;
        
        public int BrojIndexa
        {
            get { return brojIndexa; }
            set { brojIndexa = value; }
        }
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }
        public DateTime DatumRodjenja
        {
            get { return datumRodjenja; }
            set { datumRodjenja = value; }
        }
        public string MaticniBroj
        {
            get { return maticniBroj; }
            set { maticniBroj = value; }
        }
        public List<Predmeti17562> PolozeniPredmeti
        {
            get { return polozeniPredmeti; }
            set { polozeniPredmeti = value; }
        }
        public DateTime PocetakObrazovanja
        {
            get { return pocetakObrazovanja; }
            set { pocetakObrazovanja = value; }
        }
        public DateTime ZavrsenoObrazovanje
        {
            get { return zavrsenoObrazovanje; }
            set { zavrsenoObrazovanje = value; }
        }

        public string KorisnickoIme
        {
            get
            {
                return korisnickoIme;
            }

            set
            {
                korisnickoIme = value;
            }
        }

        public string Lozinka
        {
            get
            {
                return lozinka;
            }

            set
            {
                lozinka = value;
            }
        }

        public Image Slika
        {
            get
            {
                return slika;
            }

            set
            {
                slika = value;
            }
        }

        public List<Predmeti17562> AktivniPredmeti
        {
            get
            {
                return aktivniPredmeti;
            }

            set
            {
                aktivniPredmeti = value;
            }
        }

        public Student17562(string nime, string nprezime, DateTime ndatumRodjenja, string nmaticniBroj, DateTime nzavrsenoObrazovanje, DateTime pocObrazovanja, List<Predmeti17562> pPredmeti, Image slika_)
        {
                ime = nime;
                prezime = nprezime;
                datumRodjenja = ndatumRodjenja;
                maticniBroj = nmaticniBroj;
                pocetakObrazovanja = pocObrazovanja;
                zavrsenoObrazovanje = nzavrsenoObrazovanje;
                polozeniPredmeti = pPredmeti;
                aktivniPredmeti = new List<Predmeti17562>();
                slika = slika_;
                korisnickoIme = "";
        }
        
        public override string ToString()
        {
            return string.Format("Ime i prezime: {0} {1}, datum rođenja: {2}, matični broj: {3}, završio prethodno obrazovanje: {4}, upisan na fakultet: {5}\n", ime, prezime, datumRodjenja.ToString("dd/MM/yyyy"), maticniBroj, zavrsenoObrazovanje.ToString("dd/MM/yyyy"), pocetakObrazovanja.ToString("dd/MM/yyyy"));
        }
    }
}
