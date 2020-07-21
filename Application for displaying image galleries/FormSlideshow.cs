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
    public partial class FormSlideshow : Form
    {
          

        public FormSlideshow()
        {
            InitializeComponent();
        }

        public ListViewItem[] listViewItems { get; set; }
        private int prikazanaSlika { get; set; }
        private string lokacijaDatoteke { get; set; }

        private void Dijaprojekcija_Load(object sender, EventArgs e)
        {
            prikazanaSlika = 0;
            lokacijaDatoteke = listViewItems[prikazanaSlika].SubItems[1].Text;
            Bitmap bmp = new Bitmap(lokacijaDatoteke);
            prikazSlike.Image = bmp;
            this.labelCurrentIndex.Text = (prikazanaSlika + 1).ToString();
            this.labelLastIndex.Text = listViewItems.Length.ToString();
        }

        private void checkBoxDijaprojekcija_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDijaprojekcija.Checked)
            {
                brojac.Enabled = true;
                buttonSljedecaSlika.Enabled = false;
                buttonPrethodnaSlika.Enabled = false;
            }
            else
            {
                brojac.Enabled = false;
                buttonSljedecaSlika.Enabled = true;
                buttonPrethodnaSlika.Enabled = true;
            }
        }

        private void buttonSljedecaSlika_Click(object sender, EventArgs e)
        {
            if (prikazanaSlika < (listViewItems.Length - 1))
            {
                prikazanaSlika++;
            }
            else prikazanaSlika = 0;

            lokacijaDatoteke = listViewItems[prikazanaSlika].SubItems[1].Text;
            Bitmap bmp = new Bitmap(lokacijaDatoteke);
            prikazSlike.Image = bmp;
            this.labelCurrentIndex.Text = (prikazanaSlika + 1).ToString();
        }

        private void brojac_Tick(object sender, EventArgs e)
        {
            buttonSljedecaSlika_Click(sender, e);
        }

        private void buttonPrethodnaSlika_Click(object sender, EventArgs e)
        {
            if (prikazanaSlika > 0)
            {
                prikazanaSlika--;
            }
            else prikazanaSlika = listViewItems.Length - 1;

            lokacijaDatoteke = listViewItems[prikazanaSlika].SubItems[1].Text;
            Bitmap bmp = new Bitmap(lokacijaDatoteke);
            prikazSlike.Image = bmp;
            this.labelCurrentIndex.Text = (prikazanaSlika + 1).ToString();
        }

    }
}
