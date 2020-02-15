namespace _13_MayinTarlasi
{
    class class_FormBoyutlandirma
    {
        Form1 frm1;
        int tableLayoutPanelHeight;
        public class_FormBoyutlandirma(Form1 frm1,int tableLayoutPanelHeight)
        {
            this.frm1 = frm1;
            this.tableLayoutPanelHeight = tableLayoutPanelHeight;
        }
        public void setFormuBoyutlandirma(int satir, int sutun,int btnBoyut)
        {
            setFormuBoyutlandirma(satir, sutun, btnBoyut, btnBoyut);
        }
        public void setFormuBoyutlandirma(int satir, int sutun, int btnWidth, int btnHeight)
        {
            frm1.Width = (btnWidth + 1) * sutun + 20;
            frm1.Height = tableLayoutPanelHeight + (btnHeight + 1) * satir + 65;

        }
    }
}
