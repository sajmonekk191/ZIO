
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
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Playerpic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Playerpic)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 1;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // Playerpic
            // 
            this.Playerpic.BackColor = System.Drawing.Color.Transparent;
            this.Playerpic.Location = new System.Drawing.Point(360, 167);
            this.Playerpic.Name = "Playerpic";
            this.Playerpic.Size = new System.Drawing.Size(75, 100);
            this.Playerpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Playerpic.TabIndex = 0;
            this.Playerpic.TabStop = false;
            // 
            // ZIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.Playerpic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ZIO";
            this.Text = "🌿 ZIO 🌿";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ZIO_FormClosed);
            this.Load += new System.EventHandler(this.ZIO_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ZIO_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ZIO_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Playerpic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox Playerpic;
    }
}