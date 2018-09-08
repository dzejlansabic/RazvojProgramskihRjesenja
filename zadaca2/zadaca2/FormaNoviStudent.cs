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
    public partial class FormaNoviStudent : Form
    {
        Fakultet17562 f;
        public FormaNoviStudent(Fakultet17562 f_)
        {
            InitializeComponent();
            f = f_;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true) radioButton2.Checked = false;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked==true)
            {
                radioButton1.Checked = false;
                label8.Visible = true;
                textBox4.Visible = true;
            }
            else
            {
                label8.Visible = false;
                textBox4.Visible = false;
            }
        }

        private void izlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void osvjezi_Click(object sender, EventArgs e)
        {
            ime.Clear();
            prezime.Clear();
            richTextBox1.Clear();
            textBox4.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            maskedTextBox3.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkedListBox1.ClearSelected();
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            if (statusGreska.Text == "" && ime.Text!="" && prezime.Text!="" && maskedTextBox1.Text.Length!=0 && richTextBox1.Text!="" && maskedTextBox2.TextLength!=0 && maskedTextBox3.TextLength!=0)
            {
                if (radioButton1.Checked==false && radioButton2.Checked==false)
                {
                    statusGreska.ForeColor = Color.Red;
                    statusGreska.Text = "Označite da li je student na bachelor ili master studiju";
                }
                else
                {
                    List<Predmeti17562> predmeti = new List<Predmeti17562>();
                    foreach (object it in checkedListBox1.CheckedItems)
                    {
                        predmeti.Add(Pretraga.nadjiPredmet(f, it.ToString()));
                    }
                    if (radioButton1.Checked == true)
                    {
                        f.Studenti17562.Add(new BachelorStudent17562(ime.Text, prezime.Text, Convert.ToDateTime(maskedTextBox1.Text), richTextBox1.Text, Convert.ToDateTime(maskedTextBox2.Text), Convert.ToDateTime(maskedTextBox3.Text), predmeti, formaSlika.dajSliku()));
                    }
                    else if (radioButton2.Checked == true && textBox4.Text!="")
                    {
                        f.Studenti17562.Add(new MasterStudent17562(ime.Text, prezime.Text, Convert.ToDateTime(maskedTextBox1.Text), richTextBox1.Text, Convert.ToDateTime(maskedTextBox2.Text), Convert.ToDateTime(maskedTextBox3.Text), predmeti, textBox4.Text, formaSlika.dajSliku()));
                    }
                    Close();
                }
            }
            else
            {
                statusGreska.Text = "Forma nije dobro ispunjena.";
            }
        }

        private void ime_Validating(object sender, CancelEventArgs e)
        {
            if (!Validacija.validirajIme(ime.Text))
            {
                statusGreska.Text = "Ime mora sadržavati bar 3 znaka";
                errorProvider1.SetError (ime, "Greška");
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
            if (!Validacija.validirajPrezime(ime.Text))
            {
                statusGreska.Text = "Prezime mora sadržavati bar 3 znaka";
                errorProvider1.SetError(prezime, "Greška");
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
                statusGreska.Text = "Datum rođenja nije korektan";
            }
            else
            {
                ime_Validated(sender, e);
            }
        }

        private void richTextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!Validacija.validirajMaticni((maskedTextBox1.Text), richTextBox1.Text) && richTextBox1.Text!="")
            {
                errorProvider1.SetError(richTextBox1, "Greška");
                if (richTextBox1.Text.Length != 13) statusGreska.Text = "Matični broj mora sadržavati tačno 13 cifara!";
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
                statusGreska.Text = "Datum završetka prethodnog školovanja nije korektan";
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
                statusGreska.Text = "Datum završetka prethodnog školovanja nije korektan";
            }
            else if (Convert.ToDateTime(maskedTextBox2.Text)>Convert.ToDateTime(maskedTextBox3.Text))
            {
                statusGreska.Text = "Datum završetka prethodnog školovanja mora biti prije datuma upisa na fakultet";
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
    }
}
