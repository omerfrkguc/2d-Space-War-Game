using Microsoft.VisualBasic;

namespace Uzay_Savaslari_Oyunu
{
    public partial class Form1 : Form
    {

        int formYukseklik = 700, formGenislik = 500;

        int Oyuncu_X = 200, Oyuncu_Y = 400;

        int OyuncuHiz_Yatay = 0, OyuncuHiz_Dusey = 0;

        int Puan;

        List<PictureBox> Mermiler = new List<PictureBox>();

        int MermiHiz = 10;

        List<PictureBox> Dusmanlar = new List<PictureBox>();
        int DusmanHiz = 2;
        Random rnd = new Random();



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = formYukseklik;
            this.Width = formGenislik;

            OyuncuGemisi.Parent = pictureBoxGalaxy;
            labelPuan.Parent = pictureBoxGalaxy;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int hiz = 10;
            switch (e.KeyCode)
            {
                case Keys.Left:
                    OyuncuHiz_Yatay -= hiz;
                    if (Oyuncu_X <= 1)
                    {
                        OyuncuHiz_Yatay = 0;

                    }
                    break;
                case Keys.Right:
                    OyuncuHiz_Yatay += hiz;
                    if (Oyuncu_X >= formGenislik)
                    {
                        OyuncuHiz_Yatay = 0;

                    }
                    break;
                case Keys.Up:
                    OyuncuHiz_Dusey -= hiz;
                    if (Oyuncu_Y <= 1)
                    {
                        OyuncuHiz_Dusey = 0;

                    }
                    break;
                case Keys.Down:
                    OyuncuHiz_Dusey += hiz;
                    if (Oyuncu_Y >= formYukseklik)
                    {
                        OyuncuHiz_Dusey = 0;

                    }
                    break;
                case Keys.Enter:
                    Puan = 0;
                    timerOyuncu.Start();
                    timerMermiFirlat.Start();
                    timerDusmanOlustur.Start();
                    timerDusmanDusur.Start();
                    timerMermiKontrol.Start();
                    break;
                case Keys.Space:
                    MermiOlustur();
                    break;
            }
        }



        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left: OyuncuHiz_Yatay = 0; break;
                case Keys.Right: OyuncuHiz_Yatay = 0; break;
                case Keys.Up: OyuncuHiz_Dusey = 0; break;
                case Keys.Down: OyuncuHiz_Dusey = 0; break;
            }
        }

        private void timerOyuncu_Tick(object sender, EventArgs e)
        {
            Oyuncu_X += OyuncuHiz_Yatay;
            Oyuncu_Y += OyuncuHiz_Dusey;
            OyuncuGemisi.Location = new Point(Oyuncu_X, Oyuncu_Y);
        }

        public void MermiOlustur()
        {
            PictureBox Mermi = new PictureBox
            {
                Size = new Size(15, 15),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = Properties.Resources.Laser_08,
                BackColor = Color.Transparent,
            };
            int mermiLocX = OyuncuGemisi.Left + OyuncuGemisi.Width / 2 - 5;
            int mermiLocY = OyuncuGemisi.Top - 1;
            Mermi.Location = new Point(mermiLocX, mermiLocY);
            Controls.Add(Mermi);
            Mermi.Parent = pictureBoxGalaxy;
            Mermi.BringToFront();
            Mermiler.Add(Mermi);

        }
        public void MermileriFirlat()
        {
            for (int i = 0; i < Mermiler.Count; i++)
            {
                Mermiler[i].Top -= MermiHiz;
            }
        }

        private void timerMermiFirlat_Tick(object sender, EventArgs e)
        {
            MermileriFirlat();
        }
        public void DusmanOlustur()
        {
            int yer = rnd.Next(0, formGenislik - 50);
            PictureBox Dusman = new PictureBox
            {
                Size = new Size(50, 50),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = Properties.Resources.Gemi_03,
                BackColor = Color.Transparent,
                Location = new Point(yer, 0),
                Visible = true
            };
            Controls.Add(Dusman);
            Dusman.Parent = pictureBoxGalaxy;
            Dusman.BringToFront();
            Dusmanlar.Add(Dusman);
        }
        public void DusmanDusur()
        {
            for (int i = 0; i < Dusmanlar.Count; i++)
            {
                Dusmanlar[i].Top += DusmanHiz;
                if (Dusmanlar[i].Top >= formYukseklik - 10 ||
                    Dusmanlar[i].Bounds.IntersectsWith(OyuncuGemisi.Bounds))
                {
                     OyunBitir();
                }
            }
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
            for(int m =0; m < Mermiler.Count; m++)
            {
                for (int d =0; d < Dusmanlar.Count; d++)
                {
                    try
                    {
                        if (Mermiler[m].Bounds.IntersectsWith(Dusmanlar[d].Bounds))
                        {
                            Puan += 1;
                            labelPuan.Text = "Puan = " + Puan.ToString();

                            pictureBoxGalaxy.Controls.Remove(Mermiler[m]);
                            Mermiler.Remove(Mermiler[m]);

                            pictureBoxGalaxy.Controls.Remove(Dusmanlar[d]);
                            Dusmanlar.Remove(Dusmanlar[d]);

                            GC.Collect();
                            GC.WaitForPendingFinalizers();
                        }
                    }catch (ArgumentOutOfRangeException ) 
                    {
                        return;
                    }
                    
                }
            }
        }
        public void OyunBitir()
        {
            timerOyuncu.Stop();
            timerMermiFirlat.Stop();
            timerMermiKontrol.Stop();
            timerDusmanOlustur.Stop();
            timerDusmanDusur.Stop();

            MessageBox.Show("Oyun Bitti...");

        }
    }
}