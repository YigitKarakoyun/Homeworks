using System.Drawing;
using System.IO;

namespace projectWallpaper
{
    class class_Images
    {
        public Image GetImage(string file_path)
        {
            if (File.Exists(file_path))
            {
                return Image.FromFile(file_path);
            }
            return null;
        }
        public Image[] GetImages_From_Pictures(string folder_path)
        {
            string [] tempString = Directory.GetFiles(folder_path);
            if (tempString == null)
            {
                return null;
            }
            int count = tempString.Length;
            Image[] images = new Image[count];
            for (int i = 0; i < count; i++)
            {
                images[i] = GetImage(tempString[i]);
            }
            return images;
        }
        //public Image[] GetImages_From_Resources(string resources)
        //{
            //string[] tempString = Directory.GetFiles(folder_path);
            //if (tempString == null)
            //{
            //    return null;
            //}
            //int count = tempString.Length;
            //Image[] images = new Image[count];
            //for (int i = 0; i < count; i++)
            //{
            //    images[i] = GetImage(tempString[i]);
            //}
            //return images;
        //}
        //public Image GetImage_From_Resources()
        //{

        //}
    }
}
