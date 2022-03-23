using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ZIO.objekty;

namespace ZIO
{
    public partial class ZIO : Form
    {
        bool up = false;
        bool down = false;
        bool left = false;
        bool right = false;
        public ZIO()
        {
            InitializeComponent();
        }

        private void ZIO_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackgroundImage = Properties.Resources.background0;
            Playerpic.Image = Properties.Resources.player_right;
            Playerpic.Location = Player.Position;
        }

        private void ZIO_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);    
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if(up) Playerpic.Location = new Point(Player.Position.X, Player.Position.Y + 10);
            if(down) Playerpic.Location = new Point(Player.Position.X, Player.Position.Y - 10);
            if(right) Playerpic.Location = new Point(Player.Position.X + 10, Player.Position.Y);
            if(left) Playerpic.Location = new Point(Player.Position.X - 10, Player.Position.Y);

            if (Player.isleft) Playerpic.Image = Properties.Resources.player_left;
            else Playerpic.Image = Properties.Resources.player_right;
        }

        private void ZIO_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.W:
                    up = true;
                    break;
                case Keys.S:
                    down = true;
                    break;
                case Keys.A:
                    left = true;
                    break;
                case Keys.D:
                    right = true;
                    break;
            }
        }

        private void ZIO_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    up = false;
                    break;
                case Keys.S:
                    down = false;
                    break;
                case Keys.A:
                    left = false;
                    break;
                case Keys.D:
                    right = false;
                    break;
            }
        }
    }
}
