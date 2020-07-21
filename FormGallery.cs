using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacijaZaPrikazGalerijeSlika
{
    public partial class FormGallery : Form
    {
        public FormGallery()
        {
            InitializeComponent();
        }

        private void datotekaPretrage_Click(object sender, EventArgs e)
        {
            if (datotekaPretrage.ShowDialog() == DialogResult.OK)
            {
                bool postojiSlike = false;
                buttonDijaprojekcija.Enabled = false;
                listaPregleda.Items.Clear();
                string[] slike = Directory.GetFiles(datotekaPretrage.SelectedPath, "*.*", SearchOption.AllDirectories);              

                for (int i = 0; i < slike.Length; i++)
                {
                    
                    string fileName = Path.GetFileName(slike[i]);
                    if (Regex.IsMatch(fileName, @".jpg|.jpeg|.gif$"))
                    {
                        ListViewItem listaItem = new ListViewItem(fileName);
                        listaItem.SubItems.Add(slike[i]);
                        listaPregleda.Items.Add(listaItem);
                        postojiSlike = true;
                    }
                }
                
                labela.Text = datotekaPretrage.SelectedPath;

                if (postojiSlike)
                {
                    this.buttonDijaprojekcija.Enabled = true;
                }
            }
        }

        private void listaPregleda_Click(object sender, EventArgs e)
        {
            var odabraniItem = listaPregleda.SelectedItems[0];
            
            List<Form> listaForme = new List<Form>();

            foreach (Form forma in Application.OpenForms)
            {
                if (forma.GetType() == typeof(FormViewImage))
                {
                    listaForme.Add(forma);
                }
            }

            foreach (Form forma in Application.OpenForms)
            {
                if (forma.Tag.ToString() == odabraniItem.SubItems[1].Text)
                {
                    forma.Focus();
                    return;
                }
            }

            FormViewImage viewImageForm = new FormViewImage();
            viewImageForm.lokacijaDatoteke = odabraniItem.SubItems[1].Text;
            viewImageForm.Tag = odabraniItem.SubItems[1].Text;
            viewImageForm.Show();
        }

        private void dijaprojekcija_Click(object sender, EventArgs e)
        {
            FormSlideshow slideshow = new FormSlideshow();
            slideshow.Owner = this;
            slideshow.listViewItems = new ListViewItem[listaPregleda.Items.Count];
            listaPregleda.Items.CopyTo(slideshow.listViewItems, 0);
            slideshow.ShowDialog();
        }

        

        private void FormaGalerije_Activated(object sender, EventArgs e)
        {
            Application.OpenForms["FormGallery"].BringToFront();       
        }
    }
}
