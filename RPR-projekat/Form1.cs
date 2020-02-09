using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Zadaca1
{
    public partial class FormaPrijava : Form
    {
        Fakultet fakultet;
        public FormaPrijava(Fakultet f)
        {
            InitializeComponent();
            fakultet = f;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Font f1 = new Font("Showcard Gothic", 12, FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);
            e.Graphics.DrawString("Dobrodošli", f1 , new SolidBrush(ForeColor), 150,10);

            System.Drawing.Graphics mojGrafickiObjekat;
            mojGrafickiObjekat = this.CreateGraphics();
            Pen mojPen = new Pen(System.Drawing.Color.Blue, 5);     
            mojPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            SolidBrush mojBrush = new SolidBrush(System.Drawing.Color.AntiqueWhite);
            Rectangle elipsaPravougaonik = new Rectangle(20, 20, 250, 200);
            mojGrafickiObjekat.DrawEllipse(mojPen, elipsaPravougaonik);
            mojGrafickiObjekat.FillEllipse(mojBrush, 10, 10, 100, 50);
        }
        private void tabPage1_Paint(object sender, PaintEventArgs e)
        {
            Font f1 = new Font("Showcard Gothic", 12, FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);
            e.Graphics.DrawString("Dobrodošli", f1, new SolidBrush(ForeColor), 145, 10);

            Pen mojPen = new Pen(System.Drawing.Color.Blue, 8);
            SolidBrush mojBrush = new SolidBrush(System.Drawing.Color.White);
            Point[] polygonTacke = new Point[4];
            polygonTacke[0] = new Point(250, 50);
            polygonTacke[1] = new Point(150, 50);
            polygonTacke[2] = new Point(250, 150);
            polygonTacke[3] = new Point(150, 150);

            e.Graphics.DrawPolygon(mojPen, polygonTacke);
            e.Graphics.DrawLines(mojPen, polygonTacke);
            e.Graphics.FillPolygon(mojBrush, polygonTacke);
            e.Graphics.DrawString(" ETF", new Font("Times New Roman", 10, FontStyle.Regular), new SolidBrush(Color.Blue), 182, 65);
            e.Graphics.DrawString("17296", new Font("Times New Roman", 10, FontStyle.Regular), new SolidBrush(Color.Blue), 182, 125);


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pw = textBox2.Text;
            string pravi = fakultet.CalculateMD5Hash(pw);
            try
            {
                Student s = fakultet.NadjiStudentaSaUsername(user);
                string passStud = s.Password;
                if (passStud == pravi)
                {
                    Form2 studentskaForma = new Form2(fakultet, user, s);
                    studentskaForma.ShowDialog();
                    errorProvider1.Clear();
                    errorProvider2.Clear();
                }
                else
                {
                    throw new Exception("Pogrešan password");
                }
            }
            catch (Exception izuzetak)
            {
                errorProvider1.SetError(textBox1, izuzetak.Message);
            }

            try
            {
                Uposlenik u = fakultet.NadjiUposlenikaSaUsername(user);
                string passUpos = u.Password;
                if (passUpos == pravi)
                {
                    Form3 uposlenickaForma = new Form3(fakultet, user,u);
                    uposlenickaForma.ShowDialog();
                    errorProvider1.Clear();
                    errorProvider2.Clear();
                }
                else
                {
                    throw new Exception("Pogrešan password");
                }
            }
            catch (Exception izuzetak)
            {
                errorProvider1.SetError(textBox1, izuzetak.Message);
            }
            if (user == fakultet.UsernameAdmina && pravi == fakultet.CalculateMD5Hash("admin"))
            {
                Form4 adminForma = new Form4(fakultet,user);
                adminForma.ShowDialog();
                errorProvider1.Clear();
                errorProvider2.Clear();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            errorProvider2.Clear();
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            if (textBox1.Text == "") errorProvider1.SetError(textBox1, "Nije uneseno ime");
            else { errorProvider1.Clear(); }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            if(textBox2.Text=="") errorProvider2.SetError(textBox2, "Nije unesen password");
            else { errorProvider2.Clear(); }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void prikažiPwToolStripMenuItem_Click(object sender, EventArgs e)
        {

            textBox2.PasswordChar = default(char);
        }

        private void sakrijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.PasswordChar ='*';
        }
    }
}