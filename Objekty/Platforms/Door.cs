using System.Drawing;
using System.Windows.Forms;

namespace ZIO.Objekty.Platforms
{
    internal class Door
    {
        public static Point SpawnPos { get; set; }
        public static void SpawnPlatform(ZIO Game, Point pos)
        {
            var Door = new PictureBox
            {
                Name = "door",
                Tag = "Door",
                Size = new Size(50, 85),
                Location = pos,
                Image = Properties.Resources.Door,
                SizeMode = PictureBoxSizeMode.Zoom,

            };
            Game.Controls.Add(Door);
        }
    }
}
