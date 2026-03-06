using ClockWidget.Config;
using System;

/*
 * Implement:
 * Allow all settings to be controlled by a configuration file.
 * Allow resizing and repositioning the widget via mouse drag, with position and size saved to config.
 * Have a button to reveret to default position and size.
 * Have a button to hide the widget.
 * Allow app to be added to startup programs, ask user on first run.
 * Allow date to be added as well.
 * Allow for a tiny icon to appear left of clock or widget-wide backgrounnd image, support transparency
 * Hotkey to hide widget
 * OLED Pixel-Shifting
 * 
 * Make click-through optional? Can a size and scale option work on a click-through window?
 * 
 * Testing:
 * Test on multi-monitor setups with different resolutions and scaling.
 * Make sure app can handle a monitor disconnecting and reconnecting
*/

namespace ClockWidget
{
    public class ClockWidget : Form
    {
        private Label clockLabel;
        private readonly System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer? _topMostTimer;
        private ConfigModel config = new ConfigModel();

        public ClockWidget()
        {
            //Window settings
            //Implicit settings not from config
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.Manual;

            //Explicit settings from config
            var targetScreen = config.TargetScreen;
            this.FormBorderStyle = config.Borderless;
            this.BackColor = config.BackColor;
            this.Opacity = config.Opacity;
            this.Size = new Size(config.ClockSize[0], config.ClockSize[1]);
            this.Location = new Point(
                targetScreen.WorkingArea.Right - this.Width - 10,
                targetScreen.WorkingArea.Bottom - this.Height - 10
            );

            //Clock label creation/settings
            clockLabel = new Label()
            {
                //Implicit settings not from config
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 16, FontStyle.Bold),    //make font custom
                TextAlign = ContentAlignment.MiddleCenter,

                //Explicit settings from config
                ForeColor = config.TextColor,
            };
            this.Controls.Add(clockLabel);

            //Displayed Time
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += (s, e) => clockLabel.Text = DateTime.Now.ToShortTimeString();
            timer.Start();

            SetAsTopWindow();
        }

        //Makes the window click-through
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                const int WS_EX_TRANSPARENT = 0x20;
                const int WS_EX_LAYERED = 0x80000;

                cp.ExStyle |= WS_EX_TRANSPARENT | WS_EX_LAYERED;
                return cp;
            }
        }

        private void SetAsTopWindow()
        {
            _topMostTimer = new System.Windows.Forms.Timer
            {
                Interval = 500
            };

            _topMostTimer.Tick += (_, _) => TopMost = true;
            _topMostTimer.Start();
        }
    }
}
