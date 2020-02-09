using System;
using System.Xml.Serialization;
using System.IO;

namespace Zadaca1
{
    [Serializable]
    public abstract class Uposlenik
    {
        string username;
        string password;
        string ime;
        string prezime;
        string maticniBroj;
        DateTime datumRodjenja;
        public static int SIFRA = 100;
        int sifraUposlenika;

        public Uposlenik() { }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
         
        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
            }
        }

        public string Prezime
        {
            get
            {
                return prezime;
            }

            set
            {
                prezime = value;
            }
        }

        public string MaticniBroj
        {
            get
            {
                return maticniBroj;
            }

            set
            {
                maticniBroj = value;
            }
        }

        public DateTime DatumRodjenja
        {
            get
            {
                return datumRodjenja;
            }

            set
            {
                datumRodjenja = value;
            }
        }

        public int Sifra
        {
            get
            {
                return sifraUposlenika;
            }

            set
            {
                sifraUposlenika = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public virtual string GeneralneInformacije ()
        {
            return String.Format("Ime: {0}\nPrezime: {1}\nMaticni broj: {2}\nDatum rođenja: {3}\nSifra: {4}", Ime, Prezime, MaticniBroj, DatumRodjenja, Sifra);
        }
        public override string ToString()
        {
            return String.Format("Ime i prezime:{0} {1}    Sifra: {2}", Ime, Prezime, Sifra);
        }
    }

}