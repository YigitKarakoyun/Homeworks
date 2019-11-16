using System;
using System.Drawing;
namespace ChessBoardProject
{
    class _Chess
    {
        public int getTekKare(int i)
        {
            return i / 8;
        }
        public Image getSatrancImageHizli(int width, int height, Color main_color, Color side_color)
        {
            int kareGenislik = getTekKare(width);
            int kareYukseklik = getTekKare(height);

            Bitmap image = new Bitmap(width, height);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (getRenkliMi(i, j, kareGenislik, kareYukseklik))
                    {
                        setPixelBoyama(image, i, j, main_color);
                    }
                    else
                    {
                        setPixelBoyama(image, i, j, side_color);
                    }
                }
            }
            return image;

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
                    if (getRenkliMi(i, j, kareGenislik, kareYukseklik))
                    {
                        setPixelBoyama(image, i, j, main_color);
                    }
                    else
                    {
                        setPixelBoyama(image, i, j, side_color);
                    }
                }
            }
            return image;

        }
        public Color getSatrancPixelColor(Bitmap bitmap, int i, int j, Color main_color, Color side_color)
        {
            Color color;
            if (getRenkliMi(bitmap,i,j))
            {
                color = main_color;
            }
            else
            {
                color = side_color;
            }

            return color;

        }
        public Bitmap getBitmap(int x,int y)
        {
            return new Bitmap(x,y);
        }
        public bool getRenkliMi(Bitmap bitmap,int i, int j)
        {
            int kareGenislik = getTekKare(bitmap.Width);
            int kareYukseklik = getTekKare(bitmap.Height);

            return getRenkliMi(i, j, kareGenislik, kareYukseklik);
        }
        public bool getRenkliMi(int i, int j, int kareGenislik, int kareYukseklik)
        {
            if (Math.Floor((double)j / (double)kareYukseklik) % 2 == 0)
            {
                if (Math.Floor((double)i / (double)kareGenislik) % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (Math.Floor((double)i / (double)kareGenislik) % 2 != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public void setPixelBoyama(Bitmap image, int i, int j, Color color)
        {
            image.SetPixel(i, j, color);
        }

    }
}
