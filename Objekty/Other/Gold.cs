using System.Drawing;
using System.Windows.Forms;
namespace ZIO.Objekty.Other
{
    internal class Gold
    {
        public static Point SpawnPos { get; set; }

        public static void SpawnItem(ZIO Game, Point pos)
        {
            var gold = new PictureBox
            {
                Name = "platform",
                Tag = "Platform",
                Size = new Size(60, 60),
                Location = pos,
                Image = Properties.Resources.Gold,
                SizeMode = PictureBoxSizeMode.Zoom,

            };
            Game.Controls.Add(gold);
        }
    }
}
