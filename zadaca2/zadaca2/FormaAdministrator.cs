using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Zadaca1
{
    public partial class FormaAdministrator : Form
    {
        Fakultet17562 f;
        public FormaAdministrator(ref Fakultet17562 f_)
        {
            InitializeComponent();
            f= f_;
        }
        private void ocisti()
        {
            grupaBrisiStudenta.Visible = false;
            grupaBrisiUposlenog.Visible = false;
            grupaBrisiPredmet.Visible = false;
            lista1.Visible = false;
            lista2.Visible = false;
            lista2.Items.Clear();
            trazi.Visible = false;
            nazad.Visible = false;
            nazadDod.Visible = false;
            nazadlist.Visible = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            label2.Visible = false;
            nazadpret.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            nazad1.Visible = false;
            nazadu.Visible = false;
            nazadp.Visible = false;
            greska.ForeColor = Color.Red;
            ime.Clear();
            label6.Text = "Pretraga";
            lozinka.Clear();
            ime.Visible = false;
            lozinka.Visible = false;
            traziu.Visible = false;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                ocisti();
                lista1.Items.Clear();
                foreach (Student17562 student in f.Studenti17562)
                {
                    if (student.KorisnickoIme == "")
                    {
                        lista1.Items.Add(student.Ime + " " + student.Prezime + " " + student.BrojIndexa);
                    }
                }
            }
            else if (checkBox2.Checked)
            {
                ocisti();
                lista1.Items.Clear();
                foreach (Uposleni17562 uposleni in f.Uposleni17562)
                {
                    if (uposleni.KorisnickoIme == "")
                    {
                        lista1.Items.Add(uposleni.Ime + " " + uposleni.Prezime + " " + uposleni.Sifra);
                    }
                }
            }
            lista1.Visible = true;
            dodaj2.Visible = true;
            nazadlist.Visible = true;
        }
        
        private void nazad_Click(object sender, EventArgs e)
        {
            ocisti();
            groupBox1.Visible = true;
        }
       
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = lista1.Text;
            ocisti();
            groupBox3.Visible = true;
            label2.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            ime.Visible = true;
            lozinka.Visible = true;
            dodaj2.Visible = true;
            nazadDod.Visible = true;
        }
        private void dodaj2_Click(object sender, EventArgs e)
        {
            string[] ind = label2.Text.Split(' ');
            if (ind[2].Any(c => char.IsLetter(c)))
            {
                Uposleni17562 uposleni = Pretraga.nadjiUposlenog(f, ind[2].ToString());
                uposleni.KorisnickoIme = ime.Text;
                uposleni.Lozinka = Validacija.CreateMD5(lozinka.Text);
            }
            else
            {
                Student17562 student = Pretraga.pronadjiStudenta(f, ind[2].ToString());
                student.KorisnickoIme = ime.Text;
                student.Lozinka = Validacija.CreateMD5(lozinka.Text);
            }
            ocisti();
            lista1.Items.Clear();
            greska.ForeColor = Color.Green;
            greska.Text="Korisnik uspješno dodan!";
            groupBox1.Visible = true;
            System.Timers.Timer tim = new System.Timers.Timer(3000);
            tim.Elapsed += new ElapsedEventHandler(tim_Elapsed);
            tim.Start();

        }
        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaNoviStudent fns = new FormaNoviStudent(f);
            fns.ShowDialog();
        }

        private void uposleniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaNoviUposleni fnu = new FormaNoviUposleni(f);
            fnu.ShowDialog();
        }
        private void predmetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaNoviPredmet fnp = new FormaNoviPredmet(ref f);
            fnp.ShowDialog();
        }
        
        private void studentToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ocisti();
            label6.Text += " studenata";
            groupBox2.Visible = true;
            nazadpret.Visible = true;
            trazip.Visible = false;
            traziu.Visible = false;
            trazi.Visible = true;
        }
        private void predmetToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ocisti();
            label6.Text += " predmeta";
            groupBox2.Visible = true;
            nazadpret.Visible = true;
            trazip.Visible = true;
            traziu.Visible = false;
            trazi.Visible = false;
        }
        private void uposleniToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ocisti();
            label6.Text += " uposlenih";
            groupBox2.Visible = true;
            traziu.Visible = true;
            nazadpret.Visible = true;
            trazip.Visible = false;
            trazi.Visible = false;
        }
        private void trazi_Click(object sender, EventArgs e)
        {
            ocisti();
            lista2.Items.Clear();
            try
            {
                List<Student17562> lista = Pretraga.pronadjiStudente(f, textBox1.Text);
                foreach (Student17562 s in lista) lista2.Items.Add(s.Ime + " " + s.Prezime + " " + s.BrojIndexa);
                lista2.Visible = true;
                groupBox2.Visible = true;
                trazi.Visible = false;
                nazadpret.Visible = true;
                textBox1.Clear();
            }
            catch (Exception izuzetak)
            {
                greska.Text = izuzetak.Message;
                ocisti();
                groupBox2.Visible = true;
                trazi.Visible =true;
                nazadpret.Visible = true;
                textBox1.Clear();
                System.Timers.Timer tim = new System.Timers.Timer(3000);
                tim.Elapsed += new ElapsedEventHandler(tim_Elapsed);
                tim.Start();

            }
        }
        
        private void trazip_Click(object sender, EventArgs e)
        {
            ocisti();
            lista2.Items.Clear();
            try
            {
                List<Predmeti17562> lista = Pretraga.nadjiPredmete(f, textBox1.Text);
                foreach (Predmeti17562 p in lista) lista2.Items.Add(p.NazivPredmeta + " " + p.Sifra);
                lista2.Visible = true;
                groupBox2.Visible = true;
                nazadpret.Visible = true;
                trazip.Visible = false;
                textBox1.Clear();
            }
            catch (Exception izuzetak)
            {
                greska.Text = izuzetak.Message;
                ocisti();
                groupBox2.Visible = true;
                nazadpret.Visible = true;
                trazip.Visible = true;
                textBox1.Clear();
                System.Timers.Timer tim = new System.Timers.Timer(3000);
                tim.Elapsed += new ElapsedEventHandler(tim_Elapsed);
                tim.Start();

            }
        }
        
        private void traziu_Click(object sender, EventArgs e)
        {
            ocisti();
            lista2.Items.Clear();
            try
            {
                List<Uposleni17562> lista = Pretraga.nadjiUposlene(f, textBox1.Text);
                foreach (Uposleni17562 p in lista) lista2.Items.Add(p.Ime + " " + p.Prezime);
                groupBox2.Visible = true;
                traziu.Visible = false;
                lista2.Visible = true;
                nazadpret.Visible = true;
                textBox1.Clear();
            }
            catch (Exception izuzetak)
            {
                greska.Text = izuzetak.Message;
                ocisti();
                groupBox2.Visible = true;
                nazadpret.Visible = true;
                traziu.Visible = true;
                textBox1.Clear();
                System.Timers.Timer tim = new System.Timers.Timer(3000);
                tim.Elapsed += new ElapsedEventHandler(tim_Elapsed);
                tim.Start();

            }
        }
        private void tim_Elapsed(object sender, EventArgs e)
        {
            greska.Text = "";

        }
        private void nazad1_Click(object sender, EventArgs e)
        {
            ocisti();
            groupBox2.Visible = true;
            label6.Text += " uposlenih";
            textBox1.Clear();
            trazi.Visible = true;
            traziu.Visible = false;
            trazip.Visible = false;
            nazadpret.Visible = true;
        }
        private void nazadp_Click(object sender, EventArgs e)
        {
            ocisti();
            groupBox2.Visible = true;
            label6.Text += " predmeta";
            textBox1.Clear();
            trazip.Visible = true;
            traziu.Visible = false;
            trazi.Visible = false;
            nazadpret.Visible = true;
        }

        private void nazadu_Click(object sender, EventArgs e)
        {
            ocisti();
            groupBox2.Visible = true;
            textBox1.Clear();
            label6.Text += " uposlenih";
            traziu.Visible = true;
            trazi.Visible = false;
            trazip.Visible = false;
            nazadpret.Visible = true;
        }

        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ocisti();
            grupaBrisiStudenta.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            nazadBS.Visible = true;
            brisiBS.Visible = true;
            kljuc.Visible = true;
        }

        private void nazadBS_Click(object sender, EventArgs e)
        {
            ocisti();
            groupBox1.Visible = true;
        }

        private void brisiBS_Click(object sender, EventArgs e)
        {
            try
            {
                Student17562 s = Pretraga.pronadjiStudenta(f, kljuc.Text);
                f.Studenti17562.Remove(s);
                kljuc.Text = "";
                ocisti();
                groupBox1.Visible = true;
                greska.ForeColor = Color.Green;
                greska.Text = "Student uspješno obrisan!";
                System.Timers.Timer tim = new System.Timers.Timer(3000);
                tim.Elapsed += new ElapsedEventHandler(tim_Elapsed);
                tim.Start();
            }
            catch (Exception izuzetak)
            {
                kljuc.Text = "";
                greska.Text = izuzetak.Message;
                System.Timers.Timer tim = new System.Timers.Timer(3000);
                tim.Elapsed += new ElapsedEventHandler(tim_Elapsed);
                tim.Start();
            }
        }

        private void uposleniToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ocisti();
            grupaBrisiUposlenog.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            uposleniTekst.Visible = true;
            nazadBU.Visible = true;
            brisiBU.Visible = true;
        }

        private void nazadBU_Click(object sender, EventArgs e)
        {
            ocisti();
            groupBox1.Visible = true;
        }

        private void brisiBU_Click(object sender, EventArgs e)
        {
            try
            {
                Uposleni17562 u = Pretraga.nadjiUposlenog(f, uposleniTekst.Text);
                f.Uposleni17562.Remove(u);
                uposleniTekst.Text = "";
                ocisti();
                groupBox1.Visible = true;
                greska.ForeColor = Color.Green;
                greska.Text = "Uposlenik uspješno obrisan.";
                System.Timers.Timer tim = new System.Timers.Timer(3000);
                tim.Elapsed += new ElapsedEventHandler(tim_Elapsed);
                tim.Start();
            }
            catch (Exception izuzetak)
            {
                uposleniTekst.Text = "";
                greska.Text=izuzetak.Message;
                System.Timers.Timer tim = new System.Timers.Timer(3000);
                tim.Elapsed += new ElapsedEventHandler(tim_Elapsed);
                tim.Start();
            }
        }

        private void predmetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ocisti();
            grupaBrisiPredmet.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            predmetTekst.Visible = true;
            nazadBP.Visible = true;
            brisiBP.Visible = true;
        }

        private void nazadBP_Click(object sender, EventArgs e)
        {
            ocisti();
            groupBox1.Visible = true;
        }

        private void brisiBP_Click(object sender, EventArgs e)
        {
            try
            {
                Predmeti17562 p = Pretraga.nadjiPredmet(f, predmetTekst.Text);
                f.Predmeti17562.Remove(p);
                predmetTekst.Text = "";
                ocisti();
                groupBox1.Visible = true;
                greska.ForeColor = Color.Green;
                greska.Text="Predmet uspješno obrisan!";
                System.Timers.Timer tim = new System.Timers.Timer(3000);
                tim.Elapsed += new ElapsedEventHandler(tim_Elapsed);
                tim.Start();
            }
            catch (Exception izuzetak)
            {
                predmetTekst.Text = "";
                greska.Text=izuzetak.Message;
                System.Timers.Timer tim = new System.Timers.Timer(3000);
                tim.Elapsed += new ElapsedEventHandler(tim_Elapsed);
                tim.Start();
            }
        }

        private void kljuc_TextChanged(object sender, EventArgs e)
        {
            greska.Text = "";
        }

        private void nazadpret_Click(object sender, EventArgs e)
        {
            ocisti();
            groupBox1.Visible = true;
        }

        private void nazadlist_Click(object sender, EventArgs e)
        {
            ocisti();
            groupBox1.Visible = true;
        }

        private void nazads_Click(object sender, EventArgs e)
        {
            ocisti();
            groupBox2.Visible = true;
            label6.Text += " studenata";
            textBox1.Clear();
            trazi.Visible = true;
            traziu.Visible = false;
            trazip.Visible = false;
            nazadpret.Visible = true;
        }

        private void nazadDod_Click(object sender, EventArgs e)
        {
            ocisti();
            lista1.Visible = true;
            nazadlist.Visible = true;
            dodaj2.Visible = true;
        }
    }
}
