// GoldAxe Effect + Damage - DONE
// Iventory + add to inv

using System;
using System.Drawing;
using System.Windows.Forms;
using ZIO.Objekty;

namespace ZIO
{
    public partial class ZIO : Form
    {
        public static bool Left = false;
        public static bool Right = false;
        public static bool Up = false;
        public static bool LastPos = false;
        public static bool BossMax = false;

        int jumpSpeed = 4;
        int force = 10;
        public ZIO()
        {
            InitializeComponent();
        }

        private void ZIO_Load(object sender, EventArgs e)
        {
            LoadComponents();
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
                if (Objekty.Weapons.SinglePistol.Activated && Player.Ammo > 0)
                {
                    Objekty.Ammo.PistolAmmo.FireBullet(this);
                    Player.Ammo--;
                    ammolbl.Text = Player.Ammo.ToString();
                }
                else if (Objekty.Weapons.Melee.GoldAxe.Activated && Objekty.Weapons.Melee.GoldAxe.AttackReady)
                {
                    Objekty.Weapons.Melee.GoldAxe.Attack(this, Champion.Location, LastPos);
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                if (GameTimer.Enabled == true)
                {
                    Pause_Game();
                     
                }
                else Resume_Game();
            }
            if (e.KeyCode == Keys.R)
            {
                RestartLevel();
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
                if(Champion.Location.X < 20) Left = false;  
            }

            if (Right)
            {
                Champion.Left += 5;
                if (Champion.Location.X > 1880) Right = false;
            }

            if (Up)
            {
                jumpSpeed = -15;
                force -= 1;
            }
            else
            {
                jumpSpeed = 10;
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
                if (i is PictureBox)
                {
                    switch(i.Tag)
                    {
                        case "Pistol":
                            if (Champion.Bounds.IntersectsWith(i.Bounds) && !Objekty.Weapons.SinglePistol.Activated)
                            {
                                scripts.Deactive.DeactiveAllWeapons(this);
                                Objekty.Weapons.SinglePistol.GetPistol();
                                containers.hodnoty.Equiped = "Pistol";
                                RefreshStats();
                            }
                            break;
                        case "GoldAxe":
                            if (Champion.Bounds.IntersectsWith(i.Bounds) && !Objekty.Weapons.Melee.GoldAxe.Activated)
                            {
                                scripts.Deactive.DeactiveAllWeapons(this);
                                Objekty.Weapons.Melee.GoldAxe.GetItem();
                                containers.hodnoty.Equiped = "GoldAxe";
                                RefreshStats();
                            }
                            break;
                    }
                }
                if (i is PictureBox && i.Tag == "Boss")
                {
                    Objekty.Enemy.BigToast.pos = i.Bounds;
                    // Boss Move //
                    if (Objekty.Enemy.BigToast.pos.X >= 290 && !BossMax)
                    {
                        i.Left -= 5;
                    }
                    if (Objekty.Enemy.BigToast.pos.X == 289)
                    {
                        BossMax = true;
                    }
                    if (BossMax)
                    {
                        i.Left += 5;
                        if (Objekty.Enemy.BigToast.pos.X >= 540)
                        {
                            BossMax = false;
                        }
                    }
                    // Boss Move //

                    if (Objekty.Enemy.BigToast.HP <= 0)
                    {
                        Objekty.Enemy.BigToast.RemoveMob(this, (PictureBox)i);
                    }
                    else
                    {
                        progressBar1.Value = Objekty.Enemy.BigToast.HP;
                    }
                }
                if (i is PictureBox && i.Tag == "bullet")
                {
                    if (LastPos) i.Left += 50;
                    else i.Left -= 50;

                    if (Objekty.Enemy.BigToast.pos.IntersectsWith(i.Bounds) && Objekty.Enemy.BigToast.HP > 0)
                    {
                        Objekty.Enemy.BigToast.HP -= Objekty.Weapons.SinglePistol.Damage;
                        Objekty.Ammo.PistolAmmo.RemoveBullet((PictureBox)i, this);
                    }
                    if(i.Location.X > 1920 || i.Location.X < 0) Objekty.Ammo.PistolAmmo.RemoveBullet((PictureBox)i, this);
                }
                if (i is PictureBox && i.Tag == "GoldAxeEffect")
                {
                    if (Objekty.Enemy.BigToast.pos.IntersectsWith(i.Bounds) && Objekty.Enemy.BigToast.HP > 0)
                    {
                        Objekty.Enemy.BigToast.HP -= Objekty.Weapons.Melee.GoldAxe.Damage;
                    }
                }
                if (i is PictureBox && i.Tag == "LuckyBlock")
                {
                    if (Champion.Bounds.IntersectsWith(i.Bounds))
                    {
                        Objekty.Other.LuckyBlock.RemoveBlock(this, (PictureBox)i);
                        Objekty.Effekty.OpenEffect.SpawnEffect(this, i.Location);
                        Objekty.Weapons.Melee.GoldAxe.SpawnItem(this, i.Location);
                    }
                }
            }
            // Move //

            // Death Func //
            if (Champion.Location.Y > 1000)
            {
                Champion.Location = Player.SpawnPos;
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
            if(Player.HP <= 0)
            {
                Pause_Game();
            }
            // Items //
            if(Objekty.Weapons.SinglePistol.Activated || Objekty.Weapons.Melee.GoldAxe.Activated)
            {
                scripts.Items.MoveWithWeapon(this);
            }
            // Items //
        }

        private void ZIO_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        private void Pause_Game()
        {
            GameTimer.Stop();
        }
        private void Resume_Game()
        {
            GameTimer.Start();
        }
        private void RestartLevel()
        {
            GameTimer.Dispose();
            Objekty.Weapons.SinglePistol.Activated = false;
            Controls.Clear();
            InitializeComponent();
            LoadComponents();
        }
        private void RefreshStats()
        {
            ChampHPlbl.Text = Player.HP.ToString();
            Goldlbl.Text = Player.Gold.ToString();
            levellbl.Text = Player.LVL.ToString();
            ammolbl.Text = Player.Ammo.ToString();
        }
        private void LoadComponents()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.Bounds.Height);
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.TopMost = true;
            Player.SpawnPos = new Point(343, 528);
            Player.HP = 100;
            Player.Gold = 0;
            Player.LVL = 1;
            Player.Ammo = 0;
            progressBar1.Value = Objekty.Enemy.BigToast.HP;
            RefreshStats();
            LoadLevel();
        }
        private void LoadLevel()
        {
            Levels.Level1.LoadLevel(this);
        }
    }
}
