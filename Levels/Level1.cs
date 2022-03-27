
using System;
using System.Drawing;

namespace ZIO.Levels
{
    internal class Level1
    {
        // End // 
        public static Point Door1 = new Point(0, 231);
        // End // 

        // Astro Platforms // 
        public static Point Astro1 = new Point(0, 835);
        public static Point Astro2 = new Point(300, 835);
        // Astro Platforms // 

        // Big Platforms //
        public static Point Big1 = new Point(290, 316);
        // Big Platforms //

        // MediumBig Platforms // 
        public static Point MediumBig1 = new Point(723, 415);
        // MediumBig Platforms // 

        // Medium Platforms // 
        public static Point Medium1 = new Point(1619, 656);
        public static Point Medium2 = new Point(1106, 458);
        public static Point Medium3 = new Point(-52, 313);
        public static Point Medium4 = new Point(1396, 500);
        // Medium Platforms //

        // Small Platforms // 
        public static Point Small1 = new Point(56, 653);
        // Small Platforms //

        // LuckyBlocks Platforms // 
        public static Point Lucky1 = new Point(1814, 777);
        public static Point SpecialLucky1 = new Point(69, 595);
        // LuckyBlocks Platforms //

        // Boss // 
        public static Point Boss1 = new Point(439, 170);
        public static Point BossMove1 = new Point(290, 600);
        // Boss // 

        // Item // 
        public static Point Item1 = new Point(920, 772);
        // Item // 

        public static void LoadLevel(ZIO Game)
        {
            Game.progressBar1.Maximum = 30;
            Objekty.Platforms.SmallPlatform.SpawnPlatform(Game, Small1);
            Objekty.Platforms.MediumPlatform.SpawnPlatform(Game, Medium1);
            Objekty.Platforms.MediumPlatform.SpawnPlatform(Game, Medium2);
            Objekty.Platforms.MediumPlatform.SpawnPlatform(Game, Medium3);
            Objekty.Platforms.MediumPlatform.SpawnPlatform(Game, Medium4);
            Objekty.Platforms.BigPlatform.SpawnPlatform(Game, Big1);
            Objekty.Platforms.MediumBiggerPlatform.SpawnPlatform(Game, MediumBig1);
            Objekty.Platforms.AstroPlatform.SpawnPlatform(Game, Astro1);
            Objekty.Platforms.AstroPlatform.SpawnPlatform(Game, Astro2);
            Objekty.Platforms.Door.SpawnPlatform(Game, Door1);
            Objekty.Enemy.BigToast.SpawnMob(Game, Boss1);
            Objekty.Weapons.SinglePistol.SpawnItem(Game, Item1);
            Random rnd = new Random();
            int chance = rnd.Next(0, 100);
            if(chance > 95)
            {
                Objekty.Other.SpecialLuckyBlock.SpawnPlatform(Game, SpecialLucky1);
            }
            if(chance < 40)
            {
                Objekty.Other.LuckyBlock.SpawnBlock(Game, Lucky1);
            }
        }
    }
}
