using System;

namespace FormOdev2
{
    public class Info_AdSoyad
    {
        private string _AdSoyad;
        public string AdSoyad
        {
            get => _AdSoyad;
            set
            {
                string temp = value.Trim();
                if (temp != string.Empty && !Get_RakamIceriyorMu(temp))
                {
                    _AdSoyad = temp;
                }
                else
                {
                    _AdSoyad = "";
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
            return AdSoyad;
        }
    }
}
