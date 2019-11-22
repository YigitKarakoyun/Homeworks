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
        c_Random random = new c_Random();
        Random rnd = new Random();

        //BALON RESMİ
        Image bubble;
        PictureBox balon;


        //EKRAN KORUYUCU SAYMA DEĞİŞKENİ
        int countEkranKoruyucu = 0;
        //-------------------------------------------------------------------------------------

        //İLK YAPILACAKLAR
        private void Form1_Load(object sender, EventArgs e)
        {
            //RESİMLERİ ALMA
            bubble = image.GetBallonImage();
            BackgroundImage = image.GetBackGroundImage();

            balon = getBalonOlustur();

            //EKRAN KORUYUCU SAYIMINI BAŞLAT
            setTimerSifirla();
            setTimerBaslat();

            //

        }
        int ekrankoruyucu_beklemeSuresi = 1;
        //-------------------------------------------------------------------------------------
        //EKRAN KORUYUCUYU ÇALIŞTIRMAK
        private void timer1_Tick(object sender, EventArgs e)
        {
            countEkranKoruyucu++;
            if (countEkranKoruyucu > ekrankoruyucu_beklemeSuresi)
            {
                WindowState = FormWindowState.Maximized;
                setTimerSifirla();
                random.SetRandomPicture(balon, this.Size);

                //BALON YÖNLERİ
                setBalonDirection();

                timerBalloon.Stop();
                timerBalloon.Start();
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
        int balonYonX;
        int balonYonY;
        private void setBalonDirection()
        {
            balonYonX = rnd.Next(1, 3);
            balonYonY = rnd.Next(1, 3);
        }
        private int getRandomBalonDirection()
        {
            return rnd.Next(1, 3);
        }
        private void setRandomBalonDirection()
        {
            int x;
            x = rnd.Next(1, 3);
            if (balonYonX < 0)
            {
                x *=-1;
            }

            int y;
            y = rnd.Next(1, 3);
            if (balonYonY < 0)
            {
                y *= -1;
            }

            balonYonX = x;
            balonYonY = y;
        }

        private void timerBalloon_Tick(object sender, EventArgs e)
        {
            balon.Left += balonYonX;
            balon.Top += balonYonY;

            if (balonYonX <= 0)
            {
                if (balon.Left <= 0)
                {
                    balonYonX *= -1;
                    setRandomBalonDirection();
                }

            }
            else
            {
                if (balon.Left + balon.Width >= this.Width)
                {
                    balonYonX *= -1;
                    setRandomBalonDirection();
                }
            }

            if (balonYonY <= 0)
            {
                if (balon.Top <= 0)
                {
                    balonYonY *= -1;
                    setRandomBalonDirection();
                }

            }
            else
            {
                if (balon.Top + balon.Height >= this.Height)
                {
                    balonYonY *= -1;
                    setRandomBalonDirection();
                }
            }
        }

        //BALON OLUŞTURMA
        private PictureBox getPictureBox(int left, int top)
        {
            PictureBox temp = getPictureBox();
            temp.Left = left;
            temp.Top = top;
            return temp;
        }
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

        private PictureBox getBalonOlustur()
        {
            PictureBox pictureBox = getPictureBox();

            Controls.Add(pictureBox);
            return pictureBox;
        }

    }
}
