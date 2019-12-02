using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHelloWorld
{
    class class_Fabric
    {
        #region HARF LİSTESİ
        public List<string> getHarfList(char harf, int boyut, char karakter)
        {
            return getHarfList(harf.ToString(), boyut, karakter);
        }
        public List<string> getHarfList(string harf, int boyut, char karakter)
        {
            switch (harf.ToLower())
            {
                case "h": return new class_H().GetHarfler(boyut, karakter);
                case "e": return new class_E().GetHarfler(boyut, karakter);
                case "l": return new class_L().GetHarfler(boyut, karakter);
                case "o": return new class_O().GetHarfler(boyut, karakter);
                case "w": return new Class_W().GetHarfler(boyut, karakter);
                case "r": return new class_R().GetHarfler(boyut, karakter);
                case "d": return new class_D().GetHarfler(boyut, karakter);

                default: return new class_Bosluk().GetHarfler(boyut, karakter);
            }
        }

        public List<string> getHarf_Yildiz(string harf, int boyut)
        {
            return getHarfList(harf, boyut, '*');
        }

        public List<string> getHarf_C(string harf, int boyut)
        {
            return getHarfList(harf, boyut, 'C');
        }
        #endregion

        //----------------------------------------------------------------------------
        #region CUMLE
        public List<List<string>> GetCumle_Karakterler(string cumle, int boyut, string karakterler)
        {
            List<List<string>> tempKelimeler = new List<List<string>>();

            for (int i = 0; i < cumle.Length; i++)
            {
                string harf = cumle[i].ToString();
                List<string> tempString = getHarfList(harf, boyut, karakterler[i]);
                tempKelimeler.Add(tempString);
            }
            return tempKelimeler;
        }
        public List<List<string>> getCumle_Harf(string cumle, int boyut, string karakterler)
        {
            List<List<string>> tempKelimeler = new List<List<string>>();

            for (int i = 0; i < cumle.Length; i++)
            {
                tempKelimeler.Add(getHarfList(cumle[i], boyut, karakterler[i]));
            }

            return tempKelimeler;
        }
        public List<List<string>> GetCumle_Karakter(string cumle, int boyut, char karakter)
        {
            List<List<string>> tempKelimeler = new List<List<string>>();

            for (int i = 0; i < cumle.Length; i++)
            {
                tempKelimeler.Add(getHarfList(cumle[i], boyut, karakter));
            }

            return tempKelimeler;
        }
        public List<List<string>> GetCumle_Karakter(string cumle, int boyut, string karakterler)
        {
            List<List<string>> tempKelimeler = new List<List<string>>();

            for (int i = 0; i < cumle.Length; i++)
            {
                tempKelimeler.Add(getHarfList(cumle[i], boyut, karakterler[i]));
            }

            return tempKelimeler;
        }
        #endregion

        //-----------------------------------------------------------------------------------
        #region PRINT
        public void printVertical_Harfler(string cumle, int boyut, string karakterler)
        {
            if (cumle.Length == karakterler.Length || cumle.Length < karakterler.Length)
            {
                List<List<string>> tempHarfler = GetCumle_Karakterler(cumle, boyut, karakterler);
                printVertical(tempHarfler);
            }
        }
        public void printVertical(string cumle, int boyut, char karakter)
        {
            List<List<string>> tempHarfler = GetCumle_Karakter(cumle, boyut, karakter);
            printVertical(tempHarfler);
        }
        public void printVertical(List<List<string>> tempHarfler)
        {
            if (tempHarfler != null && tempHarfler.Count > 0)
            {
                foreach (List<string> item in tempHarfler)
                {
                    foreach (string harf in item)
                    {
                        Console.WriteLine(harf);
                    }
                    Console.WriteLine();
                }
            }
        }
        public void printHorizontal(string cumle, int boyut, char karakter)
        {
            List<List<string>> tempHarfler = GetCumle_Karakter(cumle, boyut, karakter);
            printHorizontal(tempHarfler);
        }
        public void printHorizontal_Harfler(string cumle, int boyut, string karakterler)
        {
            if (cumle.Length==karakterler.Length || cumle.Length<karakterler.Length)
            {
                List<List<string>> tempHarfler = GetCumle_Karakterler(cumle, boyut, karakterler);
                printHorizontal(tempHarfler);
            }
            
        }
        public void printHorizontal(List<List<string>> tempHarfler)
        {
            if (tempHarfler != null && tempHarfler.Count > 0)
            {
                int boyutDikey = tempHarfler[0].Count;
                for (int i = 0; i < boyutDikey; i++)
                {
                    for (int j = 0; j < tempHarfler.Count; j++)
                    {
                        Console.Write(tempHarfler[j][i] + "  ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        #endregion
    }
}
