using System;

namespace WindowsFormsApp1
{
    class class_Sayilar
    {
        public string getSatir(int sayi)
        {
            string temp = " ";
            temp = sayi.ToString();
            for (int i = sayi - 1; i > 0; i--)
            {
                temp += " " + i;
            }
            for (int j = 2; j <= sayi; j++)
            {
                temp += " " + j;
            }

            return temp;
        }
        public string getBosluk(int bosluk)
        {
            string temp = "";
            for (int i = 0; i < bosluk; i++)
            {
                temp += " ";
            }
            return temp;
        }
        string[] dizi;
        string[] boslukDizi;
        public void setDizi(int sayi)
        {
            dizi = new string[sayi];
            boslukDizi = new string[sayi];

            for (int i = sayi - 1; i >= 0; i--)
            {
                dizi[i] = getSatir(i + 1);
                
            }
        }
        public void setBoslukDizisi(int sayi)
        {
            int sonIndeks = sayi - 1;
            boslukDizi[sonIndeks] = " ";
            for (int i = sonIndeks; i > 0; i--)
            {
                int s1 = dizi[i].Length;
                int s2 = dizi[i - 1].Length;
                decimal temp = (s1 - s2) / 2;
                
                int sonuc = (int)Math.Ceiling(temp);
                boslukDizi[i - 1] = getBosluk(sonuc)+boslukDizi[i];
            }
        }

        public string getString(int sayi)
        {
            string temp = "";
            for (int i = 0; i < sayi; i++)
            {
                temp += dizi[i] + "\n";
            }
            return temp;

        }
        public string getString2(int sayi)
        {
            string temp = "";
            for (int i = 0; i < sayi; i++)
            {
                temp += boslukDizi[i]+dizi[i] + "\n";
            }
            return temp;

        }
    }
}
