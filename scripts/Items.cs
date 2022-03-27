using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZIO.scripts
{
    internal class Items
    {
        public static void MoveWithWeapon(ZIO Game)
        {
            foreach (Control i in Game.Controls)
            {
                if (i is PictureBox && i.Tag == "EquipItem")
                {
                    if (ZIO.Right)
                    {
                        switch (i.Name)
                        {
                            case "goldaxe":
                                i.Location = new Point(Game.Champion.Location.X + 40, Game.Champion.Location.Y + 3);
                                ((PictureBox)i).Image = Properties.Resources.GoldAxe_Right;
                                break;

                            case "pistol":
                                i.Location = new Point(Game.Champion.Location.X + 40, Game.Champion.Location.Y + 3);
                                ((PictureBox)i).Image = Properties.Resources.gun_right;
                                break;
                        }
                    }
                    else if (ZIO.Left)
                    {
                        switch (i.Name)
                        {
                            case "goldaxe":
                                i.Location = new Point(Game.Champion.Location.X - 120, Game.Champion.Location.Y + 3);
                                ((PictureBox)i).Image = Properties.Resources.GoldAxe_Left;
                                break;

                            case "pistol":
                                i.Location = new Point(Game.Champion.Location.X - 40, Game.Champion.Location.Y + 3);
                                ((PictureBox)i).Image = Properties.Resources.gun_left;
                                break;
                        }
                    }
                    else if (ZIO.LastPos)
                        switch (i.Name)
                        {
                            case "goldaxe":
                                i.Location = new Point(Game.Champion.Location.X + 40, Game.Champion.Location.Y + 3);
                                break;

                            case "pistol":
                                i.Location = new Point(Game.Champion.Location.X + 40, Game.Champion.Location.Y + 3);
                                break;
                        }
                    else if (ZIO.LastPos == false)
                        switch (i.Name)
                        {
                            case "goldaxe":
                                i.Location = new Point(Game.Champion.Location.X - 120, Game.Champion.Location.Y + 3);
                                break;

                            case "pistol":
                                i.Location = new Point(Game.Champion.Location.X - 40, Game.Champion.Location.Y + 3);
                                break;
                        }
                }
            }
        }
    }
}
