using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(Keys vKeys);
        public int score;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Location = label1.Location;
            pictureBox1.Visible = true;
        }
        private void Jump()
        {
            int MoveX = Player.Location.X;
            int MoveY = Player.Location.Y;
            for (int gravity = 0; gravity > -90; gravity--)
            {
                Player.Location = new Point(MoveX, MoveY + gravity);
            }
            Thread.Sleep(100);
            int MoveX1 = Player.Location.X;
            int MoveY1 = Player.Location.Y;
            for (int gravity = 0; gravity < 90; gravity++)
            {
                Player.Location = new Point(MoveX1, MoveY1 + gravity);
            }
        }
        private void MoveX(string gravity)
        {
            int MoveX = Player.Location.X;
            int MoveY = Player.Location.Y;
            if (gravity == "D")
            {
                for (int D = 0; D < 10; D++)
                {
                    Player.Location = new Point(MoveX + D, MoveY);
                }
            }
            if (gravity == "A")
            {
                for (int A = 0; A < 10; A++)
                {
                    Player.Location = new Point(MoveX - A, MoveY);
                }
            }
        }

        private void Updater_Tick(object sender, EventArgs e)
        {
            label2.Text = "Score: " + Convert.ToString(score);
            if (GetAsyncKeyState(Keys.W) > 0)
            {
                Jump();
            }
            if (GetAsyncKeyState(Keys.D) > 0)
            {
                MoveX("D");
            }
            if (GetAsyncKeyState(Keys.A) > 0)
            {
                MoveX("A");
            }
            if (GetAsyncKeyState(Keys.Space) > 0)
            {
                Jump();
            }
        }
    }
}
