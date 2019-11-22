using System;
using System.Drawing;

namespace ImageSatrancTahtasi
{
    class _Satranc
    {
        public int getTekKare(int i)
        {
            return i / 8;
        }
        public Image getSatrancImage(int width, int height, Color main_color, Color side_color)
        {
            int kareGenislik = getTekKare(width);
            int kareYukseklik = getTekKare(height);

            Bitmap image = new Bitmap(width, height);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (getBoyaRenkliMi(j, kareYukseklik))
                    {
                        if (getBoyaRenkliMi(i, kareGenislik))
                        {
                            image.SetPixel(i, j, main_color);
                        }
                        else
                        {
                            image.SetPixel(i, j, side_color);
                        }
                    }
                    else
                    {
                        if (!getBoyaRenkliMi(i, kareGenislik))
                        {
                            image.SetPixel(i, j, main_color);
                        }
                        else
                        {
                            image.SetPixel(i, j, side_color);
                        }
                    }
                }
            }
            return image;
            
        }
        private bool getBoyaRenkliMi(int i, int w)
        {
            if (Math.Floor((double)i / (double)w) % 2 == 0)
            {
                return true;
            }

            return false;
        }
    }
}
