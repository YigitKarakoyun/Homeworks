using System;
using System.Collections.Generic;
using System.Drawing;

namespace FormOdev2.CLASSLAR
{
    public class Insan
    {
        public string AdSoyad { get; set; } = "";
        public Sehir Sehir { get; set; } = null;
        public string TC { get; set; } = "";
        public string Cinsiyet { get; set; } = "";
        public List<string> Ehliyetler { get; set; } = null;
        public DateTime DogumTarihi { get; set; }
        public int Yas { get => DateTime.Now.Year - DogumTarihi.Year; }
        public int CocukSayisi { get; set; } = 0;
        public string WebAdresi { get; set; } = "";
        public Image Fotograf { get; set; } = null;


    }
}
