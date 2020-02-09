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
    public sealed class PrivremeniUposlenik: Uposlenik
    {
        DateTime pocetakVazenjaUgovora;
        DateTime krajVazenjaUgovora;

        public PrivremeniUposlenik() { }
        public PrivremeniUposlenik(string ime,string prezime,string maticni,DateTime datumRodj,DateTime datumPocetka,DateTime datumKraja,string username,string password)
        {
            Ime = ime;
            Prezime = prezime;
            MaticniBroj = maticni;
            DatumRodjenja = datumRodj;
            PocetakVazenjaUgovora = datumPocetka;
            KrajVazenjaUgovora = datumKraja;
            Sifra = SIFRA++;
            Username = username;
            string Pass = CalculateMD5Hash( password);
            Password = Pass;
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
        public DateTime PocetakVazenjaUgovora
        {
            get
            {
                return pocetakVazenjaUgovora;
            }

            set
            {
                pocetakVazenjaUgovora = value;
            }
        }

        public DateTime KrajVazenjaUgovora
        {
            get
            {
                return krajVazenjaUgovora;
            }

            set
            {
                krajVazenjaUgovora = value;
            }
        }
        public override string GeneralneInformacije()
        {
            return String.Format("Ime i prezime:{0} {1} Maticni broj: {2} Datum rođenja: {3}\nSifra: {4} Ugovor od {5} do {6}", Ime, Prezime, MaticniBroj, DatumRodjenja, Sifra, PocetakVazenjaUgovora, KrajVazenjaUgovora);
        }
        public override string ToString()
        {
            return String.Format("Ime i prezime:{0} {1} Sifra: {2} Ugovor od {5} do {6}", Ime, Prezime,Sifra,PocetakVazenjaUgovora,KrajVazenjaUgovora);
        }
    }
}
