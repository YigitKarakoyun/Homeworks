using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StickyNotesProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Tools_CRUD crud;
        public List<Tbl_Note> note_List { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

            crud = Tools_CRUD.instance;
            note_List = crud.Select_Notums;
            if (note_List.Count==0)
            {
                crud.Insert_Not();
                note_List = crud.Select_Notums;
            }
            foreach (Tbl_Note item in note_List)
            {
                FormNote frm = new FormNote(item);
                frm.Show();
            }
            //Veri tabanından notları çek
            //Formları oluştur
            //FormNote frm = new FormNote();
            //frm.Show();

        }
        //private void set()
        //{
        //    FormNote frm = new FormNote();
        //    frm.Show();
        //}
    }
}
