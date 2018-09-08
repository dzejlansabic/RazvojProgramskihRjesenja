using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Security.Cryptography;

namespace Zadaca1
{
    public abstract class Uposleni17562
    {
        string ime;
        string prezime;
        string sifra;
        DateTime datumRodjenja;
        string maticniBroj;
        string korisnickoIme="";
        string lozinka="";
        Image slika;

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
        public string Sifra
        {
            get { return sifra; }
            set { sifra = value; }
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

        public Uposleni17562(string nime, string nprezime, DateTime ndatumR, string mB, Image slika_)
        {
            korisnickoIme = "";
            ime = nime;
            prezime = nprezime;
            datumRodjenja = ndatumR;
            maticniBroj = mB;
            sifra = mB[0].ToString() + mB[1].ToString()+ mB[6] + nime[0] + nprezime[0];
            slika = slika_;
        }
        
    }
}
