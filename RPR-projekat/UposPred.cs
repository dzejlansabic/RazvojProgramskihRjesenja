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
    public class UposPred
    {
        int sifraUposlenika;
        int sifraPredmeta;

        public UposPred() { }
        public UposPred(int sifraUpos, int sifraPred)
        {
            SifraUposlenika = sifraUpos;
            SifraPredmeta = sifraPred;
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

        public int SifraUposlenika
        {
            get
            {
                return sifraUposlenika;
            }

            set
            {
                sifraUposlenika = value;
            }
        }
    }
}
