using Connect.classes.Api.Internet_Connection;
using Connect.Properties;
using System;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace Connect.classes.Api.InternetLogin
{
    internal class Ping
    {
        private readonly string _login1 = Resources.InternetLogin1;
        private readonly string _login2 = Resources.InternetLogin2;

        private async Task<bool> PingLogin1Async(string url)
        {
            try
            {
                var pinger = new System.Net.NetworkInformation.Ping();

                var a = await pinger.SendPingAsync(url, 3000);

                return a.Status == IPStatus.Success;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        ///Bings Login 1 and Login 2 together, and gets the one that is alive out of the two,to connect to
        /// </summary>
        /// <returns>
        /// </returns>
        /// <code>Usage:
        /// Tuple&lt;Uri, Message&gt; = await PingNow(...);
        /// </code>
        public async Task<Tuple<string, string>> PingNow()
        {
            //check if the device has internet Connection on the device
            //if (!InternetConnectionStatus.Connected())
            //{
            //    return new Tuple<string, string>(null, "No Internet Connection");
            //}

            Tuple<string, string> uri = null;

            while (!PingLogin1Async(_login1).Result || !PingLogin1Async(_login2).Result)
            {
                await PingLogin1Async(_login1).
                        ContinueWith(async (value1) =>
                        {
                            await PingLogin1Async(_login2).
                            ContinueWith((value2) =>
                            {
                                if (value2 != null && value2.Result) uri = new Tuple<string, string>(_login2, "Alive");
                            });

                            if (value1 != null && value1.Result) uri = new Tuple<string, string>(_login1, "Alive");
                        });
            }

            return uri;
        }
    }
}