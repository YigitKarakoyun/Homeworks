using PiramitSayilar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiramitSayilar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPiramid_Click(object sender, EventArgs e)
        {
            class_Piramid sayilar = new class_Piramid();
            
            //İSTENEN DEĞERİ ÇEKME
            int sayi = (int)numericUpDown1.Value;

            //DİZİLERİ GEREKLİ VERİLERLE DOLDURMA
            sayilar.setDizi(sayi);
            sayilar.setDizininBosluklari(sayi);

            //SONUCU YAZDIRMA
            label1.Text = sayilar.getStringSolBosluklariyla(sayi); ;
        }
    }
}
