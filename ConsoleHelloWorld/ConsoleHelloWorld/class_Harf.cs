using System;
using System.Collections.Generic;

namespace ConsoleHelloWorld
{
    interface IHarf
    {
        List<string> GetHarfler(int boyut, char karakter);
        List<string> GetHarfler_C(int boyut);
        List<string> GetHarfler_Yildiz(int boyut);
    }
    class class_List
    {
        protected List<string> harfListesi = new List<string>();
        protected bool GetBoyutYanlisMi(int boyut)
        {
            if (boyut < 3 || boyut > 7) { return true; }
            return false;
        }
    }
    class class_H : class_List, IHarf
    {
        public List<string> GetHarfler(int boyut, char karakter)
        {
            if (GetBoyutYanlisMi(boyut)) { return null; }

            harfListesi = GetHarfler_Yildiz(boyut);
            for (int i = 0; i < harfListesi.Count; i++)
            {
                harfListesi[i] = harfListesi[i].Replace('*', karakter);

            }
            return harfListesi;
        }

        public List<string> GetHarfler_C(int boyut)
        {
            return GetHarfler(boyut, 'C');
        }

        public List<string> GetHarfler_Yildiz(int boyut)
        {
            if (GetBoyutYanlisMi(boyut)) { return null; }

            harfListesi.Clear();
            switch (boyut)
            {
                case 3:
                    harfListesi.Add("* *");
                    harfListesi.Add("***");
                    harfListesi.Add("* *");
                    break;
                case 4:

                    harfListesi.Add("*  *");
                    harfListesi.Add("****");
                    harfListesi.Add("*  *");

                    break;

                case 5:
                    harfListesi.Add("*   *");
                    harfListesi.Add("*   *");
                    harfListesi.Add("*****");
                    harfListesi.Add("*   *");
                    harfListesi.Add("*   *");

                    break;
                case 6:
                    harfListesi.Add("*    *");
                    harfListesi.Add("*    *");
                    harfListesi.Add("******");
                    harfListesi.Add("*    *");
                    harfListesi.Add("*    *");

                    break;
                case 7:
                    harfListesi.Add("*     *");
                    harfListesi.Add("*     *");
                    harfListesi.Add("*     *");
                    harfListesi.Add("*******");
                    harfListesi.Add("*     *");
                    harfListesi.Add("*     *");
                    harfListesi.Add("*     *");

                    break;
                default:
                    break;
            }


            return harfListesi;

        }
    }
    class class_E : class_List, IHarf
    {

        public List<string> GetHarfler(int boyut, char karakter)
        {
            if (GetBoyutYanlisMi(boyut)) { return null; }

            harfListesi = GetHarfler_Yildiz(boyut);
            for (int i = 0; i < harfListesi.Count; i++)
            {
                harfListesi[i] = harfListesi[i].Replace('*', karakter);

            }
            return harfListesi;
        }

        public List<string> GetHarfler_C(int boyut)
        {
            return GetHarfler(boyut, 'C');
        }

        public List<string> GetHarfler_Yildiz(int boyut)
        {
            if (GetBoyutYanlisMi(boyut)) { return null; }

            harfListesi.Clear();
            switch (boyut)
            {
                case 3:
                    harfListesi.Add("***");
                    harfListesi.Add("*  ");
                    harfListesi.Add("***");
                    break;
                case 4:

                    harfListesi.Add("****");
                    harfListesi.Add("**  ");
                    harfListesi.Add("****");

                    break;

                case 5:
                    harfListesi.Add("*****");
                    harfListesi.Add("*    ");
                    harfListesi.Add("***  ");
                    harfListesi.Add("*    ");
                    harfListesi.Add("*****");

                    break;
                case 6:
                    harfListesi.Add("******");
                    harfListesi.Add("*     ");
                    harfListesi.Add("***** ");
                    harfListesi.Add("*     ");
                    harfListesi.Add("******");

                    break;
                case 7:
                    harfListesi.Add("*******");
                    harfListesi.Add("*      ");
                    harfListesi.Add("*      ");
                    harfListesi.Add("*******");
                    harfListesi.Add("*      ");
                    harfListesi.Add("*      ");
                    harfListesi.Add("*******");

                    break;
                default:
                    break;
            }


            return harfListesi;
        }
    }
    class class_L : class_List, IHarf
    {
        public List<string> GetHarfler(int boyut, char karakter)
        {
            if (GetBoyutYanlisMi(boyut)) { return null; }

            harfListesi = GetHarfler_Yildiz(boyut);
            for (int i = 0; i < harfListesi.Count; i++)
            {
                harfListesi[i] = harfListesi[i].Replace('*', karakter);

            }
            return harfListesi;
        }

