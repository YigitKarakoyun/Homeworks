using System;
using System.Windows.Forms;

namespace pojeYildiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonKelebek_Click(object sender, EventArgs e)
        {
            string [] dizi = printKelebek(15);
            printString(dizi, label1);
        }

        private string getStrings(int bosluk1,int bosluk2,int bosluk3)
        {
            return getString(bosluk1) + getString(bosluk2) + getString(bosluk3);
        }

        private string getString(int adet)
        {
            string temp = "";
            for (int i = 0; i < adet; i++)
            {
                temp += " ";
            }
            temp += "*";
            return temp;
        }
        private void printString(string[] dizi,Label label)
        {
            foreach (string item in dizi)
            {
                label.Text += (item)+"\n";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "";
            int diziBoyutu = Convert.ToInt32(comboBox1.Text);
            string[] dizi = printKelebek(diziBoyutu);
            printString(dizi,label1);
        }
        private string[] printKelebek(int diziBoyutu)
        {         
            int diziBoyutu_Yarisi = (diziBoyutu-3) / 2;
            string[] dizi = new string[diziBoyutu];

            //Başlangıç
            int ortasi = diziBoyutu_Yarisi + 1;
            for (int i = 0; i < ortasi; i++)
            {
                int tempBosluk = diziBoyutu_Yarisi - i;
                dizi[i] = getStrings(i,tempBosluk,tempBosluk);
                dizi[i+ortasi+1] = getStrings(tempBosluk, i, i);
            }
            //Ortasi
            int ortaAdet = (int)Math.Ceiling((diziBoyutu / 4) *1.0);
            //MessageBox.Show(diziBoyutu+" "+ortaAdet);
            for (int i = 0; i < diziBoyutu- ortaAdet; i++)
            {
                dizi[ortasi] += "*";
            }
            return dizi;
        }
    }
}
