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
    public class Studpred
    {
        int indeksStudenta;
        int sifraPredmeta;
        int ocjena;

        public Studpred() { }
        public Studpred(int indeks, int sifra, int pocjena)
        {
            IndeksStudenta = indeks;
            SifraPredmeta = sifra;
            Ocjena = pocjena;
        }

        public int IndeksStudenta
        {
            get
            {
                return indeksStudenta;
            }

            set
            {
                indeksStudenta = value;
            }
        }

        public int Ocjena
        {
            get
            {
                return ocjena;
            }

            set
            {
                ocjena = value;
            }
        }

        public int SifraPredmeta
        {
            get
            {
                return sifraPredmeta;
            }

            set
            {
                sifraPredmeta = value;
            }
        }
    }

}

