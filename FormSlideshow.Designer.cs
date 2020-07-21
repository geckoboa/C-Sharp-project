namespace AplikacijaZaPrikazGalerijeSlika
{
    partial class FormSlideshow
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.prikazSlike = new System.Windows.Forms.PictureBox();
            this.radioButtonBrziSlide = new System.Windows.Forms.RadioButton();
            this.radioButtonSporijiSlide = new System.Windows.Forms.RadioButton();
            this.checkBoxDijaprojekcija = new System.Windows.Forms.CheckBox();
            this.labelLastIndex = new System.Windows.Forms.Label();
            this.labela = new System.Windows.Forms.Label();
            this.labelCurrentIndex = new System.Windows.Forms.Label();
            this.buttonSljedecaSlika = new System.Windows.Forms.Button();
            this.buttonPrethodnaSlika = new System.Windows.Forms.Button();
            this.brojac = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prikazSlike)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.prikazSlike);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.radioButtonBrziSlide);
            this.splitContainer.Panel2.Controls.Add(this.radioButtonSporijiSlide);
            this.splitContainer.Panel2.Controls.Add(this.labelLastIndex);
            this.splitContainer.Panel2.Controls.Add(this.checkBoxDijaprojekcija);
            this.splitContainer.Panel2.Controls.Add(this.labela);
            this.splitContainer.Panel2.Controls.Add(this.labelCurrentIndex);
            this.splitContainer.Panel2.Controls.Add(this.buttonSljedecaSlika);
            this.splitContainer.Panel2.Controls.Add(this.buttonPrethodnaSlika);
            this.splitContainer.Size = new System.Drawing.Size(1143, 634);
            this.splitContainer.SplitterDistance = 540;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 0;
            // 
            // prikazSlike
            // 
            this.prikazSlike.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prikazSlike.Location = new System.Drawing.Point(0, 0);
            this.prikazSlike.Name = "prikazSlike";
            this.prikazSlike.Size = new System.Drawing.Size(1143, 540);
            this.prikazSlike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.prikazSlike.TabIndex = 0;
            this.prikazSlike.TabStop = false;
            // 
            // radioButtonBrziSlide
            // 
            this.radioButtonBrziSlide.AutoSize = true;
            this.radioButtonBrziSlide.Location = new System.Drawing.Point(226, 54);
            this.radioButtonBrziSlide.Name = "radioButtonBrziSlide";
            this.radioButtonBrziSlide.Size = new System.Drawing.Size(66, 17);
            this.radioButtonBrziSlide.TabIndex = 7;
            this.radioButtonBrziSlide.Tag = "1500";
            this.radioButtonBrziSlide.Text = "Brzi slide";
            this.radioButtonBrziSlide.UseVisualStyleBackColor = true;
           
            // 
            // radioButtonSporijiSlide
            // 
            this.radioButtonSporijiSlide.AutoSize = true;
            this.radioButtonSporijiSlide.Location = new System.Drawing.Point(108, 54);
            this.radioButtonSporijiSlide.Name = "radioButtonSporijiSlide";
            this.radioButtonSporijiSlide.Size = new System.Drawing.Size(77, 17);
            this.radioButtonSporijiSlide.TabIndex = 7;
            this.radioButtonSporijiSlide.Tag = "2500";
            this.radioButtonSporijiSlide.Text = "Sporiji slide";
            this.radioButtonSporijiSlide.UseVisualStyleBackColor = true;
            
            // 
            // checkBoxDijaprojekcija
            // 
            this.checkBoxDijaprojekcija.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBoxDijaprojekcija.AutoSize = true;
            this.checkBoxDijaprojekcija.Location = new System.Drawing.Point(155, 22);
            this.checkBoxDijaprojekcija.Name = "checkBoxDijaprojekcija";
            this.checkBoxDijaprojekcija.Size = new System.Drawing.Size(114, 17);
            this.checkBoxDijaprojekcija.TabIndex = 5;
            this.checkBoxDijaprojekcija.Text = "Start Dijaprojekcije";
            this.checkBoxDijaprojekcija.UseVisualStyleBackColor = true;
            this.checkBoxDijaprojekcija.CheckedChanged += new System.EventHandler(this.checkBoxDijaprojekcija_CheckedChanged);
            // 
            // labelLastIndex
            // 
            this.labelLastIndex.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLastIndex.AutoSize = true;
            this.labelLastIndex.BackColor = System.Drawing.Color.MediumPurple;
            this.labelLastIndex.Location = new System.Drawing.Point(607, 44);
            this.labelLastIndex.Name = "labelLastIndex";
            this.labelLastIndex.Size = new System.Drawing.Size(12, 13);
            this.labelLastIndex.TabIndex = 4;
            this.labelLastIndex.Text = "broj";
            // 
            // labela
            // 
            this.labela.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labela.AutoSize = true;
            this.labela.Location = new System.Drawing.Point(589, 44);
            this.labela.Name = "labela";
            this.labela.Size = new System.Drawing.Size(12, 13);
            this.labela.TabIndex = 3;
            this.labela.Text = "/";
            // 
            // labelCurrentIndex
            // 
            this.labelCurrentIndex.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCurrentIndex.AutoSize = true;
            this.labelCurrentIndex.Location = new System.Drawing.Point(570, 44);
            this.labelCurrentIndex.Name = "labelCurrentIndex";
            this.labelCurrentIndex.Size = new System.Drawing.Size(12, 13);
            this.labelCurrentIndex.TabIndex = 2;
            this.labelCurrentIndex.Text = "broj";
            // 
            // buttonSljedecaSlika
            // 
            this.buttonSljedecaSlika.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSljedecaSlika.Location = new System.Drawing.Point(661, 32);
            this.buttonSljedecaSlika.Name = "buttonSljedecaSlika";
            this.buttonSljedecaSlika.Size = new System.Drawing.Size(49, 37);
            this.buttonSljedecaSlika.TabIndex = 1;
            this.buttonSljedecaSlika.Text = "->";
            this.buttonSljedecaSlika.UseVisualStyleBackColor = true;
            this.buttonSljedecaSlika.Click += new System.EventHandler(this.buttonSljedecaSlika_Click);
            // 
            // buttonPrethodnaSlika
            // 
            this.buttonPrethodnaSlika.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPrethodnaSlika.Location = new System.Drawing.Point(480, 32);
            this.buttonPrethodnaSlika.Name = "buttonPrethodnaSlika";
            this.buttonPrethodnaSlika.Size = new System.Drawing.Size(49, 37);
            this.buttonPrethodnaSlika.TabIndex = 0;
            this.buttonPrethodnaSlika.Text = "<-";
            this.buttonPrethodnaSlika.UseVisualStyleBackColor = true;
            this.buttonPrethodnaSlika.Click += new System.EventHandler(this.buttonPrethodnaSlika_Click);
            // 
            // brojac
            // 
            this.brojac.Interval = 3000;
            this.brojac.Tick += new System.EventHandler(this.brojac_Tick);
            // 
            // FormSlideshow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1143, 634);
            this.Controls.Add(this.splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "FormSlideshow";
            this.Text = "Dijaprojekcija";
            this.Load += new System.EventHandler(this.Dijaprojekcija_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prikazSlike)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.PictureBox prikazSlike;   
        private System.Windows.Forms.Label labelCurrentIndex;
        private System.Windows.Forms.Label labelLastIndex;
        private System.Windows.Forms.Label labela;
        private System.Windows.Forms.CheckBox checkBoxDijaprojekcija;
        private System.Windows.Forms.Timer brojac;
        private System.Windows.Forms.RadioButton radioButtonBrziSlide;
        private System.Windows.Forms.RadioButton radioButtonSporijiSlide;
        private System.Windows.Forms.Button buttonSljedecaSlika;
        private System.Windows.Forms.Button buttonPrethodnaSlika;
    }
}