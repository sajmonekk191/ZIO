using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ZIO.containers;
using ZIO.Objekty;

namespace ZIO
{
    public partial class ZIO : Form
    {
        bool Left = false;
        bool Right = false;
        bool Up = false;
        bool LastPos = false;
        bool hitwall = false;

        int jumpSpeed = 4;
        int force = 10;
        public ZIO()
        {
            InitializeComponent();
        }

        private void ZIO_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.TopMost = true;
            Player.PlayerSpawn = new Point(343, 528);
            Player.HP = 3;
            Player.Level = 1;
            ChampHPlbl.Text = Player.HP.ToString();
            levellbl.Text = Player.Level.ToString();
            Goldlbl.Text = Player.Gold.ToString();
        }
        private void ZIO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                Left = true;
                LastPos = false;
                Champion.Image = Properties.Resources.player_left;
            }
            if (e.KeyCode == Keys.D)
            {
                Right = true;
                LastPos = true;
                Champion.Image = Properties.Resources.player_right;
            }
            if (e.KeyCode == Keys.W && !Up)
            {
                Up = true;
            }
            if(e.KeyCode == Keys.Space)
            {
                if(Objekty.Weapons.SinglePistol.Activated) Objekty.Ammo.PistolAmmo.FireBullet(this);
            }
            if (e.KeyCode == Keys.Escape)
            {
                etcs.PauseGame PG = new etcs.PauseGame();
                PG.Show();
                PG.BringToFront();
            }
        }

        private void ZIO_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                Left = false;
            }
            if (e.KeyCode == Keys.D)
            {
                Right = false;
            }
            if (Up)
            {
                Up = false;
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            // Move //
            if (Up && force < 0)
            {
                Up = false;
            }

            if (Left)
            {
                Champion.Left -= 5;
                if(Objekty.Weapons.SinglePistol.Activated)
                {
                    Item1.Image = Properties.Resources.gun_left;
                }
            }

            if (Right)
            {
                Champion.Left += 5;
                if (Objekty.Weapons.SinglePistol.Activated)
                {
                    Item1.Image = Properties.Resources.gun_right;
                }
            }

            if (Up)
            {
                jumpSpeed = -15;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }
            Champion.Top += jumpSpeed;
            // Move //

            foreach (Control i in this.Controls)
            {
                if(i is PictureBox && i.Tag == "Platform")
                {
                    if (Champion.Bounds.IntersectsWith(i.Bounds) && !Up)
                    {
                        force = 10;
                        Champion.Top = i.Top - Champion.Height - 1;
                    }
                }
                if (i is PictureBox && i.Tag == "Gold")
                {
                    if (Champion.Bounds.IntersectsWith(i.Bounds))
                    {
                        i.Dispose();
                        Player.Gold++;
                        Goldlbl.Text = Player.Gold.ToString();
                    }
                }
                if (i is PictureBox && i.Tag == "Item")
                {
                    if (Champion.Bounds.IntersectsWith(i.Bounds))
                    {
                        Objekty.Weapons.SinglePistol.GetPistol();
                    }
                }
                if(i is PictureBox && i.Tag == "Bullet")
                {
                    if (LastPos) i.Left += 30;
                    else i.Left -= 30;
                    if (i.Location.X > 1920 || i.Location.X < 0)
                    {
                        Objekty.Ammo.PistolAmmo.RemoveBullet(this,(PictureBox)i);
                    }
                }
            }
            // Move //

            // Death Func //
            if (Champion.Location.Y > 1000)
            {
                Champion.Location = Player.PlayerSpawn;
                if(Player.HP > 0)
                {
                    Player.HP--;
                    ChampHPlbl.Text = Player.HP.ToString();
                }
            }
            if(Champion.Location.X > 1600)
            {
                
            }
            // Death Func //
            if(Player.HP == 0)
            {
                Pause_Game();
            }
            // Items //
            if(Objekty.Weapons.SinglePistol.Activated)
            {
                if (Right)
                    Item1.Location = new Point(Champion.Location.X + 40, Champion.Location.Y + 3);
                else if (Left)
                    Item1.Location = new Point(Champion.Location.X - 40, Champion.Location.Y + 3);
                else if (LastPos)
                    Item1.Location = new Point(Champion.Location.X + 40, Champion.Location.Y + 3);
                else if (!LastPos)
                    Item1.Location = new Point(Champion.Location.X - 40, Champion.Location.Y + 3);
            }
            // Items //
        }

        private void ZIO_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        private void Pause_Game()
        {
            Up = false;
            Left = false;
            Right = false;
            Champion.Location = Player.PlayerSpawn;
            GameTimer.Stop();
        }
        private void Start_Game()
        {
            GameTimer.Start();
        }
    }
}
