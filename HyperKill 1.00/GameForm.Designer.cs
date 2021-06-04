namespace HyperKill
{
    partial class GameForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.OverHeatBar = new System.Windows.Forms.ProgressBar();
            this.HealthBar = new System.Windows.Forms.ProgressBar();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.KillCounter = new System.Windows.Forms.Label();
            this.BulletImage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Hero = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BulletImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hero)).BeginInit();
            this.SuspendLayout();
            // 
            // OverHeatBar
            // 
            resources.ApplyResources(this.OverHeatBar, "OverHeatBar");
            this.OverHeatBar.BackColor = System.Drawing.SystemColors.Control;
            this.OverHeatBar.MarqueeAnimationSpeed = 10;
            this.OverHeatBar.Name = "OverHeatBar";
            this.OverHeatBar.Value = 100;
            // 
            // HealthBar
            // 
            resources.ApplyResources(this.HealthBar, "HealthBar");
            this.HealthBar.BackColor = System.Drawing.SystemColors.Control;
            this.HealthBar.Name = "HealthBar";
            this.HealthBar.Value = 100;
            // 
            // MainTimer
            // 
            this.MainTimer.Enabled = true;
            this.MainTimer.Interval = 20;
            this.MainTimer.Tick += new System.EventHandler(this.TimerEvent);
            // 
            // KillCounter
            // 
            resources.ApplyResources(this.KillCounter, "KillCounter");
            this.KillCounter.BackColor = System.Drawing.Color.Transparent;
            this.KillCounter.ForeColor = System.Drawing.Color.Red;
            this.KillCounter.Name = "KillCounter";
            // 
            // BulletImage
            // 
            resources.ApplyResources(this.BulletImage, "BulletImage");
            this.BulletImage.BackColor = System.Drawing.Color.Transparent;
            this.BulletImage.Image = global::HyperKill.Properties.Resources.Bullet;
            this.BulletImage.Name = "BulletImage";
            this.BulletImage.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::HyperKill.Properties.Resources.Heart;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Hero
            // 
            this.Hero.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Hero, "Hero");
            this.Hero.Image = global::HyperKill.Properties.Resources.MoveGifUp;
            this.Hero.Name = "Hero";
            this.Hero.TabStop = false;
            // 
            // GameForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::HyperKill.Properties.Resources.BackgroundGame;
            this.Controls.Add(this.KillCounter);
            this.Controls.Add(this.BulletImage);
            this.Controls.Add(this.OverHeatBar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HealthBar);
            this.Controls.Add(this.Hero);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GameForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameField_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.BulletImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar OverHeatBar;
        private System.Windows.Forms.ProgressBar HealthBar;
        private System.Windows.Forms.PictureBox BulletImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Hero;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.Label KillCounter;
    }
}

