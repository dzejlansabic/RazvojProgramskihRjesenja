using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Zadaca1
{
    public partial class StudentForma : Form
    {
            Fakultet17562 f;
            Student17562 s;
            public StudentForma(ref Fakultet17562 f_, ref Student17562 s_)
            {
                InitializeComponent();
                f = f_;
                s = s_;
                label1.Text = DateTime.Now.ToShortDateString();
                ime.Text += s.Ime;
                prezime.Text += s.Prezime;
                datr.Text += s.DatumRodjenja.ToShortDateString();
                mb.Text += s.MaticniBroj;
                index.Text += s.BrojIndexa;
                foreach (Predmeti17562 p in s.PolozeniPredmeti)
                {
                    richTextBox1.Text += p.NazivPredmeta + "\n";
                }
                foreach (Predmeti17562 p in s.AktivniPredmeti)
                {
                    richTextBox2.Text += p.NazivPredmeta + "\n";
                }

            }
            private void ocisti()
            {
                grupaAktivni.Visible = false;
                grupaPolozeni.Visible = false;
                nazadPoloz.Visible = false;
                pocpolozeni.Visible = false;
                nazadAkt.Visible = false;
                nazadprofil.Visible = false;
                profil.Visible = false;
                grupaSvi.Visible = false;
                grupaupis.Visible = false;
                dobrodosli.Visible = false;
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                listBox1.Visible = false;
                listBox2.Visible = false;
                listBox3.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                groupBox1.Visible = false;
                treeView1.Visible = false;
            }
            private void upisToolStripMenuItem1_Click(object sender, EventArgs e)
            {
                ocisti();
                listaupis.Items.Clear();
                foreach (Predmeti17562 p in f.Predmeti17562)
                {
                    if (!s.PolozeniPredmeti.Contains(p) && !s.AktivniPredmeti.Contains(p))
                        listaupis.Items.Add(p.NazivPredmeta + " " + p.Sifra);
                }
                grupaupis.Visible = true;
                listaupis.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
            }

            private void polozeniToolStripMenuItem_Click(object sender, EventArgs e)
            {
                ocisti();
                listapolozeni.Items.Clear();
                foreach (Predmeti17562 p in s.PolozeniPredmeti)
                {
                    listapolozeni.Items.Add(p.NazivPredmeta);
                }
                grupaPolozeni.Visible = true;
                listapolozeni.Visible = true;
                nazadPoloz.Visible = true;
            }


            private void ispisToolStripMenuItem1_Click(object sender, EventArgs e)
            {
                ocisti();
                foreach (Predmeti17562 p in s.AktivniPredmeti)
                {
                    listaktivni.Items.Add(p.NazivPredmeta);
                }
                grupaAktivni.Visible = true;
                listaktivni.Visible = true;
                nazadAkt.Visible = true;
                ispisiAkt.Visible = true;
            }

            private void tim_Elapsed(object sender, EventArgs e)
            {
                statusObavijest.Text = "";
            }
            private void button2_Click(object sender, EventArgs e)
            {
                ocisti();
                treeView1.Visible = true;
                groupBox1.Visible = true;
                dobrodosli.Visible = true;
            }

            private void button3_Click(object sender, EventArgs e)
            {
            try
            {
                string[] pred = listaupis.Text.Split(' ');
                Predmeti17562 p = Pretraga.nadjiPredmet(f, pred[0]);
                if (Analiza.ukupanBrojKredita(s) + p.BrojECTS > 30)
                {
                    statusObavijest.ForeColor = Color.Red;
                    statusObavijest.Text = "Broj ECTS kredita premašuje 30!";
                    System.Timers.Timer tim = new System.Timers.Timer(5000);
                    tim.Elapsed += new ElapsedEventHandler(tim_Elapsed);
                    tim.Start();
                }
                else
                {
                    s.AktivniPredmeti.Add(p);
                    statusObavijest.ForeColor = Color.Green;
                    statusObavijest.Text = "Uspješno ste upisani na predmet " + p.NazivPredmeta + "!";
                    label2.Text= "Upisani ste na predmet " + p.NazivPredmeta + "!";
                    System.Timers.Timer tim = new System.Timers.Timer(5000);
                    tim.Elapsed += new ElapsedEventHandler(tim_Elapsed);
                    tim.Start();
                }
                ocisti();
                groupBox1.Visible = true;
                dobrodosli.Visible = true;
                treeView1.Visible = true;
            }
            catch (Exception izuzetak)
            {
                statusObavijest.Text = izuzetak.Message;
                System.Timers.Timer tim = new System.Timers.Timer(5000);
                tim.Elapsed += new ElapsedEventHandler(tim_Elapsed);
                tim.Start();
            }
       }
            private void nazadppolozeni_Click(object sender, EventArgs e)
            {
                ocisti();
                groupBox1.Visible = true;
                treeView1.Visible = true;
                dobrodosli.Visible = true;
            }
            private void ispisiAkt_Click(object sender, EventArgs e)
            {
                s.AktivniPredmeti.Remove(Pretraga.nadjiPredmet(f, listaktivni.Text));
                statusBar.ForeColor = Color.Green;
                statusBar.Text = "Uspješno ste ispisani sa predmeta " + listaktivni.Text + "!";
                label2.Text = "Ispisani ste sa predmeta " + listaktivni.Text;
                ocisti();
                groupBox1.Visible = true;
                treeView1.Visible = true;
                dobrodosli.Visible = true;
            System.Timers.Timer tim = new System.Timers.Timer(3000);
                tim.Elapsed += new ElapsedEventHandler(tim_Elapsed);
                tim.Start();
            }

            private void nazadSvi_Click(object sender, EventArgs e)
            {
                ocisti();
                groupBox1.Visible = true;
                treeView1.Visible = true;
                dobrodosli.Visible = true;
            }
            private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
            {
            if (treeView1.SelectedNode==treeView1.Nodes[0].Nodes[0])
            {
                ocisti();
                profil.Visible = true;
                nazadprofil.Visible = true;
            }
                else if (treeView1.SelectedNode == treeView1.Nodes[0].Nodes[1].Nodes[0])
                {
                ocisti();
                foreach (Predmeti17562 p in s.AktivniPredmeti)
                {
                    listaktivni.Items.Add(p.NazivPredmeta);
                }
                grupaAktivni.Visible = true;
                listaktivni.Visible = true;
                nazadAkt.Visible = true;
                ispisiAkt.Visible = true;
            }
                else if (treeView1.SelectedNode == treeView1.Nodes[0].Nodes[1].Nodes[1])
                {
                    ocisti();
                    foreach (Predmeti17562 p in s.PolozeniPredmeti)
                    {
                        listBox2.Items.Add(p.NazivPredmeta);
                    }
                    pocpolozeni.Visible = true;
                    listBox2.Visible = true;
                    nazadppolozeni.Visible = true;

                }
                else if (treeView1.SelectedNode == treeView1.Nodes[0].Nodes[1].Nodes[2])
                {
                    ocisti();
                    foreach (Predmeti17562 p in f.Predmeti17562)
                    {
                        listBox3.Items.Add(p.NazivPredmeta);
                    }
                    grupaSvi.Visible = true;
                    listBox3.Visible = true;
                    nazadSvi.Visible = true;
                }

            }

            private void nazadAkt_Click(object sender, EventArgs e)
            {
                ocisti();
                treeView1.Visible = true;
                groupBox1.Visible = true;
                dobrodosli.Visible = true;
            }

            private void nazadPoloz_Click(object sender, EventArgs e)
            {
                ocisti();
                treeView1.Visible = true;
                groupBox1.Visible = true;
                dobrodosli.Visible = true;
            }

            private void nazadprofil_Click(object sender, EventArgs e)
            {
                ocisti();
                treeView1.Visible = true;
                groupBox1.Visible = true;
                dobrodosli.Visible = true;
            }
        }
    }

