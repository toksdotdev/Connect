using Connect.classes.Api.Internet_Connection;
using Connect.classes.Custom_Controls;
using Connect.classes.Main_Page.styling;
using Connect.classes.TitleBar_Styling_And_Effects;
using Connect.Properties;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Connect
{
    public partial class MainWindow : Form
    {
        private bool _connected;
        private ConnectionNotifier _connectionNotifier;

        private bool Connected
        {
            get { return _connected; }
            set
            {
                _connected = value;

                if (_connected)
                {
                    try
                    {
                        if (_connectionNotifier == null)
                            _connectionNotifier = new ConnectionNotifier();

                        _connectionNotifier.StartNotifier()
                            .ContinueWith((isConnected) =>
                            {
                                if (!isConnected.Result) Connected = isConnected.Result;
                            });
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
                else
                {
                    if (_connectionNotifier != null) _connectionNotifier.StopNotifier();

                    BeginInvoke((MethodInvoker)delegate
                    {
                        LabelConnectionStatus.Text = Resources.Disconnected;
                    });
                }
            }
        }

        public MainWindow(bool signedIn)
        {
            InitializeComponent();

            //sets the active Tab as Purchase Tab of index 0
            _activePanel = new ActivePanel(m1, 0);

            if (signedIn == false)
                labelPurchase_Click(this, new EventArgs());
            else
                labelProfile_Click(this, new EventArgs());
        }

        private static void ChangeToActiveTab(Panel panelToChangeColor, Color toChangeToColor)
        {
            panelToChangeColor.BackColor = toChangeToColor;
        }

        private void ovalShape1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ovalShape2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ovalShape3_Click(object sender, EventArgs e)
        {
            WindowState = WindowState.Equals(FormWindowState.Maximized)
                ? FormWindowState.Normal
                : FormWindowState.Maximized;
        }

        #region TabBar Styling

        #region Variable declaration

        private readonly Color[] _tabBarColors = new[] {
            Color.FromArgb(44, 152, 224),
            Color.FromArgb(254, 208, 114),
            Color.FromArgb(235, 124, 107),
            Color.FromArgb(27, 184, 155),
            Color.FromArgb(255, 128, 0),
            Color.Transparent
        };

        private ActivePanel _activePanel;

        #endregion Variable declaration

        #region Tab bar Click Events

        private void labelPurchase_Click(object sender, EventArgs e)
        {
            _activePanel.Panel.BackColor = _tabBarColors[5];
            _activePanel = new ActivePanel(m1, 0);

            //change tab bachground color
            ChangeToActiveTab(m1, m11.BackColor);

            //shows The PurchaseWindow as Active Screen / Panel
            ChangeActivePanel(new PurchaseWindow());
        }

        private void labelSell_Click(object sender, EventArgs e)
        {
            _activePanel.Panel.BackColor = _tabBarColors[5];
            _activePanel = new ActivePanel(m2, 1);

            //change tab bachground color
            ChangeToActiveTab(m2, m22.BackColor);

            //shows The SellDataWindow as Active Screen / Panel
            ChangeActivePanel(new SellDataWindow());
        }

        private void labelProfile_Click(object sender, EventArgs e)
        {
            _activePanel.Panel.BackColor = _tabBarColors[5];
            _activePanel = new ActivePanel(m3, 2);

            //change tab bachground color
            ChangeToActiveTab(m3, m33.BackColor);

            //shows The ProfileWindow as Active Screen / Panel
            ChangeActivePanel(new ProfileWindow());
        }

        private void labelSettings_Click(object sender, EventArgs e)
        {
            _activePanel.Panel.BackColor = _tabBarColors[5];
            _activePanel = new ActivePanel(m4, 3);

            //change tab bachground color
            ChangeToActiveTab(m4, m44.BackColor);
        }

        private void labelLogout_Click(object sender, EventArgs e)
        {
            _activePanel.Panel.BackColor = _tabBarColors[5];
            _activePanel = new ActivePanel(m5, 4);

            //change tab bachground color
            ChangeToActiveTab(m5, m55.BackColor);

            //shows the logout dialogBox
            ChangeActivePanel(new LogoutDialogBox(panel1), true,
                (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left));
        }

        #endregion Tab bar Click Events

        private void TabBarItem_MouseEnter(object sender, EventArgs e)
        {
            if (sender.GetType() == new Panel().GetType())
            {
                if (_activePanel.Panel != sender as Panel)
                    ((Panel)sender).BackColor = Color.DarkCyan;
            }
            else
            {
                if (_activePanel.Panel != ((Control)sender).Parent)
                {
                    var a = (Control)sender;
                    a.Parent.BackColor = Color.DarkCyan;
                }
            }
        }

        private void TabBarItem_MouseLeave(object sender, EventArgs e)
        {
            if (sender.GetType() == new Panel().GetType())
            {
                if (_activePanel.Panel != sender as Panel)
                    ((Panel)sender).BackColor = Color.CadetBlue;
            }
            else
            {
                if (_activePanel.Panel != ((Control)sender).Parent)
                    ((Control)sender).Parent.BackColor = Color.DarkCyan;
            }
        }

        #endregion TabBar Styling

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            new DraggableTitleBar(Handle, sender, e);
        }

        private void ChangeActivePanel(Form windowFormToActivate, bool addToParentForm = false, AnchorStyles anchorStyles = AnchorStyles.None)
        {
            //shows the Profile dialog
            windowFormToActivate.TopLevel = false;
            windowFormToActivate.Dock = DockStyle.Fill;

            if (addToParentForm)
                Controls.Add(windowFormToActivate);
            else
            {
                //clear the controls before making the given control active, for memory effieciency
                panel4.Controls.Clear();
                panel4.Controls.Add(windowFormToActivate);
            }

            if (anchorStyles != AnchorStyles.None)
                windowFormToActivate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left;

            windowFormToActivate.Show();
            windowFormToActivate.BringToFront();

            panelVersion.BringToFront();

            //this.DisposeControls(windowFormToActivate, addToParentForm);
            panelVersion.BackColor = Color.WhiteSmoke; label5.BackColor = Color.WhiteSmoke;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var loadingLbl = new LoadingLabel(LabelConnectionStatus, 200, "Connecting");
            loadingLbl.Start();
            new classes.Api.InternetLogin.Connect("ebuka", "pass")
                .ConnectAsync().ContinueWith((result) =>
                {
                    BeginInvoke((MethodInvoker)delegate
                    {
                        loadingLbl.Stop();

                        LabelConnectionStatus.Text = result.Result
                            ? Resources.Connected
                            : Resources.Disconnected;
                    });

                    //user asynchronous thread sleeps for 10 seconds, to ensure that all preocesses required
                    //to connect to the world internet are accomplished
                    //i.e. the loading time
                    if (result.Result) Thread.Sleep(10000);

                    Connected = result.Result;
                });
        }
    }
}