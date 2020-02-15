using System.Drawing;

namespace projectWallpaper
{
    class class_Colors
    {
        public Color GetColor(int red, int green, int blue)
        {
            return Color.FromArgb(red, green, blue);
        }
        public Color GetColor(int alpha,int red, int green, int blue)
        {
            return Color.FromArgb(alpha,red, green, blue);
        }
        public Color[] GetColors()
        {
            Color[] colors = new Color[16];
            int count = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int h = 0; h < 2; h++)
                    {
                        colors[count] = GetColor((i * 45) + 120, j * 100 + 25, h * 100);
                        count++;
                    }

                }
            }
            return colors;
        }


        //Düzgün renk bilgisi gir
        public Color[] GetColorsNext()
        {
            Color[] colors = new Color[16];
            //int count = 0;
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        for (int h = 0; h < 2; h++)
            //        {
            //            colors[count] = GetColor((i * 45) + 120, j * 100 + 25, h * 100);
            //            count++;
            //        }

            //    }
            //}
            return colors;
        }
    
    }
    
}
