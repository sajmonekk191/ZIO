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
                if (i is PictureBox)
                {
                    if (ZIO.Left)
                    {
                        switch (i.Tag)
                        {
                            case "GoldAxe":
                                if (containers.hodnoty.Equiped == "GoldAxe")
                                {
                                    i.Location = new Point(Game.Champion.Location.X - 120, Game.Champion.Location.Y + 3);
                                    ((PictureBox)i).Image = Properties.Resources.GoldAxe_Left;
                                }
                                break;

                            case "Pistol":
                                if (containers.hodnoty.Equiped == "Pistol")
                                {
                                    i.Location = new Point(Game.Champion.Location.X - 40, Game.Champion.Location.Y + 3);
                                    ((PictureBox)i).Image = Properties.Resources.gun_left;
                                }
                                break;
                        }
                    }
                    if (ZIO.Right)
                    {
                        switch (i.Tag)
                        {
                            case "GoldAxe":
                                if(containers.hodnoty.Equiped == "GoldAxe")
                                {
                                    i.Location = new Point(Game.Champion.Location.X + 40, Game.Champion.Location.Y + 3);
                                    ((PictureBox)i).Image = Properties.Resources.GoldAxe_Right;
                                }
                                break;

                            case "Pistol":
                                if (containers.hodnoty.Equiped == "Pistol")
                                {
                                    i.Location = new Point(Game.Champion.Location.X + 40, Game.Champion.Location.Y + 3);
                                    ((PictureBox)i).Image = Properties.Resources.gun_right;
                                }
                                break;
                        }
                    }
                    if (ZIO.LastPos)
                    {
                        switch (i.Tag)
                        {
                            case "GoldAxe":
                                if (containers.hodnoty.Equiped == "GoldAxe")
                                    i.Location = new Point(Game.Champion.Location.X + 40, Game.Champion.Location.Y + 3);
                                break;

                            case "Pistol":
                                if (containers.hodnoty.Equiped == "Pistol")
                                    i.Location = new Point(Game.Champion.Location.X + 40, Game.Champion.Location.Y + 3);
                                break;
                        }
                    }
                    if (ZIO.LastPos == false)
                    {
                        switch (i.Tag)
                        {
                            case "GoldAxe":
                                if (containers.hodnoty.Equiped == "GoldAxe")
                                    i.Location = new Point(Game.Champion.Location.X - 120, Game.Champion.Location.Y + 3);
                                break;

                            case "Pistol":
                                if (containers.hodnoty.Equiped == "Pistol")
                                    i.Location = new Point(Game.Champion.Location.X - 40, Game.Champion.Location.Y + 3);
                                break;
                        }
                    }
                }
            }
        }
        public static void AddItemToInventory()
        {

        }
    }
}
