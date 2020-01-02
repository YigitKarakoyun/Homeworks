using System;
using System.Windows.Forms;

namespace FormOdev2
{
    public partial class Form2 : Form
    {
        Insan info;
        public Form2(Insan info)
        {
            InitializeComponent();
            this.info = info;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (info!=null)
            {
                lblAdSoyad.Text = info.AdSoyad.ToString();
                lblSehir.Text = info.Sehir.ToString();
                lblTC_No.Text = info.TC.ToString();
                lblCinsiyet.Text = info.Cinsiyet.ToString();
                lblCocukSayisi.Text = info.CocukSayisi.ToString();
                lblWebAdresi.Text = info.WebAdresi.ToString();
                webBrowser1.Navigate(lblWebAdresi.Text);
            }
        }
    }
}
