namespace Uzay_Savaslari_Oyunu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBoxGalaxy = new PictureBox();
            OyuncuGemisi = new PictureBox();
            labelPuan = new Label();
            timerOyuncu = new System.Windows.Forms.Timer(components);
            timerMermiFirlat = new System.Windows.Forms.Timer(components);
            timerDusmanDusur = new System.Windows.Forms.Timer(components);
            timerDusmanOlustur = new System.Windows.Forms.Timer(components);
            timerMermiKontrol = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxGalaxy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OyuncuGemisi).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxGalaxy
            // 
            pictureBoxGalaxy.Dock = DockStyle.Fill;
            pictureBoxGalaxy.Image = Properties.Resources.Evren_04;
            pictureBoxGalaxy.Location = new Point(0, 0);
            pictureBoxGalaxy.Name = "pictureBoxGalaxy";
            pictureBoxGalaxy.Size = new Size(800, 497);
            pictureBoxGalaxy.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxGalaxy.TabIndex = 0;
            pictureBoxGalaxy.TabStop = false;
            // 
            // OyuncuGemisi
            // 
            OyuncuGemisi.BackColor = Color.Transparent;
            OyuncuGemisi.Image = Properties.Resources.Gemi_01;
            OyuncuGemisi.Location = new Point(333, 340);
            OyuncuGemisi.Name = "OyuncuGemisi";
            OyuncuGemisi.Size = new Size(125, 85);
            OyuncuGemisi.SizeMode = PictureBoxSizeMode.StretchImage;
            OyuncuGemisi.TabIndex = 1;
            OyuncuGemisi.TabStop = false;
            // 
            // labelPuan
            // 
            labelPuan.AutoSize = true;
            labelPuan.BackColor = Color.Transparent;
            labelPuan.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelPuan.ForeColor = SystemColors.ButtonFace;
            labelPuan.Location = new Point(12, 9);
            labelPuan.Name = "labelPuan";
            labelPuan.Size = new Size(99, 38);
            labelPuan.TabIndex = 2;
            labelPuan.Text = "Puan :";
            labelPuan.Click += label1_Click;
            // 
            // timerOyuncu
            // 
            timerOyuncu.Interval = 1;
            timerOyuncu.Tick += timerOyuncu_Tick;
            // 
            // timerMermiFirlat
            // 
            timerMermiFirlat.Interval = 1;
            timerMermiFirlat.Tick += timerMermiFirlat_Tick;
            // 
            // timerDusmanDusur
            // 
            timerDusmanDusur.Interval = 10;
            timerDusmanDusur.Tick += timerDusmanDusur_Tick;
            // 
            // timerDusmanOlustur
            // 
            timerDusmanOlustur.Interval = 2000;
            timerDusmanOlustur.Tick += timerDusmanOlustur_Tick;
            // 
            // timerMermiKontrol
            // 
            timerMermiKontrol.Tick += timerMermiKontrol_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 497);
            Controls.Add(labelPuan);
            Controls.Add(OyuncuGemisi);
            Controls.Add(pictureBoxGalaxy);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)pictureBoxGalaxy).EndInit();
            ((System.ComponentModel.ISupportInitialize)OyuncuGemisi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxGalaxy;
        private PictureBox OyuncuGemisi;
        private Label labelPuan;
        private System.Windows.Forms.Timer timerOyuncu;
        private System.Windows.Forms.Timer timerMermiFirlat;
        private System.Windows.Forms.Timer timerDusmanDusur;
        private System.Windows.Forms.Timer timerDusmanOlustur;
        private System.Windows.Forms.Timer timerMermiKontrol;
    }
}