using System;

namespace ClockWidget
{
    public class InternalConfig
    {
        public Screen TargetScreen { get; set; } = Screen.AllScreens[0];
        public int[] ClockSize { get; set; } = new int[2] { 120, 40 };
        public FormBorderStyle Borderless { get; set; } = FormBorderStyle.None;
        public Color BackColor { get; set; } = Color.Black;
        public Color TextColor { get; set; } = Color.White;
        public double Opacity { get; set; } = 0.7;
        public bool ClickThrough { get; set; } = true;


        //Constructor that grabs all config settings, or uses defaults
        //Will eventually be used to read from a config file, but for now it just sets defaults again lol
        public InternalConfig()
        {
            TargetScreen = Screen.AllScreens[0]; //Screen.AllScreens[fromSavedSettings int]
            ClockSize = [120, 40];  //[width from file, height from file]
            Borderless = FormBorderStyle.None; //true/false from file, borderless if true
            BackColor = Color.FromArgb(0, 0, 0);
            TextColor = Color.FromArgb(255, 255, 255);
            Opacity = 0.7;  //slider in settings, value from file
            ClickThrough = true;
        }

        //Writes all settings to config file
        public void SaveConfig()
        {

        }

        //Set of methods to set values that are edited by actions, not settings
        //ex. SetSize
    }
}
