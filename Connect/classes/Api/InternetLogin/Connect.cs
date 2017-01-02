using System;
using System.Collections.Specialized;
using System.Net;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace Connect.classes.Api.InternetLogin
{
    internal class Connect : IDisposable
    {
        #region Variable Declarations

        private readonly WebClient _client = new WebClient();
        private readonly string _username;
        private readonly string _password;
        private bool _success;
        private NameValueCollection _loginInfo;
        private readonly Timer _timer = new Timer();
        private bool _hasStartedTimer;
        private int _timeOutSeconds = 20;
        private string _serverStringUri;

        #endregion Variable Declarations

        public Connect(string username, string password)
        {
            _timer.Interval = 1000;

            _timer.Tick += _timer_Tick;
            _timer.Enabled = true;

            _username = username;
            _password = password;
            _success = false;
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            if ((_timeOutSeconds == 1) && _client.IsBusy)
            {
                _success = false;
                Dispose();
                _timer.Stop();
            }

            _timeOutSeconds--;
        }

        public async Task<bool> ConnectAsync()
        {
            byte[] lenght = null;
            bool hasPingedFailed = false;

            await new Ping().PingNow()
                .ContinueWith(async (pingResult) =>
                {
                    if (pingResult.Result != null && pingResult.Result.Item1 != null)
                    {
                        _serverStringUri = pingResult.Result.Item1;
                    }
                    else
                    {
                        hasPingedFailed = true;
                        return false;
                    }

                    try
                    {
                        _loginInfo = new NameValueCollection(2)
                        {
                            {"username", _username},
                            {"password", _password}
                        };

                        if (!_hasStartedTimer) _timer.Start();
                        _hasStartedTimer = true;

                        lenght =
                        await
                        _client.UploadValuesTaskAsync(new Uri(_serverStringUri), "POST", _loginInfo);
                    }
                    catch (Exception)
                    {
                        _success = false;
                    }
                    return _success;
                });

            if (lenght != null) _success = true;

            if (_timeOutSeconds > 0 && !_success && !hasPingedFailed)
            {
                await ConnectAsync()
                    .ContinueWith((result) =>
                    {
                        _success = result.Result;
                    });
            }
            return _success;
        }

        public void Dispose()
        {
            try
            {
                _client.Dispose();
            }
            catch (Exception)
            {
                //log this later
            }
        }
    }
}