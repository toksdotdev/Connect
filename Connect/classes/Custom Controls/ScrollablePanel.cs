using System;
using System.Drawing;
using System.Windows.Forms;

namespace Connect.classes.Custom_Controls
{
    public partial class ScrollablePanel : UserControl
    {
        public int Value
        {
            get { return Value; }
            set
            {
                if (value >= 100)
                    Value = 100;
                else
                {
                    Value = value;
                    panel1.VerticalScroll.Value = value;
                }
            }
        }

        public int InitialLocation;

        public override Color BackColor
        {
            get { return BackColor; }
            set { panel1.BackColor = BackColor; }
        }

        public override bool AutoSize
        {
            get { return AutoSize; }
            set { panel1.AutoSize = value; }
        }

        private int ScrollableHeight
        {
            get { return ScrollableHeight; }
            set
            {
                //resize vertical scrollbar automatically
                rectangleShape2.Location = new Point(rectangleShape2.Location.X, ((value / 10) * Value));
            }
        }

        public ScrollablePanel()
        {
            InitializeComponent();
            panel1.VerticalScroll.Enabled = true;
            panel1.VerticalScroll.Visible = false;

            ScrollableHeight = panel1.Size.Height;
        }

        private void rectangleShape2_MouseDown(object sender, MouseEventArgs e)
        {
            InitialLocation = rectangleShape2.Location.Y;

            while (true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    //rectangleShape2.Location = new System.Drawing.Point(rectangleShape2.Location.X, this.ScrollableHeight);

                    //gets the distance between the new mouse position
                    int distance = MousePosition.Y - InitialLocation;

                    Value += distance / 10;
                }
            }
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            ScrollableHeight = panel1.Size.Height;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}