using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClockWidget
{
    internal static class Program
    {
        static OptionsMenu optionsMenu;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SetNotifyIcon();

            Application.Run(new ClockWidget());
        }
        private static void SetNotifyIcon()
        {
            //Sets system tray icon
            NotifyIcon notifyIcon = new NotifyIcon
            {
                Icon = Properties.Resources.ClockWidgetIcon,
                Visible = true,
                Text = "Clock Widget",
            };
            notifyIcon.Click += NotifyIcon_Click;
        }
        private static void NotifyIcon_Click(object? sender, EventArgs e)
        {
            if (optionsMenu == null || optionsMenu.IsDisposed)
            {
                optionsMenu = new OptionsMenu();
                optionsMenu.Show();
            }
            else
            {
                optionsMenu.BringToFront();
            }
        }
    }
}
