namespace FormOdev2
{
    public class Insan_WebAdresi
    {
        private string _Adres;

        public string Adres
        {
            get { return _Adres; }
            set {
                string temp = value.Trim();
                if (temp != string.Empty && BeginsWith(temp))
                {
                    _Adres = value;
                }
                else
                {
                    _Adres = "";
                }
                
            }
        }
        private bool BeginsWith(string temp)
        {
            temp = temp.ToLower();
            if (temp.Length<=2)
            {
                return false;
            }

            return (temp[0] == 'w' && temp[1] == 'w' && temp[2] == 'w');
        }


        public override string ToString()
        {
            return Adres;
        }
    }
}
