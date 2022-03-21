
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
            this.Player = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Platform1 = new System.Windows.Forms.PictureBox();
            this.Platform2 = new System.Windows.Forms.PictureBox();
            this.Platform3 = new System.Windows.Forms.PictureBox();
            this.Platform4 = new System.Windows.Forms.PictureBox();
            this.Platform5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform5)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Player.Image = global::ZIO.Properties.Resources.player_right;
            this.Player.Location = new System.Drawing.Point(343, 584);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(47, 74);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
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
            this.Platform1.Location = new System.Drawing.Point(322, 679);
            this.Platform1.Name = "Platform1";
            this.Platform1.Size = new System.Drawing.Size(183, 74);
            this.Platform1.TabIndex = 1;
            this.Platform1.TabStop = false;
            this.Platform1.Tag = "Platform";
            // 
            // Platform2
            // 
            this.Platform2.Image = global::ZIO.Properties.Resources.block;
            this.Platform2.Location = new System.Drawing.Point(664, 679);
            this.Platform2.Name = "Platform2";
            this.Platform2.Size = new System.Drawing.Size(183, 74);
            this.Platform2.TabIndex = 2;
            this.Platform2.TabStop = false;
            this.Platform2.Tag = "Platform";
            // 
            // Platform3
            // 
            this.Platform3.Image = global::ZIO.Properties.Resources.block;
            this.Platform3.Location = new System.Drawing.Point(1102, 584);
            this.Platform3.Name = "Platform3";
            this.Platform3.Size = new System.Drawing.Size(183, 74);
            this.Platform3.TabIndex = 3;
            this.Platform3.TabStop = false;
            this.Platform3.Tag = "Platform";
            // 
            // Platform4
            // 
            this.Platform4.Image = global::ZIO.Properties.Resources.block;
            this.Platform4.Location = new System.Drawing.Point(1601, 491);
            this.Platform4.Name = "Platform4";
            this.Platform4.Size = new System.Drawing.Size(183, 74);
            this.Platform4.TabIndex = 4;
            this.Platform4.TabStop = false;
            this.Platform4.Tag = "Platform";
            // 
            // Platform5
            // 
            this.Platform5.Image = global::ZIO.Properties.Resources.block;
            this.Platform5.Location = new System.Drawing.Point(1415, 815);
            this.Platform5.Name = "Platform5";
            this.Platform5.Size = new System.Drawing.Size(183, 74);
            this.Platform5.TabIndex = 5;
            this.Platform5.TabStop = false;
            this.Platform5.Tag = "Platform";
            // 
            // ZIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.Platform5);
            this.Controls.Add(this.Platform4);
            this.Controls.Add(this.Platform3);
            this.Controls.Add(this.Platform2);
            this.Controls.Add(this.Platform1);
            this.Controls.Add(this.Player);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ZIO";
            this.Text = "🌿 ZIO 🌿";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ZIO_FormClosed);
            this.Load += new System.EventHandler(this.ZIO_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ZIO_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ZIO_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox Platform1;
        private System.Windows.Forms.PictureBox Platform2;
        private System.Windows.Forms.PictureBox Platform3;
        private System.Windows.Forms.PictureBox Platform4;
        private System.Windows.Forms.PictureBox Platform5;
    }
}