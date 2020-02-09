using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Zadaca1
{
    public partial class Form5 : Form
    {
        Fakultet f;
        string username;
        public Form5(Fakultet faks, string user)
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
                groupBox5.Visible = true;
            }
            else if(radioButton3.Checked)
            groupBox5.Visible = false;
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
            bool registrovan = false;
           if(radioButton3.Checked)
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
                    StudentBachelor sb = new StudentBachelor(textBox1.Text, textBox2.Text, maskedTextBox1.Text, dateTimePicker1.Value, dateTimePicker2.Value, textBox4.Text, textBox5.Text);
                    f.RegistrujStudenta(sb);
                    registrovan = true;
                    statusStrip1.Visible = true;
                    toolStripStatusLabel1.Text = "Student Bachelor je uspješno registrovan.";
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
           else if(radioButton4.Checked)
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
                    StudentMaster sm = new StudentMaster(textBox1.Text, textBox2.Text, maskedTextBox1.Text, dateTimePicker1.Value, dateTimePicker2.Value, dateTimePicker3.Value, textBox7.Text, textBox4.Text, textBox5.Text);
                    f.RegistrujStudenta(sm);
                    registrovan = true;
                    statusStrip1.Visible = true;
                    toolStripStatusLabel1.Text = "Student Master je uspješno registrovan.";
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
           if(!registrovan)
            {
                statusStrip1.Visible = true;
                toolStripStatusLabel1.Text = "GREŠKA! Student nije uspješno registrovan.";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                groupBox5.Visible = true;
            }
            else if (radioButton3.Checked)
                groupBox5.Visible = false;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student st = BuildStudent();
            XmlSerializer xs = new XmlSerializer(typeof(Student));
            SaveFileDialog sfd = new SaveFileDialog() { FileName = "student.xml", AddExtension = true, DefaultExt = "xml", };
            if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName.EndsWith(".xml"))
            {
                using (Stream s = File.Create(sfd.FileName))
                    xs.Serialize(s, st); 
        }
    }
        private Student BuildStudent()
        {
            if (radioButton3.Checked==true) {
                StudentBachelor s = new StudentBachelor(textBox1.Text, textBox2.Text, maskedTextBox1.Text, dateTimePicker1.Value, dateTimePicker2.Value, textBox4.Text, textBox5.Text);
                return s;
            }
            else
            {
                StudentMaster sm = new StudentMaster(textBox1.Text, textBox2.Text, maskedTextBox1.Text, dateTimePicker1.Value, dateTimePicker2.Value, dateTimePicker3.Value, textBox7.Text, textBox4.Text, textBox5.Text);
                return sm;
            }
        }
    }
}
