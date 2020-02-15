using System;
using System.Drawing;
using System.Windows.Forms;

namespace projectWallpaper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region VARIABLES
        Color colorpanelDefault;
        Color colorpanelClick;
        Color colorlabelDefault;
        Color colorlabelClick;

        Color[] colors;
        PictureBox[] pictureBoxes;
        Image[] imagesWallpaper;
        Image[] imagesUser;

        string menuSecim = "0";

        PictureBox pictureBoxSelected = null;
        #endregion

        #region CLASSES
        class_Colors class_Colors = new class_Colors();
        class_Colors_To_PictureBoxes class_SetColors = new class_Colors_To_PictureBoxes();
        class_PanelObject_LabelObject class_panelLabelObject = new class_PanelObject_LabelObject();
        class_ChangeBackground class_ChangeBackground = new class_ChangeBackground();
        class_ChangeBackgroundColor class_ChangeBackgroundColor = new class_ChangeBackgroundColor();
        #endregion

        #region BEGINNING
        private void Form1_Load(object sender, EventArgs e)
        {
            #region WALLPAPERS TAG
            lblWallpapers.Tag = pnlWallpapers;
            lblPictures.Tag = pnlPictures;
            lblColours.Tag = pnlColours;

            pnlWallpapers.Tag = "0";
            pnlPictures.Tag = "1";
            pnlColours.Tag = "2";
            #endregion

            #region COLOR DEFAULT & CLICK
            colorpanelDefault = pnlWallpapers.BackColor;
            colorpanelClick = Color.Blue;

            colorlabelDefault = lblWallpapers.ForeColor;
            colorlabelClick = Color.White;
            #endregion

            #region SELECTED MENU THIS IS
            setMenuClick(lblWallpapers);
            setMenuSecim(lblWallpapers);
            #endregion

            #region SET COLORS & PICTUREBOXES
            SetColors();
            SetPictureBoxes();
            SetColorsToPictureBoxes();
            #endregion

            setClickForPictureBoxes();
        }
        #endregion

        #region SET LABEL AND PANEL COLOR
        private void setLabelColor(Label label)
        {
            //LABEL YAZI RENGİNİ SIFIRLAR
            lblWallpapers.ForeColor = colorlabelDefault;
            lblPictures.ForeColor = colorlabelDefault;
            lblColours.ForeColor = colorlabelDefault;

            //LABEL YAZI RENGİNİ DEĞİŞTİRİR
            label.ForeColor = colorlabelClick;
        }
        private void setPanelColor(Label label)
        {
            //PANEL BİLGİSİ ALIR
            Panel panel = (Panel)(label.Tag);

            //PANEL ARKAPLAN RENGİNİ SIFIRLAR
            pnlWallpapers.BackColor = colorpanelDefault;
            pnlPictures.BackColor = colorpanelDefault;
            pnlColours.BackColor = colorpanelDefault;

            //PANEL & LABEL ARKAPLAN RENGİNİ DEĞİŞTİRİR
            panel.BackColor = colorpanelClick;
            label.BackColor = colorpanelDefault;
        }
        #endregion

        #region MENU CLICK
        private void setMenuClick(Label label)
        {
            setLabelColor(label);
            setPanelColor(label);
            setMenuSecim(label);
        }
        private void lblMenu_Click(object sender, EventArgs e)
        {
            Label label = class_panelLabelObject.GetLabel(sender);
            Panel panel = class_panelLabelObject.GetPanel(label);

            setMenuClick(label);
        }
        #endregion

        #region SELECT MENU
        
        private void setMenuSecim(Label label)
        {
            menuSecim = GetMenuSecim(label) ;
        }
        private string GetMenuSecim(Label label)
        {
            return class_panelLabelObject.GetPanel_TagToString(label);
        }
        #endregion

        #region SET COLORS
        private Color[] GetColors()
        {
            return class_Colors.GetColors();
        }
        private void SetColors()
        {
            colors = GetColors();

        }
        private void SetColorsToPictureBoxes()
        {
            class_SetColors.SetColors_To_PictureBoxes(pictureBoxes, colors);
        }
        #endregion

        #region SET PICTUREBOXES
        
        public void SetPictureBoxes()
        {
            pictureBoxes = class_SetColors.GetPictureBoxes(flowLayoutPanel1);
        }
        #endregion

        #region SELECT COLOR
        public void setBackground(PictureBox pictureBox)
        {
            class_ChangeBackgroundColor.SetColor(pictureBox.BackColor);
        }

        #endregion

        #region CLICK FOR PICTUREBOXES
        public void setClickForPictureBoxes()
        {
            foreach (PictureBox item in flowLayoutPanel1.Controls)
            {
                item.Click += pictureBoxClick;
            }
        }

        private void pictureBoxClick(object sender, EventArgs e)
        {
            foreach (PictureBox item in flowLayoutPanel1.Controls)
            {
                item.BorderStyle = BorderStyle.None;
            }
            pictureBoxSelected = sender as PictureBox;
            pictureBoxSelected.BorderStyle = BorderStyle.Fixed3D;
        }
        #endregion

        #region FORM MOVE
        bool isMove;

        int mx, my;

        private void form_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMove)
            {
                //------------------------ TUTTUÄ�UN YERDEN TAÅ�IMA------------------------------
               SetDesktopLocation(MousePosition.X - mx-lblCancel.Width, MousePosition.Y - my);//TuttuÄŸun yerden taÅŸÄ±ma

            }
        }

        //------------------------ BIRAKTIÄ�INDA---------------------------------------

        private void form_MouseUp(object sender, MouseEventArgs e)
        {
            isMove = false;
        }

        //------------------------ TUTTUÄ�UNDA -----------------------------------------

        private void form_MouseDown(object sender, MouseEventArgs e)
        {
            isMove = true;
            mx = e.X;
            my = e.Y;
        }
        #endregion


        private void lblSelect_Click(object sender, EventArgs e)
        {
            if (pictureBoxSelected != null )
            {
                setBackground(pictureBoxSelected);
            }
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
