using System;
using System.Collections.Generic;

namespace ConsoleHelloWorld
{
    interface IHarf
    {
        List<string> getHarfler(int boyut);
    }
    class class_H : IHarf
    {
        List<string> temp;
        public class_H()
        {
            temp = new List<string>();
        }
        public List<string> getHarfler(int boyut)
        {
            if (boyut < 3 || boyut > 7) { return null; }

            temp.Clear();
            switch (boyut)
            {
                case 3:
                    temp.Add("C C");
                    temp.Add("CCC");
                    temp.Add("C C");
                    break;
                case 4:

                    temp.Add("C  C");
                    temp.Add("CCCC");
                    temp.Add("C  C");

                    break;

                case 5:
                    temp.Add("C   C");
                    temp.Add("C   C");
                    temp.Add("CCCCC");
                    temp.Add("C   C");
                    temp.Add("C   C");
                    //System.Windows.Forms.MessageBox.Show(temp[0].Length+"-"+ temp[0]+"-");

                    break;
                case 6:
                    temp.Add("C    C");
                    temp.Add("C    C");
                    temp.Add("CCCCCC");
                    temp.Add("C    C");
                    temp.Add("C    C");

                    break;
                case 7:
                    temp.Add("C     C");
                    temp.Add("C     C");
                    temp.Add("C     C");
                    temp.Add("CCCCCCC");
                    temp.Add("C     C");
                    temp.Add("C     C");
                    temp.Add("C     C");

                    break;
                default:
                    break;
            }


            return temp;

        }
    }
    class class_E : IHarf
    {
        List<string> temp;
        public class_E()
        {
            temp = new List<string>();
        }
        public List<string> getHarfler(int boyut)
        {
            if (boyut < 3 || boyut > 7)
            {
                return null;
            }
            temp.Clear();
            switch (boyut)
            {
                case 3:
                    temp.Add("CCC");
                    temp.Add("C  ");
                    temp.Add("CCC");
                    break;
                case 4:

                    temp.Add("CCCC");
                    temp.Add("CC  ");
                    temp.Add("CCCC");

                    break;

                case 5:
                    temp.Add("CCCCC");
                    temp.Add("C    ");
                    temp.Add("CCC  ");
                    temp.Add("C    ");
                    temp.Add("CCCCC");

                    break;
                case 6:
                    temp.Add("CCCCCC");
                    temp.Add("C     ");
                    temp.Add("CCCCC ");
                    temp.Add("C     ");
                    temp.Add("CCCCCC");

                    break;
                case 7:
                    temp.Add("CCCCCCC");
                    temp.Add("C      ");
                    temp.Add("C      ");
                    temp.Add("CCCCCCC");
                    temp.Add("C      ");
                    temp.Add("C      ");
                    temp.Add("CCCCCCC");

                    break;
                default:
                    break;
            }


            return temp;

        }
    }
    class class_L : IHarf
    {
        List<string> temp;
        public class_L()
        {
            temp = new List<string>();
        }
        public List<string> getHarfler(int boyut)
        {
            if (boyut < 3 || boyut > 7)
            {
                return null;
            }
            temp.Clear();
            switch (boyut)
            {
                case 3:
                    temp.Add("C  ");
                    temp.Add("C  ");
                    temp.Add("CCC");
                    break;
                case 4:

                    temp.Add("C   ");
                    temp.Add("C   ");
                    temp.Add("CCCC");

                    break;

                case 5:
                    temp.Add("C    ");
                    temp.Add("C    ");
                    temp.Add("C    ");
                    temp.Add("C    ");
                    temp.Add("CCCCC");

                    break;
                case 6:
                    temp.Add("C     ");
                    temp.Add("C     ");
                    temp.Add("C     ");
                    temp.Add("C     ");
                    temp.Add("CCCCCC");

                    break;
                case 7:
                    temp.Add("C      ");
                    temp.Add("C      ");
                    temp.Add("C      ");
                    temp.Add("C      ");
                    temp.Add("C      ");
                    temp.Add("C      ");
                    temp.Add("CCCCCCC");

                    break;
                default:
                    break;
            }


            return temp;

        }
    }

    class class_O : IHarf
    {
        List<string> temp;
        public class_O()
        {
            temp = new List<string>();
        }
        public List<string> getHarfler(int boyut)
        {
            if (boyut < 3 || boyut > 7)
            {
                return null;
            }
            temp.Clear();
            switch (boyut)
            {
                case 3:
                    temp.Add("CCC");
                    temp.Add("C C");
                    temp.Add("CCC");
                    break;
                case 4:

                    temp.Add("CCCC");
                    temp.Add("C  C");
                    temp.Add("CCCC");

                    break;

                case 5:
                    temp.Add("CCCCC");
                    temp.Add("C   C");
                    temp.Add("C   C");
                    temp.Add("C   C");
                    temp.Add("CCCCC");

                    break;
                case 6:
                    temp.Add("CCCCCC");
                    temp.Add("C    C");
                    temp.Add("C    C");
                    temp.Add("C    C");
                    temp.Add("CCCCCC");

                    break;
                case 7:
                    temp.Add("CCCCCCC");
                    temp.Add("C     C");
                    temp.Add("C     C");
                    temp.Add("C     C");
                    temp.Add("C     C");
                    temp.Add("C     C");
                    temp.Add("CCCCCCC");

                    break;
                default:
                    break;
            }


            return temp;

        }
    }

