using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Uzay_Savaşları_Oyunu
{
    public partial class Form1 : Form
    {
        int formYukseklik = 700, formGenislik = 500;
        int Oyuncu_X = 200, Oyuncu_Y = 400;//Oyuncu koordinatlar
        int OyuncuHiz_Yatay =0, OyuncuHiz_Dusey = 0;
        int Puan ;

        List<PictureBox> Mermiler = new List<PictureBox>();

        int MermiHiz = 20;

        List<PictureBox> Dusmanlar = new List<PictureBox>();
        int DusmanHiz = 2;
        Random rnd= new Random();


        public Form1()
        {
            InitializeComponent();
        }

        private void timerOyuncu_Tick(object sender, EventArgs e)
        {
            Oyuncu_X += OyuncuHiz_Yatay;
            Oyuncu_Y += OyuncuHiz_Dusey;
            OyuncuGemisi.Location = new Point(Oyuncu_X, Oyuncu_Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = formYukseklik;
            this.Width= formGenislik;
            //Objelerimizi Galaxy içine alıyoruz.
            OyuncuGemisi.Parent = Galaxy;
            LabelPuan.Parent= Galaxy;
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int hiz = 2;
            switch (e.KeyCode)
            {
                case Keys.Left:OyuncuHiz_Yatay -= hiz;
                    break;
                case Keys.Right:OyuncuHiz_Yatay += hiz;
                    break;
                case Keys.Up:OyuncuHiz_Dusey   -= hiz;
                    break;
                case Keys.Down:OyuncuHiz_Dusey+= hiz;
                    break;                

                    case Keys.Enter:
                    Puan = 0;
                    timerOyuncu.Start();
                    timerDusmanOlustur.Start();
                    timerDusmanDusur.Start();
                    timerMermiFirlat.Start();
                    timerMermiKontrol.Start();
                    break;

                    case Keys.Space:
                    MermiOlustur();
                    break;
            }

        }

        private void timerMermiFirlat_Tick(object sender, EventArgs e)
        {
            MermileriFirlat();

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    OyuncuHiz_Yatay = 0;
                    break;
                case Keys.Right:
                    OyuncuHiz_Yatay = 0;
                    break;
                case Keys.Up:
                    OyuncuHiz_Dusey = 0;
                    break;
                case Keys.Down:
                    OyuncuHiz_Dusey = 0;
                    break;
            }

        }

        public void MermiOlustur() 
        {
            PictureBox Mermi = new PictureBox
            {
                Size = new Size(15, 15),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = Properties.Resources.Laser_08,
                BackColor = Color.Transparent
            };
            int MermiLocX = OyuncuGemisi.Left + OyuncuGemisi.Width/ 2 - 5;
            int MermiLocY = OyuncuGemisi.Top - 1 ;
            Mermi.Location = new Point(MermiLocX, MermiLocY );
            Controls.Add( Mermi );
            Mermi.Parent = Galaxy;
            Mermi.BringToFront(); //Galaxy resminin üstüne çıkartıyoruz.
            Mermiler.Add( Mermi );
        }

        private void timerDusmanDusur_Tick(object sender, EventArgs e)
        {
            DusmanDusur();
        }

        private void timerDusmanOlustur_Tick(object sender, EventArgs e)
        {
            DusmanOlustur();
        }

        private void timerMermiKontrol_Tick(object sender, EventArgs e)
        {
            for (int m = 0; m < Mermiler.Count; m++)
            {
                for (int d = 0; d < Dusmanlar.Count; d++)
                {
                    //mermi ile düşman çarpıştı mı?
                    if (Mermiler[m].Bounds.IntersectsWith(Dusmanlar[d].Bounds))
                    {
                        Puan += 1;
                        LabelPuan.Text = "Puan=" +Puan.ToString();

                        Galaxy.Controls.Remove(Mermiler[m]);
                        Mermiler.Remove(Mermiler[m]);

                        Galaxy.Controls.Remove(Dusmanlar[d]);
                        Dusmanlar.Remove(Dusmanlar[d]);

                        //RAM hafıza temizleme
                        GC.Collect();//Çöp toplayıcısı
                        GC.WaitForPendingFinalizers();//Çöpleri yok et
                    }
                }
            }
        }

        public void MermileriFirlat() 
        {
            for (int i = 0; i < Mermiler.Count; i++)
            {
                Mermiler[i].Top -= MermiHiz;
            }
        }

        private void Galaxy_Click(object sender, EventArgs e)
        {

        }

        public void DusmanOlustur() 
        {
            int yer = rnd.Next(0,formGenislik - 50);
            PictureBox Dusman = new PictureBox
            {
                Size = new Size(50, 50),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = Properties.Resources.Gemi_03,
                BackColor = Color.Transparent,
                Location = new Point(yer, 0),
                Visible = true
            };
            Controls.Add( Dusman );// forma ekledik
            Dusman.Parent= Galaxy;// Galaxy içine aldık
            Dusman.BringToFront();// öne getirdik
            Dusmanlar.Add(Dusman);
        }

        public void DusmanDusur() 
        {
            for (int i = 0; i < Dusmanlar.Count; i++)
            {
                Dusmanlar[i].Top += DusmanHiz;
                //Düşman gemisi formun dışına çıkarsa
                //Oyuncunun gemisine çarparsa
                if (Dusmanlar[i].Top >= formYukseklik - 10 || Dusmanlar[i].Bounds.IntersectsWith(OyuncuGemisi.Bounds))
                {
                    //oyun bitti
                    OyunBitir();
                }
            }
        }


        public void OyunBitir() 
        {
            timerOyuncu.Stop();
            timerMermiFirlat.Stop();
            timerDusmanDusur.Stop();
            timerMermiKontrol.Stop();
            timerDusmanOlustur.Stop();

            MessageBox.Show("Oyun Bitti,İşinin başına...!");
        }
    }


}
