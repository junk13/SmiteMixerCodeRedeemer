﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DolphinScript.Lib.Backend.WinAPI;

namespace SmiteMixerCodeGrabberGUI.Classes
{
    class Globals
    {
        public static bool AFKMode { get; set; }
        public static bool shouldUpdateActiveList { get; set; }
        public static bool shouldUpdateExpiredList { get; set; }
        public static bool shouldMinimise { get; set; }
        public static string smiteWindowTitle { get; set; }

        public static int minWordLength
        {
            get { return Properties.Settings.Default.minWordLength; }
            set
            {
                Properties.Settings.Default.minWordLength = value;
                SaveSettings();
            }
        }
        public static int maxWordLength
        {
            get { return Properties.Settings.Default.maxWordLength; }
            set
            {
                Properties.Settings.Default.maxWordLength = value;
                SaveSettings();
            }
        }
        public static bool useDarkTheme
        {
            get { return Properties.Settings.Default.useDarkTheme; }
            set
            {
                Properties.Settings.Default.useDarkTheme = value;
                SaveSettings();
            }
        }
        public static bool notificationSetting
        {
            get { return Properties.Settings.Default.notificationSetting; }
            set
            {
                Properties.Settings.Default.notificationSetting = value;
                SaveSettings();
            }
        }
        public static bool firstLaunch
        {
            get { return Properties.Settings.Default.firstLaunch; }
            set
            {
                Properties.Settings.Default.firstLaunch = value;
                SaveSettings();
            }
        }
        public static bool useAggressiveParser
        {
            get { return Properties.Settings.Default.useAggressiveParser; }
            set
            {
                Properties.Settings.Default.useAggressiveParser = value;
                SaveSettings();
            }
        }
        public static bool killswitchEnabled
        {
            get { return Properties.Settings.Default.killswitchEnabled; }
            set
            {
                Properties.Settings.Default.killswitchEnabled = value;
                SaveSettings();
            }
        }
        public static bool notificationSound
        {
            get { return Properties.Settings.Default.notificationSound; }
            set
            {
                Properties.Settings.Default.notificationSound = value;
                SaveSettings();
            }
        }
        public static bool minimiseAfterRedeeming
        {
            get { return Properties.Settings.Default.minimiseAfterRedeeming; }
            set
            {
                Properties.Settings.Default.minimiseAfterRedeeming = value;
                SaveSettings();
            }
        }
        public static System.Collections.Specialized.StringCollection whitelistedUsernames
        {
            get { return Properties.Settings.Default.whitelistedUsernames; }
            set
            {
                Properties.Settings.Default.whitelistedUsernames = value;
                SaveSettings();
            }
        }
        public static System.Collections.Specialized.StringCollection blacklistedWords
        {
            get { return Properties.Settings.Default.blacklistedWords; }
            set
            {
                Properties.Settings.Default.blacklistedWords = value;
                SaveSettings();
            }
        }
        public static string notificationSoundFilePath
        {
            get { return Properties.Settings.Default.notificationSoundFilePath; }
            set
            {
                Properties.Settings.Default.notificationSoundFilePath = value;
                SaveSettings();
            }
        }
        public static string killswitchKeyString
        {
            get => Enum.GetName(typeof(VirtualKeyStates), killswitchKey); 
        }
        public static int killswitchKey
        {
            get { return Properties.Settings.Default.killswitchKey; }
            set
            {
                Properties.Settings.Default.killswitchKey = value;
                SaveSettings();
            }
        }
        public static int redeemDelay
        {
            get { return Properties.Settings.Default.redeemDelay; }
            set
            {
                Properties.Settings.Default.redeemDelay = value;
                SaveSettings();
            }
        }

        public static void SaveSettings()
        {
            Properties.Settings.Default.Save();
        }
    }
}