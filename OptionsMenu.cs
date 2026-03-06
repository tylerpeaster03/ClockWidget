using System.Diagnostics;

namespace ClockWidget
{
    public partial class OptionsMenu : Form
    {
        public OptionsMenu()
        {
            InitializeComponent();
        }

        private void OptionsMenu_Load(object sender, EventArgs e)
        {

        }

        private void linkLabelDisplaySettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLink("ms-settings:display");
        }

        private void linkLabelCreditGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLink("https://github.com/tylerpeaster03/ClockWidget");
        }

        private static void OpenLink(string link)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = link,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to open link: {ex.Message}");
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
