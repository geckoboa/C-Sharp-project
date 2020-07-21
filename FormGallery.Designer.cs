namespace AplikacijaZaPrikazGalerijeSlika
{
    partial class FormGallery
    {
        
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        
        private void InitializeComponent()
        {
            this.labela = new System.Windows.Forms.Label();
            this.buttonPretrazivanje = new System.Windows.Forms.Button();
            this.datotekaPretrage = new System.Windows.Forms.FolderBrowserDialog();
            this.listaPregleda = new System.Windows.Forms.ListView();
            this.imeSlike = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.putanjaSlike = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDijaprojekcija = new System.Windows.Forms.Button();
            
            this.SuspendLayout();
            // 
            // labela
            // 
            this.labela.AutoSize = true;
            this.labela.Location = new System.Drawing.Point(250, 13);
            this.labela.Name = "labela";
            this.labela.Size = new System.Drawing.Size(86, 13);
            this.labela.TabIndex = 0;
            this.labela.Text = "Odabrana datoteka:";
            // 
            // buttonPretrazivanje
            // 
            this.buttonPretrazivanje.Location = new System.Drawing.Point(170, 50);
            this.buttonPretrazivanje.Name = "buttonPretrazivanje";
            this.buttonPretrazivanje.Size = new System.Drawing.Size(75, 25);
            this.buttonPretrazivanje.TabIndex = 1;
            this.buttonPretrazivanje.Text = "Pretraga";
            this.buttonPretrazivanje.UseVisualStyleBackColor = true;
            this.buttonPretrazivanje.Click += new System.EventHandler(this.datotekaPretrage_Click);
            // 
            
            // listaPregleda
            // 
            this.listaPregleda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.imeSlike,
            this.putanjaSlike});
            this.listaPregleda.FullRowSelect = true;
            this.listaPregleda.GridLines = true;
            this.listaPregleda.HideSelection = false;
            this.listaPregleda.Location = new System.Drawing.Point(67, 98);
            this.listaPregleda.Name = "listaPregleda";
            this.listaPregleda.Size = new System.Drawing.Size(575, 340);
            this.listaPregleda.TabIndex = 3;
            this.listaPregleda.UseCompatibleStateImageBehavior = false;
            this.listaPregleda.View = System.Windows.Forms.View.Details;
            this.listaPregleda.DoubleClick += new System.EventHandler(this.listaPregleda_Click);
            // 
            // imeSlike
            // 
            this.imeSlike.Text = "Naziv slike";
            this.imeSlike.Width = 91;
            // 
            // putanjaSlike
            // 
            this.putanjaSlike.Text = "Putanja";
            this.putanjaSlike.Width = 575;
            // 
            // buttonDijaprojekcija
            // 
            this.buttonDijaprojekcija.Enabled = false;
            this.buttonDijaprojekcija.Location = new System.Drawing.Point(350, 50);
            this.buttonDijaprojekcija.Name = "buttonDijaprojekcija";
            this.buttonDijaprojekcija.Size = new System.Drawing.Size(85, 25);
            this.buttonDijaprojekcija.TabIndex = 4;
            this.buttonDijaprojekcija.Text = "Dijaprojekcija";
            this.buttonDijaprojekcija.UseVisualStyleBackColor = true;
            this.buttonDijaprojekcija.Click += new System.EventHandler(this.dijaprojekcija_Click);
            
            // 
            // FormGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.buttonDijaprojekcija);
            this.Controls.Add(this.listaPregleda);
            this.Controls.Add(this.buttonPretrazivanje);
            this.Controls.Add(this.labela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGallery";
            this.Tag = "";
            this.Text = "Prikaz slika iz galerije";
            this.Activated += new System.EventHandler(this.FormaGalerije_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labela;
        private System.Windows.Forms.FolderBrowserDialog datotekaPretrage;
        private System.Windows.Forms.ListView listaPregleda;
        private System.Windows.Forms.ColumnHeader imeSlike;
        private System.Windows.Forms.ColumnHeader putanjaSlike;
        private System.Windows.Forms.Button buttonPretrazivanje;
        private System.Windows.Forms.Button buttonDijaprojekcija;
        
    }
}

