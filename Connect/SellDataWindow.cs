using Connect.classes.Custom_Controls;
using Connect.classes.Form_Styling.Purchase_Window_Styles;
using Connect.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Connect
{
    public partial class SellDataWindow : Form
    {
        private readonly List<TextBoxControlVerifier> _textBoxControlDictionaries = new List<TextBoxControlVerifier>();

        public SellDataWindow()
        {
            InitializeComponent();
            var orangeButton1 = new OrangeButton(panelOrangeBtn1, Color.DarkSlateGray, Color.DarkOrange, Color.FromArgb(255, 51, 0), containsPictureBox: true);
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

        #region Events

        private void checkBoxUnlimitedTime_CheckedChanged(object sender, EventArgs e)
        {
            var chkBox = sender as CheckBox;

            if (chkBox != null) panelExpiryDate.Visible = !chkBox.Checked;
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            _textBoxControlDictionaries.Find(cd => cd._txtBox.Equals((sender as TextBox))).VerifyInput();
        }

        private void textBoxExpiryDate_TextChanged(object sender, EventArgs e)
        {
            ((TextBoxGroupControlVerifier)_textBoxControlDictionaries.ElementAt(2)).VerifyInput();
        }

        #region On Click and OnLeave Events for day, month and year textbox

        private void textBoxExpiryDateDay_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxExpiryDateDay.Text.Equals(Resources.Day))
                textBoxExpiryDateDay.Text = String.Empty;
        }

        private void textBoxExpiryDateDay_Leave(object sender, EventArgs e)
        {
            if (textBoxExpiryDateDay.Text.Equals(String.Empty))
                textBoxExpiryDateDay.Text = Resources.Day;
        }

        private void textBoxExpiryDateMonth_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxExpiryDateMonth.Text.Equals(Resources.Month))
                textBoxExpiryDateMonth.Text = String.Empty;
        }

        private void textBoxExpiryDateMonth_Leave(object sender, EventArgs e)
        {
            if (textBoxExpiryDateMonth.Text.Equals(String.Empty))
                textBoxExpiryDateMonth.Text = Resources.Month;
        }

        private void textBoxExpiryDateYear_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxExpiryDateYear.Text.Equals(Resources.Year))
                textBoxExpiryDateYear.Text = String.Empty;
        }

        private void textBoxExpiryDateYear_Leave(object sender, EventArgs e)
        {
            if (textBoxExpiryDateYear.Text.Equals(String.Empty))
                textBoxExpiryDateYear.Text = Resources.Year;
        }

        #endregion On Click and OnLeave Events for day, month and year textbox

        #endregion Events
    }
}