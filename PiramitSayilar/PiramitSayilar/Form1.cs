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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            class_Sayilar sayilar = new class_Sayilar();
            int sayi = (int)numericUpDown1.Value;
            sayilar.setDizi(sayi);
            sayilar.setBoslukDizisi(sayi);
            string temp = sayilar.getString2(sayi);
            label1.Text = temp;
        }
    }
}
