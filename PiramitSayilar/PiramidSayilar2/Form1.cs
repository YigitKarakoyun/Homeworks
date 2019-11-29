using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiramidSayilar2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPiramid_Click(object sender, EventArgs e)
        {
            print();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            print();
        }
        private void print()
        {
            class_Piramid piramid = new class_Piramid();

            int sayi = (int)numericUpDown1.Value;
            piramid.setDiziOlusturup_Doldurur(sayi);
            piramid.setDiziDuzenle();
            string print = piramid.getPrint();
            label1.Text = print;
        }
    }
}
