using Connect.classes.Custom_Controls;
using Connect.classes.Form_Styling.Purchase_Window_Styles;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Connect
{
    public partial class SellDataWindow : Form
    {
        private readonly List<TextBoxControlVerifier> _textBoxControlDictionaries = new List<TextBoxControlVerifier>();

        public SellDataWindow()
        {
            InitializeComponent();
            var orangeButton1 = new OrangeButton(panelOrangeBtn1, Color.DarkSlateGray, Color.DarkOrange, Color.FromArgb(255, 51, 0), true);
            orangeButton1.FillInProperties();

            _textBoxControlDictionaries.AddRange(new[]{

                #region contains textbox groupings

                new TextBoxControlVerifier(textBoxUsername,rectangleShapeUsername,pictureBoxUsename),
                new TextBoxControlVerifier(textBoxPassword,rectangleShapePassword,pictureBoxPassword),
                new TextBoxGroupControlVerifier(
                    new []
                    {
                        textBoxExpiryDateDay, textBoxExpiryDateMonth,textBoxExpiryDateYear
                    },
                    new []
                    {
                        rectangleShapeExpiryDateDay, rectangleShapeExpiryDateMonth,rectangleShapeExpiryDateYear
                    },
                    pictureBoxExpiryDate,
                    new []
                    {
                        TextBoxControlVerifier.CustomNumberStyles.NotMoreThan31Days,
                        TextBoxControlVerifier.CustomNumberStyles.MonthLimit,
                        TextBoxControlVerifier.CustomNumberStyles.YearLimit,
                    })

                #endregion contains textbox groupings
            });
        }

        private void checkBoxUnlimitedTime_CheckedChanged(object sender, EventArgs e)
        {
            var chkBox = sender as CheckBox;

            if (chkBox != null) panelExpiryDate.Visible = !chkBox.Checked;
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            _textBoxControlDictionaries.Find(cd => cd._txtBox.Equals((sender as TextBox))).VerifyInput();
        }

        private void textBoxExpiryDateDay_TextChanged(object sender, EventArgs e)
        {
            {
                _textBoxControlDictionaries.ElementAt(2).VerifyInput();//.Find(cd => cd._txtBox.Equals((sender as TextBox))).VerifyInput();
            }
        }
    }
}