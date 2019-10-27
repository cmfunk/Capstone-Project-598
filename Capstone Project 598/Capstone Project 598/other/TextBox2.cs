using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Project_598
{
    class TextBox2 : TextBox
    {
        private Timer _timer = new Timer();
        public event EventHandler TextChangedDelayed;

        public TextBox2()
        {
            _timer.Interval = 1200;
            _timer.Tick += new EventHandler(_timer_Tick);
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            _timer.Stop();
            OnTextChangedDelayed();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            _timer.Stop();
            _timer.Start();
        }

        protected virtual void OnTextChangedDelayed()
        {
            if (TextChangedDelayed != null)
                TextChangedDelayed(this, EventArgs.Empty);
        }
    }
}
