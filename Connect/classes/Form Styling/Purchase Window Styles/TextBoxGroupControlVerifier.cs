using Connect.Properties;
using Microsoft.VisualBasic.PowerPacks;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect.classes.Form_Styling.Purchase_Window_Styles
{
    internal class TextBoxGroupControlVerifier : TextBoxControlVerifier
    {
        private new readonly TextBox[] _txtBox;
        private readonly RectangleShape[] _rectangleShape;
        private readonly PictureBox _iconPictureBox;
        private readonly NumberStyles _style1;
        private readonly CustomNumberStyles[] _style2;

        public TextBoxGroupControlVerifier(TextBox[] textBox, RectangleShape[] rectangleShape,
            PictureBox iconPictureBox, NumberStyles style = NumberStyles.Any)
        {
            _txtBox = textBox;
            _rectangleShape = rectangleShape;
            _iconPictureBox = iconPictureBox;
            _style1 = style;
        }

        public TextBoxGroupControlVerifier(TextBox[] textBox, RectangleShape[] rectangleShape,
            PictureBox iconPictureBox, CustomNumberStyles[] style)
        {
            _txtBox = textBox;
            _rectangleShape = rectangleShape;
            _iconPictureBox = iconPictureBox;
            _style2 = style;
            _style1 = NumberStyles.Any;
        }

        public override bool VerifyInput()
        {
            bool passedTest = false;

            for (int i = 0; i < _txtBox.Length; i++)
            {
                if (_style1 != NumberStyles.Any)
                    passedTest =
                        new TextBoxControlVerifier(_txtBox[i], _rectangleShape[i], null, _style1).VerifyInput();
                else
                    passedTest =
                        new TextBoxControlVerifier(_txtBox[i], _rectangleShape[i], null, _style2[i]).VerifyInput();

                if (!passedTest) break;
            }
            if (!passedTest)
            {
                _iconPictureBox.Image = Resources.Delete_16px;
                _iconPictureBox.Visible = true;
            }
            else
            {
                _iconPictureBox.Image = Resources.Checkmark_16px;
                _iconPictureBox.Visible = true;
            }

            return passedTest;
        }
    }
}