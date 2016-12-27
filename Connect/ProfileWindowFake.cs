using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect
{
    public partial class ProfileWindowFake : Form
    {
        private int scrollableHeight = 0;

        private int ScrollableHeight
        {
            get { return this.scrollableHeight; }
            set
            {
                //resize vertical scrollbar automatically
                if (this.Value != 0 && )
                    rectangleShape2.Location = new System.Drawing.Point(rectangleShape2.Location.X, ((value / 100) * this.Value));
            }
        }

        public ProfileWindowFake()
        {
            InitializeComponent();

            panel1.VerticalScroll.Enabled = true;
            panel1.VerticalScroll.Visible = false;
            rectangleShape1.BringToFront();
            rectangleShape2.BringToFront();

            SetValue(0);
            this.ScrollableHeight = this.panel1.Size.Height;
        }

        private void ovalShape1_Click(object sender, EventArgs e)
        {
            //panel1.VerticalScroll.Enabled = true;
            //panel1.VerticalScroll.Visible = true;
        }

        public int Value = 0;

        private void SetValue(int val)
        {
            if (val >= 100)
            {
                this.Value = 100;
                panel1.VerticalScroll.Value = this.Value;
            }
            else
            {
                this.Value = val;
                panel1.VerticalScroll.Value = this.Value;
            }
        }

        public int InitialLocation = 0;

        private void rectangleShape2_MouseDown(object sender, MouseEventArgs e)
        {
            this.InitialLocation = rectangleShape2.Location.Y;

            //gets the distance between the new mouse position
            int distance = MousePosition.Y - InitialLocation;
            rectangleShape2.Location = new System.Drawing.Point(rectangleShape2.Location.X, MousePosition.Y);

            int val = Value += distance / 100;
            SetValue(val);
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            //this.ScrollableHeight = this.panel1.Size.Height;
        }

        private void rectangleShape2_MouseWheel(object sender, MouseEventArgs e)
        {
            Graphics.FromImage(Image.FromFile())
            ScrollBarRenderer.DrawUpperVerticalTrack();

            this.InitialLocation = rectangleShape2.Location.Y;

            //gets the distance between the new mouse position
            int distance = MousePosition.Y - InitialLocation;
            rectangleShape2.Location = new System.Drawing.Point(rectangleShape2.Location.X, MousePosition.Y);

            int val = Value += distance / 100;
            SetValue(val);
        }
    }
}