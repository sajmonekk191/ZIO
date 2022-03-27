
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ChampHPlbl = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Goldlbl = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.levellbl = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.boosbarlbl = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.ammolbl = new System.Windows.Forms.Label();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Champion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            this.SuspendLayout();
            // 
            // Champion
            // 
            this.Champion.BackColor = System.Drawing.Color.Transparent;
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
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(699, 40);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(486, 22);
            this.progressBar1.TabIndex = 21;
            // 
            // boosbarlbl
            // 
            this.boosbarlbl.AutoSize = true;
            this.boosbarlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.boosbarlbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.boosbarlbl.Location = new System.Drawing.Point(901, 12);
            this.boosbarlbl.Name = "boosbarlbl";
            this.boosbarlbl.Size = new System.Drawing.Size(99, 21);
            this.boosbarlbl.TabIndex = 22;
            this.boosbarlbl.Text = "BoosBar_lbl";
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::ZIO.Properties.Resources.Ammo;
            this.pictureBox12.Location = new System.Drawing.Point(1831, 20);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(50, 50);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 24;
            this.pictureBox12.TabStop = false;
            // 
            // ammolbl
            // 
            this.ammolbl.AutoSize = true;
            this.ammolbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ammolbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ammolbl.Location = new System.Drawing.Point(1756, 30);
            this.ammolbl.Name = "ammolbl";
            this.ammolbl.Size = new System.Drawing.Size(164, 32);
            this.ammolbl.TabIndex = 25;
            this.ammolbl.Text = "Pistol_Ammo";
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = global::ZIO.Properties.Resources.MediumPlatform;
            this.pictureBox15.Location = new System.Drawing.Point(-94, 313);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(60, 60);
            this.pictureBox15.TabIndex = 36;
            this.pictureBox15.TabStop = false;
            // 
            // ZIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.ammolbl);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.boosbarlbl);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Champion);
            this.Controls.Add(this.levellbl);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Goldlbl);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.ChampHPlbl);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ZIO";
            this.Text = "🌿 ZIO 🌿";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ZIO_FormClosed);
            this.Load += new System.EventHandler(this.ZIO_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ZIO_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ZIO_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Champion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox Champion;
        public System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ChampHPlbl;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Goldlbl;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label levellbl;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Label boosbarlbl;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label ammolbl;
        private System.Windows.Forms.PictureBox pictureBox15;
    }
}