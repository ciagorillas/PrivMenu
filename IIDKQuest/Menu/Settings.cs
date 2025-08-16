using IIDKQuest.Classes;
using UnityEngine;
using static IIDKQuest.Menu.Main;

namespace IIDKQuest
{
    internal class Settings
    {
        public static ExtGradient backgroundColor = new ExtGradient { colors = GetSolidGradient(new Color(0f, 0f, 0f)) };
        public static ExtGradient[] buttonColors = new ExtGradient[]
        {
            new ExtGradient{isRainbow = false}, // Enabled
            new ExtGradient{colors = GetSolidGradient(new Color(0.054f, 0.054f, 0.054f))}, // Disabled
        };
        public static Color[] textColors = new Color[]
        {
            Color.white, // Disabled
            Color.green // Enabled
        };

        public static Font currentFont = (Resources.GetBuiltinResource<Font>("Arial.ttf") as Font);

        public static bool fpsCounter = true;
        public static Color ButtonColor = new Color(0.054f, 0.054f, 0.054f);
        public static bool ping = true;
        public static bool disconnectButton = true;
        public static bool rightHanded = false;
        public static bool disableNotifications = false;

        public static KeyCode keyboardButton = KeyCode.Q;

        public static Vector3 menuSize = new Vector3(0.1f, 1f, 1f); // Depth, Width, Height
        public static int buttonsPerPage = 8;
    }
}
