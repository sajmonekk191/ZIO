using System.Windows.Forms;

namespace ZIO.scripts
{
    internal class Deactive
    {
        public static void DeactiveAllWeapons(ZIO Game)
        {
            Objekty.Weapons.Melee.GoldAxe.Activated = false;
            Objekty.Weapons.SinglePistol.Activated = false;
        }
    }
}
