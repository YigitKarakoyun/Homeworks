using System.Windows.Forms;

namespace projectWallpaper
{
    class class_PanelObject_LabelObject
    {
        public Label GetLabel(object sender)
        {
            if (sender is Label) return (sender as Label);
            return null;
        }
        public Panel GetPanel(object sender)
        {
            if (sender is Panel) return (sender as Panel);
            return null;
        }
        public Panel GetPanel(Label label)
        {
            if (label.Tag is Panel) return (Panel)(label.Tag);
            return null;
        }
        public string GetPanel_TagToString(Panel panel)
        {
            return panel.Tag.ToString();
        }
        public string GetPanel_TagToString(Label label)
        {
            Panel panel = GetPanel(label);
            if (panel == null)
            {
                return "";
            }
            return GetPanel_TagToString(panel);
        }
    }
}
