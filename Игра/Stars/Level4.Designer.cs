
namespace Stars
{
    partial class Level4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level4));
            this.background = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.platform1 = new System.Windows.Forms.PictureBox();
            this.key = new System.Windows.Forms.PictureBox();
            this.platform2 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.TimerTxt = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.friendsTxt = new System.Windows.Forms.Label();
            this.danger3 = new System.Windows.Forms.PictureBox();
            this.danger2 = new System.Windows.Forms.PictureBox();
            this.danger1 = new System.Windows.Forms.PictureBox();
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.coin2 = new System.Windows.Forms.PictureBox();
            this.coin3 = new System.Windows.Forms.PictureBox();
            this.coin4 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.danger4 = new System.Windows.Forms.PictureBox();
            this.danger5 = new System.Windows.Forms.PictureBox();
            this.danger6 = new System.Windows.Forms.PictureBox();
            this.danger7 = new System.Windows.Forms.PictureBox();
            this.danger8 = new System.Windows.Forms.PictureBox();
            this.danger9 = new System.Windows.Forms.PictureBox();
            this.friend2 = new System.Windows.Forms.PictureBox();
            this.friend3 = new System.Windows.Forms.PictureBox();
            this.coin6 = new System.Windows.Forms.PictureBox();
            this.coin5 = new System.Windows.Forms.PictureBox();
            this.coin7 = new System.Windows.Forms.PictureBox();
            this.coin8 = new System.Windows.Forms.PictureBox();
            this.coin9 = new System.Windows.Forms.PictureBox();
            this.coin10 = new System.Windows.Forms.PictureBox();
            this.coin11 = new System.Windows.Forms.PictureBox();
            this.coin12 = new System.Windows.Forms.PictureBox();
            this.coin13 = new System.Windows.Forms.PictureBox();
            this.speakingHead = new System.Windows.Forms.PictureBox();
            this.dialog = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danger3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danger2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danger1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danger4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danger5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danger6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danger7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danger8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danger9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friend2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friend3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speakingHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dialog)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Image = ((System.Drawing.Image)(resources.GetObject("background.Image")));
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(3830, 920);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            this.background.Tag = "background";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // platform1
            // 
            this.platform1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("platform1.BackgroundImage")));
            this.platform1.Location = new System.Drawing.Point(0, 549);
            this.platform1.Name = "platform1";
            this.platform1.Size = new System.Drawing.Size(219, 50);
            this.platform1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.platform1.TabIndex = 1;
            this.platform1.TabStop = false;
            this.platform1.Tag = "platform";
            // 
            // key
            // 
            this.key.BackColor = System.Drawing.Color.Black;
            this.key.Image = ((System.Drawing.Image)(resources.GetObject("key.Image")));
            this.key.Location = new System.Drawing.Point(3670, 428);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(72, 115);
            this.key.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.key.TabIndex = 3;
            this.key.TabStop = false;
            this.key.Tag = "key";
            // 
            // platform2
            // 
            this.platform2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("platform2.BackgroundImage")));
            this.platform2.Location = new System.Drawing.Point(3611, 549);
            this.platform2.Name = "platform2";
            this.platform2.Size = new System.Drawing.Size(219, 50);
            this.platform2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.platform2.TabIndex = 4;
            this.platform2.TabStop = false;
            this.platform2.Tag = "platform";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Black;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(129, 444);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(54, 99);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player.TabIndex = 5;
            this.player.TabStop = false;
            this.player.Tag = "player";
            // 
            // TimerTxt
            // 
            this.TimerTxt.AutoSize = true;
            this.TimerTxt.BackColor = System.Drawing.Color.Black;
            this.TimerTxt.Font = new System.Drawing.Font("Courier New", 20.25F);
            this.TimerTxt.ForeColor = System.Drawing.Color.White;
            this.TimerTxt.Location = new System.Drawing.Point(12, 841);
            this.TimerTxt.Name = "TimerTxt";
            this.TimerTxt.Size = new System.Drawing.Size(253, 30);
            this.TimerTxt.TabIndex = 53;
            this.TimerTxt.Text = "Time: 0 seconds";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.Black;
            this.txtScore.Font = new System.Drawing.Font("Courier New", 20.25F);
            this.txtScore.ForeColor = System.Drawing.Color.White;
            this.txtScore.Location = new System.Drawing.Point(12, 811);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(141, 30);
            this.txtScore.TabIndex = 54;
            this.txtScore.Text = "Score: 0";
            // 
            // friendsTxt
            // 
            this.friendsTxt.AutoSize = true;
            this.friendsTxt.BackColor = System.Drawing.Color.Black;
            this.friendsTxt.Font = new System.Drawing.Font("Courier New", 20.25F);
            this.friendsTxt.ForeColor = System.Drawing.Color.White;
            this.friendsTxt.Location = new System.Drawing.Point(12, 781);
            this.friendsTxt.Name = "friendsTxt";
            this.friendsTxt.Size = new System.Drawing.Size(205, 30);
            this.friendsTxt.TabIndex = 55;
            this.friendsTxt.Text = "Friends: 0/3";
            // 
            // danger3
            // 
            this.danger3.BackColor = System.Drawing.Color.Black;
            this.danger3.Image = ((System.Drawing.Image)(resources.GetObject("danger3.Image")));
            this.danger3.Location = new System.Drawing.Point(1149, 220);
            this.danger3.Name = "danger3";
            this.danger3.Size = new System.Drawing.Size(100, 100);
            this.danger3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.danger3.TabIndex = 56;
            this.danger3.TabStop = false;
            this.danger3.Tag = "danger";
            // 
            // danger2
            // 
            this.danger2.BackColor = System.Drawing.Color.Black;
            this.danger2.Image = ((System.Drawing.Image)(resources.GetObject("danger2.Image")));
            this.danger2.Location = new System.Drawing.Point(766, 405);
            this.danger2.Name = "danger2";
            this.danger2.Size = new System.Drawing.Size(100, 100);
            this.danger2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.danger2.TabIndex = 57;
            this.danger2.TabStop = false;
            this.danger2.Tag = "danger";
            // 
            // danger1
            // 
            this.danger1.BackColor = System.Drawing.Color.Black;
            this.danger1.Image = ((System.Drawing.Image)(resources.GetObject("danger1.Image")));
            this.danger1.Location = new System.Drawing.Point(383, 590);
            this.danger1.Name = "danger1";
            this.danger1.Size = new System.Drawing.Size(100, 100);
            this.danger1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.danger1.TabIndex = 58;
            this.danger1.TabStop = false;
            this.danger1.Tag = "danger";
            // 
            // coin1
            // 
            this.coin1.BackColor = System.Drawing.Color.Black;
            this.coin1.Image = ((System.Drawing.Image)(resources.GetObject("coin1.Image")));
            this.coin1.Location = new System.Drawing.Point(423, 445);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(30, 30);
            this.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coin1.TabIndex = 59;
            this.coin1.TabStop = false;
            this.coin1.Tag = "coin";
            // 
            // coin2
            // 
            this.coin2.BackColor = System.Drawing.Color.Black;
            this.coin2.Image = ((System.Drawing.Image)(resources.GetObject("coin2.Image")));
            this.coin2.Location = new System.Drawing.Point(615, 353);
            this.coin2.Name = "coin2";
            this.coin2.Size = new System.Drawing.Size(30, 30);
            this.coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coin2.TabIndex = 60;
            this.coin2.TabStop = false;
            this.coin2.Tag = "coin";
            // 
            // coin3
            // 
            this.coin3.BackColor = System.Drawing.Color.Black;
            this.coin3.Image = ((System.Drawing.Image)(resources.GetObject("coin3.Image")));
            this.coin3.Location = new System.Drawing.Point(806, 260);
            this.coin3.Name = "coin3";
            this.coin3.Size = new System.Drawing.Size(30, 30);
            this.coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coin3.TabIndex = 61;
            this.coin3.TabStop = false;
            this.coin3.Tag = "coin";
            // 
            // coin4
            // 
            this.coin4.BackColor = System.Drawing.Color.Black;
            this.coin4.Image = ((System.Drawing.Image)(resources.GetObject("coin4.Image")));
            this.coin4.Location = new System.Drawing.Point(998, 133);
            this.coin4.Name = "coin4";
            this.coin4.Size = new System.Drawing.Size(30, 30);
            this.coin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coin4.TabIndex = 62;
            this.coin4.TabStop = false;
            this.coin4.Tag = "coin";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Black;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(1149, 42);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(100, 100);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 63;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "friend";
            // 
            // danger4
            // 
            this.danger4.BackColor = System.Drawing.Color.Black;
            this.danger4.Image = ((System.Drawing.Image)(resources.GetObject("danger4.Image")));
            this.danger4.Location = new System.Drawing.Point(1532, 405);
            this.danger4.Name = "danger4";
            this.danger4.Size = new System.Drawing.Size(100, 100);
            this.danger4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.danger4.TabIndex = 64;
            this.danger4.TabStop = false;
            this.danger4.Tag = "danger";
            // 
            // danger5
            // 
            this.danger5.BackColor = System.Drawing.Color.Black;
            this.danger5.Image = ((System.Drawing.Image)(resources.GetObject("danger5.Image")));
            this.danger5.Location = new System.Drawing.Point(1915, 590);
            this.danger5.Name = "danger5";
            this.danger5.Size = new System.Drawing.Size(100, 100);
            this.danger5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.danger5.TabIndex = 65;
            this.danger5.TabStop = false;
            this.danger5.Tag = "danger";
            // 
            // danger6
            // 
            this.danger6.BackColor = System.Drawing.Color.Black;
            this.danger6.Image = ((System.Drawing.Image)(resources.GetObject("danger6.Image")));
            this.danger6.Location = new System.Drawing.Point(2298, 405);
            this.danger6.Name = "danger6";
            this.danger6.Size = new System.Drawing.Size(100, 100);
            this.danger6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.danger6.TabIndex = 66;
            this.danger6.TabStop = false;
            this.danger6.Tag = "danger";
            // 
            // danger7
            // 
            this.danger7.BackColor = System.Drawing.Color.Black;
            this.danger7.Image = ((System.Drawing.Image)(resources.GetObject("danger7.Image")));
            this.danger7.Location = new System.Drawing.Point(2681, 220);
            this.danger7.Name = "danger7";
            this.danger7.Size = new System.Drawing.Size(100, 100);
            this.danger7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.danger7.TabIndex = 67;
            this.danger7.TabStop = false;
            this.danger7.Tag = "danger";
            // 
            // danger8
            // 
            this.danger8.BackColor = System.Drawing.Color.Black;
            this.danger8.Image = ((System.Drawing.Image)(resources.GetObject("danger8.Image")));
            this.danger8.Location = new System.Drawing.Point(3064, 405);
            this.danger8.Name = "danger8";
            this.danger8.Size = new System.Drawing.Size(100, 100);
            this.danger8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.danger8.TabIndex = 68;
            this.danger8.TabStop = false;
            this.danger8.Tag = "danger";
            // 
            // danger9
            // 
            this.danger9.BackColor = System.Drawing.Color.Black;
            this.danger9.Image = ((System.Drawing.Image)(resources.GetObject("danger9.Image")));
            this.danger9.Location = new System.Drawing.Point(3447, 590);
            this.danger9.Name = "danger9";
            this.danger9.Size = new System.Drawing.Size(100, 100);
            this.danger9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.danger9.TabIndex = 69;
            this.danger9.TabStop = false;
            this.danger9.Tag = "danger";
            // 
            // friend2
            // 
            this.friend2.BackColor = System.Drawing.Color.Black;
            this.friend2.Image = ((System.Drawing.Image)(resources.GetObject("friend2.Image")));
            this.friend2.Location = new System.Drawing.Point(1915, 443);
            this.friend2.Name = "friend2";
            this.friend2.Size = new System.Drawing.Size(100, 100);
            this.friend2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.friend2.TabIndex = 70;
            this.friend2.TabStop = false;
            this.friend2.Tag = "friend";
            // 
            // friend3
            // 
            this.friend3.BackColor = System.Drawing.Color.Black;
            this.friend3.Image = ((System.Drawing.Image)(resources.GetObject("friend3.Image")));
            this.friend3.Location = new System.Drawing.Point(2681, 42);
            this.friend3.Name = "friend3";
            this.friend3.Size = new System.Drawing.Size(100, 100);
            this.friend3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.friend3.TabIndex = 71;
            this.friend3.TabStop = false;
            this.friend3.Tag = "friend";
            // 
            // coin6
            // 
            this.coin6.BackColor = System.Drawing.Color.Black;
            this.coin6.Image = ((System.Drawing.Image)(resources.GetObject("coin6.Image")));
            this.coin6.Location = new System.Drawing.Point(1572, 260);
            this.coin6.Name = "coin6";
            this.coin6.Size = new System.Drawing.Size(30, 30);
            this.coin6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coin6.TabIndex = 72;
            this.coin6.TabStop = false;
            this.coin6.Tag = "coin";
            // 
            // coin5
            // 
            this.coin5.BackColor = System.Drawing.Color.Black;
            this.coin5.Image = ((System.Drawing.Image)(resources.GetObject("coin5.Image")));
            this.coin5.Location = new System.Drawing.Point(1381, 133);
            this.coin5.Name = "coin5";
            this.coin5.Size = new System.Drawing.Size(30, 30);
            this.coin5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coin5.TabIndex = 73;
            this.coin5.TabStop = false;
            this.coin5.Tag = "coin";
            // 
            // coin7
            // 
            this.coin7.BackColor = System.Drawing.Color.Black;
            this.coin7.Image = ((System.Drawing.Image)(resources.GetObject("coin7.Image")));
            this.coin7.Location = new System.Drawing.Point(1764, 353);
            this.coin7.Name = "coin7";
            this.coin7.Size = new System.Drawing.Size(30, 30);
            this.coin7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coin7.TabIndex = 74;
            this.coin7.TabStop = false;
            this.coin7.Tag = "coin";
            // 
            // coin8
            // 
            this.coin8.BackColor = System.Drawing.Color.Black;
            this.coin8.Image = ((System.Drawing.Image)(resources.GetObject("coin8.Image")));
            this.coin8.Location = new System.Drawing.Point(2147, 353);
            this.coin8.Name = "coin8";
            this.coin8.Size = new System.Drawing.Size(30, 30);
            this.coin8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coin8.TabIndex = 75;
            this.coin8.TabStop = false;
            this.coin8.Tag = "coin";
            // 
            // coin9
            // 
            this.coin9.BackColor = System.Drawing.Color.Black;
            this.coin9.Image = ((System.Drawing.Image)(resources.GetObject("coin9.Image")));
            this.coin9.Location = new System.Drawing.Point(2338, 260);
            this.coin9.Name = "coin9";
            this.coin9.Size = new System.Drawing.Size(30, 30);
            this.coin9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coin9.TabIndex = 76;
            this.coin9.TabStop = false;
            this.coin9.Tag = "coin";
            // 
            // coin10
            // 
            this.coin10.BackColor = System.Drawing.Color.Black;
            this.coin10.Image = ((System.Drawing.Image)(resources.GetObject("coin10.Image")));
            this.coin10.Location = new System.Drawing.Point(2530, 133);
            this.coin10.Name = "coin10";
            this.coin10.Size = new System.Drawing.Size(30, 30);
            this.coin10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coin10.TabIndex = 77;
            this.coin10.TabStop = false;
            this.coin10.Tag = "coin";
            // 
            // coin11
            // 
            this.coin11.BackColor = System.Drawing.Color.Black;
            this.coin11.Image = ((System.Drawing.Image)(resources.GetObject("coin11.Image")));
            this.coin11.Location = new System.Drawing.Point(2913, 133);
            this.coin11.Name = "coin11";
            this.coin11.Size = new System.Drawing.Size(30, 30);
            this.coin11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coin11.TabIndex = 78;
            this.coin11.TabStop = false;
            this.coin11.Tag = "coin";
            // 
            // coin12
            // 
            this.coin12.BackColor = System.Drawing.Color.Black;
            this.coin12.Image = ((System.Drawing.Image)(resources.GetObject("coin12.Image")));
            this.coin12.Location = new System.Drawing.Point(3104, 260);
            this.coin12.Name = "coin12";
            this.coin12.Size = new System.Drawing.Size(30, 30);
            this.coin12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coin12.TabIndex = 79;
            this.coin12.TabStop = false;
            this.coin12.Tag = "coin";
            // 
            // coin13
            // 
            this.coin13.BackColor = System.Drawing.Color.Black;
            this.coin13.Image = ((System.Drawing.Image)(resources.GetObject("coin13.Image")));
            this.coin13.Location = new System.Drawing.Point(3296, 353);
            this.coin13.Name = "coin13";
            this.coin13.Size = new System.Drawing.Size(30, 30);
            this.coin13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coin13.TabIndex = 80;
            this.coin13.TabStop = false;
            this.coin13.Tag = "coin";
            // 
            // speakingHead
            // 
            this.speakingHead.BackColor = System.Drawing.Color.Black;
            this.speakingHead.Image = ((System.Drawing.Image)(resources.GetObject("speakingHead.Image")));
            this.speakingHead.Location = new System.Drawing.Point(352, 694);
            this.speakingHead.Name = "speakingHead";
            this.speakingHead.Size = new System.Drawing.Size(179, 306);
            this.speakingHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.speakingHead.TabIndex = 105;
            this.speakingHead.TabStop = false;
            // 
            // dialog
            // 
            this.dialog.BackColor = System.Drawing.Color.Black;
            this.dialog.Image = ((System.Drawing.Image)(resources.GetObject("dialog.Image")));
            this.dialog.InitialImage = null;
            this.dialog.Location = new System.Drawing.Point(513, 595);
            this.dialog.Name = "dialog";
            this.dialog.Size = new System.Drawing.Size(661, 181);
            this.dialog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dialog.TabIndex = 108;
            this.dialog.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Courier New", 13F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(611, 609);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 140);
            this.label1.TabIndex = 109;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // Level4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1620, 920);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dialog);
            this.Controls.Add(this.speakingHead);
            this.Controls.Add(this.coin13);
            this.Controls.Add(this.coin12);
            this.Controls.Add(this.coin11);
            this.Controls.Add(this.coin10);
            this.Controls.Add(this.coin9);
            this.Controls.Add(this.coin8);
            this.Controls.Add(this.coin7);
            this.Controls.Add(this.coin5);
            this.Controls.Add(this.coin6);
            this.Controls.Add(this.friend3);
            this.Controls.Add(this.friend2);
            this.Controls.Add(this.danger9);
            this.Controls.Add(this.danger8);
            this.Controls.Add(this.danger7);
            this.Controls.Add(this.danger6);
            this.Controls.Add(this.danger5);
            this.Controls.Add(this.danger4);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.coin4);
            this.Controls.Add(this.coin3);
            this.Controls.Add(this.coin2);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.danger1);
            this.Controls.Add(this.danger2);
            this.Controls.Add(this.danger3);
            this.Controls.Add(this.friendsTxt);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.TimerTxt);
            this.Controls.Add(this.player);
            this.Controls.Add(this.platform2);
            this.Controls.Add(this.key);
            this.Controls.Add(this.platform1);
            this.Controls.Add(this.background);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Level4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseGame);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danger3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danger2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danger1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danger4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danger5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danger6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danger7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danger8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danger9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friend2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friend3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speakingHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dialog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox platform1;
        private System.Windows.Forms.PictureBox key;
        private System.Windows.Forms.PictureBox platform2;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label TimerTxt;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label friendsTxt;
        private System.Windows.Forms.PictureBox danger3;
        private System.Windows.Forms.PictureBox danger2;
        private System.Windows.Forms.PictureBox danger1;
        private System.Windows.Forms.PictureBox coin1;
        private System.Windows.Forms.PictureBox coin2;
        private System.Windows.Forms.PictureBox coin3;
        private System.Windows.Forms.PictureBox coin4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox danger4;
        private System.Windows.Forms.PictureBox danger5;
        private System.Windows.Forms.PictureBox danger6;
        private System.Windows.Forms.PictureBox danger7;
        private System.Windows.Forms.PictureBox danger8;
        private System.Windows.Forms.PictureBox danger9;
        private System.Windows.Forms.PictureBox friend2;
        private System.Windows.Forms.PictureBox friend3;
        private System.Windows.Forms.PictureBox coin6;
        private System.Windows.Forms.PictureBox coin5;
        private System.Windows.Forms.PictureBox coin7;
        private System.Windows.Forms.PictureBox coin8;
        private System.Windows.Forms.PictureBox coin9;
        private System.Windows.Forms.PictureBox coin10;
        private System.Windows.Forms.PictureBox coin11;
        private System.Windows.Forms.PictureBox coin12;
        private System.Windows.Forms.PictureBox coin13;
        public System.Windows.Forms.Timer GameTimer;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox speakingHead;
        private System.Windows.Forms.PictureBox dialog;
        private System.Windows.Forms.Label label1;
    }
}