        public List<string> GetHarfler_C(int boyut)
        {
            return GetHarfler(boyut, 'C');
        }

        public List<string> GetHarfler_Yildiz(int boyut)
        {
            if (GetBoyutYanlisMi(boyut)) { return null; }

            harfListesi.Clear();
            switch (boyut)
            {
                case 3:
                    harfListesi.Add("*  ");
                    harfListesi.Add("*  ");
                    harfListesi.Add("***");
                    break;
                case 4:

                    harfListesi.Add("*   ");
                    harfListesi.Add("*   ");
                    harfListesi.Add("****");

                    break;

                case 5:
                    harfListesi.Add("*    ");
                    harfListesi.Add("*    ");
                    harfListesi.Add("*    ");
                    harfListesi.Add("*    ");
                    harfListesi.Add("*****");

                    break;
                case 6:
                    harfListesi.Add("*     ");
                    harfListesi.Add("*     ");
                    harfListesi.Add("*     ");
                    harfListesi.Add("*     ");
                    harfListesi.Add("******");

                    break;
                case 7:
                    harfListesi.Add("*      ");
                    harfListesi.Add("*      ");
                    harfListesi.Add("*      ");
                    harfListesi.Add("*      ");
                    harfListesi.Add("*      ");
                    harfListesi.Add("*      ");
                    harfListesi.Add("*******");

                    break;
                default:
                    break;
            }

            return harfListesi;
        }
    }
    class class_O : class_List, IHarf
    {
        public List<string> GetHarfler(int boyut, char karakter)
        {
            if (GetBoyutYanlisMi(boyut)) { return null; }

            harfListesi = GetHarfler_Yildiz(boyut);
            for (int i = 0; i < harfListesi.Count; i++)
            {
                harfListesi[i] = harfListesi[i].Replace('*', karakter);

            }
            return harfListesi;
        }

        public List<string> GetHarfler_C(int boyut)
        {
            return GetHarfler(boyut, 'C');
        }

        public List<string> GetHarfler_Yildiz(int boyut)
        {
            if (GetBoyutYanlisMi(boyut)) { return null; }

            harfListesi.Clear();
            switch (boyut)
            {
                case 3:
                    harfListesi.Add("***");
                    harfListesi.Add("* *");
                    harfListesi.Add("***");
                    break;
                case 4:

                    harfListesi.Add("****");
                    harfListesi.Add("*  *");
                    harfListesi.Add("****");

                    break;

                case 5:
                    harfListesi.Add("*****");
                    harfListesi.Add("*   *");
                    harfListesi.Add("*   *");
                    harfListesi.Add("*   *");
                    harfListesi.Add("*****");

                    break;
                case 6:
                    harfListesi.Add("******");
                    harfListesi.Add("*    *");
                    harfListesi.Add("*    *");
                    harfListesi.Add("*    *");
                    harfListesi.Add("******");

                    break;
                case 7:
                    harfListesi.Add("*******");
                    harfListesi.Add("*     *");
                    harfListesi.Add("*     *");
                    harfListesi.Add("*     *");
                    harfListesi.Add("*     *");
                    harfListesi.Add("*     *");
                    harfListesi.Add("*******");

                    break;
                default:
                    break;
            }


            return harfListesi;
        }
    }
    class Class_W : class_List, IHarf
    {
        public List<string> GetHarfler(int boyut, char karakter)
        {
            harfListesi = GetHarfler_Yildiz(boyut);
            if (GetBoyutYanlisMi(boyut)) { return null; }


            for (int i = 0; i < harfListesi.Count; i++)
            {
                harfListesi[i] = harfListesi[i].Replace('*', karakter);

            }
            return harfListesi;
        }

        public List<string> GetHarfler_C(int boyut)
        {
            return GetHarfler(boyut, 'C');
        }
        public List<string> GetHarfler_Yildiz(int boyut)
        {
            if (GetBoyutYanlisMi(boyut)) { return null; }

            harfListesi.Clear();
            switch (boyut)
            {
                case 3:
                    harfListesi.Add("* *");
                    harfListesi.Add("***");
                    harfListesi.Add("* *");
                    break;
                case 4:

                    harfListesi.Add("* * *");
                    harfListesi.Add("** **");
                    harfListesi.Add("*   *");

                    break;

                case 5:
                    harfListesi.Add("*   *");
                    harfListesi.Add("*   *");
                    harfListesi.Add("* * *");
                    harfListesi.Add("** **");
                    harfListesi.Add("*   *");

                    break;
                case 6:
                    harfListesi.Add("*    *");
                    harfListesi.Add("*    *");
                    harfListesi.Add("* ** *");
                    harfListesi.Add("**  **");
                    harfListesi.Add("*    *");

                    break;
                case 7:
                    harfListesi.Add("*     *");
                    harfListesi.Add("*     *");
                    harfListesi.Add("*     *");
                    harfListesi.Add("*  *  *");
                    harfListesi.Add("* * * *");
                    harfListesi.Add("**   **");
                    harfListesi.Add("*     *");

                    break;
                default:
                    break;
            }


            return harfListesi;

        }


    }
    class class_R : class_List, IHarf
    {
        public List<string> GetHarfler(int boyut, char karakter)
        {
            harfListesi = GetHarfler_Yildiz(boyut);
            if (GetBoyutYanlisMi(boyut)) { return null; }


            for (int i = 0; i < harfListesi.Count; i++)
            {
                harfListesi[i] = harfListesi[i].Replace('*', karakter);

            }
            return harfListesi;
        }

