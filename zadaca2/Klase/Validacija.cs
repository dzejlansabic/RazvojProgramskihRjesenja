using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Zadaca1
{
    public class Validacija
    {
        public static bool validirajDatum(string s)
        {
            if (s.Length != 10) return false;
            DateTime datum;
            if (DateTime.TryParse(s, out datum)) return true;
            return false;
        }
        public static bool validirajMaticni(string datRodj, string maticni)
        {
            if (maticni.Length != 13) return false;
            string sdan = maticni.Substring(0, 2);
            if (sdan != (datRodj[0].ToString()+datRodj[1].ToString())) return false;
            string smjesec = maticni.Substring(2, 2);
            if (smjesec != datRodj[3].ToString()+datRodj[4].ToString()) return false;
            string sgodina = maticni.Substring(4, 3);
            if (sgodina != datRodj[7].ToString()+datRodj[8].ToString()+datRodj[9].ToString()) return false;
           
            string smjesto = maticni.Substring(7, 2);
            int mjesto = Int32.Parse(smjesto);
            if (mjesto < 10 || mjesto > 19) return false;
            int L= ((7 * ((maticni[0]-48) + (maticni[6]-48)) + 6 * ((maticni[1]-48) + (maticni[7])-48) + 5 * ((maticni[2]-48) + (maticni[8])-48) + 4 * ((maticni[3]-48) + (maticni[9]-48)) + 3 * ((maticni[4]-48) + (maticni[10]-48)) + 2 * ((maticni[5]-48) + (maticni[11]-48))) % 11);
            if (L != 0 && L != 1) L = 11 - L;
            if (!(L.ToString() == (maticni[12]).ToString())) return false;
            return true;
        }
       
        public static string odrediUlogu(Fakultet17562 f,string korisnik)
        {
            if (f.Studenti17562.Exists(student => student.KorisnickoIme == korisnik)) return "student";
            else if (f.Uposleni17562.Exists(uposleni => uposleni.KorisnickoIme == korisnik)) return "uposleni";
            else if (f.Administrator == korisnik) return "administrator";
            return "greska";
        }
        public static string CreateMD5(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
        public static bool validirajLozinku (Fakultet17562 f, string korisnik, string pw)
        {
            if (f.Administrator == korisnik && f.Lozinka == CreateMD5(pw)) return true;
            else if (f.Studenti17562.Exists(student => (student.KorisnickoIme == korisnik && student.Lozinka == CreateMD5(pw)))) return true;
            else if (f.Uposleni17562.Exists(uposleni => (uposleni.KorisnickoIme == korisnik && uposleni.Lozinka == CreateMD5(pw)))) return true;
            return false;
        }
       public static bool validirajIme (string ime)
        {
            if (ime.Length < 3) return false;
            return true;
        }
        public static bool validirajPrezime(string prezime)
        {
            if (prezime.Length < 3) return false;
            return true;
        }
        public static bool validirajSve()
        {
            return true;
        }
    }
}
