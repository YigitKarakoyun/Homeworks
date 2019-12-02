using System;
using System.Collections.Generic;

namespace ConsoleHelloWorld
{
    interface IHarf
    {
        List<string> getHarfler(int boyut);
    }
    class class_List
    {
        protected List<string> harfListesi = new List<string>();
        protected bool GetBoyutYanlisMi(int boyut)
        {
            if (boyut < 3 || boyut > 7){ return true; }
            return false;
        }
    }
    class class_H : class_List, IHarf
    {
        public List<string> getHarfler(int boyut)
        {
            if (GetBoyutYanlisMi(boyut)) { return null; }

            harfListesi.Clear();
            switch (boyut)
            {
                case 3:
                    harfListesi.Add("C C");
                    harfListesi.Add("CCC");
                    harfListesi.Add("C C");
                    break;
                case 4:

                    harfListesi.Add("C  C");
                    harfListesi.Add("CCCC");
                    harfListesi.Add("C  C");

                    break;

                case 5:
                    harfListesi.Add("C   C");
                    harfListesi.Add("C   C");
                    harfListesi.Add("CCCCC");
                    harfListesi.Add("C   C");
                    harfListesi.Add("C   C");
                    //System.Windows.Forms.MessageBox.Show(temp[0].Length+"-"+ temp[0]+"-");

                    break;
                case 6:
                    harfListesi.Add("C    C");
                    harfListesi.Add("C    C");
                    harfListesi.Add("CCCCCC");
                    harfListesi.Add("C    C");
                    harfListesi.Add("C    C");

                    break;
                case 7:
                    harfListesi.Add("C     C");
                    harfListesi.Add("C     C");
                    harfListesi.Add("C     C");
                    harfListesi.Add("CCCCCCC");
                    harfListesi.Add("C     C");
                    harfListesi.Add("C     C");
                    harfListesi.Add("C     C");

                    break;
                default:
                    break;
            }


            return harfListesi;

        }
    }
    class class_E : class_List, IHarf
    {
        public List<string> getHarfler(int boyut)
        {
            if (GetBoyutYanlisMi(boyut)) { return null; }

            harfListesi.Clear();
            switch (boyut)
            {
                case 3:
                    harfListesi.Add("CCC");
                    harfListesi.Add("C  ");
                    harfListesi.Add("CCC");
                    break;
                case 4:

                    harfListesi.Add("CCCC");
                    harfListesi.Add("CC  ");
                    harfListesi.Add("CCCC");

                    break;

                case 5:
                    harfListesi.Add("CCCCC");
                    harfListesi.Add("C    ");
                    harfListesi.Add("CCC  ");
                    harfListesi.Add("C    ");
                    harfListesi.Add("CCCCC");

                    break;
                case 6:
                    harfListesi.Add("CCCCCC");
                    harfListesi.Add("C     ");
                    harfListesi.Add("CCCCC ");
                    harfListesi.Add("C     ");
                    harfListesi.Add("CCCCCC");

                    break;
                case 7:
                    harfListesi.Add("CCCCCCC");
                    harfListesi.Add("C      ");
                    harfListesi.Add("C      ");
                    harfListesi.Add("CCCCCCC");
                    harfListesi.Add("C      ");
                    harfListesi.Add("C      ");
                    harfListesi.Add("CCCCCCC");

                    break;
                default:
                    break;
            }


            return harfListesi;

        }
    }
    class class_L : class_List, IHarf
    {
        public List<string> getHarfler(int boyut)
        {
            if (GetBoyutYanlisMi(boyut)) { return null; }

            harfListesi.Clear();
            switch (boyut)
            {
                case 3:
                    harfListesi.Add("C  ");
                    harfListesi.Add("C  ");
                    harfListesi.Add("CCC");
                    break;
                case 4:

                    harfListesi.Add("C   ");
                    harfListesi.Add("C   ");
                    harfListesi.Add("CCCC");

                    break;

                case 5:
                    harfListesi.Add("C    ");
                    harfListesi.Add("C    ");
                    harfListesi.Add("C    ");
                    harfListesi.Add("C    ");
                    harfListesi.Add("CCCCC");

                    break;
                case 6:
                    harfListesi.Add("C     ");
                    harfListesi.Add("C     ");
                    harfListesi.Add("C     ");
                    harfListesi.Add("C     ");
                    harfListesi.Add("CCCCCC");

                    break;
                case 7:
                    harfListesi.Add("C      ");
                    harfListesi.Add("C      ");
                    harfListesi.Add("C      ");
                    harfListesi.Add("C      ");
                    harfListesi.Add("C      ");
                    harfListesi.Add("C      ");
                    harfListesi.Add("CCCCCCC");

                    break;
                default:
                    break;
            }


            return harfListesi;

        }
    }
    class class_O : class_List, IHarf
    {
        public List<string> getHarfler(int boyut)
        {
            if (GetBoyutYanlisMi(boyut)) { return null; }

            harfListesi.Clear();
            switch (boyut)
            {
                case 3:
                    harfListesi.Add("CCC");
                    harfListesi.Add("C C");
                    harfListesi.Add("CCC");
                    break;
                case 4:

                    harfListesi.Add("CCCC");
                    harfListesi.Add("C  C");
                    harfListesi.Add("CCCC");

                    break;

                case 5:
                    harfListesi.Add("CCCCC");
                    harfListesi.Add("C   C");
                    harfListesi.Add("C   C");
                    harfListesi.Add("C   C");
                    harfListesi.Add("CCCCC");

                    break;
                case 6:
                    harfListesi.Add("CCCCCC");
                    harfListesi.Add("C    C");
                    harfListesi.Add("C    C");
                    harfListesi.Add("C    C");
                    harfListesi.Add("CCCCCC");

                    break;
                case 7:
                    harfListesi.Add("CCCCCCC");
                    harfListesi.Add("C     C");
                    harfListesi.Add("C     C");
                    harfListesi.Add("C     C");
                    harfListesi.Add("C     C");
                    harfListesi.Add("C     C");
                    harfListesi.Add("CCCCCCC");

                    break;
                default:
                    break;
            }


            return harfListesi;

        }
    }
    class class_W : class_List, IHarf
    {
        public List<string> getHarfler(int boyut)
        {
            if (GetBoyutYanlisMi(boyut)) { return null; }

            harfListesi.Clear();
            switch (boyut)
            {
                case 3:
                    harfListesi.Add("C C");
                    harfListesi.Add("CCC");
                    harfListesi.Add("C C");
                    break;
                case 4:

                    harfListesi.Add("C C C");
                    harfListesi.Add("CCCCC");
                    harfListesi.Add("C   C");

                    break;

                case 5:
                    harfListesi.Add("C   C");
                    harfListesi.Add("C   C");
                    harfListesi.Add("C C C");
                    harfListesi.Add("CC CC");
                    harfListesi.Add("C   C");

                    break;
                case 6:
                    harfListesi.Add("C    C");
                    harfListesi.Add("C    C");
                    harfListesi.Add("C CC C");
                    harfListesi.Add("CC  CC");
                    harfListesi.Add("C    C");

                    break;
                case 7:
                    harfListesi.Add("C     C");
                    harfListesi.Add("C     C");
                    harfListesi.Add("C     C");
                    harfListesi.Add("C  C  C");
                    harfListesi.Add("C C C C");
                    harfListesi.Add("CC   CC");
                    harfListesi.Add("C     C");

                    break;
                default:
                    break;
            }


            return harfListesi;

        }
    }
    class class_R : class_List, IHarf
    {
        public List<string> getHarfler(int boyut)
        {
            if (GetBoyutYanlisMi(boyut)) { return null; }

            harfListesi.Clear();
            switch (boyut)
            {
                case 3:
                    harfListesi.Add("CCC");
                    harfListesi.Add("CCC");
                    harfListesi.Add("C C");
                    break;
                case 4:

                    harfListesi.Add("CCCC");
                    harfListesi.Add("CCCC");
                    harfListesi.Add("C  C");

                    break;

                case 5:
                    harfListesi.Add("CCCCC");
                    harfListesi.Add("C   C");
                    harfListesi.Add("CCCCC");
                    harfListesi.Add("C  C ");
                    harfListesi.Add("C   C");

                    break;
                case 6:
                    harfListesi.Add("CCCCCC");
                    harfListesi.Add("C    C");
                    harfListesi.Add("CCCCCC");
                    harfListesi.Add("C   C ");
                    harfListesi.Add("C    C");

                    break;
                case 7:
                    harfListesi.Add("CCCCCCC");
                    harfListesi.Add("C     C");
                    harfListesi.Add("CCCCCCC");
                    harfListesi.Add("C  C   ");
                    harfListesi.Add("C   C  ");
                    harfListesi.Add("C    C ");
                    harfListesi.Add("C     C");

                    break;
                default:
                    break;
            }


            return harfListesi;

        }
    }
    class class_D : class_List, IHarf
    {
        public List<string> getHarfler(int boyut)
        {
            if (GetBoyutYanlisMi(boyut)) { return null; }

            harfListesi.Clear();
            switch (boyut)
            {
                case 3:
                    harfListesi.Add("CC ");
                    harfListesi.Add("C C");
                    harfListesi.Add("CC ");
                    break;
                case 4:

                    harfListesi.Add("CCC ");
                    harfListesi.Add("C  C");
                    harfListesi.Add("CCC ");

                    break;

                case 5:
                    harfListesi.Add("CCCC ");
                    harfListesi.Add("C   C");
                    harfListesi.Add("C   C");
                    harfListesi.Add("C   C");
                    harfListesi.Add("CCCC ");

                    break;
                case 6:
                    harfListesi.Add("CCCCC ");
                    harfListesi.Add("C    C");
                    harfListesi.Add("C    C");
                    harfListesi.Add("C    C");
                    harfListesi.Add("CCCCC ");

                    break;
                case 7:
                    harfListesi.Add("CCCCCC ");
                    harfListesi.Add("C     C");
                    harfListesi.Add("C     C");
                    harfListesi.Add("C     C");
                    harfListesi.Add("C     C");
                    harfListesi.Add("C     C");
                    harfListesi.Add("CCCCCC ");

                    break;
                default:
                    break;
            }


            return harfListesi;

        }
    }
    class class_Bosluk : class_List, IHarf
    {
        public List<string> getHarfler(int boyut)
        {
            if (GetBoyutYanlisMi(boyut)) { return null; }

            harfListesi.Clear();
            switch (boyut)
            {
                case 3:
                    harfListesi.Add("   ");
                    harfListesi.Add("   ");
                    harfListesi.Add("   ");
                    break;
                case 4:

                    harfListesi.Add("    ");
                    harfListesi.Add("    ");
                    harfListesi.Add("    ");

                    break;

                case 5:
                    harfListesi.Add("     ");
                    harfListesi.Add("     ");
                    harfListesi.Add("     ");
                    harfListesi.Add("     ");
                    harfListesi.Add("     ");

                    break;
                case 6:
                    harfListesi.Add("      ");
                    harfListesi.Add("      ");
                    harfListesi.Add("      ");
                    harfListesi.Add("      ");
                    harfListesi.Add("      ");

                    break;
                case 7:
                    harfListesi.Add("       ");
                    harfListesi.Add("       ");
                    harfListesi.Add("       ");
                    harfListesi.Add("       ");
                    harfListesi.Add("       ");
                    harfListesi.Add("       ");
                    harfListesi.Add("       ");

                    break;
                default:
                    break;
            }


            return harfListesi;

        }
    }
    class class_Fabric
    {

