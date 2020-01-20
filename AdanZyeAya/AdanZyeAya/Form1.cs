using System;
using System.Windows.Forms;

namespace AdanZyeAya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnHarf_Click(object sender, EventArgs e)
        {


            MetinYaz(7);
            
            
        }

        private void MetinYaz(int adet)
        {
            try
            {

                string z_den_aya = string.Empty;
                string a_dan_zye = string.Empty;
                int a = 'A';

                int enbuyuk = 100;
                int z = a + adet;

                if (adet > enbuyuk)
                {
                    MessageBox.Show("adet" + (enbuyuk) + " dan büyük olamaz");
                    return;
                }
                int count = 0;
                for (int i = a; i < z; i++)
                {
                    if (i < z - 1)
                    {
                        a_dan_zye += ((char)i).ToString();
                    }

                    z_den_aya += ((char)(z - count - 1)).ToString();
                    count++;
                }



                string metin = string.Empty;
                for (int i = 0; i < a_dan_zye.Length; i++)
                {
                    metin += a_dan_zye[i].ToString() + " ";
                }
                for (int i = 0; i < z_den_aya.Length; i++)
                {
                    metin += z_den_aya[i].ToString() + " ";
                }

               

                string[] metinler = new string[adet];
                metinler[0] = metin;
                int len = metinler.Length;
                
                for (int i = 1; i < len; i++)
                {
                    metinler[i] = metinler[i - 1].Replace(z_den_aya[i - 1], ' ');
              
                }
                string tumsatir = string.Empty;
                foreach (string satir in metinler)
                {
                    tumsatir += (satir) + "\n";
                }
                label1.Text = tumsatir;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
