using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca1
{
    public partial class Pretraga
    {
        public static Student17562 pronadjiStudenta(Fakultet17562 f, string izbor)
        {
            if (Char.IsDigit(izbor[0]))
            {
                if (f.Studenti17562.Exists(student17562 => (student17562.BrojIndexa.ToString() == izbor)))
                {
                    return f.Studenti17562.Find(student17562 => (student17562.BrojIndexa.ToString() == izbor));
                }
            }
            else if (Char.IsLetter(izbor[0]))
            {
                if(f.Studenti17562.Exists(student17562 => (student17562.Ime == izbor)))
                {
                    return f.Studenti17562.Find(student17562 => (student17562.Ime == izbor));
                }
            }
            throw new Exception("Student ne postoji.");
        }
        public static Uposleni17562 nadjiUposlenog(Fakultet17562 f, string izbor)
        {
            if (Char.IsLetter(izbor[0]))
            {
                if (f.Uposleni17562.Exists(uposlenik17562 => (uposlenik17562.Ime == izbor))) 
                    return f.Uposleni17562.Find(uposlenik17562 => (uposlenik17562.Ime == izbor));
            }
            else if (Char.IsDigit(izbor[0]))
            {
                if (f.Uposleni17562.Exists(uposlenik17562 => (uposlenik17562.Sifra.ToString() == izbor)))
                    return f.Uposleni17562.Find(uposlenik17562 => (uposlenik17562.Sifra.ToString() == izbor));
            }
            throw new Exception("Uposleni ne postoji.");
        }
        public static Predmeti17562 nadjiPredmet(Fakultet17562 f, string pr)
        {
            if (Char.IsLetter(pr[0]))
            {
                if (f.Predmeti17562.Exists(predmet17562 => (predmet17562.NazivPredmeta == pr)))
                    return f.Predmeti17562.Find(predmet17562 => (predmet17562.NazivPredmeta == pr));
            }
            else if (Char.IsDigit(pr[0]))
            {
                if (f.Predmeti17562.Exists(predmet17562 => (predmet17562.Sifra.ToString() == pr)))
                    return f.Predmeti17562.Find(predmet17562 => (predmet17562.Sifra.ToString() == pr));
            }
            throw new Exception("Predmet ne postoji");
        }
        
       
    }
}
