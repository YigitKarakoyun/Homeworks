namespace FormOdev2
{
    public class Sehir
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
        public int Plaka { get; set; }
        public override string ToString()
        {
            return SehirAdi;
        }

    }
}
