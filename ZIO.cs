using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ZIO.containers;

namespace ZIO
{
    public partial class ZIO : Form
    {
        bool Left = false;
        bool Right = false;
        bool Up = false;

        int jumpSpeed = 4;
        int force = 8;
        int score = 0;
        public ZIO()
        {
            InitializeComponent();
        }

        private void ZIO_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.TopMost = true;
            hodnoty.PlayerSpawn = new Point(343, 528);
        }
        private void ZIO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                Left = true;
                Player.Image = Properties.Resources.player_left;
            }
            if (e.KeyCode == Keys.D)
            {
                Right = true;
                Player.Image = Properties.Resources.player_right;
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
            Player.Top += jumpSpeed;
            if (Up && force < 0)
            {
                Up = false;
            }

            if (Left)
            {
                Player.Left -= 5;
            }

            if (Right)
            {
                Player.Left += 5;
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
            // Move //

            foreach(Control i in this.Controls)
            {
                if(i is PictureBox && i.Tag == "Platform")
                {
                    if (Player.Bounds.IntersectsWith(i.Bounds) && !Up)
                    {
                        force = 8;
                        Player.Top = i.Top - Player.Height - 1;
                    }
                }
            }
            // Move //

            // Death Func //
            if(Player.Location.Y > 1000)
            {
                Player.Location = hodnoty.PlayerSpawn;
            }
            // Death Func //
        }

        private void ZIO_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
