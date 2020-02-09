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
    public class Fakultet
    {
        string usernameAdmina = "admin";
        string passwordAdmina;       // U property sam dodao password "admin"..Receno je da moze ovako da ne moramo praviti dodatnu klasu i to..
        string nazivFakulteta;
        int brojStudenataB;
        int brojStudenataM;
        int brojPredmeta;
        int brojUposlenih;
        List<Student> studenti;
        List<Uposlenik> uposlenici;
        List<Predmet> predmeti;
        List<Studpred> sveOcjene;
        List<UposPred> sviPredmeti;

        public Fakultet() { }

        public Fakultet(string naziv)
        {
            NazivFakulteta = naziv;
            Studenti = new List<Student>();
            Uposlenici = new List<Uposlenik>();
            predmeti = new List<Predmet>();
            SveOcjene = new List<Studpred>();
            sviPredmeti = new List<UposPred>();
            brojPredmeta = BrojStudenataB = BrojStudenataM = BrojUposlenih = 0;
        }
        public List<Predmet> DajListuPredmeta(string user)
        {
            foreach (Student s in Studenti)
            {
                if (user == s.Username)
                {
                    return s.DajStudentskuListuPredmeta();
                }
            }
            throw new Exception ("Nema studentske liste predmeta");
        }
        public void NadjiPredmet(string naziv,Student s)
        {
            foreach(Predmet p in predmeti)
            {
                if(p.NazivPredmeta==naziv)
                {
                    s.UpisiNaPredmet(p);
                }
            }
        }
        public Predmet VratiPredmet(string naziv)
        {
            foreach (Predmet p in predmeti)
            {
                if (p.NazivPredmeta == naziv)
                {
                    return p;
                }
            }
            throw new Exception("Nema predmeta");
        }
        public string DajNazivPredmetaPrekoSifre(int sifra)
        {
            foreach(Predmet p in predmeti)
            {
                if(p.SifraPredmeta==sifra)
                {
                    return p.NazivPredmeta;
                }
            }
            throw new Exception("Nema predmeta");
        }
        public List<Studpred> DajListuOcjena(string user)
        {
            List<Studpred> novaLista = new List<Studpred>();
            foreach(Student s in Studenti)
            {
                if(s.Username==user)
                {
                    foreach(Studpred sp in SveOcjene)
                    {
                        if(s.BrojIndeksa==sp.IndeksStudenta)
                        {
                            novaLista.Add(sp);
                        }
                    }
                }
            }
            return novaLista;
        } 
        public string NazivFakulteta
        {
            get
            {
                return nazivFakulteta;
            }
            set
            {
                nazivFakulteta = value;
            }
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

        public List<Studpred> SveOcjene
        {
            get
            {
                return sveOcjene;
            }

            set
            {
                sveOcjene = value;
            }
        }

        public string UsernameAdmina
        {
            get
            {
                return usernameAdmina;
            }

            set
            {
                usernameAdmina = value;
            }
        }

        public string PasswordAdmina
        {
            get
            {
                return passwordAdmina;
            }

            set
            {
                passwordAdmina = CalculateMD5Hash("admin");
            }
        }

        public List<Student> Studenti
        {
            get
            {
                return studenti;
            }

            set
            {
                studenti = value;
            }
        }

        public List<Uposlenik> Uposlenici
        {
            get
            {
                return uposlenici;
            }

            set
            {
                uposlenici = value;
            }
        }

        public int BrojStudenataB
        {
            get
            {
                return brojStudenataB;
            }

            set
            {
                brojStudenataB = value;
            }
        }

        public int BrojStudenataM
        {
            get
            {
                return brojStudenataM;
            }

            set
            {
                brojStudenataM = value;
            }
        }

        public int BrojUposlenih
        {
            get
            {
                return brojUposlenih;
            }

            set
            {
                brojUposlenih = value;
            }
        }

        public void RegistrujStudenta(Student s)
        {
            if (s is StudentBachelor) BrojStudenataB++;
            else if (s is StudentMaster) BrojStudenataM++;
            Studenti.Add(s);
        }

        public void ObrisiStudenta(int index)
        {
            bool postoji = false;
            foreach (Student student in Studenti.ToList())
            {
                if (student.BrojIndeksa == index)
                {
                    Studenti.Remove(student);
                    postoji = true;
                }
            }
            if (postoji == false) throw new Exception("Nije nadjen student za brisanje");
        }


        public void RegistrujPredmet(Predmet p)
        {
            predmeti.Add(p);
            brojPredmeta++;
        }
        public void ObrisiPredmet(int sifra)
        {
            bool postoji = false;
            foreach(Predmet predmet in predmeti)
            {
                if(predmet.SifraPredmeta==sifra)
                {
                    predmeti.Remove(predmet);
                    postoji = true;
                }
            }
            if (!postoji) throw new Exception("Nije nadjen predmet za brisanje");
        }
        public Student NadjiStudentaSaUsername(string user)
        {
            foreach(Student s in Studenti)
            {
                if (s.Username == user)
                    return s;
            }
            throw new Exception("Pogrešan username ili password!");
        }

        public Uposlenik NadjiUposlenikaSaUsername(string user)
        {
            foreach (Uposlenik u in Uposlenici)
            {
                if (u.Username == user)
                    return u;
            }
            throw new Exception("Pogrešan username ili password!");
        }

        public void Ocjeni(Studpred sp)
        {
            string naziv="";
            SveOcjene.Add(sp);
            foreach(Predmet p in predmeti )
            {
                if (p.SifraPredmeta == sp.SifraPredmeta)
                    naziv = p.NazivPredmeta;
            }
            foreach(Student s in Studenti)
            {
                if(sp.IndeksStudenta==s.BrojIndeksa)
                {
                    if(naziv!="")
                    s.IspisiSaPredmeta(naziv);
                }
            }
        }
        public void DodajNaPredmet(Uposlenik uposlenik, string Naziv)
        {
            foreach (Predmet p in predmeti)
            {
                if (p.NazivPredmeta == Naziv)
                {
                    p.NastavniAnsamblPredmeta += ", " + uposlenik.Ime + " " + uposlenik.Prezime;
                }
            }
        }
        public void RegistrujUposlenika (Uposlenik u)
        {
            Uposlenici.Add(u);
            BrojUposlenih++;
        }
       

        public void ObrisiUposlenika(int sifra)
        {
            bool postoji = false;
            foreach (Uposlenik uposlenik in Uposlenici)
            {
                if (uposlenik.Sifra == sifra)
                {
                    Uposlenici.Remove(uposlenik);
                    postoji = true;
                }
            }
            if (!postoji) throw new Exception("Nije nadjen uposlenik");
        }

        public void Pretraga()
        {
           
        } 
            public List<String> vratiPredmeteSaIstimCikl(string ciklusTrazeni)
        {
            bool i = false;
            List<String> nova4 = new List<String>();
            foreach (Predmet pPretrage in predmeti)
            {
                if (pPretrage.StudijPredmeta == ciklusTrazeni)
                {
                    nova4.Add(pPretrage.NazivPredmeta);
                    i = true;
                }
            }
            if (i == true) return nova4;
            else throw new Exception("Nije nadjen");
        }

        public void AnalizaSadrzaja()
        {
          
        }
        public void DodatniUnosi()
        {
      
        }
        public void IspisDodatnogMenija()
        {
          
        }
        public void IspisMenija()
        {
         
        }
        public bool ValidacijaMaticnog(string maticni,DateTime datumRodj)
        {
            if (maticni.Length != 13) return false;
            string dan = "" + maticni[0] + "" + maticni[1];
            string mjesec = "" + maticni[2] + "" + maticni[3];
            string godina = "1" + maticni[4] + "" + maticni[5] + "" + maticni[6];
            string datum =""+ dan + "/" + mjesec + "/" + godina;
           // DateTime datumpravi = Convert.ToDateTime(datum);
            DateTime datumpravi =new DateTime(Convert.ToInt32(godina),Convert.ToInt32(mjesec),Convert.ToInt32(dan));
            if (datumpravi.Date == datumRodj.Date) return true;
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
    }
}