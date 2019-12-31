namespace FormOdev2
{
    public class Info_Sehir
    {
        private string _SehirAdi;
        public string SehirAdi {
            get { return _SehirAdi; }
            set {
                string temp = value.Trim();
                if (temp!=string.Empty)
                {
                    _SehirAdi = temp;
                }
            }
        }

        public string Aciklama { get; set; }
        public override string ToString()
        {
            return SehirAdi;
        }

    }
}