        public List<string> getHarf(string harf, int boyut)
        {
            switch (harf.ToLower())
            {
                case "h": return new class_H().getHarfler(boyut);
                case "e": return new class_E().getHarfler(boyut);
                case "l": return new class_L().getHarfler(boyut);
                case "o": return new class_O().getHarfler(boyut);
                case "w": return new class_W().getHarfler(boyut);
                case "r": return new class_R().getHarfler(boyut);
                case "d": return new class_D().getHarfler(boyut);

                default: return new class_Bosluk().getHarfler(boyut);
            }


        }
        public List<List<string>> getCumle(string cumle, int boyut)
        {
            List<List<string>> tempKelimeler = new List<List<string>>();

            for (int i = 0; i < cumle.Length; i++)
            {
                string harf = cumle[i].ToString();
                List<string> tempString = getHarf(harf, boyut);
                tempKelimeler.Add(tempString);
            }

            return tempKelimeler;

        }
        public void printVertical(string cumle, int boyut)
        {
            List<List<string>> tempKelimeler = getCumle(cumle, boyut);
            foreach (List<string> item in tempKelimeler)
            {
                foreach (string harf in item)
                {
                    Console.WriteLine(harf);
                }
                Console.WriteLine();
            }

        }
        public void printHorizontal(string cumle, int boyut)
        {
           
            List<List<string>> tempHarfler = new List<List<string>>();
            foreach (char harf in cumle)
            {
                List<string> harfString = getHarf(harf.ToString(), boyut);
                if (harfString!=null)
                {
                    tempHarfler.Add(harfString);
                }
                
            }
            if (tempHarfler.Count>0)
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
    }
}
