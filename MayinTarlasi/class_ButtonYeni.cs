using System;
using System.Linq;

namespace _13_MayinTarlasi
{
    class class_ButtonYeni
    {
        public ButtonYeni GetButtonYeni()
        {
            return new ButtonYeni();
        }
        public ButtonYeni[] GetButtonYeniler(int satir, int sutun, int boyut)
        {
            return  GetButtonYeniler(satir,sutun,boyut,boyut);
        }
        public ButtonYeni[] GetButtonYeniler(int satir, int sutun,int width, int height)
        {
            int araziAdeti = satir * sutun;
            ButtonYeni[] mayinlar = new ButtonYeni[araziAdeti];
            for (int i = 0; i < araziAdeti; i++)
            {
                mayinlar[i] = new ButtonYeni() { Width = width, Height = height };
            }
            return mayinlar;
        }
        public void SetMayinlariDoldur(ButtonYeni[] buttonYenis)
        {
            int araziAdeti = buttonYenis.Length;
            int mayinAdeti = araziAdeti / 10;
            int[] mayinliAraziler = new int[mayinAdeti];

            Random random = new Random();
            for (int i = 0; i < mayinAdeti; i++)
            {
                int mayinArazisi = random.Next(araziAdeti);

                if (mayinliAraziler.Contains(mayinArazisi))
                {
                    i--;
                }
                else
                {
                    mayinliAraziler[i] = mayinArazisi;
                }
            }
            for (int i = 0; i < mayinliAraziler.Length; i++)
            {
                int mayinVar = mayinliAraziler[i];
                buttonYenis[mayinVar].setMayinla();
            }
            
        }
        
    }
}
