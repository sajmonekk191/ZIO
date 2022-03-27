using System.Drawing;
using System.Windows.Forms;

namespace ZIO.Objekty.Other
{
    internal class SpecialLuckyBlock
    {
        public static Point SpawnPos { get; set; }
        public static void SpawnPlatform(ZIO Game, Point pos)
        {
            var Sluckyblock = new PictureBox
            {
                Name = "luckyblock",
                Tag = "SpecialLuckyBlock",
                Size = new Size(45, 45),
                Location = pos,
                Image = Properties.Resources.SpecialLuckyBlock1,
                SizeMode = PictureBoxSizeMode.Zoom,

            };
            Game.Controls.Add(Sluckyblock);
        }
    }
}
