using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca1
{
    public sealed class Predmeti17562 : IPredmetInfo
    {
        int sifra;
        string nazivPredmeta;
        string studij;
        int brojP;
        int brojV;
        int brojS;
        int brojECTS;
        List<Uposleni17562> nastAnsambl;
        string opis;

        public Predmeti17562(int nsifra, string nnazivPredmeta, string nstudij, int nbrojP, int nbrojV, int nbrojS, List<Uposleni17562> nA, int nbrojECTS, string nopis) {
            sifra = nsifra;
            nazivPredmeta = nnazivPredmeta;
            studij = nstudij;
            brojP = nbrojP;
            brojV = nbrojV;
            brojS = nbrojS;
            nastAnsambl = nA;
            brojECTS = nbrojECTS;
            opis = nopis;
        }
        public int Sifra
        {
            get { return sifra; }
            set { sifra = value; }
        }
        public List<Uposleni17562> NastAnsambl
        {
            get { return nastAnsambl; }
            set { nastAnsambl = value; }
        }
        public string NazivPredmeta
        {
            get { return nazivPredmeta; }
            set { nazivPredmeta = value; }
        }
        public int BrojP
        {
            get { return brojP; }
            set { brojP = value; }
        }
        public int BrojV
        {
            get { return brojV; }
            set { brojV = value; }
        }
        public string Studij
        {
            get { return studij; }
            set { studij = value; }
        }
        public int BrojS
        {
            get { return brojS; }
            set { brojS = value; }
        }
        public int BrojECTS
        {
            get { return brojECTS; }
            set { brojECTS = value; }
        }
        public string Opis
        {
            get { return opis; }
            set { opis = value; }
        }

        public string generalneInformacije()
        {
            return ToString(sifra, nazivPredmeta, studij, brojP, brojV, brojS, brojECTS);
        }
        public string ToString (int sifra, string nazivPredmeta, string studij, int brojP, int brojV, int brojS, int brojECTS)
        {
            return string.Format("Šifra: {0}\nNaziv predmeta: {1} Studij: {2}\nBroj predavanja: {3} Broj vježbi: {4}\nBroj studenata: {5}\nBroj ECTS kredita: {6}\n", sifra, nazivPredmeta, studij, brojP, brojV, brojS, brojECTS);
        }
        public string nastavniAnsambl()
        {
            string svi="";
            foreach (Uposleni17562 s in nastAnsambl)
            {
                svi += (s.Ime + " " + s.Prezime+ " , ");
            }
            return svi;
        }
        public int ECTSuSate()
        {
            return brojECTS * BrojV;
        }
    };
}
