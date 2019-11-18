using System;
using System.Drawing;
using System.Windows.Forms;

namespace BubbleScreenServer
{
    class c_Random
    {
        Random rnd = new Random();
        public Point GetRandomPoint(int width,int height)
        {
            int x = rnd.Next(0, width);
            int y = rnd.Next(0, height);
            return new Point(x,y);
        }
        public Point GetRandomPoint(Point point)
        {
            return GetRandomPoint(point.X, point.Y);
        }
        public Point GetRandomPoint(Size point)
        {
            return GetRandomPoint(point.Width, point.Height);
        }
        public Point SetRandomPicture(PictureBox picture, Size size)
        {
            picture.Location = GetRandomPoint(size-picture.Size);
            return picture.Location;
        }
    }
}
