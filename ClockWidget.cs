using System;
using System.Drawing;
using System.Windows.Forms;

/*
 * Implement:
 * Allow all settings to be controlled by a configuration file.
 * Allow resizing and repositioning the widget via mouse drag, with position and size saved to config.
 * Have a button to reveret to default position and size.
 * Have a button to hide the widget.
 * Allow app to be added to startup programs, ask user on first run.
 * Allow date to be added as well.
 * 
 * Testing:
 * Test on multi-monitor setups with different resolutions and scaling.
*/

namespace ClockWidget
{
    public class ClockWidget : Form
    {
        private Label clockLabel;
        private System.Windows.Forms.Timer timer;

        public ClockWidget()
        {
            // Selects monitor #2 for temp testing
            var screens = Screen.AllScreens;
            var targetScreen = screens.Length > 1 ? screens[1] : screens[0];

            // Window style
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;

            SetAsTopWindow();

            this.ShowInTaskbar = false;
            this.BackColor = Color.Black;
            this.Opacity = 0.7;

            // Adjust size
            this.Size = new Size(120, 40);

            // Position bottom-right of monitor #2
            this.Location = new Point(
                targetScreen.WorkingArea.Right - this.Width - 10,
                targetScreen.WorkingArea.Bottom - this.Height - 10
            );

            // Clock label
            clockLabel = new Label()
            {
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent
            };
            this.Controls.Add(clockLabel);

            // Timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += (s, e) => clockLabel.Text = DateTime.Now.ToShortTimeString();
            timer.Start();
        }

        // Make the window click-through
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_EX_TRANSPARENT = 0x20;
                const int WS_EX_LAYERED = 0x80000;

                var cp = base.CreateParams;
                cp.ExStyle |= WS_EX_TRANSPARENT | WS_EX_LAYERED;
                return cp;
            }
        }

        // Apparently, this is the only reliable way to keep a window always on top
        // Checking once per half-second should have negligible performance impact
        private void SetAsTopWindow() {
            new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        this.TopMost = true;
                        Thread.Sleep(500);
                    }
                }
                catch (Exception) { }
            }).Start();
        }
    }
}
