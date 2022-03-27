using System.Drawing;
using System.Windows.Forms;

namespace ZIO.Objekty.Weapons.Melee
{
    internal class GoldAxe
    {
        public static bool Activated = false;
        public static int Damage = 12;

        public static void SpawnItem(ZIO Game, Point pos)
        {
            var Item = new PictureBox
            {
                Name = "goldaxe",
                Tag = "GoldAxe",
                Size = new Size(244 / 2, 85 / 2),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = Properties.Resources.GoldAxe_Left,
                Location = pos,
            };
            Item.BringToFront();
            Game.Controls.Add(Item);
        }
        public static void GetItem()
        {
            Activated = true;
        }
        public static void Attack(ZIO Game, Point pos, bool Location)
        {
            var Effect = new PictureBox
            {
                Name = "GoldAxeEffect",
                Tag = "GoldAxeEffect",
                Size = new Size(322 / 2, 241 / 2),
                SizeMode = PictureBoxSizeMode.Zoom,
                
            };
            if (Location == true)
            {
                Effect.Location = new Point(pos.X + 80, pos.Y - 40);
                Effect.Image = Properties.Resources.GoldAxeAttack_Right;
            }
            else
            {
                Effect.Location = new Point(pos.X - 160, pos.Y - 40);
                Effect.Image = Properties.Resources.GoldAxeAttack_Left;
            }
            Effect.BringToFront();
            Game.Controls.Add(Effect);
            etcs.Funkce.Wait(500);
            Game.Controls.Remove(Effect);
            Effect.Dispose();
        }
    }
}
