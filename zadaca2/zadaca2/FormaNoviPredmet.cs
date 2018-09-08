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
    public partial class FormaNoviPredmet : Form
    {
        Fakultet17562 f;
        public FormaNoviPredmet(ref Fakultet17562 f_)
        {
            InitializeComponent();
            f = f_;
            foreach (Uposleni17562 u in f.Uposleni17562)
            {
                if (u is UposleniPoUgovoruoDjelu17562) profesori.Items.Add(u.Ime + " " + u.Prezime);
                if (u is StalnoUposleni17562 && (u as StalnoUposleni17562).NeNastavno=="nastavno") profesori.Items.Add(u.Sifra + " " + u.Ime + " " + u.Prezime);
            }
        }


        private void maskedTextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (maskedTextBox1.Text.Length!=5)
            {
                statusGreska.Text = "Šifra mora imati tačno 5 cifara.";
                errorProvider1.SetError(maskedTextBox1, "Greška");
                e.Cancel = true;
            }
        }

        private void maskedTextBox1_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            statusGreska.Text = "";
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (textBox3.Text.Length<1)
            {
                errorProvider1.SetError(textBox3, "Greška");
                statusGreska.Text = "Dodajte opis predmeta.";
            }
            else
            {
                maskedTextBox1_Validated(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            numericUpDown1.Value = 20;
            numericUpDown2.Value = 10;
            numericUpDown3.Value = 5;
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            List<Uposleni17562> uposleni=new List<Uposleni17562>();
            foreach (object u in profesori.SelectedItems)
            {
                string[] pretrazi = u.ToString().Split(' ');

                uposleni.Add(Pretraga.nadjiUposlenog(f, pretrazi[1]));
            }
            f.Predmeti17562.Add(new Predmeti17562(Convert.ToInt32(maskedTextBox1.Text), textBox1.Text, domainUpDown1.Text, Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value), Convert.ToInt32(textBox2.Text), uposleni, Convert.ToInt32(numericUpDown3.Value), textBox3.Text));
            Close();
        }
    }
}
