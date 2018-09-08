using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca1
{
    public class Analiza : IProsjekPlata
    {
        public double prosjekPlata(Fakultet17562 f)
        {
            double plate = 0;
            int i = 0;
            foreach (Uposleni17562 uposleni in f.Uposleni17562)
            {
                if ((uposleni is StalnoUposleni17562))
                {
                    plate += ((StalnoUposleni17562)uposleni).Plata;
                    i++;
                }
            }
            return plate / i;
        }
        public int vecaPlata(Fakultet17562 f)
        {
            int i = 0;
            double prosjek = prosjekPlata(f);
            foreach (Uposleni17562 uposleni in f.Uposleni17562)
            {
                if ((uposleni is StalnoUposleni17562))
                {
                    if (((StalnoUposleni17562)uposleni).Plata > prosjek) i++;
                }
            }
            return i;
        }
        public static int brojPredmeta(Fakultet17562 f, Uposleni17562 radi)
        {
            int brojPred = 0;
            foreach (Predmeti17562 predmet in f.Predmeti17562)
            {
                foreach (Uposleni17562 uposleni in predmet.NastAnsambl)
                {
                    if (uposleni.Sifra == radi.Sifra) brojPred++;
                }
            }
            return brojPred;
        }
        public static int straniStudenti(Fakultet17562 f)
        {
            int i = 0;
            foreach (Student17562 student in f.Studenti17562)
            {
                if (student is MasterStudent17562)
                {
                    i += ((MasterStudent17562)student).MjestoZ();
                }

            }
            return i;
        }
        public static int ukupanBrojKredita(Student17562 s)
        {
            int krediti=0;
            foreach (Predmeti17562 p in s.AktivniPredmeti)
            {
                krediti += p.BrojECTS;
            }
            return krediti;
        } 
        public static int polozilo(Fakultet17562 f, Predmeti17562 p)
        {
            int plus=0;
            foreach (Student17562 s in f.Studenti17562)
            {
                if (s.PolozeniPredmeti.Contains(p)) plus++;
            }
            return plus;
        }
        public static int slusa(Fakultet17562 f, Predmeti17562 p)
        {
            int plus = 0;
            foreach (Student17562 s in f.Studenti17562)
            {
                if (s.AktivniPredmeti.Contains(p)) plus++;
            }
            return plus;
        }
        public static int nePrati(Fakultet17562 f, Predmeti17562 p)
        {
            int plus = 0;
            foreach (Student17562 s in f.Studenti17562)
            {
                if (!s.AktivniPredmeti.Contains(p) && !s.PolozeniPredmeti.Contains(p)) plus++;
            }
            return plus;
        }
    }
}
