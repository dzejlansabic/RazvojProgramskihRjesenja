using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Zadaca1
{
    public partial class StudentBachelor:Student
    {
        public override string ToString()
        {
            return string.Format("BACHELOR STUDENET\nIme i prezime studenta: {0} {1} " + Environment.NewLine + "Broj indeksa:           {5} " + Environment.NewLine + "Datum rodjenja:         {2} " + Environment.NewLine + "Maticni broj:           {3} " + Environment.NewLine + "Datum zavrsenog prethodnog obrazovanja: {4} " + Environment.NewLine + "Datum upisa: {6} " + Environment.NewLine, Ime, Prezime, DatumRodjenja, MaticniBroj, DatumPrethodnogObrazovanja, BrojIndeksa, DatumUpisa);
        }
    }
}
