using System;
using System.Windows.Forms;

namespace _13_MayinTarlasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void setYeniOyun(int boyut,int satir, int sutun,byte secim)
        {
            this.secim = secim;
            btnBoyut = boyut;
            Top = 0;
            setTarlayiDoldur(satir, sutun);
        }
        private void kolayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setYeniOyun(70, 10, 10, 0);
        }

        private void ortaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setYeniOyun(45, 15, 15, 1);
        }

        private void zortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setYeniOyun(34, 20, 20, 2);
        }
        byte secim = 0;
        ButtonYeni[] buttons;
        int btnBoyut = 50;
        public void setTarlayiDoldur(int satir, int sutun)
        {
            
            class_Saat.setTimerSifirla();
            timerSure.Start();
            class_FormBoyutlandirma.setFormuBoyutlandirma(satir, sutun,btnBoyut);
            buttons = GetButtons(satir, sutun, btnBoyut);
            setMayinlariButtonlaraDoldurur(buttons);
            setMayinlariFlowLayoutaDoldurur(buttons);

        }
        #region SÜRE

        private void timerSure_Tick(object sender, EventArgs e)
        {
            class_Saat.setTick();
        }
        #endregion

        private void btnEmoji_Click(object sender, EventArgs e)
        {
            if (secim == 0)
            {
                kolayToolStripMenuItem_Click(null, null);
            }
            else if (secim == 1)
            {
                ortaToolStripMenuItem_Click(null, null);
            }
            else
            {
                zortToolStripMenuItem_Click(null, null);
            }
            class_Saat.setTimerSifirla();
        }
        class_ButtonYeni class_ButtonYeni = new class_ButtonYeni();
        private ButtonYeni[] GetButtons(int satir, int sutun)
        {
            return class_ButtonYeni.GetButtonYeniler(satir, sutun, btnBoyut, btnBoyut);
        }
        private ButtonYeni[] GetButtons(int satir, int sutun, int boyutu)
        {
            return class_ButtonYeni.GetButtonYeniler(satir, sutun, boyutu, boyutu);
        }
        private void setMayinlariButtonlaraDoldurur(ButtonYeni[] Buttons)
        {
            class_ButtonYeni.SetMayinlariDoldur(Buttons);
        }
        private void setMayinlariFlowLayoutaDoldurur(ButtonYeni[] buttons)
        {
            fpMayinTarlasi.Controls.Clear();
            for (int i = 0; i < buttons.Length; i++)
            {
                ButtonYeni buttonYeni = buttons[i];
                buttonYeni.Click += ButtonYeni_Click;
                fpMayinTarlasi.Controls.Add(buttonYeni);
                Application.DoEvents();
            }

        }

        private void ButtonYeni_Click(object sender, EventArgs e)
        {
            ButtonYeni temp = sender as ButtonYeni;
            if (temp.mayinliMi)
            {
                foreach (ButtonYeni item in buttons)
                {
                    if (item.mayinliMi)
                    {
                        item.setMayinliMi_BackColor();

                    }
                    else
                    {
                        item.setMayinliMi_BackColor();
                    }
                }

                timerSkor.Stop();
                timerSure.Stop();
                DialogResult result = MessageBox.Show("Yeni Oyun Oynamak İstermisiniz!", "Yenildiniz", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    btnEmoji_Click(null, null);
                }
            }
            else
            {
                temp.setMayinliMi_BackColor();
            }
        }

        class_Saat class_Saat;
        class_FormBoyutlandirma class_FormBoyutlandirma;
        private void Form1_Load(object sender, EventArgs e)
        {
            class_Saat = new class_Saat(labelSure);
            class_FormBoyutlandirma = new class_FormBoyutlandirma(this, tableLayoutPanelBaslik.Height);
            kolayToolStripMenuItem_Click(null, null);
        }
    }
}
