using System;
using System.Windows.Forms;
using SinemaOtomasyonu.Properties;

namespace SinemaOtomasyonu
{
    public partial class FormRezarvasyon : Form
    {
        public FormRezarvasyon()
        {
            InitializeComponent();
        }

        //Field
        Button btn;
        public FormRezarvasyon(Button btn)
        {
            InitializeComponent();
            this.btn = btn;
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            //Cinsiyet Kontrolü
            string cinsiyet = "";

            if (radioBay.Checked)
            {
                cinsiyet = radioBay.Text;
            }
            else
            {
                cinsiyet = radioBayan.Text;
            }

            //Ad Soyad Kontrolü
            string adSoyad = txtAdSoyad.Text.Trim();
            int adSoyadSize = adSoyad.Length;
            if (adSoyadSize <= 0)
            {
                MessageBox.Show("Ad Soyad Giriniz");
                return;
            }

            //Tc Kontrolü
            string tc = maskedTC.Text.Trim();
            int tcSize = tc.Length;
            if (tcSize != 11)
            {
                MessageBox.Show("TC 11 Haneli Olacak Şekilde Giriniz");
                return;
            }

            //Koltuğa Rezervasyon Yapar
            if (btn != null)
            {
                btn.Tag = adSoyad + "&" + tc + "&" + cinsiyet;
                btn.BackgroundImage = Resources.imageskirmizi;
            }
            Dispose();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            //Koltuk içi dolu mu onu kontrol eder
            if (btn != null && btn.Tag.ToString() != string.Empty)
            {
                //Koltuktan kaydı silmek isteyip istemediğinizi sorar.
                DialogResult dialogResult = MessageBox.Show("Silmek istiyormusunuz?", "Silme", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    btn.Tag = "";
                    btn.BackgroundImage = Resources.imagesmavi;
                }
            }

            Dispose();
        }

        //Koltuk Doluysa Bilgileri Doldurur.
        private void FormRezarvasyon_Load(object sender, EventArgs e)
        {
            if (btn != null)
            {
                string btnText = btn.Tag.ToString();
                if (btnText != string.Empty)
                {
                    var btnInfos = btnText.Split('&');
                    txtAdSoyad.Text = btnInfos[0];
                    maskedTC.Text = btnInfos[1];
                    string cins = btnInfos[2];
                    if (cins == radioBay.Text)
                    {
                        radioBay.Checked = true;
                    }
                    else
                    {
                        radioBayan.Checked = true;
                    }
                }
            }
        }
    }
}
