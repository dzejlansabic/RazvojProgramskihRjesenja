using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Xml.Serialization;
using System.IO;

namespace Zadaca1
{
    [Serializable]
    public class StalniUposlenik: Uposlenik
    {

        string pozicijaUposlenika;
        string titula;
        string strucnaSprema;
        int plata;
        bool nastavnoOsoblje = false;

        public StalniUposlenik() { }
        public StalniUposlenik (string ime,string prezime,string maticni,DateTime datumRodj,bool nastavno,string pozicija,string strSprema,string ptitula,int pplata,string username,string password)
        {
            Ime = ime;
            Prezime = prezime;
            MaticniBroj = maticni;
            DatumRodjenja = datumRodj;
            nastavnoOsoblje = nastavno;
            pozicijaUposlenika = pozicija;
            StrucnaSprema = strSprema;
            Titula = ptitula;
            Plata = pplata;
            Sifra = SIFRA++;
            Username = username;
            string pass =CalculateMD5Hash( password);
            Password = pass;
        }
        public string CalculateMD5Hash(string input)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
        public string Pozicija
        {
            get
            {
                return pozicijaUposlenika;
            }

            set
            {
                pozicijaUposlenika = value;
            }
        }

        public string Titula
        {
            get
            {
                return titula;
            }

            set
            {
                titula = value;
            }
        }

        public string StrucnaSprema
        {
            get
            {
                return strucnaSprema;
            }

            set
            {
                strucnaSprema = value;
            }
        }

        public int Plata
        {
            get
            {
                return plata;
            }

            set
            {
                plata = value;
            }
        }
        public override string GeneralneInformacije()
        {
            return string.Format("Ime: { 0}\nPrezime: { 1}\nMaticni broj: { 2}\nDatum rođenja: { 3}\nSifra: { 4}\nPozicija: {5}\nTitula: {6}\nStrucna sprema: {7}\nPlata: {8} ", Ime, Prezime, MaticniBroj, DatumRodjenja, Sifra, Pozicija, Titula, StrucnaSprema, Plata);

        }
        public override string ToString ()
        {
            return string.Format("Ime i prezime:{0} {1} Sifra: {2} Titula: {3}", Ime, Prezime, Sifra, Titula);
        }
    }
}
