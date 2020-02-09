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
    public partial class Form2 : Form
    {
        Student s;
        Fakultet f;
        string username;
        public Form2(Fakultet fa,string user,Student st)
        {
            InitializeComponent();
            f = fa;
            username = user;
            s = st;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text += s.Ime + " " + s.Prezime;
            int i = 0;
            foreach (Predmet p in s.DajStudentskuListuPredmeta()) {
                listBox1.Items.Insert(i,p.NazivPredmeta);
                i++;
            }
            foreach (Predmet p in f.Predmeti)
            {
                int j = 0;
                bool ima = false;
                foreach(Predmet s in s.DajStudentskuListuPredmeta())
                {
                    if(p.NazivPredmeta==s.NazivPredmeta)
                    {
                        ima = true;
                    }
                }
                foreach(Studpred sp in f.SveOcjene)
                {
                    if(sp.SifraPredmeta==p.SifraPredmeta && sp.IndeksStudenta==s.BrojIndeksa)
                    {
                        ima = true;
                    }
                }
                if(!ima)
                {
                    listBox2.Items.Insert(j, p.NazivPredmeta);
                    j++;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                richTextBox1.Clear();
                List<Predmet> predm = f.DajListuPredmeta(username);
                
                for(int i=0; i<predm.Count; i++)
                {
                    richTextBox1.Text+= predm[i].NazivPredmeta+"\n";
                }
                
            }
            if (radioButton1.Checked)
            {
                richTextBox1.Clear();
                List<Studpred> lista = f.DajListuOcjena(username);
                for (int i = 0; i < lista.Count; i++)
                {
                    richTextBox1.Text +=f.DajNazivPredmetaPrekoSifre(lista[i].SifraPredmeta)+".....  " + lista[i].Ocjena + "\n";
                }
            }
            

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string predmetIspisat = listBox1.SelectedItem.ToString();
            s.IspisiSaPredmeta(predmetIspisat);
            button1.PerformClick();
        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
            int sumaBodova = 0;
            try
            {
                foreach(Predmet p in s.DajStudentskuListuPredmeta())
                {
                    sumaBodova += p.EctsBodovi;
                }
                if (sumaBodova >= 30) throw new NullReferenceException("Previše ECTS bodova.");
                string predmetUpisat = listBox2.SelectedItem.ToString();
                if (sumaBodova + (f.VratiPredmet(predmetUpisat)).EctsBodovi > 30) throw new NullReferenceException("Previse ects bodova!");
                f.NadjiPredmet(predmetUpisat, s);
                button1.PerformClick();
                listBox2.SelectedItems.Remove(f.VratiPredmet(predmetUpisat));
                listBox2.Refresh();
            }
            catch (NullReferenceException izuz)
            {
                statusStrip1.Visible = true;
                toolStripStatusLabel1.Text = izuz.Message;
            }
            catch (NotFiniteNumberException izuze)
            {
                statusStrip1.Visible = true;
                toolStripStatusLabel1.Text = izuze.Message;
            }
            catch (Exception izuzetak)
            {
                statusStrip1.Visible = true;
                toolStripStatusLabel1.Text = izuzetak.Message;                
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            foreach (Predmet p in f.Predmeti)
            {
                if (p.NazivPredmeta.Contains(textBox1.Text) || p.NastavniAnsamblPredmeta.Contains(textBox1.Text))
                {

                    richTextBox1.Text += p.NazivPredmeta + " - " + p.NastavniAnsamblPredmeta + "\n";
                } 
                else if (richTextBox1.Text == "")  richTextBox1.Clear(); 
            }
            if (richTextBox1.Text == "") richTextBox1.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            double suma = 0;
            int brojPredmeta = 0;
            double prosjek = 0;
            foreach (Studpred sp in f.SveOcjene)
            {
                if(sp.IndeksStudenta==s.BrojIndeksa)
                {
                    suma += sp.Ocjena;
                    brojPredmeta++;
                }
            }
            if (brojPredmeta != 0)
            {
                prosjek = suma / brojPredmeta;
                richTextBox1.Text = "Prosjek ocjena je: " + prosjek;
            }
            else richTextBox1.Text = "Nema položenih predmeta!";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox2.Visible = true;
            richTextBox2.Text = "Raspored studenta u izradi...";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach(Student s in f.Studenti)
            {
                if (s is StudentMaster)
                {
                    richTextBox1.Text += s.DajMasterIndex() + "  " + s.Ime + "\n";
                }
                else if (s is StudentBachelor)
                {
                    richTextBox1.Text += s.BrojIndeksa + "  " + s.Ime + "\n";
                }
            }
        }
    }
}
