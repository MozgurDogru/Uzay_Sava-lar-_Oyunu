namespace Uzay_Savaşları_Oyunu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Galaxy = new System.Windows.Forms.PictureBox();
            this.OyuncuGemisi = new System.Windows.Forms.PictureBox();
            this.LabelPuan = new System.Windows.Forms.Label();
            this.timerOyuncu = new System.Windows.Forms.Timer(this.components);
            this.timerMermiFirlat = new System.Windows.Forms.Timer(this.components);
            this.timerDusmanDusur = new System.Windows.Forms.Timer(this.components);
            this.timerDusmanOlustur = new System.Windows.Forms.Timer(this.components);
            this.timerMermiKontrol = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Galaxy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OyuncuGemisi)).BeginInit();
            this.SuspendLayout();
            // 
            // Galaxy
            // 
            this.Galaxy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Galaxy.Image = global::Uzay_Savaşları_Oyunu.Properties.Resources.Evren_04__1_;
            this.Galaxy.Location = new System.Drawing.Point(0, 0);
            this.Galaxy.Name = "Galaxy";
            this.Galaxy.Size = new System.Drawing.Size(472, 588);
            this.Galaxy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Galaxy.TabIndex = 0;
            this.Galaxy.TabStop = false;
            this.Galaxy.Click += new System.EventHandler(this.Galaxy_Click);
            // 
            // OyuncuGemisi
            // 
            this.OyuncuGemisi.BackColor = System.Drawing.Color.Transparent;
            this.OyuncuGemisi.Image = global::Uzay_Savaşları_Oyunu.Properties.Resources.Gemi_01;
            this.OyuncuGemisi.Location = new System.Drawing.Point(184, 419);
            this.OyuncuGemisi.Name = "OyuncuGemisi";
            this.OyuncuGemisi.Size = new System.Drawing.Size(92, 69);
            this.OyuncuGemisi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OyuncuGemisi.TabIndex = 1;
            this.OyuncuGemisi.TabStop = false;
            // 
            // LabelPuan
            // 
            this.LabelPuan.AutoSize = true;
            this.LabelPuan.BackColor = System.Drawing.Color.Transparent;
            this.LabelPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelPuan.ForeColor = System.Drawing.Color.White;
            this.LabelPuan.Location = new System.Drawing.Point(12, 9);
            this.LabelPuan.Name = "LabelPuan";
            this.LabelPuan.Size = new System.Drawing.Size(85, 24);
            this.LabelPuan.TabIndex = 2;
            this.LabelPuan.Text = "Puan = 0";
            // 
            // timerOyuncu
            // 
            this.timerOyuncu.Interval = 2;
            this.timerOyuncu.Tick += new System.EventHandler(this.timerOyuncu_Tick);
            // 
            // timerMermiFirlat
            // 
            this.timerMermiFirlat.Interval = 10;
            this.timerMermiFirlat.Tick += new System.EventHandler(this.timerMermiFirlat_Tick);
            // 
            // timerDusmanDusur
            // 
            this.timerDusmanDusur.Interval = 50;
            this.timerDusmanDusur.Tick += new System.EventHandler(this.timerDusmanDusur_Tick);
            // 
            // timerDusmanOlustur
            // 
            this.timerDusmanOlustur.Interval = 5000;
            this.timerDusmanOlustur.Tick += new System.EventHandler(this.timerDusmanOlustur_Tick);
            // 
            // timerMermiKontrol
            // 
            this.timerMermiKontrol.Tick += new System.EventHandler(this.timerMermiKontrol_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 588);
            this.Controls.Add(this.LabelPuan);
            this.Controls.Add(this.OyuncuGemisi);
            this.Controls.Add(this.Galaxy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Galaxy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OyuncuGemisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Galaxy;
        private System.Windows.Forms.PictureBox OyuncuGemisi;
        private System.Windows.Forms.Label LabelPuan;
        private System.Windows.Forms.Timer timerOyuncu;
        private System.Windows.Forms.Timer timerMermiFirlat;
        private System.Windows.Forms.Timer timerDusmanDusur;
        private System.Windows.Forms.Timer timerDusmanOlustur;
        private System.Windows.Forms.Timer timerMermiKontrol;
    }
}

