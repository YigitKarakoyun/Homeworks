using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormNot : Form
    {
        tblNot tblNot;
        public FormNot(tblNot tblNot)
        {
            InitializeComponent();
            this.tblNot = tblNot;
            txtNot.Text = tblNot.Notum;
        }
        Tools_CRUD crud = new Tools_CRUD();
        private void txtNot_TextChanged(object sender, EventArgs e)
        {
            tblNot.Notum = txtNot.Text;
            crud.Update_Not(tblNot);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            crud.Delete_Not(tblNot);
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tblNot tblNot = crud.Insert_Not("");
            FormBegin.Show_FormNot(tblNot);
        }

        private void FormNot_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormBegin.Remove_FormNot(this);
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




        //------------------------ TUTTUÄ�UNDA -----------------------------------------

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)

        {

            isMove = true;

            mx = e.X;

            my = e.Y;

        }
    }
}
