using BubbleScreenServer.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BubbleScreenServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Image bubble;
        private void Form1_Load(object sender, EventArgs e)
        {
            bubble = Resources.water_bubble;
            BackgroundImage = bubble;
            WindowState = FormWindowState.Minimized;

            setTimerSifirla();
            setTimerBaslat();
        }
        int round = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            round++;
            if (round > 1)
            {
                WindowState = FormWindowState.Maximized;
                setTimerSifirla();
               
            }
        }
        public void setTimerSifirla()
        {
            round = 0;
            timer1.Stop();
        }
        public void setTimerBaslat()
        {
            timer1.Start();
        }

        private void kucult()
        {
            WindowState = FormWindowState.Minimized;
            setTimerSifirla();
            setTimerBaslat();
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;

            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                kucult();
            }
        }

       
    }
}
