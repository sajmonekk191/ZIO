using System.Windows.Forms;

namespace ZIO.scripts
{
    internal class Deactive
    {
        public static void DeactiveAllWeapons(ZIO Game)
        {
            foreach(Control i in Game.Controls)
            {
                if(i is PictureBox && i.Tag == "EquipItem")
                {
                    ((PictureBox)i).Tag = "Item";
                }
            }
            Objekty.Weapons.Melee.GoldAxe.Activated = false;
            Objekty.Weapons.SinglePistol.Activated = false;
        }
    }
}
