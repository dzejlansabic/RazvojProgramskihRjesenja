using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca1
{
    public partial class Pretraga
    {
        public static List<Student17562> pronadjiStudente(Fakultet17562 f, string izbor)
        {
            if (f.Studenti17562.Exists(student17562 => ((student17562.Ime.Contains(izbor) || student17562.Prezime.Contains(izbor) || student17562.PolozeniPredmeti.Contains(f.Predmeti17562.Find(predmet => predmet.NazivPredmeta.Contains(izbor)))))))
            {
                List<Student17562> studenti = new List<Student17562>();
                studenti.Add(f.Studenti17562.Find(student17562 => ((student17562.Ime.Contains(izbor) || student17562.Prezime.Contains(izbor) || student17562.PolozeniPredmeti.Contains(f.Predmeti17562.Find(predmet => predmet.NazivPredmeta.Contains(izbor)))))));
                return studenti;
            }
            throw new Exception("Ne postoje studenti koji odgovaraju Vašem upitu.");
        }
        public static List<Uposleni17562> nadjiUposlene(Fakultet17562 f, string izbor)
        {
            if (f.Uposleni17562.Exists(uposleni17562 => (uposleni17562.Ime.Contains(izbor) || uposleni17562.Prezime.Contains(izbor))))
            {
                List<Uposleni17562> uposleni = new List<Uposleni17562>();
                uposleni.Add(f.Uposleni17562.Find(uposleni17562 => (uposleni17562.Ime.Contains(izbor) || uposleni17562.Prezime.Contains(izbor))));
                return uposleni;
            }
            throw new Exception("Ne postoje uposleni koji odgovaraju Vašem upitu.");
           
           
        }
        public static List<Predmeti17562> nadjiPredmete(Fakultet17562 f, string izbor)
        {
            if (f.Predmeti17562.Exists(p => (p.NazivPredmeta.Contains(izbor) || p.Sifra.ToString().Contains(izbor) || p.NastAnsambl.Contains(f.Uposleni17562.Find(uposleni => uposleni.Ime.Contains(izbor) || uposleni.Prezime.Contains(izbor))))))
            {
                List<Predmeti17562> predmeti = new List<Predmeti17562>();
                predmeti.Add(f.Predmeti17562.Find(p => (p.NazivPredmeta.Contains(izbor) || p.Sifra.ToString().Contains(izbor) || p.NastAnsambl.Contains(f.Uposleni17562.Find(uposleni => uposleni.Ime.Contains(izbor) || uposleni.Prezime.Contains(izbor))))));
                return predmeti;
            }
            throw new Exception("Ne postoje predmeti koji odgovaraju Vašem upitu.");
        }
    }
}
