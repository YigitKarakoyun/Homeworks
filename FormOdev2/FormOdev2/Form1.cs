using System;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            cBoxSehir.Items.Clear();
            cBoxSehir.Items.Add(new Sehir() { Adi = "Izmir", Aciklama = "" });
            cBoxSehir.Items.Add(new Sehir() { Adi = "Manisa", Aciklama = "" });
            cBoxSehir.Items.Add(new Sehir() { Adi = "Erzurum", Aciklama = "" });
            cBoxSehir.Items.Add(new Sehir() { Adi = "Bitlis", Aciklama = "" });
            cBoxSehir.Items.Add(new Sehir() { Adi = "Trabzon", Aciklama = "" });
            cBoxSehir.Items.Add(new Sehir() { Adi = "Usak", Aciklama = "" });
        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                pBoxFotograf.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
            }
        }

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
                    txtTCNo.Text = txtTCNo.Text.Remove(i,1);
                    txtTCNo.Select(i, 0);

                }
            }
            
            
        }

        private void txtWebAdresi_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtWebAdresi.Text);
        }

        private void btnShowAllInfo_Click(object sender, EventArgs e)
        {
            string adSoyadText = txtAdSoyad.Text.Trim();
            if (adSoyadText==string.Empty)
            {
                adSoyadText = "";
                MessageBox.Show("Ad Soyad Giriniz");
                return;
            }
            var sehirItem = cBoxSehir.SelectedItem;
            if (sehirItem==null)
            {
                MessageBox.Show("Şehir Seçiniz");
                return;
            }
            string sehirText = sehirItem.ToString();

            string tcText = txtTCNo.Text;
            int tcLen = tcText.Length;
            if (tcLen!=11)
            {
                MessageBox.Show("11 Haneli TC No Giriniz");
                return;
            }
            string cinsiyetText = "";
            if (radioBtnErkek.Checked)
            {
                cinsiyetText = radioBtnErkek.Text;
            }
            else
            {
                cinsiyetText = radioBtnBayan.Text;
            }
            string yazBeni = string.Format(
                "Ad Soyad: {0}\n" +
                "Sehir: {1}\n" +
                "TC Kimlik No:{2}\n" +
                "Cinsiyet: {3}\n" +
                "Cocuk Sayısı: {4}\n" +
                "Web Adresi: {5}",
                
                adSoyadText,
                sehirText,
                tcText, 
                cinsiyetText,
                numCocukSayisi.Value,
                txtWebAdresi.Text);

            MessageBox.Show(yazBeni);
        }

        private void dTPickerDogumTarihi_ValueChanged(object sender, EventArgs e)
        {
            int yil = dTPickerDogumTarihi.Value.Year;

            int buyil = DateTime.Now.Year;

            lblYas.Text = (buyil - yil).ToString();

        }
    }
    public class Sehir
    {
        public string Adi { get; set; }
        public string Aciklama { get; set; }
        public override string ToString()
        {
            return Adi;
        }
    }
}
