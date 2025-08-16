using IIDKQuest.Classes;
using IIDKQuest.Mods;
using IIDKQuest.Mods.Gth;
using IIDKQuest.Mods.Movement;
using IIDKQuest.Mods.Overpowered;
using IIDKQuest.Mods.Prefabs;
using IIDKQuest.Mods.Rig;
using IIDKQuest.Mods.Visual;
using Maximility.Menu;
using Photon.Pun;
using static IIDKQuest.Settings;

namespace IIDKQuest.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Opens the main settings page for the menu."},
            },

            new ButtonInfo[] { // Settings
                new ButtonInfo { buttonText = "<color=red>Exit</color>", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Menu", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "Notifications", method = () => Loadnotis.loadem(), disableMethod = () => Loadnotis.fuckem(), enabled = true, isTogglable = false, toolTip = "Notifications for the menu." },
                new ButtonInfo { buttonText = "Clear Notifications", method = () => Loadnotis.fuckem(), isTogglable = false, toolTip = "CLears notifications for the menu." },
                new ButtonInfo { buttonText = "Projectile", method =() => SettingsMods.ProjectileSettings(), isTogglable = false, toolTip = "Opens the projectile settings for the menu."},
                new ButtonInfo { buttonText = "MOTD", method = () => CoustmMOTD.Motd(), disableMethod = () => Loadnotis.fuckem(), enabled = true, toolTip = "MOTD for the menu." },
            },

            new ButtonInfo[] { // Menu Settings
                new ButtonInfo { buttonText = "<color=red>Exit</color>", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Disconnect", method =() => PhotonNetwork.Disconnect(), isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "home", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
            },

            new ButtonInfo[] { // Movement Settings
                new ButtonInfo { buttonText = "<color=red>Exit</color>", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
            },

            new ButtonInfo[] { // Projectile Settings
                new ButtonInfo { buttonText = "<color=red>Exit</color>", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
            },
        };
    }
}

