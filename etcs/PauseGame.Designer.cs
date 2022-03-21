
namespace ZIO.etcs
{
    partial class PauseGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PauseGame));
            this.resgamelbl = new System.Windows.Forms.Label();
            this.savegamelbl = new System.Windows.Forms.Label();
            this.backtmlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resgamelbl
            // 
            this.resgamelbl.AutoSize = true;
            this.resgamelbl.BackColor = System.Drawing.Color.Transparent;
            this.resgamelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resgamelbl.Location = new System.Drawing.Point(148, 40);
            this.resgamelbl.Name = "resgamelbl";
            this.resgamelbl.Size = new System.Drawing.Size(111, 21);
            this.resgamelbl.TabIndex = 0;
            this.resgamelbl.Text = "Resume Game";
            // 
            // savegamelbl
            // 
            this.savegamelbl.AutoSize = true;
            this.savegamelbl.Location = new System.Drawing.Point(157, 105);
            this.savegamelbl.Name = "savegamelbl";
            this.savegamelbl.Size = new System.Drawing.Size(65, 15);
            this.savegamelbl.TabIndex = 1;
            this.savegamelbl.Text = "Save Game";
            // 
            // backtmlbl
            // 
            this.backtmlbl.AutoSize = true;
            this.backtmlbl.Location = new System.Drawing.Point(148, 170);
            this.backtmlbl.Name = "backtmlbl";
            this.backtmlbl.Size = new System.Drawing.Size(81, 15);
            this.backtmlbl.TabIndex = 2;
            this.backtmlbl.Text = "Back To Menu";
            // 
            // PauseGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(410, 201);
            this.Controls.Add(this.backtmlbl);
            this.Controls.Add(this.savegamelbl);
            this.Controls.Add(this.resgamelbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PauseGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PauseGame";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resgamelbl;
        private System.Windows.Forms.Label savegamelbl;
        private System.Windows.Forms.Label backtmlbl;
    }
}