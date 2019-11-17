using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessBoard
{
    class classButonMaker
    {
        public Button GetButton(int x, int y, int width,int height)
        {
            return new Button() {Left = x, Top = y, Width = width, Height = height };
        }
        public void setColor(Button button,Color buton_color)
        {
            button.BackColor = buton_color;
        }

    }
}
