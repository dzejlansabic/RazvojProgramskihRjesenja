using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadaca1
{
    
    public partial class Form8 : Form
    {
        Fakultet f;
        public Form8(Fakultet faks)
        {
            InitializeComponent();
            f = faks;
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int indeks = Convert.ToInt32(textBox1.Text);
            for (int i=0; i<f.Studenti.Count; i++)
            {
                if (f.Studenti[i].BrojIndeksa == indeks)
                {
                    f.Studenti.Remove(f.Studenti[i]);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sifraUposlenika = Convert.ToInt32(textBox2.Text);
            foreach(Uposlenik u in f.Uposlenici)
            {
                if(u.Sifra==sifraUposlenika)
                {
                    f.Uposlenici.Remove(u);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sifraPredmeta = Convert.ToInt32(textBox3.Text);
            foreach(Predmet p in f.Predmeti)
            {
                if(p.SifraPredmeta==sifraPredmeta)
                {
                    f.Predmeti.Remove(p);
                    break; 
                }
            }
        }
    }
}
