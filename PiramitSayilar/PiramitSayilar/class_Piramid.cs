using System;

namespace PiramitSayilar
{
    class class_Piramid
    {
        #region SATIRBİLGİSİ VE BOŞLUK OLUŞTURMA
        //İlgili Satırı String Döndürür(Bosluksuz)
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
        //İstenen Kadar Boşluk Oluşturur
        public string getBosluk(int bosluk)
        {
            string temp = "";
            for (int i = 0; i < bosluk; i++)
            {
                temp += " ";
            }
            return temp;
        }
        #endregion

        #region DİZİ DEĞİŞKENLERİ
        string[] dizi;
        string[] diziBosluklariTutan;
        #endregion

        #region DİZİLERİ DOLDURMA
        //String Dizisini Doldurur(Soldan Bosluksuz Dizi)
        public void setDizi(int sayi)
        {
            dizi = new string[sayi];
            diziBosluklariTutan = new string[sayi];

            for (int i = sayi - 1; i >= 0; i--)
            {
                dizi[i] = getSatir(i + 1);
            }
        }
        //Soldaki olması gereken boşlukları tutan diziyi doldurur
        public void setDizininBosluklari(int sayi)
        {
            int sonIndeks = sayi - 1;
            diziBosluklariTutan[sonIndeks] = " ";
            for (int i = sonIndeks; i > 0; i--)
            {
                int s1 = dizi[i].Length;
                int s2 = dizi[i - 1].Length;
                decimal temp = (s1 - s2) / 2;
                
                int sonuc = (int)Math.Ceiling(temp);
                diziBosluklariTutan[i - 1] = getBosluk(sonuc)+diziBosluklariTutan[i];
            }
        }
        #endregion

        #region DİZİLERİ KULLANARAK SONUÇ DÖNDÜRME
        //(Sola yapışık)
        //Tum Bilgiyi Tek String Olarak Dondurur
        public string getString(int sayi)
        {
            string temp = "";
            for (int i = 0; i < sayi; i++)
            {
                temp += dizi[i] + "\n";
            }
            return temp;

        }
        //(Ortada)
        //Tum Bilgiyi (Sol)Boşluklarıyla Bir Tek String Olarak Dondurur
        public string getStringSolBosluklariyla(int sayi)
        { 
            string temp = "";
            for (int i = 0; i < sayi; i++)
            {
                temp += diziBosluklariTutan[i]+dizi[i] + "\n";
            }
            return temp;

        }
        #endregion
    }
}
