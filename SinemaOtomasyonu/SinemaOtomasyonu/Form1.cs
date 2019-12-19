using System;
using System.Drawing;
using System.Windows.Forms;
using SinemaOtomasyonu.Properties;

namespace SinemaOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Fieldlar
        Image imageBlue;
        Image imageRed;
        int row = 6;
        int column = 12;
        int buttonSize = 60;
        int offsetX = 0;
        int offsetY = 0;
        int count = 0;
        int spaceLeft = 30;
        int spaceTop = 4;

        //Bay ve Bayan sayılarını öğrenmek için kullanılan ortak metod
        int GetCinsCount(string cins)
        {
            int count = 0;
            foreach (Button item in groupBox1.Controls)
            {
                string btnTag = item.Tag.ToString();
                if (btnTag != string.Empty)
                {
                    var btnInfo = btnTag.Split('&');
                    if (btnInfo[2] == cins)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        //Bay Sayisini Öğrenme
        int GetBayCount()
        {
            return GetCinsCount("Bay");
        }

        //Bayan Sayisini Öğrenme
        int GetBayanCount()
        {
            return GetCinsCount("Bayan");
        }

        //Sinema Salonunu Oluşturma
        private void Form1_Load(object sender, EventArgs e)
        {
            imageBlue = Resources.imagesmavi;
            imageRed = Resources.imageskirmizi;

            offsetX = buttonSize / 2;
            offsetY = buttonSize / 2;

            count = 0;
            int sumSpaceTop = 0;
            for (int i = 0; i < row; i++)
            {
                int sumSpaceLeft = 0;
                sumSpaceTop += spaceTop;
                for (int j = 0; j < column; j++)
                {
                    if (j % 2 != 0)
                    {
                        sumSpaceLeft += spaceLeft;
                    }
                    if (GetButtonExist(i, j))
                    {
                        int left1 = j * buttonSize + offsetX + sumSpaceLeft;
                        int top1 = i * buttonSize + offsetY + sumSpaceTop;
                        AddButton_To_GroupBoxControl(left1, top1);
                    }
                }
            }
        }

        //Koltuk Oluşturma
        private Button GetButton()
        {
            Button btn = new Button();
            btn.Size = new Size(buttonSize, buttonSize);
            btn.BackgroundImage = imageBlue;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.ForeColor = Color.AliceBlue;
            btn.Font = new Font("Showcard Gothic", 14.25f);
            btn.Tag = "";
            btn.MouseDown += Btn_MouseDown;
            return btn;
        }

        //Koltuk Rezarvasyon
        private void Btn_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            FormRezarvasyon temp = new FormRezarvasyon(btn);
            temp.ShowDialog();
        }

        //Sinema Salonuna koltuk ekler.
        private void AddButton_To_GroupBoxControl(int left1, int top1)
        {
            Button btn = GetButton();
            btn.Left = left1;
            btn.Top = top1;

            count++;
            btn.Text = count.ToString();
            groupBox1.Controls.Add(btn);
        }
        
        //Koltuk Oluşturulma Koşuluna Uygun Mu Kontrol Eder
        private bool GetButtonExist(int i, int j)
        {
            return !(GetRowDouble(i) && GetColumnDouble(j));
        }
        
        //Çiftli sirada mi onu anlıyoruz.
        private bool GetRowDouble(int i)
        {
            return i % 2 == 0;
        }
        
        //Çiftli sıradaki koltuklar hangileri oluşturulsun.
        private bool GetColumnDouble(int j)
        {
            return j < 2 || j + 2 >= column;
        }

        //Günlük Analiz Formun Oluşturulduğu Yer
        private void btnGunlukAnaliz_Click(object sender, EventArgs e)
        {
            FormGunlukAnaliz frm = new FormGunlukAnaliz(GetBayCount(), GetBayanCount());
            frm.ShowDialog();
        }
    }
}
