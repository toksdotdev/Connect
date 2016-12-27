using Connect.Properties;
using Microsoft.VisualBasic.PowerPacks;
using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Connect.classes.Form_Styling.Purchase_Window_Styles
{
    internal class TextBoxGroupControlVerifier : TextBoxControlVerifier
    {
        private new readonly TextBox[] _txtBox;
        private readonly RectangleShape[] _rectangleShape; private readonly PictureBox _iconPictureBox;
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
                var isMatch = _style2 != null && Regex.Match(_txtBox[i].Text, "[0-9]", RegexOptions.IgnoreCase).Success;

                uint text = (isMatch) ? Convert.ToUInt32(_txtBox[i].Text) : 0;

                if (_style1 != NumberStyles.Any)
                {
                    passedTest = new TextBoxControlVerifier(_txtBox[i], _rectangleShape[i], null, _style1).VerifyInput();
                }
                else if (_style2 != null && _style2[i].Equals(CustomNumberStyles.NotMoreThan31Days) && isMatch)
                {
                    passedTest = (text <= 31 && text >= 1);
                }
                else if (_style2 != null && _style2[i].Equals(CustomNumberStyles.MonthLimit) && isMatch)
                {
                    passedTest = (text <= 12 && text >= 1);
                }
                else if (_style2 != null && _style2[i].Equals(CustomNumberStyles.YearLimit) && isMatch)
                {
                    passedTest = (text <= 3000 && text >= DateTime.Now.Year);
                }
                else
                    passedTest = false;

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