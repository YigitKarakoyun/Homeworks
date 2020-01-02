namespace FormOdev2
{
    public class Insan_Cinsiyet
    {
        private string _Cinsiyet;
        public string Cinsiyet
        {
            get => _Cinsiyet;
            set
            {
                string temp = value.ToString();
                if (temp != string.Empty && !Get_RakamIceriyorMu(temp))
                {
                    _Cinsiyet = temp;
                }

            }
        }

        private bool Get_RakamIceriyorMu(string temp)
        {
            bool tempIceriyorMu = false;
            for (int i = 0; i <= 9; i++)
            {
                if (temp.Contains(i.ToString()))
                {
                    tempIceriyorMu = true;
                    break;
                }
            }
            return tempIceriyorMu;
        }

        public override string ToString()
        {
            return Cinsiyet.ToString();
        }

    }

}
