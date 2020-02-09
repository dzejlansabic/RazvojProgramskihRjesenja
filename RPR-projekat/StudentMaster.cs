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
    public class StudentMaster : Student
    {
        private List<Predmet> predmeti;
        int brojMasterIndeksa;
        DateTime datumPrethodnogStudija;
        string mjestoPrethodnogStudija;

        public StudentMaster() { }
        public StudentMaster(string pime, string pprezime, string pmaticniBroj, DateTime pdatumRodjenja, DateTime pdatumPrethodnogObrazovanja,  DateTime pdatumPrethodnogStudija, string pmjestoPrethodnogStudija, string pusername, string ppassword)
        {
            Ime = pime;
            Prezime = pprezime;
            MaticniBroj = pmaticniBroj;
            DatumRodjenja = pdatumRodjenja;
            DatumPrethodnogObrazovanja = pdatumPrethodnogObrazovanja;
            INDEXB++;
            BrojIndeksa = INDEXB;
            INDEXM++;
            BrojMasterIndeksa = INDEXM;
            DatumPrethodnogStudija = pdatumPrethodnogStudija;
            MjestoPrethodnogStudija = pmjestoPrethodnogStudija;
            DatumUpisa = DateTime.Today;
            Predmeti = new List<Predmet>();
            Username = pusername;
            string pravipass = CalculateMD5Hash(ppassword);
            Password = pravipass;
        }
        public override List<Predmet> DajStudentskuListuPredmeta()
        {
            return Predmeti;
        }
        public override void IspisiSaPredmeta(string naziv)
        {
            foreach (Predmet p in predmeti)
            {
                if (naziv == p.NazivPredmeta)
                    predmeti.Remove(p);
            }
        }
        public override void UpisiNaPredmet(Predmet p)
        {
            predmeti.Add(p);
        }
        public override void DodajStudentuPredmet(Predmet p)
        {
            Predmeti.Add(p);
        }
        public DateTime DatumPrethodnogStudija
        {
            get { return datumPrethodnogStudija; }
            set { datumPrethodnogStudija = value; }
        }
        public string MjestoPrethodnogStudija
        {
            get { return mjestoPrethodnogStudija; }
            set { mjestoPrethodnogStudija = value; }
        }
        public override int MasterIndeks()
        {
            return brojMasterIndeksa;
        }
        public int BrojMasterIndeksa
        {
            get
            {
                return brojMasterIndeksa;
            }

            set
            {
                brojMasterIndeksa = value;
            }
        }
        public override string DajMasterIndex()
        {
           return string.Format("{0}/{1}",brojIndeksa,BrojMasterIndeksa);
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

        public override string ToString()
        {

            return string.Format("MASTER STUDENT\nIme i prezime studenta: {0} {1} " + Environment.NewLine + "Broj indeksa:           {5}/{9} " + Environment.NewLine + "Datum rodjenja:         {2} " + Environment.NewLine + "Maticni broj:           {3} " + Environment.NewLine + "Datum zavrsenog prethodnog obrazovanja: {4} " + Environment.NewLine + "Datum zavrsenog prethodnog studija:     {6} " + Environment.NewLine + "Mjesto zavrsenog prethodnog studija:    {7} " + Environment.NewLine + "Datum upisa:    {8} " + Environment.NewLine, Ime, Prezime, DatumRodjenja, MaticniBroj, DatumPrethodnogObrazovanja, BrojIndeksa, DatumPrethodnogStudija, MjestoPrethodnogStudija,DatumUpisa,BrojMasterIndeksa);
        }
    }
}
