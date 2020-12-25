using System.Text.Json;
using System.IO;
using System.Collections.Generic;
using System;

namespace OsloOS.Settings
{
    // ComputerElite's Part Don't touch lmao
    // Ig this is some sort of Android like settings from what I've heard
    // Also listen to spotify while programming helps a lot and I should release the new Update of BMBF Manager I have it since 3 days again xD
    //
    // BTW LIVE SHARE SHIT CAUSE INTELLESENSE IS BROKEN

    
    // Settings Loader used to load the settings
    public class SettingsLoader
    {
        /* To load settings you need to do this: 

        String settingspath = "C:\Program Files\OsloOS\Settings.json";
        SettingsLoader sl = new SettingsLoader();
        Settings settings = sl.LoadSettingsFromDisk(settingspath);

        */

        public Settings LoadSettingsFromDisk(string SettingsJSONPath)
        {
            Settings s = JsonSerializer.Deserialize<Settings>(File.ReadAllText(SettingsJSONPath));
            s.SavedSettingsPath = SettingsJSONPath;
            return s;
        }
    }

    // Settings instance
    public class Settings
    {
        public string SavedSettingsPath { get; set; } = "";
        public ThemeSettings Theme { get; set; } = new ThemeSettings();

        public void SaveSettingsToDisk(string SettingsJSONPath = "")
        {
            if (SettingsJSONPath != "") SavedSettingsPath = SettingsJSONPath;
            File.WriteAllText(SavedSettingsPath, JsonSerializer.Serialize(this));
        }
    }

    // Themes
    public class ThemeSettings
    {
        public bool MixTheme { get; set; } = false;

        public List<String> BackgroundHistory { get; set; } = new List<string>();

        public void AddBackground(String BackgroundPath)
        {
            if (BackgroundHistory.Count > 5) BackgroundHistory.RemoveAt(4);
            BackgroundHistory.Insert(0, BackgroundPath);
        }

        public string GetCurrentBackground()
        {
            return BackgroundHistory[0];
        }


        /*
        To-Do in V 2

        public string ThemePath { get; set; } = "";
        */
    }
}

namespace OsloOS.Themes
{
    // To-Do in V 2
}