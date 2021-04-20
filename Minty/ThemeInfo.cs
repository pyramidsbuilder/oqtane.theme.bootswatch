﻿using Oqtane.Themes;

namespace Oqtane.Theme.Bootswatch.Minty
{
    public class ThemeInfo : ITheme
    {
        public Models.Theme Theme => new Models.Theme
        {
            Name = "Bootswatch Minty Theme",
            Version = "1.0.0",
            ContainerSettingsType = "Oqtane.Theme.Bootswatch.ContainerSettings, Oqtane.Theme.Bootswatch.Oqtane"
        };
    }
}