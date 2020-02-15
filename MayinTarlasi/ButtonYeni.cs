using System;
using System.Drawing;
using System.Windows.Forms;


namespace _13_MayinTarlasi
{

    class ButtonYeni : Button
    {
        public Color colorTemiz { get; set; } = SystemColors.ControlDark;
        public Color colorBosArazi { get; set; } = SystemColors.ControlDarkDark;
        public Color colorMayinli { get; set; } = Color.Firebrick;
        
        public int mayinSayisi { get; set; } = 0;
        public bool mayinliMi { get; set; } = false;

        public void setMayinliMi_BackColor()
        {
            if (mayinliMi)
            {
                BackColor = colorMayinli;
            }
            else
            {
                BackColor = colorBosArazi;
            }
        }
        protected override void OnCreateControl()
        {
            Tag = "";
            Text = "";
            BackColor = colorTemiz;
            Margin = new Padding(1,1,0,0);
            FlatStyle = FlatStyle.Flat;
            base.OnCreateControl();
        }

        public void setMayinla()
        {
            mayinliMi = true;
        }
        
        public void setMayinAdeti(params ButtonYeni[] cevresindekiButonlar)
        {
            int count = 0;
            for (int i = 0; i < cevresindekiButonlar.Length; i++)
            {
                if (cevresindekiButonlar[i].mayinliMi)
                {
                    count++;
                }
            }
            mayinSayisi = count;
        }
        public void setMayinAdeti_Text()
        {
            if (mayinSayisi == 0)
            {
                Text = "";
            }
            else
            {
                Text = mayinSayisi.ToString();
            }
        }
        public void setMayinBoyutu(int width, int height)
        {
            Width = width;
            Height = height;
        }
        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            if (mevent.Button == MouseButtons.Right)
            {

            }
            base.OnMouseDown(mevent);
        }
    }
}
