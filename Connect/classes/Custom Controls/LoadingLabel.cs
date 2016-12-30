using System;
using System.Windows.Forms;

namespace Connect.classes.Custom_Controls
{
    internal class LoadingLabel : Timer
    {
        private readonly Label _labelToUpdate;
        private readonly string _stringToUpdate;

        public LoadingLabel(Label labelToUpdate, int secondsIntervalconst, string stringToUpdate)
        {
            _labelToUpdate = labelToUpdate;
            _stringToUpdate = stringToUpdate;

            base.Enabled = true;
            base.Interval = secondsIntervalconst;
            Initialize();
        }

        private void Initialize()
        {
            base.Tick += delegate
            {
                if (_labelToUpdate.Text.Equals(_stringToUpdate)) _labelToUpdate.Text += ".";
                else if (_labelToUpdate.Text.Equals(String.Format("{0}.", _stringToUpdate))) _labelToUpdate.Text += ".";
                else if (_labelToUpdate.Text.Equals(String.Format("{0}..", _stringToUpdate))) _labelToUpdate.Text += ".";
                else _labelToUpdate.Text = _stringToUpdate;
            };
        }

        public new void Stop()
        {
            base.Stop();
        }

        public new void Start()
        {
            base.Start();
        }
    }
}