using System.Drawing;
using System.Windows.Forms;

namespace ZIO.Objekty.Platforms
{
    internal class SmallPlatform
    {
        public static Point SpawnPos { get; set; }
        public static void SpawnPlatform(ZIO Game, Point pos)
        {
            var gold = new PictureBox
            {
                Name = "platform",
                Tag = "Platform",
                Size = new Size(70, 56),
                Location = pos,
                Image = Properties.Resources.SmallPlatform,
                SizeMode = PictureBoxSizeMode.Zoom,

            };
            Game.Controls.Add(gold);
        }
    }
}
