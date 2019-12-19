using System.Windows.Forms;

namespace SinemaOtomasyonu
{
    public partial class FormGunlukAnaliz : Form
    {
        public FormGunlukAnaliz()
        {
            InitializeComponent();
        }

        //Günlük Analiz Bilgilerini Gösterir
        public FormGunlukAnaliz(int bay,int bayan)
        {
            InitializeComponent();
            lblBay.Text = "Bay Sayısı: "+ bay.ToString();
            lblBayan.Text = "Bayan Sayısı: " + bayan.ToString();
            lblToplam.Text = "İzleyici Sayısı: " + (bay + bayan).ToString();
        }
    }
}
