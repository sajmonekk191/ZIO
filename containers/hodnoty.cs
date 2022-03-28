using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ZIO.containers
{
    class hodnoty
    {
        // Client //
        public static bool Connected = false;
        public static string Username;
        public static string Password;
        public static int Level = 0;
        // Client //

        // IN Game //
        public static string Equiped = string.Empty;
        public static bool slot1 = false;
        public static bool slot2 = false;
        public static bool slot3 = false;

        public static List<PictureBox> equip = new List<PictureBox>();
        // IN Game //
    }
}
