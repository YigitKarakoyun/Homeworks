using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChessBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            SatrancTahtasi();
        }


        classButonMaker butonMaker = new classButonMaker();
        Color colorful = Color.White;
        Color colorless = Color.Black;

        string[] karakterler = { "A", "B", "C", "D", "E", "F", "G", "H" };
        int kareBoyut = 80;

        private void SatrancTahtasi()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Button btn = butonMaker.GetButton(i * kareBoyut, j * kareBoyut, kareBoyut, kareBoyut);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Text = karakterler[i] + "" + (j + 1);
                    btn.Font = new Font(Font.Name, 12, FontStyle.Bold);
                    btn.TextAlign = ContentAlignment.TopLeft;
                    //Satranç tahtası modunda boyama
                    if ((i + j) % 2 == 0)
                    {
                        butonMaker.setColor(btn, colorful);
                        btn.ForeColor = Color.Black;
                    }
                    else
                    {
                        butonMaker.setColor(btn, colorless);
                        btn.ForeColor = Color.White;
                    }

                    Controls.Add(btn);
                }
            }
        }
    }
}
