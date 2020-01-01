using FormOdev2.CLASSLAR;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FormOdev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Sehir[] info_sehirler = {
            new Sehir() { SehirAdi = "Izmir", Plaka = 35 },
            new Sehir() { SehirAdi = "Manisa", Plaka = 45 },
            new Sehir() { SehirAdi = "Erzurum", Plaka = 25 },
            new Sehir() { SehirAdi = "Bitlis", Plaka = 13 },
            new Sehir() { SehirAdi = "Trabzon", Plaka = 61 },
            new Sehir() { SehirAdi = "Usak", Plaka = 64 },
        };
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //Şehirleri Doldurur
            cBoxSehir.DataSource = null;
            cBoxSehir.DataSource = info_sehirler;

            radioBtnBay.Text = "Bay";
            radioBtnBayan.Text = "Bayan";

            checkBxA2.Text = "A2";
            checkBxB.Text = "B";

            //DateTimePicker MaxDate
            dTPickerDogumTarihi.MaxDate = DateTime.Now;

            //Resim Seçme Koşulu
            openFileDialog1.Filter = "All Images|*.BMP;*.DIB;*.RLE;*.JPG;*.JPEG;*.JPE;*.JFIF;*.GIF;*.TIF;*.TIFF;*.PNG";

        }

        //PİCTUREBOX IMAGE YUKLEME
        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pBoxFotograf.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
            }
        }

        //TC GİRİŞİNİ DOĞRU YAPILMASINI SAĞLAR
        private void txtTCNo_TextChanged(object sender, EventArgs e)
        {
            string txt = txtTCNo.Text;
            int len = txt.Length;

            for (int i = len-1; i >=0; i--)
            {
                char car = txt[i];

                if (
                     car != '0' && car != '1' && car != '2' && car != '3' && car != '4' &&
                     car != '5' && car != '6' && car != '7' && car != '8' && car != '9'
                    )
                {
                    errorProvider1.SetError(txtTCNo, "Sadece Rakam Giriniz");
                    txtTCNo.Text = txtTCNo.Text.Remove(i,1);
                    txtTCNo.Select(i, 0);
                }

            }
            
            
        }

        private void btnShowAllInfo_Click(object sender, EventArgs e)
        {
            //AD SOYAD KONTROLÜ YAPAR
            if (txtAdSoyad.Text.Trim() == string.Empty)
            {
                txtAdSoyad.Text = "";
                MessageBox.Show("Ad Soyad Giriniz");
                return;
            }

            //ŞEHİR KONTROLÜ YAPAR
            var sehirItem = cBoxSehir.SelectedItem;
            if (sehirItem == null)
            {
                MessageBox.Show("Şehir Seçiniz");
                return;
            }

            //TC 11 HANELİ KONTROLÜ YAPAR
            string txt_tc = txtTCNo.Text;
            int len = txt_tc.Length;

            for (int i = len - 1; i >= 0; i--)
            {
                char car = txt_tc[i];

                if (
                     car != '0' && car != '1' && car != '2' && car != '3' && car != '4' &&
                     car != '5' && car != '6' && car != '7' && car != '8' && car != '9'
                    )
                {

                    txt_tc = txt_tc.Remove(i, 1);
                }

            }

            len = txt_tc.Length;
            if (len != 11)
            {
                errorProvider1.SetError(txtTCNo, "11 Haneli TC No Giriniz");
                return;
            }


            //CİNSİYET BELİRLER
            string cinsiyet = radioBtnBayan.Text;
            if (radioBtnBay.Checked)
            {
                cinsiyet = radioBtnBay.Text;
            }

            //Ehliyetler
            List<string> ehliyetler = null;
            if (checkBxA2.Checked)
            {
                if (ehliyetler ==null)
                {
                    ehliyetler = new List<string>();
                }
                ehliyetler.Add(checkBxA2.Text);
            }

            if (checkBxB.Checked)
            {
                if (ehliyetler == null)
                {
                    ehliyetler = new List<string>();
                }
                ehliyetler.Add(checkBxB.Text);
            }

            //ÇOCUK SAYISI KONTROLÜ YAPAR
            int cocukSayisi = (int)numCocukSayisi.Value;
            if (cocukSayisi < 0)
            {
                MessageBox.Show("Çocuk Sayısı 0 dan Küçük Olamaz");
                return;
            }

            if (txtWebAdresi.Text.Trim() == string.Empty)
            {
                txtWebAdresi.Text = "";
            }

            Insan insan = new Insan();
            insan.AdSoyad = txtAdSoyad.Text;
            insan.Sehir = (Sehir)sehirItem;
            insan.Cinsiyet = cinsiyet;
            insan.Ehliyetler = ehliyetler;
            insan.CocukSayisi = cocukSayisi;
            insan.WebAdresi = txtWebAdresi.Text;
            insan.TC = txt_tc;

            Insan_Yazdirma insan_yazdirma = new Insan_Yazdirma();
            insan_yazdirma.Print_String(insan);


            //TC NO DOĞRUYSA ERROR PROVIDER SILER
            errorProvider1.SetError(txtTCNo, "");
            
            Form2 frm2 = new Form2(insan);
            frm2.ShowDialog();
            
        }

        private void dTPickerDogumTarihi_ValueChanged(object sender, EventArgs e)
        {
            int yil = dTPickerDogumTarihi.Value.Year;
            int buyil = DateTime.Now.Year;

            lblYas.Text = (buyil - yil).ToString();

        }

        //WEB SAYFASI GİRİŞ YAPAR
        private void txtWebAdresi_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtWebAdresi.Text);
        }
    }
    
}
