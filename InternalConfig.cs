using System;

namespace ClockWidget
{
    public class InternalConfig
    {
        public Screen TargetScreen { get; set; } = Screen.AllScreens[0];
        public int[] ClockSize { get; set; } = new int[2] { 120, 40 };
        public FormBorderStyle Borderless { get; set; } = FormBorderStyle.None;
        public Color Color { get; set; } = Color.Black;
        public double Opacity { get; set; } = 0.7;


        //Constructor that grabs all config settings, or uses defaults
        //Will eventually be used to read from a config file, but for now it just sets defaults again lol
        public InternalConfig()
        {
            TargetScreen = Screen.AllScreens[0]; //Screen.AllScreens[fromSavedSettings int]
            ClockSize = [120, 40];  //[width from file, height from file]
            Borderless = FormBorderStyle.None; //true/false from file, borderless if true
            Color = Color.FromArgb(0, 0, 0);
            Opacity = 0.7;  //slider in settings, value from file
        }

        //Writes all settings to config file
        public void SaveConfig()
        {

        }

        //Set of methods to set values that are edited by actions, not settings
        //ex. SetSize
    }
}
