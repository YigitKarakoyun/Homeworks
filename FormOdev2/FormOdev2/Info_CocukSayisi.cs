namespace FormOdev2
{
    public class Info_CocukSayisi
    {
        private int _CocukSayisi;
        public int CocukSayisi
        {
            get => _CocukSayisi;
            set
            {
                if (value>=0)
                {
                    _CocukSayisi = value;
                }

            }
        }
        public override string ToString()
        {
            return CocukSayisi.ToString();
        }
    }
}
