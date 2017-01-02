using Connect.Properties;
using System;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;

namespace Connect.classes.Api.Internet_Connection
{
    internal class ConnectionNotifier
    {
        /// <summary>
        /// Variable Declaration: Pinger object
        /// </summary>
        private Ping _pinger;

        public ConnectionNotifier()
        {
            _pinger = new Ping();
            _pinger.PingCompleted += _pinger_PingCompleted;
        }

        private void _pinger_PingCompleted(object sender, PingCompletedEventArgs e)
        {
            Dispose();
        }

        /// <summary>
        /// starts continous ping usage at which pinging is carried out every 5 seconds to a live webpage
        /// </summary>
        /// <returns>The connection state, if still connected to internetlogin{-}.cu.edu.ng</returns>
        public async Task<bool> StartNotifier()
        {
            bool online = true;

            while (true)
            {
                if (_pinger == null) break;
                Thread.Sleep(5000);
                await Ping().ContinueWith((res) =>
                {
                    online = res.Result;
                });

                StopNotifier();
                if (!online) break;
            }
            return false;
        }

        /// <summary>
        /// responsible for just a single ping to live webpage aside the freely accessible ones on
        /// internetlogin{-}.cu.edu.ng e.g.(google.com is freely accessible without internetlogin),
        /// such websites are not pinged here
        /// </summary>
        /// <returns>The connection state, if still connected to internetlogin{-}.cu.edu.ng</returns>
        private async Task<bool> Ping()
        {
            _pinger = new Ping();
            var a = false;

            await _pinger.SendPingAsync(Resources.PingUri, 3000)
                .ContinueWith((connected) =>
                {
                    try
                    {
                        a = connected.Result.Status == IPStatus.Success;
                    }
                    catch (Exception)
                    {
                        a = false;
                    }
                });

            return a;
        }

        /// <summary>
        /// Calls the Dipose method, to dispose all objects for pinging webpages
        /// </summary>
        public void StopNotifier()
        {
            Dispose();
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        private void Dispose()
        {
            _pinger.Dispose();
        }
    }
}