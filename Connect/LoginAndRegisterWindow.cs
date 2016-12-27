using Connect.classes.Custom_Controls;
using System.Drawing;
using System.Windows.Forms;

namespace Connect
{
    public partial class LoginAndRegisterWindow : Form
    {
        public LoginAndRegisterWindow()
        {
            InitializeComponent();
            var orangeButton1 = new OrangeButton(panelOrangeBtn1, Color.DarkSlateGray, Color.DarkOrange, Color.FromArgb(255, 51, 0));
            orangeButton1.FillInProperties();

            var orangeButton2 = new OrangeButton(panelOrangeBtn2, Color.DarkSlateGray, Color.DarkOrange, Color.FromArgb(255, 51, 0));
            orangeButton2.FillInProperties();
        }
    }
}