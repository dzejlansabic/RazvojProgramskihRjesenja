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
    public partial class FormaNoviUposleni : Form
    {
        Fakultet17562 f;
        public FormaNoviUposleni(Fakultet17562 f_)
        {
            InitializeComponent();
            f = f_;
        }
        private void ocisti()
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ocisti();
            if (checkBox1.Checked==true)
            {
                checkBox2.Checked = false;
                groupBox1.Visible = true;
            }
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ocisti();
            if (checkBox2.Checked==true)
            {
                checkBox1.Checked = false;
                groupBox2.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (statusGreska.Text=="" && ime.Text!="" && prezime.Text!="" && maskedTextBox1.Text.Length!=0 && richTextBox1.Text!="")
            {
                if (checkBox1.Checked)
                {
                    if (radioButton1.Checked)
                    {
                        f.Uposleni17562.Add(new StalnoUposleni17562(ime.Text, prezime.Text, Convert.ToDateTime(maskedTextBox1.Text), richTextBox1.Text, textBox5.Text, textBox4.Text, domainUpDown1.Text, radioButton1.Text, formaSlika.dajSliku()));
                    }
                    else
                    {
                        f.Uposleni17562.Add(new StalnoUposleni17562(ime.Text, prezime.Text, Convert.ToDateTime(maskedTextBox1.Text), richTextBox1.Text, textBox5.Text, textBox4.Text, domainUpDown1.Text, radioButton2.Text, formaSlika.dajSliku()));
                    }
                }
                else
                {
                    f.Uposleni17562.Add(new UposleniPoUgovoruoDjelu17562(ime.Text, prezime.Text, Convert.ToDateTime(maskedTextBox1.Text), richTextBox1.Text, Convert.ToDateTime(maskedTextBox2.Text), Convert.ToDateTime(maskedTextBox3.Text), formaSlika.dajSliku()));
                }
                Close();
            }
            else
            {
                statusGreska.Text = "Forma nije ispravno popunjena!";
            }
        }
        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button4.PerformClick();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ocisti();
            ime.Clear();
            prezime.Clear();
            richTextBox1.Clear();
            textBox4.Clear();
            textBox5.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            maskedTextBox3.Clear();
        }

        

        private void ime_Validating(object sender, CancelEventArgs e)
        {
            if (!Validacija.validirajIme(ime.Text))
            {
                errorProvider1.SetError(ime, "Greška");
                statusGreska.Text = "Ime mora sadržavati bar 3 znaka.";
                e.Cancel = true;
            }
        }
        private void ime_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            statusGreska.Text = "";
        }

        private void prezime_Validating(object sender, CancelEventArgs e)
        {
            if (!Validacija.validirajPrezime(prezime.Text))
            {
                errorProvider1.SetError(prezime, "Greška");
                statusGreska.Text = "Prezime mora sadržavati bar 3 znaka.";
            }
            else
            {
                ime_Validated(sender, e);
            }
        }
        

        private void formaSlika_Validating(object sender, CancelEventArgs e)
        {
            if ((DateTime.Now - formaSlika.dajDatum()).TotalDays >= 90)
            {
                statusGreska.Text = "Slika ne smije biti starija od 3 mjeseca!";
            }
            else
            {
                ime_Validated(sender, e);
            }
        }

        private void richTextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!Validacija.validirajMaticni(maskedTextBox1.Text, richTextBox1.Text) && richTextBox1.Text!="")
            {
                errorProvider1.SetError(richTextBox1, "Greška");
                if (richTextBox1.Text.Length != 13) statusGreska.Text = "Matični broj mora sadržavati tačno 13 cifara";
                else
                {
                    if (maskedTextBox1.Text.Substring(0, 2) != richTextBox1.Text.Substring(0, 2))
                    {
                        richTextBox1.Select(0, 2);
                        richTextBox1.SelectionColor = Color.Red;
                    }
                    else
                    {
                        richTextBox1.Select(0, 2);
                        richTextBox1.SelectionColor = Color.Black;
                    }
                    if (maskedTextBox1.Text.Substring(3, 2) != richTextBox1.Text.Substring(2, 2))
                    {
                        richTextBox1.Select(2, 2);
                        richTextBox1.SelectionColor = Color.Red;
                    }
                    else
                    {
                        richTextBox1.Select(2, 2);
                        richTextBox1.SelectionColor = Color.Black;
                    }
                    if (maskedTextBox1.Text.Substring(7, 3) != richTextBox1.Text.Substring(4, 3))
                    {
                        richTextBox1.Select(4, 3);
                        richTextBox1.SelectionColor = Color.Red;
                    }
                    else
                    {
                        richTextBox1.Select(4, 3);
                        richTextBox1.SelectionColor = Color.Black;
                    }
                    string smjesto = richTextBox1.Text.Substring(7, 2);
                    int mjesto = Int32.Parse(smjesto);
                    if (mjesto < 10 || mjesto > 19)
                    {
                        richTextBox1.Select(7, 2);
                        richTextBox1.SelectionColor = Color.Red;
                    }
                    else
                    {
                        richTextBox1.Select(7, 2);
                        richTextBox1.SelectionColor = Color.Black;
                    }
                    int L = ((7 * ((richTextBox1.Text[0] - 48) + (richTextBox1.Text[6] - 48)) + 6 * ((richTextBox1.Text[1] - 48) + (richTextBox1.Text[7]) - 48) + 5 * ((richTextBox1.Text[2] - 48) + (richTextBox1.Text[8]) - 48) + 4 * ((richTextBox1.Text[3] - 48) + (richTextBox1.Text[9] - 48)) + 3 * ((richTextBox1.Text[4] - 48) + (richTextBox1.Text[10] - 48)) + 2 * ((richTextBox1.Text[5] - 48) + (richTextBox1.Text[11] - 48))) % 11);
                    if (L != 0 && L != 1) L = 11 - L;
                    if (!(L.ToString() == (richTextBox1.Text[12]).ToString()))
                    {
                        richTextBox1.Select(12, 1);
                        richTextBox1.SelectionColor = Color.Red;
                    }
                    else
                    {
                        richTextBox1.Select(12, 1);
                        richTextBox1.SelectionColor = Color.Black;
                    }
                    statusGreska.Text = "Matični broj nije korektan.";
                }
            }
            else
            {
                ime_Validated(sender, e);
                richTextBox1.Select(0, 13);
                richTextBox1.SelectionColor = Color.Black;
            }
        }

        private void maskedTextBox2_Validating(object sender, CancelEventArgs e)
        {
            if (!Validacija.validirajDatum(maskedTextBox2.Text))
            {
                errorProvider1.SetError(maskedTextBox2, "Greška");
                statusGreska.Text = "Datum početka ugovora nije korektan.";
            }
            else
            {
                ime_Validated(sender, e);
            }
        }

        private void maskedTextBox3_Validating(object sender, CancelEventArgs e)
        {
            if (!Validacija.validirajDatum(maskedTextBox3.Text))
            {
                errorProvider1.SetError(maskedTextBox3, "Greška");
                statusGreska.Text = "Datum završetka ugovora nije korektan.";
            }
            else if (Convert.ToDateTime(maskedTextBox2.Text)>Convert.ToDateTime(sender.ToString()))
            {
                errorProvider1.SetError(maskedTextBox3, "Greška");
                statusGreska.Text = "Datum završetka ugovora mora biti nakon datuma početka ugovora.";
            }
            else
            {
                ime_Validated(sender, e);
            }
        }

        private void maskedTextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!Validacija.validirajDatum(maskedTextBox1.Text))
            {
                errorProvider1.SetError(maskedTextBox1, "Greška");
                statusGreska.Text = "Datum rođenja nije korektan.";
            }
            else
            {
                ime_Validated(sender, e);
            }
        }
    }
}
