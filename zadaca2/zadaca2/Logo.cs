using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadaca1
{
    public partial class Logo : UserControl
    {
        public Logo()
        {
            InitializeComponent();
            
        }

        private void Logo_Paint(object sender, PaintEventArgs e)
        {
            
            SolidBrush b = new SolidBrush(Color.LightSteelBlue);
            Rectangle r = new Rectangle(15, 15, 17, 8);

            e.Graphics.FillRectangle(b, r);
            r.X = 21;
            r.Y = 3;
            r.Width =32;
            r.Height = 30;
            e.Graphics.FillPie(b, r, 90, 180);
            r.X = 40;
            r.Y = 6;
            r.Width = 10;
            r.Height = 4;
            e.Graphics.FillRectangle(b, r);
            r.Y = 16;
            e.Graphics.FillRectangle(b, r);
            r.Y = 26;
            e.Graphics.FillRectangle(b, r);
            r.Width = 26;
            r.X = 58;
            r.Y = 4;
            e.Graphics.FillRectangle(b, r);
            r.X = 69;
            r.Width = 4;
            r.Height = 29;
            e.Graphics.FillRectangle(b, r);
            r.X = 93;
            r.Y = 4;
            e.Graphics.FillRectangle(b, r);
            r.Width = 17;
            r.Height = 4;
            e.Graphics.FillRectangle(b, r);
            r.Y = 14;
            e.Graphics.FillRectangle(b, r);
            e.Graphics.DrawLine(Pens.Black, new Point(15, 15), new Point(15, 23));
            e.Graphics.DrawLine(Pens.Gray, new Point(40, 5), new Point(40, 10));
            e.Graphics.DrawLine(Pens.Gray, new Point(40, 15), new Point(40, 20));
            e.Graphics.DrawLine(Pens.Gray, new Point(40, 25), new Point(40, 30));
            e.Graphics.DrawLine(Pens.Gray, new Point(40, 9), new Point(50, 9));
            e.Graphics.DrawLine(Pens.Gray, new Point(40, 19), new Point(50, 19));
            e.Graphics.DrawLine(Pens.Gray, new Point(40, 29), new Point(50, 29));
            e.Graphics.DrawLine(Pens.Gray, new Point(15, 23), new Point(22, 23));
            e.Graphics.DrawLine(Pens.Gray, new Point(68, 8), new Point(68, 32));
            e.Graphics.DrawLine(Pens.Gray, new Point(57, 4), new Point(57, 8));
            e.Graphics.DrawLine(Pens.Gray, new Point(98, 7), new Point(110, 7));
            e.Graphics.DrawLine(Pens.Gray, new Point(98, 17), new Point(110, 17));
            e.Graphics.DrawLine(Pens.Gray, new Point(93, 33), new Point(98, 33));
            e.Graphics.DrawLine(Pens.Gray, new Point(72, 7), new Point(85, 7));
            e.Graphics.DrawLine(Pens.Gray, new Point(93, 4), new Point(93, 32));
            e.Graphics.DrawLine(Pens.Gray, new Point(68, 7), new Point(68, 33));
            e.Graphics.DrawLine(Pens.Gray, new Point(68, 33), new Point(73, 33));
            e.Graphics.DrawLine(Pens.Gray, new Point(57, 7), new Point(68, 7));
            Pen n = new Pen(Color.Black, 2);
            e.Graphics.DrawLine(n, new Point(15, 15), new Point(22, 15));
            e.Graphics.DrawLine(n, new Point(40, 5), new Point(50, 5));
            e.Graphics.DrawLine(n, new Point(40, 15), new Point(50, 15));
            e.Graphics.DrawLine(n, new Point(40, 25), new Point(50, 25));
            e.Graphics.DrawLine(n, new Point(57, 3), new Point(85, 3));
            e.Graphics.DrawLine(n, new Point(86, 2), new Point(86, 7));
            e.Graphics.DrawLine(n, new Point(73, 8), new Point(73, 33));
            e.Graphics.DrawLine(n, new Point(110, 3), new Point(110, 7));
            e.Graphics.DrawLine(n, new Point(98, 7), new Point(98, 15));
            e.Graphics.DrawLine(n, new Point(98, 14), new Point(110, 14));
            e.Graphics.DrawLine(n, new Point(93, 3), new Point(111, 3));
            e.Graphics.DrawLine(n, new Point(110, 13), new Point(110, 18));
            e.Graphics.DrawLine(n, new Point(98, 17), new Point(98, 33));
            e.Graphics.DrawLine(n, new Point(50, 5), new Point(50, 10));
            e.Graphics.DrawLine(n, new Point(50, 15), new Point(50, 20));
            e.Graphics.DrawLine(n, new Point(50, 25), new Point(50, 30));
            e.Graphics.DrawLine(n, new Point(37, 4), new Point(37, 33));
            r.X = 20;
            r.Y = 2;
            r.Width = 32;
            r.Height = 30;
            e.Graphics.DrawArc(Pens.Gray, r, 90, 70);
            r.Y = 3;
            r.Width = 32;
            r.Height = 30;
            e.Graphics.DrawArc(n, r, 190, 80);
        }

        private void Logo_Load(object sender, EventArgs e)
        {

        }
    }
}
