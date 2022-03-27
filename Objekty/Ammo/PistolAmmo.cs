using System.Drawing;
using System.Windows.Forms;

namespace ZIO.Objekty.Ammo
{
    internal class PistolAmmo
    {
        public static void FireBullet(ZIO Game)
        {
            var bullet = new PictureBox
            {
                Name = "Bullet",
                Tag = "bullet",
                Size = new Size(10, 5),
                Location = new Point(Game.Champion.Left, Game.Champion.Top + 15),
                BackColor = Color.Black
            };
            bullet.BringToFront();
            Game.Controls.Add(bullet);
        }
        public static void RemoveBullet(PictureBox bullet, ZIO Game)
        {
            Game.Controls.Remove(bullet);
            bullet.Dispose();
        }
    }
}
