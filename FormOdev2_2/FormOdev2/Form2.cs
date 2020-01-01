using FormOdev2.CLASSLAR;
using System;
using System.Windows.Forms;

namespace FormOdev2
{
    public partial class Form2 : Form
    {
        Insan insan;
        public Form2(Insan insan)
        {
            InitializeComponent();
            this.insan = insan;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (insan!=null)
            {
                lblAdSoyad.Text = insan.AdSoyad.ToString();
                lblSehir.Text = insan.Sehir.ToString();
                lblTC_No.Text = insan.TC.ToString();
                lblCinsiyet.Text = insan.Cinsiyet.ToString();
                lblCocukSayisi.Text = insan.CocukSayisi.ToString();
                lblWebAdresi.Text = insan.WebAdresi.ToString();
                webBrowser1.Navigate(lblWebAdresi.Text);
            }
        }
    }
}
