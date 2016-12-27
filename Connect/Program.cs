using System;
using System.Windows.Forms;

namespace Connect
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow(true));
            //Application.Run(new SellDataWindow());
            //Application.Run(new PurchaseWindow());
        }
    }
}