using System.Drawing;
using System.Windows.Forms;

namespace projectWallpaper
{
    class class_Colors_To_PictureBoxes
    {
        public void SetColor_To_PictureBox(PictureBox pictureBox, Color color)
        {
            if (pictureBox == null)
            {
                MessageBox.Show("PictureBox NULL");
                return;
            }
            pictureBox.BackColor = color;
        }
        public void SetColors_To_PictureBoxes(PictureBox[] pictureBoxes, Color[] colors)
        {
            if (pictureBoxes == null || colors == null || pictureBoxes.Length > colors.Length)
            {
                return;
            }
            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                SetColor_To_PictureBox(pictureBoxes[i], colors[i]);
            }
        }
        public PictureBox[] GetPictureBoxes(FlowLayoutPanel flowLayoutPanel1)
        {
            Control.ControlCollection controlCollection = flowLayoutPanel1.Controls;
            int controlCount = controlCollection.Count;
            PictureBox[] pictureBoxes = new PictureBox[controlCount];
            int count = 0;
            foreach (Control item in controlCollection)
            {
                PictureBox pictureBox = (PictureBox)item;
                pictureBoxes[count++] = pictureBox;
            }
            if (pictureBoxes == null)
            {
                MessageBox.Show("PictureBoxes NULL");
            }
            return pictureBoxes;
        }

    }
}
