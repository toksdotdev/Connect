using Microsoft.VisualBasic.PowerPacks;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Connect.classes.Custom_Controls
{
    internal class OrangeButton
    {
        private readonly Color _onClickColor;
        private readonly Color _onHoverColor;
        private readonly Color _onLeaveColor;
        private readonly bool _containsPictureBox;
        private readonly RectangleShape _rectangleShape;
        private readonly Label _label;
        private readonly Timer _timer = new Timer();
        private int _guideTimer;
        private readonly PictureBox _pictureBox;

        public OrangeButton(Panel panel, Color onClickColor, Color onHoverColor, Color onLeaveColor, bool containsPictureBox = false)
        {
            _timer.Enabled = true;
            _timer.Interval = 100;

            _onClickColor = onClickColor;
            _onHoverColor = onHoverColor;
            _onLeaveColor = onLeaveColor;
            _containsPictureBox = containsPictureBox;

            var container = panel.Controls.OfType<ShapeContainer>().ToArray()[0];
            _rectangleShape = container.Shapes.OfType<RectangleShape>().ToArray()[0];

            if (containsPictureBox) _pictureBox = panel.Controls.OfType<PictureBox>().ToArray()[0];

            _label = panel.Controls.OfType<Label>().ToArray()[0];
        }

        public void FillInProperties()
        {
            _rectangleShape.Click += RectangleShape1_Click;
            _rectangleShape.MouseEnter += RectangleShape_MouseEnter;
            _rectangleShape.MouseLeave += RectangleShape1_MouseLeave;

            _label.Click += RectangleShape1_Click;
            _label.MouseEnter += RectangleShape_MouseEnter;
            _label.MouseLeave += RectangleShape1_MouseLeave;
        }

        private void RectangleShape_MouseEnter(object sender, EventArgs e)
        {
            _rectangleShape.FillColor = Color.DarkOrange;
            _label.BackColor = Color.DarkOrange;
            if (_containsPictureBox) _pictureBox.BackColor = Color.DarkOrange;
        }

        private void RectangleShape1_MouseLeave(object sender, EventArgs e)
        {
            _rectangleShape.FillColor = Color.FromArgb(255, 51, 0);
            _label.BackColor = Color.FromArgb(255, 51, 0);
            if (_containsPictureBox) _pictureBox.BackColor = Color.FromArgb(255, 51, 0);
        }

        public void RectangleShape1_Click(object sender, EventArgs e)
        {
            _rectangleShape.FillColor = Color.DarkSlateGray;
            _label.BackColor = Color.DarkSlateGray;
            if (_containsPictureBox) _pictureBox.BackColor = Color.DarkSlateGray;

            _timer.Tick += delegate
            {
                if (_guideTimer == 2)
                {
                    RectangleShape1_MouseLeave(sender, new EventArgs());
                    _timer.Stop();
                    _guideTimer = 0;
                }
                _guideTimer++;
            };

            _timer.Start();
        }
    }
}