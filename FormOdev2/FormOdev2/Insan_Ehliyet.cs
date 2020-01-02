namespace FormOdev2
{
    public class Insan_Ehliyet
    {
        private string _Ehliyet;

        public string Ehliyet
        {
            get { return _Ehliyet; }
            set {

                string temp = value.ToString().Trim();
                if (temp != string.Empty)
                {
                    _Ehliyet = temp;
                }
            }
        }
        public override string ToString()
        {
            return Ehliyet;
        }
    }


}
