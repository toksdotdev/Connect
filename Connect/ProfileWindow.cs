using System;
using System.Windows.Forms;

namespace Connect
{
    public partial class ProfileWindow : Form
    {
        public ProfileWindow()
        {
            InitializeComponent();
        }

        private void ovalShape1_Click(object sender, EventArgs e)
        {
            //panel1.VerticalScroll.Enabled = true;
            //panel1.VerticalScroll.Visible = true;
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            //this.ScrollableHeight = this.panel1.Size.Height;
        }
    }
}