using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StickyNotesProject
{
    public partial class FormNote : Form
    {
        #region
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

        //------------------------ TUTTUÄ�UNDA -----------------------------------------

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)

        {

            isMove = true;

            mx = e.X;

            my = e.Y;

        }


        bool frmMoveOlsunMu = false;
        private void FormNote_Move(object sender, EventArgs e)
        {
            //YENİ KONUM AL
            if (frmMoveOlsunMu)
            {
                note.KonumX = this.Left;
                note.KonumY = this.Top;
                crud.Update_Not(note);
            }
            
        }
        #endregion
        Tbl_Note note;
        public FormNote(Tbl_Note note)
        {
            InitializeComponent();
            this.note = note;
        }
        //---------------------------------------------------------
        //Variables
        public int colorid { get; set; } = 0;
        Color[] colors = null;
        bool over_the_head = true;

        //Instance Classes
        Tools_CRUD crud;
        Tools_ColorCodes colorCodes;
        Tools_Forms forms;
        
        private void FormNote_Load(object sender, EventArgs e)
        {
            crud = Tools_CRUD.instance;
            colorCodes = Tools_ColorCodes.instance;
            forms = Tools_Forms.instance;

            //Veritabanından renk idsi çekecek
            colorid = (int)note.ColorID;
            SetStickyColor();
            frmMoveOlsunMu = true;
            txtMetin.Text = note.Note;
            Left = (int)note.KonumX;
            Top = (int)note.KonumY;
        }
        
        public void SetStickyColor()
        {
            colors = colorCodes.GetColor(colorid);
            if (colors != null && colors.Length == 2)
            {
                Color tempColor = colors[0];
                txtMetin.BackColor = tempColor;
                BackColor = tempColor;
                if (over_the_head)
                {
                    panel1.BackColor = colors[1];
                }
                else
                {
                    panel1.BackColor = tempColor;
                }

            }
        }

        private void txtMetin_TextChanged(object sender, EventArgs e)
        {
            note.Note = txtMetin.Text;
            
            crud.Update_Not2(note);
        }

        private void btnNewNote_Click(object sender, EventArgs e)
        {
            Tbl_Note note = crud.Insert_Not();
            FormNote formNote = forms.AddForm(note);
            forms.ShowForm(formNote);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            forms.RemoveForm(this);
            crud.Delete_Not(note);
            Close();
        }

        private void btnColorChange_Click(object sender, EventArgs e)
        {
            colorid = colorCodes.NextColor_ID(colorid);
            SetStickyColor();
            note.ColorID = colorid;
            crud.Update_Not2(note);
        }
        


    }
}
