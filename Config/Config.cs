using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClockWidget.Config
{
    public class Config
    {
        public Config() 
        {
            string filePath = "Config.json";
            ConfigModel config = new ConfigModel();

            if (File.Exists(filePath))
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    config = JsonSerializer.Deserialize<ConfigModel>(json) ?? new ConfigModel();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading config: {ex.Message}");
                    config = new ConfigModel();
                }
            }
            else
            {
                config = new ConfigModel();
                SaveConfig();
            }
        }

        private class ConfigModel
        {
            public Screen TargetScreen { get; set; } = Screen.AllScreens[0];
            public int[] ClockSize { get; set; } = new int[2] { 120, 40 };
            public FormBorderStyle Borderless { get; set; } = FormBorderStyle.None;
            public Color BackColor { get; set; } = Color.Black;
            public Color TextColor { get; set; } = Color.White;
            public double Opacity { get; set; } = 0.7;
        }
    }
}
