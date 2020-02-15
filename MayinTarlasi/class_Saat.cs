using System.Windows.Forms;

namespace _13_MayinTarlasi
{
    class class_Saat
    {
        Label lbl;

        public int Saat { get; private set; } = 0;
        public int Dakika { get; private set; } = 0;
        public int Saniye { get; private set; } = -1;

        public string ZamanText { get; private set; } = "";

        public void setTimerSifirla()
        {
            Saat = Dakika = 0;
            Saniye = -1;
            ZamanText = "";
        }
        public void setTick()
        {
            Saniye++;
            if (Saniye > 59)
            {
                Saniye = 0;
                Dakika++;
                if (Dakika > 59)
                {
                    Dakika = 0;
                    Saat++;
                    if (Saat > 23)
                    {
                        Saat = 0;

                    }

                }

            }
            ZamanText = "Süre: ";
            if (Saat < 10) { ZamanText += string.Format("0{0}:", Saat); }
            else { ZamanText += string.Format("{0}:", Saat); }

            if (Dakika < 10) { ZamanText += string.Format("0{0}:", Dakika); }
            else { ZamanText += string.Format("{0}:", Dakika); }

            if (Saniye < 10) { ZamanText += string.Format("0{0}", Saniye); }
            else { ZamanText += string.Format("{0}", Saniye); }

            lbl.Text = ZamanText;
        }
        public class_Saat(Label label)
        {
            lbl = label;
        }

    }
}
