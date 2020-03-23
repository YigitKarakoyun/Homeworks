using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeRastgeleSayinin_Rakamlari_Toplami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRastgeleSayiOlustur_Click(object sender, EventArgs e)
        {
            int randomNumber = Get_RandomNumber();

            label1.Text = "";
            label1.Text = "Rastgele Sayı: "+ randomNumber.ToString();
            label1.Text += Environment.NewLine;
            int randomNumberSum = Get_SumNumbers(randomNumber);
            label1.Text += "Rastgele Sayının Rakamları Toplamı:" + randomNumberSum;
    
        }
        Random rnd = new Random();
        private int Get_RandomNumber()
        {
           return rnd.Next(1000);
        }
        private int Get_SumNumbers(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += (number % 10);
                number = number / 10;
            }
            return sum;
        }
    }
}
