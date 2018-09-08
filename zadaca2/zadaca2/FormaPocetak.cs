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
    public partial class FormaPocetak : Form
    {
        Fakultet17562 f;
        public FormaPocetak()
        {
            InitializeComponent();
            f = new Fakultet17562();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uloga=Validacija.odrediUlogu(f, textBox1.Text);
            if (Validacija.validirajLozinku(f, textBox1.Text, textBox2.Text))
            {
                if (uloga == "administrator")
                {
                    FormaAdministrator fa = new FormaAdministrator(ref f);
                    fa.ShowDialog();
                }
                else if (uloga == "student")
                {
                    Student17562 s = f.Studenti17562.Find(student => student.KorisnickoIme == textBox1.Text);
                    StudentForma fs = new StudentForma(ref f, ref s);
                    fs.ShowDialog();
                }
                else if (uloga=="uposleni")
                {
                    Uposleni17562 u = f.Uposleni17562.Find(uposleni => uposleni.KorisnickoIme == textBox1.Text);
                    FormaUposleni fu = new FormaUposleni(ref f, ref u);
                    fu.ShowDialog();
                }
            }
            else {
                toolStripStatusLabel1.Text = "Pogrešni pristupni podaci!";
            }
        }
    }
}
