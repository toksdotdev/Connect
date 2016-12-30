using System.Runtime.InteropServices;

namespace Connect.classes.Api.Internet_Connection
{
    internal static class InternetConnectionStatus
    {
        [DllImport("wininet.dll")]
        private static extern bool InternetGetConnectedState(out int description, int reserved);

        public static bool Connected()
        {
            int description;

            return InternetGetConnectedState(out description, 0);
        }
    }
}