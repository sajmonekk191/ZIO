using System.Windows.Forms;
using System.Drawing;

namespace ZIO.Objekty.Weapons
{
    internal class SinglePistol
    {
        public static Point SpawnPos { get; set; }
        public static bool Activated = false;
        public static int Damage = 2;

        public static void SpawnItem(ZIO Game, Point pos)
        {
            var Item = new PictureBox
            {
                Name = "pistol",
                Tag = "Pistol",
                Size = new Size(50, 50),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = Properties.Resources.gun_right,
                Location = pos,
            };
            Item.BringToFront();
            Game.Controls.Add(Item);
        }
        public static void GetPistol()
        {
            Activated = true;
            Player.Ammo += 20;
        }
    }
}
