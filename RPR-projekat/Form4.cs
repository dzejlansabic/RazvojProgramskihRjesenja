using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace Zadaca1
{
    public partial class Form4 : Form
    {
        Fakultet f;
        string username;
        public Form4(Fakultet faks,string user)
        {
            InitializeComponent();
            f = faks;
            username = user;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text += f.BrojStudenataB;
            label2.Text += f.BrojStudenataM;
            label3.Text += f.BrojUposlenih;
        }

        private void registrujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 Registracija = new Form5(f,username);
            Registracija.ShowDialog();
        }

        private void registrujToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form6 registrujUposlenika = new Form6(f, username);
            registrujUposlenika.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            if(radioButton1.Checked)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                string ime;
                string prezime;
                string indeks;
                string datum;
                string vrsta="";
                List<Student> studenti = new List<Student>();
                foreach(Student s in f.Studenti)
                {
                    try
                    {
                        if (s.Ime.Contains(textBox1.Text) || s.Prezime.Contains(textBox1.Text))
                        {
                            studenti.Add(s);
                            continue;
                        }
                    }
                    catch (Exception iz)
                    {
                        
                    }
                }
                if (studenti.Count != 0)
                {
                    foreach (Student st in studenti)
                    {
                        dataGridView1.Rows.Add();
                        ime = st.Ime;
                        prezime = st.Prezime;
                        indeks = Convert.ToString(st.BrojIndeksa);
                        datum = Convert.ToString(st.DatumRodjenja);
                        if (st is StudentBachelor)
                        {
                            vrsta = "B";
                        }
                        else if (st is StudentMaster)
                        {
                            vrsta = "M";
                        }
                        dataGridView1.Rows[i].Cells[0].Value = ime;
                        dataGridView1.Rows[i].Cells[1].Value = prezime;
                        dataGridView1.Rows[i].Cells[2].Value = indeks;
                        dataGridView1.Rows[i].Cells[3].Value = datum;
                        dataGridView1.Rows[i].Cells[4].Value = vrsta;
                        i++;
                    }
                }
                
            }
            else if (radioButton2.Checked)
            {
                panel2.Visible = false;
                panel1.Visible = true;
                string ime;
                string prezime;
                string sifra;
                string maticni;
                string vrsta = "";
                List<Uposlenik> uposlenici = new List<Uposlenik>();
                foreach (Uposlenik u in f.Uposlenici)
                {
                    try
                    {
                        if (u.Ime.Contains(textBox1.Text) || u.Prezime.Contains(textBox1.Text) || Convert.ToString(u.Sifra).Contains(textBox1.Text))
                        {
                            uposlenici.Add(u);
                            continue;
                        }
                    }
                    catch (Exception iz)
                    {
                        
                    }
                }
                if (uposlenici.Count != 0)
                {
                    foreach (Uposlenik up in uposlenici)
                    {
                        dataGridView2.Rows.Add();
                        ime = up.Ime;
                        prezime = up.Prezime;
                        sifra = Convert.ToString(up.Sifra);
                        maticni = Convert.ToString(up.MaticniBroj);
                        if (up is StalniUposlenik)
                        {
                            vrsta = "Stalni";
                        }
                        else if (up is PrivremeniUposlenik)
                        {
                            vrsta = "Privremeni";
                        }
                        dataGridView2.Rows[i].Cells[0].Value = ime;
                        dataGridView2.Rows[i].Cells[1].Value = prezime;
                        dataGridView2.Rows[i].Cells[2].Value = sifra;
                        dataGridView2.Rows[i].Cells[3].Value = maticni;
                        dataGridView2.Rows[i].Cells[4].Value = vrsta;
                        i++;
                    }
                }
            }
            else if (radioButton3.Checked)
            {
                label4.Text = "Unesi naziv: ";
                label5.Visible = true;
                label6.Visible = true;
                textBox2.Visible = true;
                panel2.Visible = true;
                panel1.Visible = true;
                panel2.Visible = true;
                dataGridView3.Visible = true;
                string naziv;
                string šifra;
                string maxbroj;
                string ects;
                string brojP;
                string brojV;
                List<Predmet> predmeti = new List<Predmet>();
                foreach (Predmet p in f.Predmeti)
                {
                    if ((p.NazivPredmeta.Contains(textBox1.Text) && textBox1.Text != "") || (Convert.ToString(p.SifraPredmeta).Contains(textBox2.Text) && textBox2.Text!="")) 
                    {
                        predmeti.Add(p);
                        continue;
                    }
                    else continue;
                }
                if (predmeti.Count != 0)
                {
                    foreach (Predmet pr in predmeti)
                    {
                        dataGridView3.Rows.Add();
                        naziv = pr.NazivPredmeta;
                        šifra =Convert.ToString(pr.SifraPredmeta);
                        maxbroj = Convert.ToString(pr.MaxStudenata);
                        ects = Convert.ToString(pr.EctsBodovi);
                        brojP = Convert.ToString(pr.BrojPredavanja);
                        brojV = Convert.ToString(pr.BrojVjezbi);

                        dataGridView3.Rows[i].Cells[0].Value = naziv;
                        dataGridView3.Rows[i].Cells[1].Value = šifra;
                        dataGridView3.Rows[i].Cells[2].Value = maxbroj;
                        dataGridView3.Rows[i].Cells[3].Value = ects;
                        dataGridView3.Rows[i].Cells[4].Value = brojP;
                        dataGridView3.Rows[i].Cells[5].Value = brojV;
                        i++;
                    }
                }

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                panel1.Visible = true;
                panel2.Visible = false;
                label4.Text = "Unesi:";
                label5.Visible = false;
                label6.Visible = false;
                textBox2.Visible = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                label4.Text = "Unesi:";
                label5.Visible = false;
                label6.Visible = false;
                textBox2.Visible = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                panel2.Visible = true;
                label4.Text = "Unesi naziv:";
                label5.Visible = true;
                label6.Visible = true;
                textBox2.Visible = true;
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void obrišiToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 registracijaPredmeta = new Form7(f);
            registracijaPredmeta.ShowDialog();
        }

        private void obrišiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 formaZaBrisanje = new Form8(f);
            formaZaBrisanje.ShowDialog();
        }

        private void obrišiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form8 formaZaBrisanje = new Form8(f);
            formaZaBrisanje.ShowDialog();
        }

        private void obrišiToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form8 formaZaBrisanje = new Form8(f);
            formaZaBrisanje.ShowDialog();
        }

        private void spasiKaoXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Student> studenti = f.Studenti.OfType<Student>().ToList<Student>();
            XmlSerializer xs = new XmlSerializer(typeof(List<Student>), new Type[] { typeof(Student), typeof(Predmet), typeof(StudentMaster), typeof(StudentBachelor) });
            TextWriter tw = new StreamWriter("studentifile.xml");
            xs.Serialize(tw, studenti);
            tw.Close();
        }

        private void učitajIzXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* XmlSerializer xs = new XmlSerializer(typeof(List<Student>), new Type[] { typeof(Student), typeof(Predmet), typeof(Studpred) });
             //TextReader tr = new StreamReader("studentifile.xml");
             FileStream tr = new FileStream("studentifile.xml", FileMode.Open);
             List<Student> stud = new List<Student>();
             stud = (List<Student>)xs.Deserialize(tr);
             foreach(Student s in stud)
             {
                 if(s is StudentBachelor)
                 {
                     StudentBachelor sb = s as StudentBachelor;
                     f.Studenti.Add(sb);
                 }
                 else
                 {
                     StudentMaster sm = s as StudentMaster;
                     f.Studenti.Add(sm);
                 }
             }
             tr.Close();*/

            OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, CheckFileExists = true };
            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.EndsWith(".xml"))
            {
                using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open))
                {
                    XmlReader reader = XmlReader.Create(fs);
                    XmlSerializer xs = new XmlSerializer(typeof(List<StudentBachelor>));
                    List<StudentBachelor> tmp = xs.Deserialize(reader) as List<StudentBachelor>;
                    if (tmp != null)
                    { 

                        foreach (StudentBachelor k in tmp)
                        {
                            bool nasao = false;
                            foreach (StudentBachelor b in f.Studenti)
                            {
                                if (b.Ime == k.Ime && b.Prezime == k.Prezime && b.Username == k.Username && b.MaticniBroj == k.MaticniBroj && b.BrojIndeksa == k.BrojIndeksa) nasao = true;
                            }
                            if (nasao == false) f.Studenti.Add(k);
                        }
                    }
                }
            }
        }
    }
}
