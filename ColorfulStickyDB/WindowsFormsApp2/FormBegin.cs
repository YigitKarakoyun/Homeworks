using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormBegin : Form
    {
        public FormBegin()
        {
            InitializeComponent();
        }
        Tools_CRUD crud = new Tools_CRUD();
        List<tblNot> list;
        static List<FormNot> list_formNot = new List<FormNot>(); 
        private void Form2_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            list = Tools_CRUD.Select_Notums;

            if (list.Count==0)
            {
                crud.Insert_Not();
                list = Tools_CRUD.Select_Notums;
            }
            foreach (tblNot item in list)
            {
                Show_FormNot(item);
            }
        }
        public static void Show_FormNot(tblNot tblNot)
        {
            FormNot temp = new FormNot(tblNot);
            list_formNot.Add(temp);
            temp.Show();
        }
        public static void Remove_FormNot(FormNot frmNot)
        {
            list_formNot.Remove(frmNot);
            //if (list_formNot.Count<=0)
            //{
            //    Close();
            //}
        }
    }
}
