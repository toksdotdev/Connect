using System.Windows.Forms;

namespace Connect.classes.Main_Page.styling
{
    internal class ActivePanel
    {
        public Panel Panel;
        public int Id;

        public ActivePanel(Panel panel, int id)
        {
            Panel = panel;
            this.Id = id;
        }
    }
}