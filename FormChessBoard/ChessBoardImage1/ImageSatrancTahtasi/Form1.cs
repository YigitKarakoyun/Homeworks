using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageSatrancTahtasi
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            setImage(buttonBoyamaMavi);
        }
        private void ImageBoyama(object sender, EventArgs e)
        {
            setImage(sender as Button);
        }

        _Satranc satranc = new _Satranc();
        public void setImage(Button button)
        {
            Color main_color = button.BackColor;
            Color side_color = Color.GhostWhite;

            pictureBox1.Image = getSatrancImage(pictureBox1.Width, pictureBox1.Height, main_color, side_color);

            label1.BackColor = main_color;
        }
        public Image getSatrancImage(int width, int height, Color main_color, Color side_color)
        {
            return satranc.getSatrancImage(width, height, main_color, side_color);
        }
    }
}
