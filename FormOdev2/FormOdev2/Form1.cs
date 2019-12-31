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
        Info_Ehliyet[] info_ehliyetler =
        {
            new Info_Ehliyet(){ Ehliyet = "A2" },
            new Info_Ehliyet(){ Ehliyet = "B" },
        };
        Info_Cinsiyet[] info_cinsiyetler =
        {
            new Info_Cinsiyet(){ Cinsiyet = "Bay" },
            new Info_Cinsiyet(){ Cinsiyet = "Bayan" },
        };
        Info_Sehir[] info_sehirler = {
            new Info_Sehir() { SehirAdi = "Izmir", Aciklama = "" },
            new Info_Sehir() { SehirAdi = "Manisa", Aciklama = "" },
            new Info_Sehir() { SehirAdi = "Erzurum", Aciklama = "" },
            new Info_Sehir() { SehirAdi = "Bitlis", Aciklama = "" },
            new Info_Sehir() { SehirAdi = "Trabzon", Aciklama = "" },
            new Info_Sehir() { SehirAdi = "Usak", Aciklama = "" },
        };
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //Şehirleri Doldurur
            cBoxSehir.DataSource = null;
            cBoxSehir.DataSource = info_sehirler;

            //Cinsiyetleri Tanımlama
            radioBtnBay.Tag = info_cinsiyetler[0];
            radioBtnBayan.Tag = info_cinsiyetler[1];

            radioBtnBay.Text = radioBtnBay.Tag.ToString();
            radioBtnBayan.Text = radioBtnBayan.Tag.ToString();

            //Ehliyetleri Tanımlama
            checkBxA2.Tag = info_ehliyetler[0];
            checkBxB.Tag = info_ehliyetler[1];

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


        Info_AdSoyad info_AdSoyad = new Info_AdSoyad();
        Info_Sehir info_Sehir = new Info_Sehir();
        Info_TC info_TC = new Info_TC();
        Info_Cinsiyet info_Cinsiyet = new Info_Cinsiyet();
        Info_CocukSayisi info_CocukSayisi = new Info_CocukSayisi();
        List<Info_Ehliyet> info_Ehliyetler = new List<Info_Ehliyet>();
        Info_WebAdresi info_WebAdresi = new Info_WebAdresi();
        private void btnShowAllInfo_Click(object sender, EventArgs e)
        {

            //AD SOYAD KONTROLÜ YAPAR
            info_AdSoyad.AdSoyad = txtAdSoyad.Text;
            if (info_AdSoyad.AdSoyad ==string.Empty)
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
            info_Sehir.SehirAdi = sehirItem.ToString();
        
            //ÇOCUK SAYISI KONTROLÜ YAPAR
            info_CocukSayisi.CocukSayisi = (int)numCocukSayisi.Value;
            if (info_CocukSayisi.CocukSayisi<0)
            {
                MessageBox.Show("Çocuk Sayısı 0 dan Küçük Olamaz");
                return;
            }

            //TC 11 HANELİ KONTROLÜ YAPAR
            string tcText = info_TC.Get_DogruString(txtTCNo.Text);
            int tcLen = tcText.Length;
            if (tcLen != 11)
            {
                errorProvider1.SetError(txtTCNo,"11 Haneli TC No Giriniz");
                return;
            }
            info_TC.TC = tcText;

            //TC NO DOĞRUYSA ERROR PROVIDER SILER
            errorProvider1.SetError(txtTCNo, "");

            //CİNSİYET BELİRLER
            if (radioBtnBay.Checked)
            {
                info_Cinsiyet = (Info_Cinsiyet)radioBtnBay.Tag;
            }
            else
            {
                info_Cinsiyet = (Info_Cinsiyet)radioBtnBayan.Tag;
            }

            //EHLİYETLERİ EKLER
            info_Ehliyetler.Clear();
            if (checkBxA2.Checked)
            {
                info_Ehliyetler.Add((Info_Ehliyet)checkBxA2.Tag);
            }
            if (checkBxB.Checked)
            {
                info_Ehliyetler.Add((Info_Ehliyet)checkBxB.Tag);
            }

            //WEB ADRESİ
            info_WebAdresi.Adres = txtWebAdresi.Text;
            if (info_WebAdresi.Adres == string.Empty)
            {
                txtWebAdresi.Text = "";
                //MessageBox.Show("Web adresleri www ile başlar");
                //return;
            }

            //Yazdırma
            Info info = new Info();
            info.AdSoyad = info_AdSoyad;
            info.Cinsiyet = info_Cinsiyet;
            info.CocukSayisi = info_CocukSayisi;
            info.Ehliyetler = info_Ehliyetler;
            info.WebAdresi = info_WebAdresi;
            info.TC = info_TC;
            info.Sehir = info_Sehir;
            info.printMbox();

            Form2 frm2 = new Form2(info);
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
