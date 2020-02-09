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
    public abstract class Student
    {
        
        string username;
        string password;
        string ime;
        string prezime;
        string maticniBroj;
        DateTime datumRodjenja;
        DateTime datumPrethodnogObrazovanja;
        DateTime datumUpisa;
        public int brojIndeksa;
        public static int INDEXB = 11000;
        public static int INDEXM = 111;


        public Student() { }
        public abstract void IspisiSaPredmeta(string p);
        public abstract void UpisiNaPredmet(Predmet p);
        public abstract List<Predmet> DajStudentskuListuPredmeta();
        public virtual void DodajStudentuPredmet(Predmet p){}
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        public abstract int MasterIndeks();
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }
        public string MaticniBroj
        {
            get { return maticniBroj; }
            set { maticniBroj = value; }
        }
        public DateTime DatumRodjenja
        {
            get { return datumRodjenja; }
            set { datumRodjenja = value; }
        }
        public abstract string DajMasterIndex();
        public DateTime DatumUpisa
        {
            get { return datumUpisa; }
            set { datumUpisa = value; }
        }

        public DateTime DatumPrethodnogObrazovanja
        {
            get { return datumPrethodnogObrazovanja; }
            set { datumPrethodnogObrazovanja = value; }
        }
        public int BrojIndeksa
        {
            get { return brojIndeksa; }
            set { brojIndeksa = value; }
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

        public bool ValidacijaMaticnog(string maticni)
        {
            if (maticni.Length != 13) return false;
            string dan = "" + maticni[0] + "" + maticni[1];
            string mjesec = "" + maticni[2] + "" + maticni[3];
            string godina = "1" + maticni[4] + "" + maticni[5] + "" + maticni[6];
            string datum = dan + mjesec + godina;
            DateTime datumpravi = Convert.ToDateTime(datum);
            if (datumpravi == DatumRodjenja) return true;
            return false;
        }
        public bool ValidacijaMaticnog(string maticni, DateTime datumRodj)
        {
            if (maticni.Length != 13) return false;
            string dan = "" + maticni[0] + "" + maticni[1];
            string mjesec = "" + maticni[2] + "" + maticni[3];
            string godina = "1" + maticni[4] + "" + maticni[5] + "" + maticni[6];
            string datum = dan + mjesec + godina;
            DateTime datumpravi = Convert.ToDateTime(datum);
            if (datumpravi == datumRodj) return true;
            return false;
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

        public virtual string GeneralneInformacije()
        {
            return string.Format("Ime i prezime studenta: { 0} { 1} " + Environment.NewLine + "Maticni broj: {2} " + Environment.NewLine + "Datum rodjenja: {3}" + Environment.NewLine, Ime, Prezime, MaticniBroj, DatumRodjenja);

        }
        public override string ToString()
        {
            return string.Format("Ime i prezime studenta: {0} {1}  Index: {2}", Ime, Prezime, BrojIndeksa);
        }
    }
}
