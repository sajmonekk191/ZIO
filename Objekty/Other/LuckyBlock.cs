using System.Drawing;
using System.Windows.Forms;

namespace ZIO.Objekty.Other
{
    internal class LuckyBlock
    {
        public static Point SpawnPos { get; set; }
        public static void SpawnBlock(ZIO Game, Point pos)
        {
            var luckyblock = new PictureBox
            {
                Name = "luckyblock",
                Tag = "LuckyBlock",
                Size = new Size(45, 45),
                Location = pos,
                Image = Properties.Resources.LuckyBlock1,
                SizeMode = PictureBoxSizeMode.Zoom,

            };
            Game.Controls.Add(luckyblock);
        }
        public static void RemoveBlock(ZIO Game, PictureBox block)
        {
            Game.Controls.Remove(block);
            block.Dispose();
        }
    }
}
