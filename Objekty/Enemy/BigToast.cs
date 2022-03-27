using System.Drawing;
using System.Windows.Forms;
namespace ZIO.Objekty.Enemy
{
    internal class BigToast
    {
        public static int HP = 30;
        public static int DMG = 3;
        public static Point Spawnpos = new Point(600, 400);
        public static Rectangle pos { get; set; }

        public static void SpawnMob(ZIO Game, Point pos)
        {
            var Enemy = new PictureBox
            {
                Name = "boss",
                Tag = "Boss",
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(396 / 3, 412 / 3),
                Image = Properties.Resources.TalirekBoos,
                Location = pos
            };

            Game.boosbarlbl.Text = "BigToast";
            Game.boosbarlbl.Visible = true;
            Game.progressBar1.Visible = true;

            Enemy.BringToFront();
            Game.Controls.Add(Enemy);
            // Settings //
            HP = 30;
            DMG = 3;
            // Settings //
        }
        public static void RemoveMob(ZIO Game, PictureBox mob)
        {
            Game.boosbarlbl.Visible = false;
            Game.progressBar1.Value = 0;
            Game.progressBar1.Visible = false;
            Game.Controls.Remove(mob);
            mob.Dispose();
        }
    }
}
