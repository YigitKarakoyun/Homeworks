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
        Insan_Ehliyet[] insan_ehliyetler =
        {
            new Insan_Ehliyet(){ Ehliyet = "A2" },
            new Insan_Ehliyet(){ Ehliyet = "B" },
        };
        Insan_Cinsiyet[] insan_cinsiyetler =
        {
            new Insan_Cinsiyet(){ Cinsiyet = "Bay" },
            new Insan_Cinsiyet(){ Cinsiyet = "Bayan" },
        };
        Insan_Sehir[] insan_sehirler = {
            new Insan_Sehir() { SehirAdi = "Izmir", Aciklama = "" },
            new Insan_Sehir() { SehirAdi = "Manisa", Aciklama = "" },
            new Insan_Sehir() { SehirAdi = "Erzurum", Aciklama = "" },
            new Insan_Sehir() { SehirAdi = "Bitlis", Aciklama = "" },
            new Insan_Sehir() { SehirAdi = "Trabzon", Aciklama = "" },
            new Insan_Sehir() { SehirAdi = "Usak", Aciklama = "" },
        };
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //Şehirleri Doldurur
            cBoxSehir.DataSource = null;
            cBoxSehir.DataSource = insan_sehirler;

            //Cinsiyetleri Tanımlama
            radioBtnBay.Tag = insan_cinsiyetler[0];
            radioBtnBayan.Tag = insan_cinsiyetler[1];

            radioBtnBay.Text = radioBtnBay.Tag.ToString();
            radioBtnBayan.Text = radioBtnBayan.Tag.ToString();

            //Ehliyetleri Tanımlama
            checkBxA2.Tag = insan_ehliyetler[0];
            checkBxB.Tag = insan_ehliyetler[1];

            checkBxA2.Text = checkBxA2.Tag.ToString();
            checkBxB.Text = checkBxB.Tag.ToString();

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


        Insan_AdSoyad insan_AdSoyad = new Insan_AdSoyad();
        Insan_Sehir insan_Sehir = new Insan_Sehir();
        Insan_TC insan_TC = new Insan_TC();
        Insan_Cinsiyet insan_Cinsiyet = new Insan_Cinsiyet();
        Insan_CocukSayisi insan_CocukSayisi = new Insan_CocukSayisi();
        List<Insan_Ehliyet> insan_Ehliyetler = new List<Insan_Ehliyet>();
        Insan_WebAdresi insan_WebAdresi = new Insan_WebAdresi();
        private void btnShowAllInsan_Click(object sender, EventArgs e)
        {

            //AD SOYAD KONTROLÜ YAPAR
            insan_AdSoyad.AdSoyad = txtAdSoyad.Text;
            if (insan_AdSoyad.AdSoyad ==string.Empty)
            {
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
            insan_Sehir.SehirAdi = sehirItem.ToString();
        
            //ÇOCUK SAYISI KONTROLÜ YAPAR
            insan_CocukSayisi.CocukSayisi = (int)numCocukSayisi.Value;
            if (insan_CocukSayisi.CocukSayisi<0)
            {
                MessageBox.Show("Çocuk Sayısı 0 dan Küçük Olamaz");
                return;
            }

            //TC 11 HANELİ KONTROLÜ YAPAR
            string tcText = insan_TC.Get_DogruString(txtTCNo.Text);
            int tcLen = tcText.Length;
            if (tcLen != 11)
            {
                errorProvider1.SetError(txtTCNo,"11 Haneli TC No Giriniz");
                return;
            }
            insan_TC.TC = tcText;

            //TC NO DOĞRUYSA ERROR PROVIDER SILER
            errorProvider1.SetError(txtTCNo, "");

            //CİNSİYET BELİRLER
            if (radioBtnBay.Checked)
            {
                insan_Cinsiyet = (Insan_Cinsiyet)radioBtnBay.Tag;
            }
            else
            {
                insan_Cinsiyet = (Insan_Cinsiyet)radioBtnBayan.Tag;
            }

            //EHLİYETLERİ EKLER
            insan_Ehliyetler.Clear();
            if (checkBxA2.Checked)
            {
                insan_Ehliyetler.Add((Insan_Ehliyet)checkBxA2.Tag);
            }
            if (checkBxB.Checked)
            {
                insan_Ehliyetler.Add((Insan_Ehliyet)checkBxB.Tag);
            }

            //WEB ADRESİ
            insan_WebAdresi.Adres = txtWebAdresi.Text;
            if (insan_WebAdresi.Adres == string.Empty)
            {
                txtWebAdresi.Text = "";
                //MessageBox.Show("Web adresleri www ile başlar");
                //return;
            }

            //Yazdırma
            Insan insan = new Insan();
            insan.AdSoyad = insan_AdSoyad;
            insan.Cinsiyet = insan_Cinsiyet;
            insan.CocukSayisi = insan_CocukSayisi;
            insan.Ehliyetler = insan_Ehliyetler;
            insan.WebAdresi = insan_WebAdresi;
            insan.TC = insan_TC;
            insan.Sehir = insan_Sehir;
            insan.printMbox();
            insan.Photo = pBoxFotograf.BackgroundImage;

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
