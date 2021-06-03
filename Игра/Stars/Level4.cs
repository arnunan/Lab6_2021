using System;
using Game;
using System.Drawing;
using System.Windows.Forms;

namespace Stars
{
    public partial class Level4 : Form
    {
        public static FinalComic finalComicStatic = new FinalComic();

        bool goLeft, goRight, jumping, hasKey;
        int jumpSpeed = 10;
        int force = 4;
        int playerSpeed = 10;
        int backgroundSpeed = 8;

        public int scoreLevel4 = 0;
        public int timeLevel4 = 0;
        public int friendsLevel4 = 0;

        Bitmap imageLeft = new Bitmap("Pics//Left.png");
        Bitmap imageRight = new Bitmap("Pics//Right.png");
        Bitmap imageStraight = new Bitmap("Pics//playerStraight.png");

        public Level4()
        {
            InitializeComponent();
            Level1.currentLevelStatic = 4;

            Load += (sender, args) => OnSizeChanged(EventArgs.Empty);
            SizeChanged += (sender, args) =>
            {
                background.Size = new Size(ClientSize.Width * 3830 / 1620, ClientSize.Height);
                TimerTxt.Location = new Point(12, ClientSize.Height - 79);
                txtScore.Location = new Point(12, ClientSize.Height - 109);
                friendsTxt.Location = new Point(12, ClientSize.Height - 139);
                speakingHead.Location = new Point(ClientSize.Width * 352 / 1620, ClientSize.Height * 694 / 920);
                dialog.Location = new Point(ClientSize.Width * 513 / 1620, ClientSize.Height * 595 / 920);
                label1.Location = new Point(ClientSize.Width * 611 / 1620, ClientSize.Height * 609 / 920);
                background.Location = new Point(0, 0);
            };
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + scoreLevel4;
            TimerTxt.Text = "Time: " + timeLevel4 + " seconds";
            friendsTxt.Text = "Friends: " + friendsLevel4 + "/3";

            player.Top += jumpSpeed;

            if (goLeft == true && player.Left > 200)
            {
                player.Image = imageLeft;
                player.Left -= playerSpeed;
            }

            if (goRight == true && player.Left + (player.Width + 200) < this.ClientSize.Width)
            {
                player.Image = imageRight;
                player.Left += playerSpeed;
            }

            if (goLeft == true && background.Left < 0)
            {
                player.Image = imageLeft;
                background.Left += backgroundSpeed;
                MoveGameElements("forward");
            }

            if (goRight == true && background.Left > -22030)
            {
                player.Image = imageRight;
                background.Left -= backgroundSpeed;
                MoveGameElements("back");
            }

            if (goRight == false && goLeft == false)
                player.Image = imageStraight;

            if (jumping == true)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
                jumpSpeed = 12;

            if (hasKey == true && friendsLevel4 == 3)
                WinTheGame();

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platform")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && jumping == false)
                    {
                        force = 8;
                        player.Top = x.Top - player.Height;
                        jumpSpeed = 0;
                    }
                    x.BringToFront();
                }

                if (x is PictureBox && (string)x.Tag == "coin")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        x.Visible = false;
                        scoreLevel4 += 1;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "friend")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        x.Visible = false;
                        friendsLevel4 += 1;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "danger")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        GameTimer.Stop();
                        timer1.Stop();

                        BlackBackground form4 = new BlackBackground();
                        Form1.BlackBGStatic = form4;
                        Form1.BlackBGStatic.Show();
                        Form1.BlackBGStatic.label1.Visible = false;
                        Died died = new Died();
                        Level1.diedStatic = died;
                        Level1.diedStatic.Show();

                        timeLevel4 = 0;
                        scoreLevel4 = 0;

                    }
                }
            }

            if (player.Bounds.IntersectsWith(key.Bounds))
            {
                key.Visible = false;
                hasKey = true;
            }

            if (player.Top + player.Height > this.ClientSize.Height)
            {
                GameTimer.Stop();
                timer1.Stop();

                BlackBackground form4 = new BlackBackground();
                Form1.BlackBGStatic = form4;
                Form1.BlackBGStatic.Show();
                Form1.BlackBGStatic.label1.Visible = false;
                Died died = new Died();
                Level1.diedStatic = died;
                Level1.diedStatic.Show();

                timeLevel4 = 0;
                scoreLevel4 = 0;
            }
        }

        public void WinTheGame()
        {
            GameTimer.Stop();
            timer1.Stop();

            player.Image = imageStraight;

            Level1.scoreStatic += scoreLevel4;
            Level1.timeStatic += timeLevel4;
            Level1.wonLevelStatic = 4;
            Level1.pictureOfWin = 4;

            BlackBackground form4 = new BlackBackground();
            Form1.BlackBGStatic = form4;
            Form1.BlackBGStatic.Show();
            Form1.BlackBGStatic.label1.Visible = false;
            Winning winning = new Winning();
            Level1.winningStatic = winning;
            Level1.winningStatic.Show();
        }

        public void RestartGame()
        {
            this.Close();

            Level4 level4 = new Level4();
            Level3.level4Static = level4;
            Level3.level4Static.Show();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                timer1.Stop();
                BlackBackground form4 = new BlackBackground();
                Form1.BlackBGStatic = form4;
                Form1.BlackBGStatic.Show();
                Form1.BlackBGStatic.label1.Visible = true;
                Settings set = new Settings();
                Level1.settingsStatic = set;
                Level1.settingsStatic.Show();
            }

            if (e.KeyCode == Keys.Left)
                goLeft = true;

            if (e.KeyCode == Keys.Right)
                goRight = true;

            if (e.KeyCode == Keys.Space && jumping == false)
                jumping = true;
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                goLeft = false;

            if (e.KeyCode == Keys.Right)
                goRight = false;

            if (jumping == true)
                jumping = false;
        }
        private void CloseGame(object sender, FormClosedEventArgs e)
        {
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timeLevel4 += 1;
        }

        private void MoveGameElements(string direction)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platform"
                    || x is PictureBox && (string)x.Tag == "coin"
                    || x is PictureBox && (string)x.Tag == "key"
                    || x is PictureBox && (string)x.Tag == "danger"
                    || x is PictureBox && (string)x.Tag == "friend"
                    )
                {
                    if (direction == "back")
                        x.Left -= backgroundSpeed;

                    if (direction == "forward")
                        x.Left += backgroundSpeed;
                }
            }
        }
    }
}