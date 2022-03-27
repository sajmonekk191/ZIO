using System.Drawing;
using System.Windows.Forms;

namespace ZIO.Objekty.Effekty
{
    internal class OpenEffect
    {
        public static void SpawnEffect(ZIO Game, Point pos)
        {
            var effect = new PictureBox
            {
                Name = "effect",
                Tag = "Effect",
                Size = new Size(50, 50),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = Properties.Resources.LuckyBlockOpen,
                Location = pos,
            };
            effect.BringToFront();
            Game.Controls.Add(effect);
            etcs.Funkce.Wait(1000);
            Game.Controls.Remove(effect);
            effect.Dispose();
        }
    }
}
