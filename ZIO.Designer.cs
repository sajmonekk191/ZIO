
namespace ZIO
{
    partial class ZIO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZIO));
            this.Champion = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Platform1 = new System.Windows.Forms.PictureBox();
            this.Platform2 = new System.Windows.Forms.PictureBox();
            this.Platform3 = new System.Windows.Forms.PictureBox();
            this.Platform4 = new System.Windows.Forms.PictureBox();
            this.Platform5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ChampHPlbl = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Gold1 = new System.Windows.Forms.PictureBox();
            this.Item1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Goldlbl = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.levellbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Champion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gold1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // Champion
            // 
            this.Champion.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Champion.Image = global::ZIO.Properties.Resources.player_right;
            this.Champion.Location = new System.Drawing.Point(343, 584);
            this.Champion.Name = "Champion";
            this.Champion.Size = new System.Drawing.Size(47, 74);
            this.Champion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Champion.TabIndex = 0;
            this.Champion.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 1;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // Platform1
            // 
            this.Platform1.Image = global::ZIO.Properties.Resources.block;
            this.Platform1.Location = new System.Drawing.Point(878, 763);
            this.Platform1.Name = "Platform1";
            this.Platform1.Size = new System.Drawing.Size(183, 74);
            this.Platform1.TabIndex = 1;
            this.Platform1.TabStop = false;
            this.Platform1.Tag = "Platform";
            // 
            // Platform2
            // 
            this.Platform2.Image = global::ZIO.Properties.Resources.block;
            this.Platform2.Location = new System.Drawing.Point(1237, 763);
            this.Platform2.Name = "Platform2";
            this.Platform2.Size = new System.Drawing.Size(183, 74);
            this.Platform2.TabIndex = 2;
            this.Platform2.TabStop = false;
            this.Platform2.Tag = "Platform";
            // 
            // Platform3
            // 
            this.Platform3.Image = global::ZIO.Properties.Resources.block;
            this.Platform3.Location = new System.Drawing.Point(1058, 690);
            this.Platform3.Name = "Platform3";
            this.Platform3.Size = new System.Drawing.Size(183, 74);
            this.Platform3.TabIndex = 3;
            this.Platform3.TabStop = false;
            this.Platform3.Tag = "Platform";
            // 
            // Platform4
            // 
            this.Platform4.Image = global::ZIO.Properties.Resources.block;
            this.Platform4.Location = new System.Drawing.Point(1531, 548);
            this.Platform4.Name = "Platform4";
            this.Platform4.Size = new System.Drawing.Size(183, 74);
            this.Platform4.TabIndex = 4;
            this.Platform4.TabStop = false;
            this.Platform4.Tag = "Platform";
            // 
            // Platform5
            // 
            this.Platform5.Image = global::ZIO.Properties.Resources.block;
            this.Platform5.Location = new System.Drawing.Point(1058, 763);
            this.Platform5.Name = "Platform5";
            this.Platform5.Size = new System.Drawing.Size(183, 74);
            this.Platform5.TabIndex = 5;
            this.Platform5.TabStop = false;
            this.Platform5.Tag = "Platform";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ZIO.Properties.Resources.Hearth;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ChampHPlbl
            // 
            this.ChampHPlbl.AutoSize = true;
            this.ChampHPlbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChampHPlbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ChampHPlbl.Location = new System.Drawing.Point(68, 20);
            this.ChampHPlbl.Name = "ChampHPlbl";
            this.ChampHPlbl.Size = new System.Drawing.Size(128, 32);
            this.ChampHPlbl.TabIndex = 7;
            this.ChampHPlbl.Text = "Player_HP";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ZIO.Properties.Resources.TerainPlatform;
            this.pictureBox2.Location = new System.Drawing.Point(-2, 828);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1920, 292);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "Platform";
            // 
            // Gold1
            // 
            this.Gold1.BackColor = System.Drawing.Color.Transparent;
            this.Gold1.Image = global::ZIO.Properties.Resources.Gold;
            this.Gold1.Location = new System.Drawing.Point(1122, 626);
            this.Gold1.Name = "Gold1";
            this.Gold1.Size = new System.Drawing.Size(50, 50);
            this.Gold1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Gold1.TabIndex = 9;
            this.Gold1.TabStop = false;
            this.Gold1.Tag = "Gold";
            // 
            // Item1
            // 
            this.Item1.BackColor = System.Drawing.Color.Transparent;
            this.Item1.Image = global::ZIO.Properties.Resources.gun;
            this.Item1.Location = new System.Drawing.Point(1595, 481);
            this.Item1.Name = "Item1";
            this.Item1.Size = new System.Drawing.Size(50, 50);
            this.Item1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Item1.TabIndex = 10;
            this.Item1.TabStop = false;
            this.Item1.Tag = "Item";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ZIO.Properties.Resources.Gold;
            this.pictureBox3.Location = new System.Drawing.Point(12, 68);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // Goldlbl
            // 
            this.Goldlbl.AutoSize = true;
            this.Goldlbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Goldlbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Goldlbl.Location = new System.Drawing.Point(68, 75);
            this.Goldlbl.Name = "Goldlbl";
            this.Goldlbl.Size = new System.Drawing.Size(149, 32);
            this.Goldlbl.TabIndex = 12;
            this.Goldlbl.Text = "Player_Gold";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ZIO.Properties.Resources.Level;
            this.pictureBox4.Location = new System.Drawing.Point(12, 124);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // levellbl
            // 
            this.levellbl.AutoSize = true;
            this.levellbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.levellbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.levellbl.Location = new System.Drawing.Point(69, 131);
            this.levellbl.Name = "levellbl";
            this.levellbl.Size = new System.Drawing.Size(153, 32);
            this.levellbl.TabIndex = 14;
            this.levellbl.Text = "Player_Level";
            // 
            // ZIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1904, 1059);
            this.Controls.Add(this.levellbl);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Goldlbl);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Item1);
            this.Controls.Add(this.Gold1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ChampHPlbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Platform5);
            this.Controls.Add(this.Platform4);
            this.Controls.Add(this.Platform3);
            this.Controls.Add(this.Platform2);
            this.Controls.Add(this.Platform1);
            this.Controls.Add(this.Champion);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ZIO";
            this.Text = "🌿 ZIO 🌿";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ZIO_FormClosed);
            this.Load += new System.EventHandler(this.ZIO_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ZIO_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ZIO_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Champion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gold1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Champion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox Platform1;
        private System.Windows.Forms.PictureBox Platform2;
        private System.Windows.Forms.PictureBox Platform3;
        private System.Windows.Forms.PictureBox Platform4;
        private System.Windows.Forms.PictureBox Platform5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ChampHPlbl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Gold1;
        private System.Windows.Forms.PictureBox Item1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Goldlbl;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label levellbl;
    }
}