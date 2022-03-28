using System;
using System.Drawing;
using System.Windows.Forms;

namespace ZIO.Objekty.Weapons.Melee
{
    internal class GoldAxe
    {
        // CDR //
        private static System.Timers.Timer cdr = new System.Timers.Timer(1000);
        public static bool AttackReady = false;
        // CDR //
        public static bool Activated = false;
        public static int Damage = 1;

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
            AttackReady = true;
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
                Effect.Location = new Point(pos.X + 140, pos.Y - 40);
                Effect.Image = Properties.Resources.GoldAxeAttack_Right;
            }
            else
            {
                Effect.Location = new Point(pos.X - 240, pos.Y - 40);
                Effect.Image = Properties.Resources.GoldAxeAttack_Left;
            }
            Effect.BringToFront();
            Game.Controls.Add(Effect);
            AttackReady = false;
            cdr.Elapsed += OnTimedEvent;
            cdr.Start();
            etcs.Funkce.Wait(300);
            Game.Controls.Remove(Effect);
            Effect.Dispose();
        }
        public static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            AttackReady = true;
        }
        public static void AddToInv()
        {

        }
    }
}
