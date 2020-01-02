using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormOdev2
{
    public class Insan
    {
        public Insan_AdSoyad  AdSoyad { get; set; }
        public Insan_Cinsiyet Cinsiyet { get; set; }
        public List<Insan_Ehliyet> Ehliyetler { get; set; }
        public Insan_Sehir Sehir { get; set; }
        public Insan_CocukSayisi CocukSayisi { get; set; }
        public Insan_TC TC { get; set; }
        public Insan_WebAdresi WebAdresi { get; set; }
        public override string ToString()
        {
            string temp = 
                "Ad Soyad: "+AdSoyad+"\n"+
                "Sehir: "+Sehir+ "\n" +
                "TC Kimlik: " +TC+ "\n" +
                "Cinsiyet: " +Cinsiyet+ "\n" +
                "CocukSayisi: " +CocukSayisi+ "\n" +
                "Web Adresi: " +WebAdresi;
            return temp;
        }
        public void printMbox()
        {
            System.Windows.Forms.MessageBox.Show(ToString());
        }
    }
}
