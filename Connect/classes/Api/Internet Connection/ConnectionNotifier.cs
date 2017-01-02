using System;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace Connect.classes.Api.Internet_Connection
{
    internal class ConnectionNotifier
    {
        private readonly System.Net.NetworkInformation.Ping _pinger;

        public ConnectionNotifier()
        {
            _pinger = new System.Net.NetworkInformation.Ping();
        }

        public async Task<bool> StartNotifier()
        {
            var a = await _pinger.SendPingAsync("localhost", 3000).
                ContinueWith((connected) =>
                {
                    return connected.Result.Status == IPStatus.Success;
                });
            return a;
        }

        public void StopNotifier()
        {
            Dispose();
        }

        /// <summary>Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.</summary>
        private void Dispose()
        {
            _pinger.Dispose();
        }
    }
}