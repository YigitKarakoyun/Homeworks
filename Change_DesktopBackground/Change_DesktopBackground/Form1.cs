using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Change_DesktopBackground
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int iBackground = 0;
        private void changeDesktopBackground()
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string[] temp = Directory.GetFiles(path);
            if (temp == null || 0 >= temp.Length)
            {
                return;
            }

            iBackground++;
            if (iBackground >= temp.Length)
            {
                iBackground = 0;
            }
            string file_fullpath_name = temp[iBackground];

            setDesktopBackground(file_fullpath_name);
        }
        private void setDesktopBackground(string file_fullpath_name)
        {
            const int SET_DESKTOP_BACKGROUND = 20;
            const int UPDATE_INI_FILE = 1;
            const int SEND_WINDOWS_INI_CHANGE = 2;

            win32.SystemParametersInfo(SET_DESKTOP_BACKGROUND, 0, file_fullpath_name, UPDATE_INI_FILE | SEND_WINDOWS_INI_CHANGE);
        }

        string path;
        private void Form1_Load(object sender, EventArgs e)
        {
            path = Application.StartupPath + "\\Images\\";
        }

        private void btnChangeDesktopBackground_Click(object sender, EventArgs e)
        {
            changeDesktopBackground();
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
