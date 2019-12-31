using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormOdev2
{
    public class Info
    {
        public Info_AdSoyad  AdSoyad { get; set; }
        public Info_Cinsiyet Cinsiyet { get; set; }
        public List<Info_Ehliyet> Ehliyetler { get; set; }
        public Info_Sehir Sehir { get; set; }
        public Info_CocukSayisi CocukSayisi { get; set; }
        public Info_TC TC { get; set; }
        public Info_WebAdresi WebAdresi { get; set; }
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
