using System;
using Game;
using System.Drawing;
using System.Windows.Forms;

namespace Stars
{
    public partial class Level1 : Form
    {
        public static Settings settingsStatic = new Settings();
        public static Died diedStatic = new Died();
        public static Winning winningStatic = new Winning();
        public static Level2 level2Static = new Level2();

        public static int currentLevelStatic = 1;
        public static int wonLevelStatic = 1;
        public static int pictureOfWin = 1;

        public static int scoreStatic = 0;
        public static int timeStatic = 0;
        
        bool goLeft, goRight, jumping, hasKey;
        int jumpSpeed = 10;
        int force = 4;

        public int scoreLevel1 = 0;
        public int timeLevel1 = 0;
        int playerSpeed = 10;
        int backgroundSpeed = 8;

        Bitmap imageLeft = new Bitmap("Pics//Left.png");
        Bitmap imageRight = new Bitmap("Pics//Right.png");
        Bitmap imageStraight = new Bitmap("Pics//playerStraight.png");

        public Level1()
        {
            InitializeComponent();

            currentLevelStatic = 1;
            wonLevelStatic = 1;
            pictureOfWin = 1;

        Load += (sender, args) => OnSizeChanged(EventArgs.Empty);
            SizeChanged += (sender, args) =>
            {
                background.Size = new Size(ClientSize.Width * 3830 / 1620, ClientSize.Height);
                TimerTxt.Location = new Point(12, ClientSize.Height - 79);
                txtScore.Location = new Point(12, ClientSize.Height - 109);
                pictureBox45.Location = new Point(ClientSize.Width*408 / 1620, ClientSize.Height *646 / 920);
                pictureBox46.Location = new Point(ClientSize.Width  * 599 / 1620, ClientSize.Height  * 597 / 920);
                label1.Location = new Point(ClientSize.Width  * 690 / 1620, ClientSize.Height  * 620 / 920);
                background.Location = new Point(0, 0);
            };
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + scoreLevel1;
            TimerTxt.Text = "Time: " + timeLevel1 + " seconds";
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

            if (goRight == true && background.Left > -9780)
            {
                player.Image = imageRight;
                background.Left -= backgroundSpeed;
                MoveGameElements("back");
            }

            if (goRight == false && goLeft == false)
                player.Image = imageStraight;

            if (force < 0 && jumping)
                jumping = false;

            if (jumping == true)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
                jumpSpeed = 12;

            if (hasKey == true)
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
                        scoreLevel1 += 1;
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
                diedStatic = died;
                diedStatic.Show();

                timeLevel1 = 0;
                scoreLevel1 = 0;
            }
        }

        public void WinTheGame()
        {
            GameTimer.Stop();
            timer1.Stop();

            player.Image = imageStraight;

            scoreStatic += scoreLevel1;
            timeStatic += timeLevel1;

            pictureOfWin = 1;

            BlackBackground form4 = new BlackBackground();
            Form1.BlackBGStatic = form4;
            Form1.BlackBGStatic.Show();

            Form1.BlackBGStatic.label1.Visible = false;

            Winning winning = new Winning();
            winningStatic = winning;
            winningStatic.Show();
        }

        public void RestartGame()
        {
            this.Close();

            Level1 level1 = new Level1();
            StarterComic.level1Static = level1;
            StarterComic.level1Static.Show();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
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

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            timeLevel1 += 1;
        }

        private void MoveGameElements(string direction)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platform" 
                    || x is PictureBox && (string)x.Tag == "coin" 
                    || x is PictureBox && (string)x.Tag == "key")
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