        public List<string> GetHarfler_C(int boyut)
        {
            return GetHarfler(boyut, 'C');
        }
        public List<string> GetHarfler_Yildiz(int boyut)
        {
            if (GetBoyutYanlisMi(boyut)) { return null; }

            harfListesi.Clear();
            switch (boyut)
            {
                case 3:
                    harfListesi.Add("***");
                    harfListesi.Add("***");
                    harfListesi.Add("* *");
                    break;
                case 4:

                    harfListesi.Add("****");
                    harfListesi.Add("****");
                    harfListesi.Add("*  *");

                    break;

                case 5:
                    harfListesi.Add("*****");
                    harfListesi.Add("*   *");
                    harfListesi.Add("*****");
                    harfListesi.Add("*  * ");
                    harfListesi.Add("*   *");

                    break;
                case 6:
                    harfListesi.Add("******");
                    harfListesi.Add("*    *");
                    harfListesi.Add("******");
                    harfListesi.Add("*   * ");
                    harfListesi.Add("*    *");

                    break;
                case 7:
                    harfListesi.Add("*******");
                    harfListesi.Add("*     *");
                    harfListesi.Add("*******");
                    harfListesi.Add("*  *   ");
                    harfListesi.Add("*   *  ");
                    harfListesi.Add("*    * ");
                    harfListesi.Add("*     *");

                    break;
                default:
                    break;
            }


            return harfListesi;

        }

    }
    class class_D : class_List, IHarf
    {
        public List<string> GetHarfler(int boyut, char karakter)
        {
            harfListesi = GetHarfler_Yildiz(boyut);
            if (GetBoyutYanlisMi(boyut)) { return null; }


            for (int i = 0; i < harfListesi.Count; i++)
            {
                harfListesi[i] = harfListesi[i].Replace('*', karakter);

            }
            return harfListesi;
        }

        public List<string> GetHarfler_C(int boyut)
        {
            return GetHarfler(boyut, 'C');
        }
        public List<string> GetHarfler_Yildiz(int boyut)
        {
            if (GetBoyutYanlisMi(boyut)) { return null; }

            harfListesi.Clear();
            switch (boyut)
            {
                case 3:
                    harfListesi.Add("** ");
                    harfListesi.Add("* *");
                    harfListesi.Add("** ");
                    break;
                case 4:

                    harfListesi.Add("*** ");
                    harfListesi.Add("*  *");
                    harfListesi.Add("*** ");

                    break;

                case 5:
                    harfListesi.Add("**** ");
                    harfListesi.Add("*   *");
                    harfListesi.Add("*   *");
                    harfListesi.Add("*   *");
                    harfListesi.Add("**** ");

                    break;
                case 6:
                    harfListesi.Add("***** ");
                    harfListesi.Add("*    *");
                    harfListesi.Add("*    *");
                    harfListesi.Add("*    *");
                    harfListesi.Add("***** ");

                    break;
                case 7:
                    harfListesi.Add("****** ");
                    harfListesi.Add("*     *");
                    harfListesi.Add("*     *");
                    harfListesi.Add("*     *");
                    harfListesi.Add("*     *");
                    harfListesi.Add("*     *");
                    harfListesi.Add("****** ");

                    break;
                default:
                    break;
            }


            return harfListesi;

        }

    }
    class class_Bosluk : class_List, IHarf
    {
        public List<string> GetHarfler(int boyut, char karakter)
        {
            harfListesi = GetHarfler_Yildiz(boyut);
            if (GetBoyutYanlisMi(boyut)) { return null; }


            for (int i = 0; i < harfListesi.Count; i++)
            {
                harfListesi[i] = harfListesi[i].Replace('*', karakter);

            }
            return harfListesi;
        }

        public List<string> GetHarfler_C(int boyut)
        {
            return GetHarfler(boyut, 'C');
        }
        public List<string> GetHarfler_Yildiz(int boyut)
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
    
}
