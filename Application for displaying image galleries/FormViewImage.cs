using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacijaZaPrikazGalerijeSlika
{
    public partial class FormViewImage : Form
    {
        public string lokacijaDatoteke { get; set; }

        public FormViewImage()
        {
            InitializeComponent();
        }

       

        private void ViewImageForm_Load(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(@lokacijaDatoteke);
            prikazSlike.Image = bmp;
        }
    }
}
