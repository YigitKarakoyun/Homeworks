namespace PiramidSayilar2
{
    class class_Piramid
    {
        //TEK SATIR DÖNDÜRÜR
        public string getSatirString(int sayi)
        {
            string tempString = sayi.ToString();
            for (int i = sayi - 1; i > 0; i--)
            {
                tempString += " " + i;
            }
            for (int i = 2; i < sayi + 1; i++)
            {
                tempString += " " + i;
            }
            return tempString;
        }
        #region DİZİYİ OLUŞTURUR
        public string[] dizi { get; set; }
        public int diziBoyut { get; set; }
        public void setDiziOlusturup_Doldurur(int sayi)
        {
            dizi = new string[sayi];
            diziBoyut = sayi;

            for (int i = 1; i < sayi + 1; i++)
            {
                dizi[i - 1] = getSatirString(i).Trim();
            }
        }
        #endregion

        public void setDiziDuzenle()
        {
            for (int i = 0; i < diziBoyut; i++)
            {
                int solBosluk = ((dizi[diziBoyut - 1].Length - dizi[i].Length) / 2) + (diziBoyut - i - 1);

                if (i < 9 && diziBoyut > 9)
                {
                    dizi[i] = getBosluk(solBosluk + (diziBoyut - 9)) + dizi[i];
                }
                else if (i >= 9 && i < diziBoyut - 1)
                {
                    dizi[i] = getBosluk(solBosluk + (diziBoyut - i - 1)) + dizi[i];
                }
                else
                {
                    dizi[i] = getBosluk(solBosluk) + dizi[i];
                }
                dizi[i] += " bosluk: "+solBosluk;
            }
        }
        private string getBosluk(int solBosluk)
        {
            string temp = "";
            for (int i = 0; i < solBosluk; i++)
            {
                temp += " ";
            }
            return temp;
        }

        public string getPrint()
        {
            string temp = "";
            for (int i = 0; i < diziBoyut; i++)
            {
                temp += dizi[i] + "\n";
            }
            return temp;
        }
    }
}
