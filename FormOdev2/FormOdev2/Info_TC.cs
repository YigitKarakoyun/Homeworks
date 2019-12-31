namespace FormOdev2
{
    public class Info_TC
    {
        private string _TC;
        public string TC
        {
            get => _TC;
            set
            {
                string temp = value.Trim();
                if (temp != string.Empty && Get_RakamIceriyorMu(temp))
                {
                    _TC = temp;
                }
                else
                {
                    _TC = "";
                }
            }
        }
        public string Get_DogruString(string txt)
        {
            int len = txt.Length;

            for (int i = len - 1; i >= 0; i--)
            {
                char car = txt[i];

                if (
                     car != '0' && car != '1' && car != '2' && car != '3' && car != '4' &&
                     car != '5' && car != '6' && car != '7' && car != '8' && car != '9'
                    )
                {
                    
                    return txt.Remove(i, 1);
                }

            }
            return txt;
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
            return TC;
        }
    }
}