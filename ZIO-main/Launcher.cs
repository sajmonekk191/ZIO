using System;
using System.Drawing;
using System.Windows.Forms;
using ZIO.containers;

namespace ZIO
{
    public partial class Launcher : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public Launcher()
        {
            InitializeComponent();
        }

        private void Launcher_Load(object sender, EventArgs e)
        {
            ExitPanel.BackColor = Color.FromArgb(121, 9, 9);
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ExitLabel_MouseEnter(object sender, EventArgs e)
        {
            ExitPanel.BackColor = Color.FromArgb(208, 38, 38);
        }

        private void ExitLabel_MouseLeave(object sender, EventArgs e)
        {
            ExitPanel.BackColor = Color.FromArgb(121, 9, 9);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            MinimizePanel.BackColor = Color.Silver;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            MinimizePanel.BackColor = Color.Gainsboro;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (account1.Visible == true)
            {
                account1.Visible = false;
            }
            else
            {
                account1.Visible = true;
                account1.BringToFront();
            }
        }

        private void Launcher_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Launcher_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Launcher_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (hodnoty.Connected)
            {
                MessageBox.Show("You must be Connected to ZIO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ZIO game = new ZIO();
                ClientTimer.Stop();
                game.Show();
                game.BringToFront();
                this.Hide();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Multiplayer isn´t available right now !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ClientTimer_Tick(object sender, EventArgs e)
        {
            if (hodnoty.Connected == true)
            {
                label2.Text = "Account: " + hodnoty.Username;
                label3.Text = "Level: " + hodnoty.Level;
            }
            else
            {
                label2.Text = "Account: Not Connected";
                label3.Text = "Level: 0";
            }
        }
    }
}
