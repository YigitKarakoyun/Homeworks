using BubbleScreenServer.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BubbleScreenServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //-------------------------------TANIMLAMA-------------------------------------------
        
        //SINIFLAR
        c_ImageGetter image = new c_ImageGetter();

        //BALON RESMİ
        Image bubble;

        //EKRAN KORUYUCU SAYMA DEĞİŞKENİ
        int countEkranKoruyucu = 0;
        //-------------------------------------------------------------------------------------

        //İLK YAPILACAKLAR
        private void Form1_Load(object sender, EventArgs e)
        {
            //RESİMLERİ ALMA
            bubble = image.GetBallonImage();
            BackgroundImage = image.GetBackGroundImage();

            //EKRAN KORUYUCU SAYIMINI BAŞLAT
            setTimerSifirla();
            setTimerBaslat();

            //
            PictureBox[] pictureBoxes = getPictureBoxs(2);
            addPictureBoxs(pictureBoxes);
        }
        //-------------------------------------------------------------------------------------
        //EKRAN KORUYUCUYU ÇALIŞTIRMAK
        private void timer1_Tick(object sender, EventArgs e)
        {
            countEkranKoruyucu++;
            if (countEkranKoruyucu > 1)
            {
                WindowState = FormWindowState.Maximized;
                setTimerSifirla();
               
            }
        }
        //-------------------------------------------------------------------------------------
        //EKRAN KORUYUCU TİMER RESETLEME VE DURDURMA YAPAR
        public void setTimerSifirla()
        {
            countEkranKoruyucu = 0;
            timerEkranKoruyucu.Stop();
        }

        //-------------------------------------------------------------------------------------
        //EKRAN KORUYUCU TİMER BAŞLATIR
        public void setTimerBaslat()
        {
            timerEkranKoruyucu.Start();
        }

        //-------------------------------------------------------------------------------------
        //KUCULTME METODU
        private void kucult()
        {
            WindowState = FormWindowState.Minimized;
            setTimerSifirla();
            setTimerBaslat();
        }

        //-------------------------------------------------------------------------------------
        //EKRAN KORUYUCUDAN ÇIKMA
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;

            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                kucult();
            }
        }

        //-------------------------------------------------------------------------------------
        //BALON OLUŞTURMA
        private void timerBalloon_Tick(object sender, EventArgs e)
        {
          
        }

        //BALON OLUŞTURMA
        private PictureBox getPictureBox()
        {
            Image tempImage = image.GetBallonImage();
            PictureBox pictureBox = new PictureBox();
            pictureBox.Width = tempImage.Width;
            pictureBox.Height = tempImage.Height;
            pictureBox.Image = tempImage;
            pictureBox.BackColor = Color.Transparent;
            return pictureBox;
        }
        private PictureBox[] getPictureBoxs(int adet)
        {
            PictureBox[] temp = new PictureBox[adet];
            for (int i = 0; i < adet; i++)
            {
                temp[i] = getPictureBox();
            }
            return temp;
        }
        private void addPictureBoxs(PictureBox[] pictureBoxes)
        {
            foreach (PictureBox item in pictureBoxes)
            {
                Controls.Add(item);
            }
        }
    }
}
