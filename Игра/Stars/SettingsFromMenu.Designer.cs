
namespace Stars
{
    partial class SettingsFromMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsFromMenu));
            this.pictureBoxSound = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonOn = new System.Windows.Forms.Button();
            this.buttonOff = new System.Windows.Forms.Button();
            this.pictureBoxNameSettings = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNameSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSound
            // 
            this.pictureBoxSound.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSound.Image")));
            this.pictureBoxSound.Location = new System.Drawing.Point(515, 396);
            this.pictureBoxSound.Name = "pictureBoxSound";
            this.pictureBoxSound.Size = new System.Drawing.Size(245, 85);
            this.pictureBoxSound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSound.TabIndex = 1;
            this.pictureBoxSound.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonExit.BackgroundImage")));
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.ForeColor = System.Drawing.Color.Black;
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonExit.Location = new System.Drawing.Point(640, 693);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(341, 114);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // buttonOn
            // 
            this.buttonOn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOn.BackgroundImage")));
            this.buttonOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOn.Location = new System.Drawing.Point(931, 401);
            this.buttonOn.Name = "buttonOn";
            this.buttonOn.Size = new System.Drawing.Size(160, 73);
            this.buttonOn.TabIndex = 9;
            this.buttonOn.UseVisualStyleBackColor = true;
            this.buttonOn.Click += new System.EventHandler(this.ButtonOn_Click);
            // 
            // buttonOff
            // 
            this.buttonOff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOff.BackgroundImage")));
            this.buttonOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOff.Location = new System.Drawing.Point(931, 401);
            this.buttonOff.Name = "buttonOff";
            this.buttonOff.Size = new System.Drawing.Size(160, 73);
            this.buttonOff.TabIndex = 10;
            this.buttonOff.UseVisualStyleBackColor = true;
            this.buttonOff.Visible = false;
            this.buttonOff.Click += new System.EventHandler(this.ButtonOff_Click);
            // 
            // pictureBoxNameSettings
            // 
            this.pictureBoxNameSettings.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNameSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxNameSettings.BackgroundImage")));
            this.pictureBoxNameSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxNameSettings.Location = new System.Drawing.Point(515, 48);
            this.pictureBoxNameSettings.Name = "pictureBoxNameSettings";
            this.pictureBoxNameSettings.Size = new System.Drawing.Size(636, 179);
            this.pictureBoxNameSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNameSettings.TabIndex = 11;
            this.pictureBoxNameSettings.TabStop = false;
            // 
            // SettingsFromMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1620, 920);
            this.Controls.Add(this.pictureBoxNameSettings);
            this.Controls.Add(this.buttonOff);
            this.Controls.Add(this.buttonOn);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.pictureBoxSound);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsFromMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNameSettings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxSound;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonOn;
        private System.Windows.Forms.Button buttonOff;
        private System.Windows.Forms.PictureBox pictureBoxNameSettings;
    }
}