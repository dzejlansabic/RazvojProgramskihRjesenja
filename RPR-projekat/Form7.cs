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
    public partial class Form7 : Form
    {
        Fakultet f;
        public Form7(Fakultet faks)
        {
            InitializeComponent();
            f = faks;
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || numericUpDown1.Value == 0 || numericUpDown2.Value == 0 || numericUpDown3.Value == 0 || numericUpDown4.Value == 0 || numericUpDown5.Value == 0)
            {
                statusStrip1.Visible = true;
                toolStripStatusLabel1.Text = "Neuspješan pokušaj. Popunite sva polja!!";
            }
            else
            {
                statusStrip1.Visible = false;
                string naziv = textBox1.Text;
                int sifra = Convert.ToInt32(numericUpDown2.Value);
                string studij = textBox2.Text;
                string opis = textBox3.Text;
                string ansambl = textBox4.Text;
                int ects = Convert.ToInt32(numericUpDown1.Value);
                int maxstudenata = Convert.ToInt32(numericUpDown3.Value);
                int predavanja = Convert.ToInt32(numericUpDown4.Value);
                int vjezbe = Convert.ToInt32(numericUpDown5.Value);
                Predmet novi = new Predmet(sifra, naziv, studij, predavanja, vjezbe, maxstudenata, ects, ansambl, opis);
                f.Predmeti.Add(novi);
                statusStrip1.Visible = true;
                toolStripStatusLabel1.Text = "Uspješno dodana knjiga.";
            }
        }
    }
}