    class class_W : IHarf
    {
        List<string> temp;
        public class_W()
        {
            temp = new List<string>();
        }
        public List<string> getHarfler(int boyut)
        {
            if (boyut < 3 || boyut > 7)
            {
                return null;
            }
            temp.Clear();
            switch (boyut)
            {
                case 3:
                    temp.Add("C C");
                    temp.Add("CCC");
                    temp.Add("C C");
                    break;
                case 4:

                    temp.Add("C C C");
                    temp.Add("CCCCC");
                    temp.Add("C   C");

                    break;

                case 5:
                    temp.Add("C   C");
                    temp.Add("C   C");
                    temp.Add("C C C");
                    temp.Add("CC CC");
                    temp.Add("C   C");

                    break;
                case 6:
                    temp.Add("C    C");
                    temp.Add("C    C");
                    temp.Add("C CC C");
                    temp.Add("CC  CC");
                    temp.Add("C    C");

                    break;
                case 7:
                    temp.Add("C     C");
                    temp.Add("C     C");
                    temp.Add("C     C");
                    temp.Add("C  C  C");
                    temp.Add("C C C C");
                    temp.Add("CC   CC");
                    temp.Add("C     C");

                    break;
                default:
                    break;
            }


            return temp;

        }
    }
    class class_R : IHarf
    {
        List<string> temp;
        public class_R()
        {
            temp = new List<string>();
        }
        public List<string> getHarfler(int boyut)
        {
            if (boyut < 3 || boyut > 7)
            {
                return null;
            }
            temp.Clear();
            switch (boyut)
            {
                case 3:
                    temp.Add("CCC");
                    temp.Add("CCC");
                    temp.Add("C C");
                    break;
                case 4:

                    temp.Add("CCCC");
                    temp.Add("CCCC");
                    temp.Add("C  C");

                    break;

                case 5:
                    temp.Add("CCCCC");
                    temp.Add("C   C");
                    temp.Add("CCCCC");
                    temp.Add("C  C ");
                    temp.Add("C   C");

                    break;
                case 6:
                    temp.Add("CCCCCC");
                    temp.Add("C    C");
                    temp.Add("CCCCCC");
                    temp.Add("C   C ");
                    temp.Add("C    C");

                    break;
                case 7:
                    temp.Add("CCCCCCC");
                    temp.Add("C     C");
                    temp.Add("CCCCCCC");
                    temp.Add("C  C   ");
                    temp.Add("C   C  ");
                    temp.Add("C    C ");
                    temp.Add("C     C");

                    break;
                default:
                    break;
            }


            return temp;

        }
    }
    class class_D : IHarf
    {
        List<string> temp;
        public class_D()
        {
            temp = new List<string>();
        }
        public List<string> getHarfler(int boyut)
        {
            if (boyut < 3 || boyut > 7)
            {
                return null;
            }
            temp.Clear();
            switch (boyut)
            {
                case 3:
                    temp.Add("CC ");
                    temp.Add("C C");
                    temp.Add("CC ");
                    break;
                case 4:

                    temp.Add("CCC ");
                    temp.Add("C  C");
                    temp.Add("CCC ");

                    break;

                case 5:
                    temp.Add("CCCC ");
                    temp.Add("C   C");
                    temp.Add("C   C");
                    temp.Add("C   C");
                    temp.Add("CCCC ");

                    break;
                case 6:
                    temp.Add("CCCCC ");
                    temp.Add("C    C");
                    temp.Add("C    C");
                    temp.Add("C    C");
                    temp.Add("CCCCC ");

                    break;
                case 7:
                    temp.Add("CCCCCC ");
                    temp.Add("C     C");
                    temp.Add("C     C");
                    temp.Add("C     C");
                    temp.Add("C     C");
                    temp.Add("C     C");
                    temp.Add("CCCCCC ");

                    break;
                default:
                    break;
            }


            return temp;

        }
    }
    class class_Bosluk : IHarf
    {
        List<string> temp;
        public class_Bosluk()
        {
            temp = new List<string>();
        }
        public List<string> getHarfler(int boyut)
        {
            if (boyut < 3 || boyut > 7)
            {
                return null;
            }
            temp.Clear();
            switch (boyut)
            {
                case 3:
                    temp.Add("   ");
                    temp.Add("   ");
                    temp.Add("   ");
                    break;
                case 4:

                    temp.Add("    ");
                    temp.Add("    ");
                    temp.Add("    ");

                    break;

                case 5:
                    temp.Add("     ");
                    temp.Add("     ");
                    temp.Add("     ");
                    temp.Add("     ");
                    temp.Add("     ");

                    break;
                case 6:
                    temp.Add("      ");
                    temp.Add("      ");
                    temp.Add("      ");
                    temp.Add("      ");
                    temp.Add("      ");

                    break;
                case 7:
                    temp.Add("       ");
                    temp.Add("       ");
                    temp.Add("       ");
                    temp.Add("       ");
                    temp.Add("       ");
                    temp.Add("       ");
                    temp.Add("       ");

                    break;
                default:
                    break;
            }


            return temp;

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
