using Microsoft.VisualBasic.PowerPacks;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Connect.classes.Custom_Controls
{
    internal class OrangeButton
    {
        private readonly Color _onClickRectangleColor;
        private readonly Color _onEnterRectangleColor;
        private readonly Color _onLeaveRectangleColor;
        private readonly Color _onClickLabelColor;
        private readonly Color _onEnterLabelColor;
        private readonly Color _onLeaveLabelColor;

        private readonly bool _containsPictureBox;
        private readonly RectangleShape _rectangleShape;
        private readonly Label _label;
        private readonly Timer _timer = new Timer();
        private int _guideTimer;
        private readonly PictureBox _pictureBox;

        public OrangeButton(Panel panel, Color onClickColorRectangle, Color onEnterColorRectangle, Color onLeaveColorRectangle,
           bool containsPictureBox = false, Color onClickLabelColor = default(Color), Color onEnterLabelColor = default(Color), Color onLeaveLabelColor = default(Color))
        {
            _onEnterLabelColor = onEnterLabelColor;
            _timer.Enabled = true;
            _timer.Interval = 100;

            _onClickRectangleColor = onClickColorRectangle;
            _onEnterRectangleColor = onEnterColorRectangle;
            _onLeaveRectangleColor = onLeaveColorRectangle;
            _onClickLabelColor = onClickLabelColor;
            _onEnterLabelColor = onEnterLabelColor;
            _onLeaveLabelColor = onLeaveLabelColor;
            _containsPictureBox = containsPictureBox;

            var container = panel.Controls.OfType<ShapeContainer>().ToArray()[0];
            _rectangleShape = container.Shapes.OfType<RectangleShape>().ToArray()[0];
            _rectangleShape.FillStyle = FillStyle.Solid;
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
            //_label.MouseLeave += RectangleShape1_MouseLeave;
        }

        private void RectangleShape_MouseEnter(object sender, EventArgs e)
        {
            _rectangleShape.FillColor = _onEnterRectangleColor;
            _label.BackColor = _onEnterRectangleColor;
            _label.ForeColor = (_onEnterLabelColor != default(Color)) ? _onEnterLabelColor : _label.ForeColor;
            if (_containsPictureBox) _pictureBox.BackColor = _onEnterRectangleColor;
        }

        private void RectangleShape1_MouseLeave(object sender, EventArgs e)
        {
            _rectangleShape.FillColor = _onLeaveRectangleColor;
            _label.BackColor = _onLeaveRectangleColor;
            _label.ForeColor = (_onLeaveLabelColor != default(Color)) ? _onLeaveLabelColor : _label.ForeColor;
            if (_containsPictureBox) _pictureBox.BackColor = _onLeaveRectangleColor;
        }

        public void RectangleShape1_Click(object sender, EventArgs e)
        {
            _rectangleShape.FillColor = _onClickRectangleColor;
            _label.BackColor = _onClickRectangleColor;
            _label.ForeColor = (_onClickLabelColor != default(Color)) ? _onClickLabelColor : _label.ForeColor;
            if (_containsPictureBox) _pictureBox.BackColor = _onClickRectangleColor;

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