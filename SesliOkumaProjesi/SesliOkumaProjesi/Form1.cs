using SpeechLib;
using System;
using System.Windows.Forms;
namespace SesliOkumaProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Com-Speach-alttaki seç
        private void button1_Click(object sender, EventArgs e)
        {
            SpVoice voice = new SpVoice();
            voice.Speak(richTextBox1.Text);
        }
    }
}
