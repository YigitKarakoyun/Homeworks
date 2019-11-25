using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panelSil_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Ayarları Yapılandırılmamıştır :)","Ayarlanmamış");
            //setColorRed();
        }

        private void panelEkle_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
        private void setColor(Color colorText,Color colorHead)
        {
            textBox1.BackColor = colorText;
            panelBaslik.BackColor = colorHead;
            tableLayoutPanel1.BackColor = colorHead;
        }
        private void setColor(int r1,int g1,int b1, int r2, int g2, int b2)
        {
            setColor(Color.FromArgb(r1, g1, b1), Color.FromArgb(r2, g2, b2));
        }
        private void setColorYellow()
        {
            setColor(255, 255, 220, 255, 255, 192);
        }
        private void setColorGreen()
        {
            //setColor(192, 255, 192, 200, 255, 200);
            setColor(192, 255, 192, 150, 255, 150);
        }
        private void setColorBlue()
        {
            setColor(225, 225, 255, 192, 192, 255);
        }
        private void setColorRed()
        {
            setColor(255, 192, 192, 225, 170, 170);
        }
        
        private void setColorBlack()
        {
            setColor(Color.Silver, Color.Gray);
        }
        ////////////////////////////////////////////////////////////////////////////////
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
        int renk = 0;


        private void lblAyarlar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                renk++;
                if (renk >= 5)
                {
                    renk = 0;
                    
                }
                if (renk == 0) setColorYellow();
                else if (renk == 1) setColorGreen();
                else if (renk == 2) setColorBlue();
                else if (renk == 3) setColorRed();
                else
                {
                    setColorBlack();
                }
            }
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
