using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChessBoardProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setImage(buttonBoyamaMavi);
            
        }
        private void ImageBoyama(object sender, EventArgs e)
        {
            timer1.Stop();
            setImage(sender as Button);
        }

        _Chess satranc = new _Chess();
        public void setImage(Button button)
        {
            Color main_color = button.BackColor;
            Color side_color = Color.GhostWhite;

            pictureBox1.Image = getSatrancImage(pictureBox1.Width, pictureBox1.Height, main_color, side_color);

            label1.BackColor = main_color;
        }
        public void setImage2(Button button)
        {
            Color main_color = button.BackColor;
            Color side_color = Color.GhostWhite;
            Bitmap bitmap = satranc.getBitmap(pictureBox1.Width, pictureBox1.Height);

            pictureBox1.Image = getSatrancImage(pictureBox1.Width, pictureBox1.Height, main_color, side_color);

            label1.BackColor = main_color;
        }
        public Image getSatrancImage(int width, int height, Color main_color, Color side_color)
        {
            return satranc.getSatrancImage(width, height, main_color, side_color);
        }



        int i2 = 0, j2 = 0;
        Bitmap bitmap2;
        Color main_color2 = Color.MediumBlue;
        Color side_color2 = Color.GhostWhite;

        private void button6_Click(object sender, EventArgs e)
        {
            bitmap2 = satranc.getBitmap(pictureBox1.Width, pictureBox1.Height);
            i2 = 0; j2 = 0;
            main_color2 = (sender as Button).BackColor;

            timer1.Stop();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i2 < pictureBox1.Width / 16)
            {
                if (j2 < pictureBox1.Height)
                {
                    setBoyaBeni16(bitmap2, i2, j2, main_color2, side_color2);
                    pictureBox1.Image = bitmap2;

                    j2++;
                }
                else
                {
                    j2 = 0;
                    i2++;
                }
            }
            else
            {
                timer1.Stop();
            }
        }
        private void setBoyaBeni(Bitmap bitmap, int i, int j, Color main, Color side)
        {
            Color color = satranc.getSatrancPixelColor(bitmap, i, j, main, side);
            satranc.setPixelBoyama(bitmap, i, j, color);
        }
        private void setBoyaBeni16(Bitmap bitmap, int i, int j, Color main, Color side)
        {
            int kareGenislik = satranc.getTekKare(bitmap.Width);

            int ileri,geri;
            for (int wuf = 0; i + wuf < bitmap.Width; wuf += kareGenislik)
            {
                ileri = i + wuf;
                Color color1 = satranc.getSatrancPixelColor(bitmap, ileri, j, main, side);
                satranc.setPixelBoyama(bitmap, ileri, j, color1);

                geri = bitmap.Width - ileri - 1;
               
                Color color2 = satranc.getSatrancPixelColor(bitmap, geri, j, main, side);
                satranc.setPixelBoyama(bitmap, geri, j, color2);
            }
        }
    }
}
