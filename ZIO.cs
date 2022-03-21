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

        int jumpSpeed = 4;
        int force = 8;
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
                Champion.Image = Properties.Resources.player_left;
            }
            if (e.KeyCode == Keys.D)
            {
                Right = true;
                Champion.Image = Properties.Resources.player_right;
            }
            if (e.KeyCode == Keys.W && !Up || e.KeyCode == Keys.Space && !Up)
            {
                Up = true;
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
            }

            if (Right)
            {
                Champion.Left += 5;
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
                        force = 8;
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
                        i.Visible = false;

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
            // Death Func //
            if(Player.HP == 0)
            {
                Pause_Game();
            }
        }

        private void ZIO_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        private void Pause_Game()
        {
            GameTimer.Stop();
        }
        private void Start_Game()
        {
            GameTimer.Start();
        }
    }
}
