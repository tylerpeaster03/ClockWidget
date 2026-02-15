using System;

/*
 * Implement:
 * Allow all settings to be controlled by a configuration file.
 * Allow resizing and repositioning the widget via mouse drag, with position and size saved to config.
 * Have a button to reveret to default position and size.
 * Have a button to hide the widget.
 * Allow app to be added to startup programs, ask user on first run.
 * Allow date to be added as well.
 * 
 * Make click-through optional? Can a size and scale option work on a click-through window?
 * 
 * Testing:
 * Test on multi-monitor setups with different resolutions and scaling.
*/

namespace ClockWidget
{
    public class ClockWidget : Form
    {
        //Sets system tray icon
        NotifyIcon notifyIcon = new NotifyIcon
        {
            Icon = Properties.Resources.ClockWidgetIcon,
            Visible = true,
            Text = "Clock Widget"
        };

        private Label clockLabel;
        private readonly System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer? _topMostTimer;
        private InternalConfig config = new InternalConfig();

        public ClockWidget()
        {
            //Implicit settings
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.Manual;

            //Explicit settings from config
            var targetScreen = config.TargetScreen;
            this.FormBorderStyle = config.Borderless;
            this.BackColor = config.Color;
            this.Opacity = config.Opacity;
            this.Size = new Size(config.ClockSize[0], config.ClockSize[1]);
            this.Location = new Point(
                targetScreen.WorkingArea.Right - this.Width - 10,
                targetScreen.WorkingArea.Bottom - this.Height - 10
            );

            SetAsTopWindow();

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

        //Make the window click-through
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
