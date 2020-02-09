using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Xml.Serialization;
using System.IO;

namespace Zadaca1
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Fakultet fakultet = new Fakultet("etf");
          


            DateTime datum1 = new DateTime(1996, 9, 13);
            DateTime datum2 = new DateTime(2015, 7, 11);
            DateTime datum3 = new DateTime(1961, 8, 24);
            DateTime datum4 = new DateTime(2016, 7, 27);
            StudentBachelor sb = new StudentBachelor("Džejlan", "Šabić", "1309996111088", datum1, datum2,"dsabic1","dzejlanos");
            StudentBachelor sb2 = new StudentBachelor("Džejlan", "Bean", "1309996111088", datum1, datum2, "dsabic2", "dzejlanos2");
            StudentMaster sm = new StudentMaster("Šaban", "Šaulić", "2408961111044", datum3, datum2, datum4, "Sarajevo","šapke","galebbeli");
            StudentMaster sm3 = new StudentMaster("Šaban", "Žilić", "2408961111044", datum3, datum2, datum4, "Sarajevo", "šap", "galeb");
            StudentMaster sm2 = new StudentMaster("Steven", "Segal", "1309996111088", datum1, datum2, datum4, "Tuzla","Stevo","repić");
            fakultet.RegistrujStudenta(sb);
            fakultet.RegistrujStudenta(sb2);
            fakultet.RegistrujStudenta(sm);
            fakultet.RegistrujStudenta(sm2);
            fakultet.RegistrujStudenta(sm3);
            Predmet p1 = new Predmet(123, "Razvoj programskih rješenja", "RI2", 20, 10, 80, 5, "Dzenana Đonko", "Programiranje u c#");
            Predmet p2 = new Predmet(124, "Algoritmi i struktura podataka", "RI2", 20, 10, 80, 5, "Haris Supic, Alen Islamovic", "Prog. u c++");
            Predmet p3 = new Predmet(125, "Inzenjerska matematika 1", "RI1", 25, 14, 300, 7, "Huse Fatkic", "Tesko brate");
            Predmet p4 = new Predmet(126, "Linearna algebra", "RI1", 25, 14, 300, 7, "Almasa Odzak", "Matrice");
            Predmet p5 = new Predmet(127, "Osnove racunarstva", "RI1", 25, 14, 300, 7, "Vedran Ljubovic", "Jezik C");
            Predmet p6 = new Predmet(128, "Osnove elektrotehnike", "RI1", 25, 14, 300, 7, "Narcis Behlilovic", "Struuja");
            Predmet p7 = new Predmet(129, "Operativni sistemi", "RI1", 25, 14, 300, 7, "Samir Ribic", "Laganica");
            fakultet.RegistrujPredmet(p1);
            fakultet.RegistrujPredmet(p2);
            fakultet.RegistrujPredmet(p3);
            fakultet.RegistrujPredmet(p4);
            fakultet.RegistrujPredmet(p5);
            fakultet.RegistrujPredmet(p6);
            fakultet.RegistrujPredmet(p7);
            StalniUposlenik su1 = new StalniUposlenik("Nedjeljko", "Bajic", "1309996111088", datum1, false, "profesor", "Visa strucna sprema", "Dipl. pravnik", 1200,"baja","legenda");
            StalniUposlenik su2 = new StalniUposlenik("Safet", "Isovic", "2408961111044", datum3, true, "dekan", "VIII stepen", "Dr. fizike", 2300,"sajo","slavuj");
            PrivremeniUposlenik pu = new PrivremeniUposlenik("Alen", "Islamovic", "2408961111044", datum3, datum1, datum2,"čupo","lopov");
            fakultet.DodajNaPredmet(pu,"Osnove elektrotehnike" );
            fakultet.RegistrujUposlenika(su1);
            fakultet.RegistrujUposlenika(su2);
            fakultet.RegistrujUposlenika(pu);
            sb.DodajStudentuPredmet(p1);
            sb.DodajStudentuPredmet(p2);
            sb.DodajStudentuPredmet(p3);
            Studpred prvaOcjena = new Studpred(11001,123,10);
            fakultet.Ocjeni(prvaOcjena);
            Studpred drugaOcjena = new Studpred(11001, 124, 8);

            FormaPrijava prvaForma = new FormaPrijava(fakultet);
            Application.Run(prvaForma);

        }
    }
}