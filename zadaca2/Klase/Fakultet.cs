using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Zadaca1
{
    public partial class Fakultet17562 
    {
        public string ime;
        public string mjestoFakulteta;
        private string administrator="rseferagic1";
        private string lozinka=Validacija.CreateMD5("etf");
        List<Predmeti17562> predmeti17562;
        List<Uposleni17562> uposleni17562;
        List<Student17562> studenti17562;
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        public string MjestoFakulteta
        {
            get { return mjestoFakulteta; }
            set { mjestoFakulteta = value; }
        }

        public List<Student17562> Studenti17562
        {
            get
            {
                return studenti17562;
            }

            set
            {
                studenti17562 = value;
            }
        }

        public List<Uposleni17562> Uposleni17562
        {
            get
            {
                return uposleni17562;
            }

            set
            {
                uposleni17562 = value;
            }
        }

        public List<Predmeti17562> Predmeti17562
        {
            get
            {
                return predmeti17562;
            }

            set
            {
                predmeti17562 = value;
            }
        }

        public string Administrator
        {
            get
            {
                return administrator;
            }
        }

        public string Lozinka
        {
            get
            {
                return lozinka;
            }
            
        }

        public Fakultet17562()
        {
            ime = "ETF";
            mjestoFakulteta = "Sarajevo";
            predmeti17562 = new List<Predmeti17562>();
            uposleni17562 = new List<Uposleni17562>();
            studenti17562 = new List<Student17562>();
            uposleni17562.Add(new StalnoUposleni17562("Rijad", "Saric", Convert.ToDateTime("08/04/1964"), "0804964756210", "profesor", "doktorat", "DR", "nastavno", null));
            uposleni17562.Add(new UposleniPoUgovoruoDjelu17562("Sandra", "Seferagic", Convert.ToDateTime("31/03/1991"), "3103991115018", Convert.ToDateTime("10/07/2013"), Convert.ToDateTime("27/05/2016"), null));
            uposleni17562.Add(new StalnoUposleni17562("Lana", "Tomasevic", Convert.ToDateTime("27/01/1985"), "2701985754950", "sekretarica", "bachelor", "BA", "nenastavno", null));
            predmeti17562.Add(new Predmeti17562(14734, "RPR", "RI", 26, 14, 100,  Uposleni17562 , 5, "Rad na računaru"));
            predmeti17562.Add(new Predmeti17562(12939, "IM2", "A", 36, 16, 100, Uposleni17562, 5, "Inzenjerska matematika 2"));
            predmeti17562.Add(new Predmeti17562(13372, "IF1", "RI", 24, 10, 75, Uposleni17562, 4, "Inženjerska fizika 1"));
            predmeti17562.Add(new Predmeti17562(15246, "IM1", "A", 36, 16, 100, Uposleni17562, 5, "Inženjerska matematika 1"));
            predmeti17562.Add(new Predmeti17562(11023, "OS", "RI", 25, 14, 80, Uposleni17562, 4, "Operativni sistemi"));
            predmeti17562.Add(new Predmeti17562(25693, "DM", "RI", 26, 14, 110, Uposleni17562, 5, "Diskretna matematika"));
            List<Predmeti17562> p = new List<Predmeti17562>();
            List<Predmeti17562> a = new List<Predmeti17562>();
            p.Add(predmeti17562[2]);
            p.Add(predmeti17562[3]);
            p.Add(predmeti17562[4]);
            a.Add(predmeti17562[0]);
            a.Add(predmeti17562[5]);
            studenti17562.Add(new BachelorStudent17562("Zijad", "Seferagić", Convert.ToDateTime("08/01/1997"), "0801997115050", Convert.ToDateTime("21/06/2015"), Convert.ToDateTime("10/10/2015"), p, null));
            studenti17562.Add(new MasterStudent17562("Harun", "Vuković", Convert.ToDateTime("21/06/1995"), "2106995759420", Convert.ToDateTime("15/05/2014"), Convert.ToDateTime("03/10/2014"), p, "Sarajevo", null));
            studenti17562.Add(new MasterStudent17562("Haseda", "Hujić", Convert.ToDateTime("14/07/1992"), "1407992759524", Convert.ToDateTime("17/04/2010"), Convert.ToDateTime("04/10/2011"), p, "Bihac", null));
            studenti17562[2].KorisnickoIme = "hhujic1";
            studenti17562[2].Lozinka = Validacija.CreateMD5("etf");
            studenti17562[2].AktivniPredmeti.AddRange(a);
            uposleni17562[0].KorisnickoIme = "rsaric1";
            uposleni17562[0].Lozinka = Validacija.CreateMD5("etf");
        } 

    }
}
