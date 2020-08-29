﻿namespace ColorControl
{
    class Config
    {
        public bool StartMinimized { get; set; }

        public int DisplaySettingsDelay { get; set; }

        public string ScreenSaverShortcut { get; set; }

        public int FormWidth { get; set; }
        public int FormHeight { get; set; }

        public Config()
        {
            DisplaySettingsDelay = 1000;
            ScreenSaverShortcut = string.Empty;
            FormWidth = 900;
            FormHeight = 600;
        }
    }
}