
namespace Stars
{
    partial class Winning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Winning));
            this.buttonGoToNextLevel = new System.Windows.Forms.Button();
            this.pictureBoxCoin = new System.Windows.Forms.PictureBox();
            this.pictureBoxTime = new System.Windows.Forms.PictureBox();
            this.labelPoints = new System.Windows.Forms.Label();
            this.labelSeonds = new System.Windows.Forms.Label();
            this.buttonFinishGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTime)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGoToNextLevel
            // 
            this.buttonGoToNextLevel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGoToNextLevel.BackgroundImage")));
            this.buttonGoToNextLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonGoToNextLevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGoToNextLevel.Location = new System.Drawing.Point(225, 349);
            this.buttonGoToNextLevel.Name = "buttonGoToNextLevel";
            this.buttonGoToNextLevel.Size = new System.Drawing.Size(290, 85);
            this.buttonGoToNextLevel.TabIndex = 0;
            this.buttonGoToNextLevel.UseVisualStyleBackColor = true;
            this.buttonGoToNextLevel.Click += new System.EventHandler(this.ButtonGoToNextLevel_Click);
            // 
            // pictureBoxCoin
            // 
            this.pictureBoxCoin.BackColor = System.Drawing.Color.White;
            this.pictureBoxCoin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoin.Image")));
            this.pictureBoxCoin.Location = new System.Drawing.Point(175, 214);
            this.pictureBoxCoin.Name = "pictureBoxCoin";
            this.pictureBoxCoin.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCoin.TabIndex = 1;
            this.pictureBoxCoin.TabStop = false;
            // 
            // pictureBoxTime
            // 
            this.pictureBoxTime.BackColor = System.Drawing.Color.White;
            this.pictureBoxTime.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTime.Image")));
            this.pictureBoxTime.Location = new System.Drawing.Point(410, 214);
            this.pictureBoxTime.Name = "pictureBoxTime";
            this.pictureBoxTime.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTime.TabIndex = 2;
            this.pictureBoxTime.TabStop = false;
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.BackColor = System.Drawing.Color.White;
            this.labelPoints.Font = new System.Drawing.Font("Courier New", 12.25F);
            this.labelPoints.ForeColor = System.Drawing.Color.Black;
            this.labelPoints.Location = new System.Drawing.Point(270, 240);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(0, 20);
            this.labelPoints.TabIndex = 3;
            // 
            // labelSeonds
            // 
            this.labelSeonds.AutoSize = true;
            this.labelSeonds.BackColor = System.Drawing.Color.White;
            this.labelSeonds.Font = new System.Drawing.Font("Courier New", 12.25F);
            this.labelSeonds.Location = new System.Drawing.Point(503, 240);
            this.labelSeonds.Name = "labelSeonds";
            this.labelSeonds.Size = new System.Drawing.Size(0, 20);
            this.labelSeonds.TabIndex = 4;
            // 
            // buttonFinishGame
            // 
            this.buttonFinishGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonFinishGame.BackgroundImage")));
            this.buttonFinishGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFinishGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFinishGame.Location = new System.Drawing.Point(225, 349);
            this.buttonFinishGame.Name = "buttonFinishGame";
            this.buttonFinishGame.Size = new System.Drawing.Size(303, 85);
            this.buttonFinishGame.TabIndex = 5;
            this.buttonFinishGame.UseVisualStyleBackColor = true;
            this.buttonFinishGame.Visible = false;
            this.buttonFinishGame.Click += new System.EventHandler(this.ButtonFinishGame_Click);
            // 
            // Winning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(733, 509);
            this.Controls.Add(this.buttonFinishGame);
            this.Controls.Add(this.labelSeonds);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.pictureBoxTime);
            this.Controls.Add(this.pictureBoxCoin);
            this.Controls.Add(this.buttonGoToNextLevel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Winning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGoToNextLevel;
        private System.Windows.Forms.PictureBox pictureBoxCoin;
        private System.Windows.Forms.PictureBox pictureBoxTime;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.Label labelSeonds;
        private System.Windows.Forms.Button buttonFinishGame;
    }
}