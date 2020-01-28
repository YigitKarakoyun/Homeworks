using System;
using System.Drawing;
using System.Linq;

namespace StickyNotesProject
{
    class Tools_ColorCodes
    {
        public static Tools_ColorCodes instance { get; private set; } = new Tools_ColorCodes();

        Color[] colors_yellow = new Color[2]
        {
            Color.FromArgb(255,255,192),
            Color.FromArgb(255,255,220)
        };
        Color[] colors_green = new Color[2]
        {
            Color.FromArgb(150, 255, 150),
            Color.FromArgb(192, 255, 192)
        };
        Color[] colors_blue = new Color[2]
        {
            Color.FromArgb(192, 192, 255),
            Color.FromArgb(225, 225, 255)
        };
        Color[] colors_red = new Color[2]
        {
            Color.FromArgb(225, 170, 170),
            Color.FromArgb(255, 192, 192)
        };
        Color[] colors_black = new Color[2]
        {
            Color.Gray,
            Color.Silver
        };
        public Color[] GetColor(int i)
        {
            switch (i)
            {
                case 0: return colors_yellow;
                case 1: return colors_green;
                case 2: return colors_blue;
                case 3: return colors_red;
                default:return colors_black;
            }
        }
       
        public Color[] NextColor(int i)
        {
            return GetColor(NextColor_ID(i));
        }
        public int NextColor_ID(int i)
        { 
            return (i+1) % 5;
        }
    }
}
