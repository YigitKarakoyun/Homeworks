using System.Collections.Generic;

namespace ProjectStar.Models
{
    public class Kelebek
    {
        public Kelebek(char yildiz, char bosluk)
        {
            Yildiz = yildiz.ToString();
            Bosluk = bosluk.ToString();
        }
        public Kelebek(bool birsifir)
        {
            if (birsifir)
            {
                Yildiz = "1";
                Bosluk = "0";
            }
            else
            {
                Yildiz = "0";
                Bosluk = "1";
            }

        }

        public Kelebek()
        {
            Yildiz = "*";
            Bosluk = " ";
        }
        string Yildiz { get; set; }
        string Bosluk { get; set; }

        string GetYildiz()
        {
            return Yildiz;
        }
        string GetBosluk()
        {
            return Bosluk;
        }

        string GetKelebekString(int bosluk1, int bosluk2, int bosluk3)
        {
            string temp = "";
            temp += GetBoslukYildiz(bosluk1);
            temp += GetBoslukYildiz(bosluk2);
            temp += GetBoslukYildiz(bosluk3);
            return temp;
        }
        string GetBoslukYildiz(int bosluk)
        {
            string temp = "";
            for (int i = 0; i < bosluk; i++)
            {
                temp += GetBosluk();
            }
            temp += GetYildiz();
            return temp;
        }
        public List<string> GetKelebekList()
        {
            return GetKelebekList(15);
        }

        public List<string> GetKelebekList(int kadar)
        {
            List<string> temp = new List<string>();
            int yarisi = (kadar - 3) / 2;

            for (int i = 0; i <= yarisi; i++)
            {
                int bosluk = yarisi - i;
                string newstring = GetKelebekString(i, bosluk, bosluk);
                for (int j = 0; j < i; j++)
                {
                    newstring += GetBosluk();
                }
                temp.Add(newstring);
            }
            int yatayCizgi = kadar;
            if (kadar % 2 == 0)
            {
                yatayCizgi = kadar - 1;
            }

            string newyatay = "";
            for (int i = 0; i < yatayCizgi; i++) newyatay += GetYildiz();

            temp.Add(newyatay);

            for (int i = yarisi; i >= 0; i--)
            {

                int bosluk = yarisi - i;
                string newstring = GetKelebekString(i, bosluk, bosluk);

                for (int j = 0; j < i; j++)
                {
                    newstring += GetBosluk();
                }
                temp.Add(newstring);
            }
            return temp;
        }
        public string GetBaslik(string kelime)
        {
            return GetBaslik(kelime, 15);
        }
        public string GetBaslik(string kelime, int boyut)
        {
            int kelimeBoyutu = kelime.Length;
            string yeniKelime = "";
            if (boyut > kelimeBoyutu)
            {
                int yildiz = (boyut - kelimeBoyutu) / 2;
                for (int i = 0; i < yildiz; i++)
                {
                    yeniKelime += "-";
                }
                yeniKelime += kelime;
                for (int i = 0; i < yildiz; i++)
                {
                    yeniKelime += "-";
                }
                return (yeniKelime);
            }
            else
            {
                return (kelime);
            }
        }
    }
}
