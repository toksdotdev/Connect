using Connect.classes.Custom_Controls;
using Connect.classes.Data_Calculator;
using Connect.classes.Form_Styling.Purchase_Window_Styles;
using Connect.Properties;
using Microsoft.VisualBasic.PowerPacks;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Connect
{
    public partial class PurchaseWindow : Form
    {
        private readonly List<TextBoxControlVerifier> _textBoxControlDictionaries = new List<TextBoxControlVerifier>();
        private readonly Dictionary<int, Point> _currencyLengthLocationDictionary;

        public PurchaseWindow()
        {
            InitializeComponent();

            //Creates Functionalaties for Custom Orange Button
            var orangeButton1 = new OrangeButton(panelOrangeBtn1, Color.DarkSlateGray, Color.DarkOrange, Color.FromArgb(255, 51, 0), containsPictureBox: true);
            orangeButton1.FillInProperties();

            _textBoxControlDictionaries.AddRange(new[]{

                #region contains textbox groupings

                new TextBoxControlVerifier(textBoxCardNo,rectangleShapeCardNo,pictureBoxCardNo, NumberStyles.Integer),
                new TextBoxControlVerifier(textBoxNameOnCard,rectangleShapeNameOnCard,pictureBoxNameOnCard),
                new TextBoxControlVerifier(textBoxAddress,rectangleShapeAddress,pictureBoxAddress),new TextBoxControlVerifier(textBoxState,rectangleShapeState,pictureBoxState),
                new TextBoxControlVerifier(textBoxCountry,rectangleShapeCountry,pictureBoxCountry),
                new TextBoxControlVerifier(textBoxZipCode,rectangleShapeZipCode,pictureBoxZipCode, NumberStyles.Integer),
                new TextBoxControlVerifier(textBoxCreditCardYear,rectangleShapeCreditCardYear,pictureBoxCreditCardYear, NumberStyles.Integer),
                new TextBoxControlVerifier(textBoxCreditCardMonth,rectangleShapeCreditCardMonth,pictureBoxCreditCardMonth, NumberStyles.Integer),
                new TextBoxControlVerifier(textBoxCreditCardCVV,rectangleShapeCreditCardCVV,pictureBoxCreditCardCVV, NumberStyles.Integer)

                #endregion contains textbox groupings
            });
            lineShape2.BringToFront();

            _currencyLengthLocationDictionary =
            new Dictionary<int, Point>()
            {
                {5, new Point(42,8)},
                {4, new Point(58,8)},
                {3, new Point(85,8)},
                {2, new Point(106,8)}
            };
        }

        private void textBoxCreditCardYear_Click(object sender, EventArgs e)
        {
            if (textBoxCreditCardYear.Text.Equals(Resources.Year))
                textBoxCreditCardYear.Text = String.Empty;
        }

        private void textBoxCreditCardYear_Leave(object sender, EventArgs e)
        {
            if (textBoxCreditCardYear.Text.Equals(String.Empty))
                textBoxCreditCardYear.Text = Resources.Year;
        }

        private void textBoxCreditCardMonth_Click(object sender, EventArgs e)
        {
            if (textBoxCreditCardMonth.Text.Equals(Resources.Month))
                textBoxCreditCardMonth.Text = String.Empty;
        }

        private void textBoxCreditCardMonth_Leave(object sender, EventArgs e)
        {
            if (textBoxCreditCardMonth.Text.Equals(String.Empty))
                textBoxCreditCardMonth.Text = Resources.Month;
        }

        private void rectangleShapeCustomTitleBar_Paint(object sender, PaintEventArgs e)
        {
            ((RectangleShape)sender).SendToBack();
        }

        private void textBoxCreditCardCVV_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxCreditCardCVV.Text.Equals(Resources.Cvv))
                textBoxCreditCardCVV.Text = String.Empty;
        }

        private void textBoxCreditCardCVV_Leave(object sender, EventArgs e)
        {
            if (textBoxCreditCardCVV.Text.Equals(String.Empty))
                textBoxCreditCardCVV.Text = Resources.Cvv;
        }

        private void textBoxForCreditCardDetails_TextChanged(object sender, EventArgs e)
        {
            _textBoxControlDictionaries.Find(cd => cd._txtBox.Equals((sender as TextBox))).VerifyInput();
        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            if ((e.State == DrawItemState.Selected))
            {
                //Text color
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(255, 51, 0)), e.Bounds);
            } using (SolidBrush b = new SolidBrush(e.ForeColor))
            {
                e.Graphics.DrawString(comboBox1.GetItemText(comboBox1.Items[e.Index]), e.Font, b, e.Bounds);
            }
            e.DrawFocusRectangle();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var combo = (sender as ComboBox);

            //MessageBox.Show(combo.SelectedItem.ToString());
            //Debug.Assert(combo != null, "combo != null");
            comboBox3.SelectedItem = combo != null && Convert.ToDouble(combo.SelectedItem.ToString()) < 100 ? comboBox3.Items[0] : comboBox3.Items[1];

            //calculate price
            if (combo != null)
            {
                var chargeCalculator = new CalculatePrice(Convert.ToDouble(combo.SelectedItem));
                labelPriceNaira.Location =
                    _currencyLengthLocationDictionary[chargeCalculator.GetPrice().ToString().Length];

                labelPriceNaira.Text = chargeCalculator.ToString();
            }
        }
    }
}