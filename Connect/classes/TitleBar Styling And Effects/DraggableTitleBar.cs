using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Connect.classes.TitleBar_Styling_And_Effects
{
    internal class DraggableTitleBar
    {
        private readonly IntPtr _handleIntPtr;
        private object _sender;
        private MouseEventArgs _e;

        public DraggableTitleBar(IntPtr handle, object sender, MouseEventArgs e)
        {
            _handleIntPtr = handle;
            this._sender = sender;
            this._e = e;
            Move();
        }

        #region Title Bar Properties and Effects

        #region Variable for Draggable Effect

        public const int WmNclbuttondown = 0xA1;
        public const int HtCaption = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion Variable for Draggable Effect

        private void Move()
        {
            if (_e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(_handleIntPtr, WmNclbuttondown, HtCaption, 0);
            }
        }

        #endregion Title Bar Properties and Effects
    }
}