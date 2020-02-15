using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectFolder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static void ApplyFolderIcon(string targetFolderPath, string iconFilePath)
        {
            var iniPath = Path.Combine(targetFolderPath, "desktop.ini");
            if (File.Exists(iniPath))
            {
                //remove hidden and system attributes to make ini file writable
                File.SetAttributes(
                   iniPath,
                   File.GetAttributes(iniPath) &
                   ~(FileAttributes.Hidden | FileAttributes.System));
            }

            //create new ini file with the required contents
            var iniContents = new StringBuilder()
                .AppendLine("[.ShellClassInfo]")
                .AppendLine($"IconResource={iconFilePath},0")
                .AppendLine($"IconFile={iconFilePath}")
                .AppendLine("IconIndex=0")
                .ToString();
            File.WriteAllText(iniPath, iniContents);

            //hide the ini file and set it as system
            File.SetAttributes(
               iniPath,
               File.GetAttributes(iniPath) | FileAttributes.Hidden | FileAttributes.System);
            //set the folder as system
            File.SetAttributes(
                targetFolderPath,
                File.GetAttributes(targetFolderPath) | FileAttributes.System);
        }

        string iconPath;
        private void btnChangeFolderIcon_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = folderBrowserDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK) 
            {
                string folderPath = folderBrowserDialog1.SelectedPath;
                ApplyFolderIcon(folderPath,iconPath);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            iconPath = Application.StartupPath+ @"\folderIcon.ico";
        }
    }
}
