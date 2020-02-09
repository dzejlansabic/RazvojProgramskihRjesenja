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
    public partial class StudentBachelor : Student
    {
        private List<Predmet> predmeti;

        public StudentBachelor() { }
        public StudentBachelor(string pime, string pprezime, string pmaticniBroj, DateTime pdatumRodjenja, DateTime pdatumPrethodnogObrazovanja,string pusername,string ppassword)
        {
            Ime = pime;
            Prezime = pprezime;
            MaticniBroj = pmaticniBroj;
            DatumRodjenja = pdatumRodjenja;
            DatumPrethodnogObrazovanja = pdatumPrethodnogObrazovanja;
            INDEXB++;
            BrojIndeksa = INDEXB;
            DatumUpisa = DateTime.Today;
            Username = pusername;
            string pravipass = CalculateMD5Hash(ppassword);
            Password = pravipass;
            Predmeti = new List<Predmet>(); 
        }
        public override string DajMasterIndex()
        {
            return string.Format("{0}", BrojIndeksa);
        }
        public override int MasterIndeks()
        {
            return brojIndeksa;
        }
        public override void IspisiSaPredmeta(string naziv)
        {
            foreach (Predmet p in predmeti)
            {
                if(naziv==p.NazivPredmeta)
                predmeti.Remove(p);
                break;
            }
        }
        public override void UpisiNaPredmet(Predmet p)
        {
            bool ima = false;
            foreach(Predmet k in predmeti)
            {
                if (p.SifraPredmeta == k.SifraPredmeta)
                    ima = true;
            }
            if (!ima) { predmeti.Add(p); }
            else throw new NotFiniteNumberException("Student je vec upisan na dati predmet!");
            
        }
        public List<Predmet> Predmeti
        {
            get
            {
                return predmeti;
            }

            set
            {
                predmeti = value;
            }
        }

        public override List<Predmet> DajStudentskuListuPredmeta()
        {
            return Predmeti;
        }
        public override void DodajStudentuPredmet(Predmet p)
        {
            Predmeti.Add(p);
        }
        public new bool  ValidacijaMaticnog(string maticni)
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
        public new bool ValidacijaMaticnog(string maticni, DateTime datumRodj)
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
    }
}