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
            if (!InternetConnectionStatus.Connected())
            {
                return new Tuple<string, string>(null, "No Internet Connection");
            }

            Tuple<string, string> uri = null;

            for (int i = 0; i < 5; i++)
            {
                await new System.Net.NetworkInformation.Ping().SendPingAsync(_login1, 3000)
                    .ContinueWith(async (value1) =>
                    {
                        if (value1.Status == TaskStatus.RanToCompletion && value1.Result.Status == IPStatus.Success)
                        {
                            uri = new Tuple<string, string>(_login1, "Alive");
                            return uri;
                        }
                        await new System.Net.NetworkInformation.Ping().SendPingAsync(_login2, 3000)
                            .ContinueWith((value2) =>
                            {
                                if (value2.Result.Status != IPStatus.Success) return uri; // i.e null

                                //got a success value
                                uri = new Tuple<string, string>(_login2, "Alive");
                                return uri;
                            });

                        return uri;
                    });

                if (uri != null) break;
            }

            return uri;
        }
    }
}