
namespace Stars
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.buttonBackToGame = new System.Windows.Forms.Button();
            this.buttonExitFromGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBackToGame
            // 
            this.buttonBackToGame.BackColor = System.Drawing.Color.White;
            this.buttonBackToGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBackToGame.BackgroundImage")));
            this.buttonBackToGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBackToGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBackToGame.Location = new System.Drawing.Point(173, 162);
            this.buttonBackToGame.Name = "buttonBackToGame";
            this.buttonBackToGame.Size = new System.Drawing.Size(301, 89);
            this.buttonBackToGame.TabIndex = 0;
            this.buttonBackToGame.UseVisualStyleBackColor = false;
            this.buttonBackToGame.Click += new System.EventHandler(this.ButtonBackToGame_Click);
            // 
            // buttonExitFromGame
            // 
            this.buttonExitFromGame.BackColor = System.Drawing.Color.White;
            this.buttonExitFromGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonExitFromGame.BackgroundImage")));
            this.buttonExitFromGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExitFromGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExitFromGame.Location = new System.Drawing.Point(173, 269);
            this.buttonExitFromGame.Name = "buttonExitFromGame";
            this.buttonExitFromGame.Size = new System.Drawing.Size(305, 89);
            this.buttonExitFromGame.TabIndex = 1;
            this.buttonExitFromGame.UseVisualStyleBackColor = false;
            this.buttonExitFromGame.Click += new System.EventHandler(this.ButtonExitFromGame_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.buttonExitFromGame);
            this.Controls.Add(this.buttonBackToGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBackToGame;
        private System.Windows.Forms.Button buttonExitFromGame;
    }
}