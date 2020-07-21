namespace AplikacijaZaPrikazGalerijeSlika
{
    partial class FormViewImage
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
            this.prikazSlike = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.prikazSlike)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.prikazSlike.BackColor = System.Drawing.Color.MediumPurple;
            this.prikazSlike.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prikazSlike.Location = new System.Drawing.Point(0, 0);
            this.prikazSlike.Name = "prikazSlike";
            this.prikazSlike.Size = new System.Drawing.Size(800, 450);
            this.prikazSlike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.prikazSlike.TabIndex = 0;
            this.prikazSlike.TabStop = false;
            // 
            // FormViewImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prikazSlike);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "prikazSlike";
            this.Text = "Prikaz Slike";
            this.Load += new System.EventHandler(this.ViewImageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prikazSlike)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox prikazSlike;
    }
}