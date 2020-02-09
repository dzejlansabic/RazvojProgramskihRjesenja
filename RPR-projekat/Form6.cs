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
    public partial class Form6 : Form
    {
        Fakultet f;
        string username;
        public Form6(Fakultet faks, string user)
        {
            InitializeComponent();
            f = faks;
            username = user;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                groupBox5.Visible = false;
                panel1.Visible = true;
                checkBox1.Visible = false;
            }
            else if (radioButton3.Checked)
            {
                panel1.Visible = false;
                groupBox5.Visible = true;
                checkBox1.Visible = true;
            }

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                groupBox5.Visible = false;
                panel1.Visible = true;
                checkBox1.Visible = false;
            }
            else if (radioButton3.Checked)
            {
                panel1.Visible = false;
                groupBox5.Visible = true;
                checkBox1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            statusStrip1.Visible = false;
            toolStripStatusLabel1.Text = "";
            bool boolMaticni = false;
            bool boolPassword = false;
            
            if (radioButton3.Checked && checkBox1.Checked)
            {
                if (f.ValidacijaMaticnog(maskedTextBox1.Text,dateTimePicker1.Value))
                {
                    boolMaticni = true;
                }
                if (textBox5.Text == textBox6.Text)
                {
                    boolPassword = true;
                }
                if (boolPassword && boolMaticni)
                {
                    StalniUposlenik su1 = new StalniUposlenik(textBox1.Text, textBox2.Text, maskedTextBox1.Text, dateTimePicker1.Value, true, textBox7.Text, textBox9.Text, textBox8.Text, Convert.ToInt32(textBox10.Text), textBox4.Text, textBox5.Text);
                    f.RegistrujUposlenika(su1);
                    statusStrip1.Visible = true;
                    toolStripStatusLabel1.Text = "Uspješno registrovan stalni uposlenik.(nastavno osoblje)";
                }
                if(!boolMaticni)
                {
                    errorProvider2.SetError(maskedTextBox1, "Pogrešan matični ili datum rođenja");
                }
                if(!boolPassword)
                {
                    errorProvider3.SetError(textBox6, "Passwordi se ne podudaraju");
                }
            }
            else if (radioButton3.Checked && !checkBox1.Checked)
            {
                if (f.ValidacijaMaticnog(maskedTextBox1.Text, dateTimePicker1.Value))
                {
                    boolMaticni = true;
                }
                if (textBox5.Text == textBox6.Text)
                {
                    boolPassword = true;
                }
                if (boolPassword && boolMaticni)
                {
                    StalniUposlenik su2 = new StalniUposlenik(textBox1.Text, textBox2.Text, maskedTextBox1.Text, dateTimePicker1.Value, false, textBox7.Text, textBox9.Text, textBox8.Text, Convert.ToInt32(textBox10.Text), textBox4.Text, textBox5.Text);
                    f.RegistrujUposlenika(su2);
                    statusStrip1.Visible = true;
                    toolStripStatusLabel1.Text = "Uspješno registrovan stalni uposlenik.";
                }
            if (!boolMaticni)
            {
                errorProvider2.SetError(maskedTextBox1, "Pogrešan matični ili datum rođenja");
            }
            if (!boolPassword)
            {
                errorProvider3.SetError(textBox6, "Passwordi se ne podudaraju");
            }

        }
            else if (radioButton4.Checked)
            {
                bool boolDatum = false;
                if (f.ValidacijaMaticnog(maskedTextBox1.Text, dateTimePicker1.Value))
                {
                    boolMaticni = true;
                }
                if (textBox5.Text == textBox6.Text)
                {
                    boolPassword = true;
                }
                if (dateTimePicker2.Value < dateTimePicker3.Value)
                {
                    boolDatum = true;
                }
                if(boolDatum && boolMaticni && boolPassword)
                {
                    PrivremeniUposlenik pu = new PrivremeniUposlenik(textBox1.Text, textBox2.Text, maskedTextBox1.Text, dateTimePicker1.Value, dateTimePicker2.Value, dateTimePicker3.Value, textBox4.Text, textBox5.Text);
                    f.RegistrujUposlenika(pu);
                    statusStrip1.Visible = true;
                    toolStripStatusLabel1.Text = "Uspješno registrovan privremeni uposlenik.";
                }
                if(!boolDatum)
                {
                    errorProvider1.SetError(dateTimePicker2, "Pogrešan unos datuma.");
                }
                if (!boolMaticni)
                {
                    errorProvider2.SetError(maskedTextBox1, "Pogrešan matični ili datum rođenja");
                }
                if (!boolPassword)
                {
                    errorProvider3.SetError(textBox6, "Passwordi se ne podudaraju");
                }
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
