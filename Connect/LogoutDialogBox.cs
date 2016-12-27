using Connect.classes.Custom_Controls;
using Connect.classes.TitleBar_Styling_And_Effects;
using Microsoft.VisualBasic.PowerPacks;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Connect
{
    public partial class LogoutDialogBox : Form
    {
        protected Control ToHideControl;

        ///  <summary>
        ///
        ///  </summary>
        ///  <param name="controlToHide">Control to hide when the logout dialog is visible</param>
        ///  <param>Enables the Draggable Title bar for dialog Control</param>
        public LogoutDialogBox(Control controlToHide)
        {
            ToHideControl = controlToHide;
            InitializeComponent();

            panel1Btn.Focus();

            var btn1 = new OrangeButton(panel1Btn, Color.Empty, Color.DarkSlateGray, Color.White, false,
                 Color.Empty, Color.White, Color.CornflowerBlue);
            btn1.FillInProperties();

            var btn2 = new OrangeButton(panel2Btn, Color.Empty, Color.DarkSlateGray, Color.White, false,
                 Color.Empty, Color.White, Color.CornflowerBlue);
            btn2.FillInProperties();
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {
        }

        private void rectangleShape_MouseEnter(object sender, EventArgs e)
        {
            ((SimpleShape)sender).FillStyle = FillStyle.Solid;

            if (((SimpleShape)sender) == rectangleShape1)
            {
                if (rectangleShape1 != null) label2.BackColor = rectangleShape1.FillColor;
                label2.ForeColor = Color.White;
            }
            else
            {
                label3.BackColor = rectangleShape1.FillColor;
                label3.ForeColor = Color.White;
            }
        }

        private void rectangleShape_MouseLeave(object sender, EventArgs e)
        {
            ((SimpleShape)sender).FillStyle = FillStyle.Transparent;
            if (((SimpleShape)sender) == rectangleShape1)
            {
                label2.ForeColor = Color.CornflowerBlue;
                label2.BackColor = Color.Transparent;
            }
            else
            {
                label3.ForeColor = Color.CornflowerBlue;
                label3.BackColor = Color.Transparent;
            }
        }

        private void ovalShape1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            ToHideControl.Enabled = true;
            DestroyHandle();
        }

        private void Logout_Shown(object sender, EventArgs e)
        {
            rectangleShape3.SendToBack();
            ToHideControl.Enabled = false;
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            new DraggableTitleBar(Handle, sender, e);
        }
    }
}