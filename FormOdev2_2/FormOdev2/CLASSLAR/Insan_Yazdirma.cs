using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormOdev2.CLASSLAR
{
    class Insan_Yazdirma
    {
        public string Get_String(Insan insan)
        {
            string temp =
                "Ad Soyad: " + insan.AdSoyad + "\n" +
                "Sehir: " + insan.Sehir + "\n" +
                "TC Kimlik: " + insan.TC + "\n" +
                "Cinsiyet: " + insan.Cinsiyet + "\n" +
                "CocukSayisi: " + insan.CocukSayisi + "\n" +
                "Web Adresi: " + insan.WebAdresi;
            return temp;
        }
        public void Print_String(Insan insan)
        {
            string temp = Get_String(insan);
            System.Windows.Forms.MessageBox.Show(temp);
        }
    }
}
