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
    public partial class Form3 : Form
    {
        Fakultet f;
        string username;
        Uposlenik u;
        public Form3(Fakultet faks, string user, Uposlenik uposlenik) 
        {
            InitializeComponent();
            f = faks;
            username = user;
            u = uposlenik;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text+= " "+ u.Ime +" "+u.Prezime;
            foreach (Predmet p in f.Predmeti)
            {
                if (p.NastavniAnsamblPredmeta.Contains(u.Ime) && p.NastavniAnsamblPredmeta.Contains(u.Prezime))
                {
                    listBox1.Items.Add(p.NazivPredmeta);
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            foreach (Predmet p in f.Predmeti)
            {
                if (p.NastavniAnsamblPredmeta.Contains(u.Ime) && p.NastavniAnsamblPredmeta.Contains(u.Prezime))
                {
                    richTextBox1.Text+=(p.NazivPredmeta)+"\n";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            int brojStudenata = 0;
            foreach (Student s in f.Studenti)
            {
             foreach(Predmet p in s.DajStudentskuListuPredmeta())
                {
                    if (p.NastavniAnsamblPredmeta.Contains(u.Ime) && p.NastavniAnsamblPredmeta.Contains(u.Prezime))
                    {
                        brojStudenata++;
                    }
                }
            }
            richTextBox1.Text += "Ukupan broj studenata na vašim predmetima je: " + brojStudenata;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            
                StalniUposlenik su = u as StalniUposlenik;
                if (su is StalniUposlenik)
                {
                    richTextBox1.Clear();
                    richTextBox1.Text = "Vaša plata je: " + su.Plata;
                }
                else
                {
                    richTextBox1.Clear();
                    richTextBox1.Text = "Vaša plata nije fiksna. ";
                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = false;
            int index = Convert.ToInt32(textBox1.Text);
            int ocjena = Convert.ToInt32(numericUpDown1.Value);
            string naziv = Convert.ToString(listBox1.SelectedItem);
            int sifra = 0;
            bool pravilno = false;
            foreach(Predmet p in f.Predmeti)
            {
                if(naziv==p.NazivPredmeta)
                {
                    sifra = p.SifraPredmeta;
                }
            }
            foreach(Student s in f.Studenti)
            {
                foreach(Predmet p in s.DajStudentskuListuPredmeta())
                {
                    if (p.NazivPredmeta == naziv)
                    {
                        pravilno = true;
                        //s.IspisiSaPredmeta(naziv);
                        //button1.PerformClick();
                    }
                }
            }
            if (pravilno)
            {
                Studpred ocjenaStudenta = new Studpred(index, sifra, ocjena);
                f.Ocjeni(ocjenaStudenta);
                statusStrip1.Visible = true;
                toolStripStatusLabel1.Text = "Uspješno ste ocijenili studenta";
            }
            else if(!pravilno)
            {
                statusStrip1.Visible = true;
                toolStripStatusLabel1.Text = "Neuspješan pokušaj ocjenjivanja";
            }
            else
            {
                statusStrip1.Visible = true;
                toolStripStatusLabel1.Text = "Neuspješan pokušaj ocjenjivanja";

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
