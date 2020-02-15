using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace projectWallpaper
{
    class class_ChangeBackground
    {
        public void SetDesktopBackground(string file_fullpath_name)
        {
            if (File.Exists(file_fullpath_name))
            {
                const int SET_DESKTOP_BACKGROUND = 20;
                const int UPDATE_INI_FILE = 1;
                const int SEND_WINDOWS_INI_CHANGE = 2;

                win32.SystemParametersInfo(SET_DESKTOP_BACKGROUND, 0, file_fullpath_name, UPDATE_INI_FILE | SEND_WINDOWS_INI_CHANGE);
                
            }
        }
        string path;
        public class_ChangeBackground()
        {
            path = Application.StartupPath + "\\Images\\";
        }
        public void CreateImageFolder()
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
    }
    internal sealed class win32
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern int SystemParametersInfo(
               int uAction,
               int uParam,
               String lpvParam,
               int fuWinIni
               );
    }
}

