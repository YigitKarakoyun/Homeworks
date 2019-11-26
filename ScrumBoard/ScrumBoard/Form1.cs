using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrumBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //------------------------ FORM HAREKET ETTÄ°RME---------------------------------

        bool isMove;

        int mx, my;

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)

        {

            if (isMove)
            {

                //------------------------ ORTADAN TAÅ�IMA ------------------------------------- 

                //this.SetDesktopLocation(MousePosition.X - pictureBox1.Width/2, MousePosition.Y - my);



                //------------------------ TUTTUÄ�UN YERDEN TAÅ�IMA------------------------------

                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);//TuttuÄŸun yerden taÅŸÄ±ma

            }

        }

        //------------------------ BIRAKTIÄ�INDA---------------------------------------

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)

        {

            isMove = false;

        }

        //------------------------ TUTTUÄ�UNDA -----------------------------------------

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)

        {

            isMove = true;

            mx = e.X;

            my = e.Y;

        }


    }
}
