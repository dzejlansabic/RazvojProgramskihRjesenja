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
    public partial class FormaSlika : UserControl
    {
        public FormaSlika()
        {
            InitializeComponent();
        }
        private void dodajSliku_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Izaberite sliku";
                dlg.Filter = "jpg files (*.jpg)|*.jpg";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    slika.Image = new Bitmap(dlg.FileName);
                }
            }
        }
        public Image dajSliku()
        {
            return slika.BackgroundImage;
        }
        public DateTime dajDatum()
        {
            return dateTimePicker1.Value;
        }
        
    }
}
