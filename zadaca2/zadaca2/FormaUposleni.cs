using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadaca1
{
    public partial class FormaUposleni : Form
    {
        Fakultet17562 f;
        Uposleni17562 u;
        public FormaUposleni(ref Fakultet17562 f_, ref Uposleni17562 u_)
        {
            InitializeComponent();
            f = f_;
            u = u_;
            ime.Text += u.Ime;
            prezime.Text += u.Prezime;
            dr.Text += u.DatumRodjenja.ToShortDateString();
            mb.Text += u.MaticniBroj;
            if (u is StalnoUposleni17562)
            {
                su.Text += "Da";
                label3.Text = "Stručna sprema: " + (u as StalnoUposleni17562).StrucnaSprema;
                label4.Text = "Pozicija: " + (u as StalnoUposleni17562).Pozicija;
                label5.Text = "Titula: " + (u as StalnoUposleni17562).Titula;
                label5.Visible = true;
            }
            else
            {
                su.Text += "Ne";
                label5.Visible = false;
                label3.Text = "Datum početka ugovora: " + (u as UposleniPoUgovoruoDjelu17562).PocetakUgovora;
                label4.Text = "Datum završetka ugovora: " + (u as UposleniPoUgovoruoDjelu17562).KrajUgovora;
            }
            pictureBox1.BackgroundImage = u.Slika;
            foreach (Predmeti17562 p in f.Predmeti17562)
            {
                if (p.NastAnsambl.Exists(up => up.Sifra == u.Sifra)) checkedListBox1.Items.Add(p.NazivPredmeta + " " + p.Sifra);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count!=1)
            {
                status.ForeColor = Color.Red;
                status.Text = "Odaberite 1 predmet!";
                System.Timers.Timer tim = new System.Timers.Timer(3000);
                tim.Elapsed += new ElapsedEventHandler(tim_Elapsed);
                tim.Start();
            }
            else
            {
                groupBox7.Text = checkedListBox1.SelectedItem.ToString();
                string[] pred = checkedListBox1.SelectedItem.ToString().Split(' ');
                Predmeti17562 p = Pretraga.nadjiPredmet(f, pred[0]);
                slusa.Text = "Predmet sluša " + Analiza.slusa(f, p) + " studenata";
                polozilo.Text = "Predmet položilo " + Analiza.polozilo(f, p) + " studenata";
                groupBox7.Visible = true;
            }
        }
        private void tim_Elapsed(object sender, EventArgs e)
        {
            status.Text = "";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 1)
            {
                tabControl1.SelectTab(3);
                Graphics g = panel1.CreateGraphics();
                Pen mp = new Pen(Color.Black, 2);
                g.DrawString("Broj studenata", new Font("Consolas", 8, FontStyle.Regular), Brushes.Black, new Point(0, 5));
                g.DrawLine(mp, new Point(0, 30), new Point(5, 25));
                g.DrawLine(mp, new Point(5, 25), new Point(10, 30));
                g.DrawLine(mp, new Point(5, 25), new Point(5, 210));
                g.DrawLine(mp, new Point(5, 210), new Point(250, 210));
                g.DrawLine(mp, new Point(245, 205), new Point(250, 210));
                g.DrawLine(mp, new Point(245, 215), new Point(250, 210));
                string[] pred = checkedListBox1.SelectedItem.ToString().Split(' ');
                Predmeti17562 p = Pretraga.nadjiPredmet(f, pred[0]);
                int x = Analiza.slusa(f, p);
                int y = Analiza.polozilo(f, p);
                int z = Analiza.nePrati(f, p);
                Rectangle r = new Rectangle(new Point(10, 210 - (x * 100 / (x + y + z))), new Size(50, x * 100 / (x + y + z)));
                g.FillRectangle(Brushes.BlueViolet, r);
                g.DrawString("Slušaju", new Font("Consolas", 7, FontStyle.Regular), Brushes.Black, new Point(10, 215));
                r.X = 60;
                r.Y = 210 - (y * 100 / (x + y + z));
                r.Height = y * 100 / (x + y + z);
                g.FillRectangle(Brushes.YellowGreen, r);
                g.DrawString("Položili", new Font("Consolas", 7, FontStyle.Regular), Brushes.Black, new Point(60, 215));
                r.X = 110;
                r.Y = 210 - (z * 100 / (x + y + z));
                r.Height = z * 100 / (x + y + z);
                g.FillRectangle(Brushes.Plum, r);
                g.DrawString("Ne slušaju", new Font("Consolas", 7, FontStyle.Regular), Brushes.Black, new Point(110, 215));
                g.DrawString("Nisu položili", new Font("Consolas", 7, FontStyle.Regular), Brushes.Black, new Point(110, 224));
            }
            else
            {
                status.ForeColor = Color.Red;
                status.Text = "Odaberite 1 predmet!";
                System.Timers.Timer tim = new System.Timers.Timer(3000);
                tim.Elapsed += new ElapsedEventHandler(tim_Elapsed);
                tim.Start();
            }
        }
    }
}
