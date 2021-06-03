using Stars;
using System;
using System.Media;
using System.Drawing;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        public class Star
        {
            public float X { get; set; }
            public float Y { get; set; }
            public float Z { get; set; }
        }

        public static BlackBackground BlackBGStatic = new BlackBackground();
        public static ExitFromMenu ExitStatic = new ExitFromMenu();
        public static StarterComic StarterComicStatic = new StarterComic();
        public static SettingsFromMenu SettingsFromMenuStatic = new SettingsFromMenu();

        public static string musicOnOff = "on";

        private Star[] stars = new Star[15000];
        private Random random = new Random();
        private Graphics graphics;

        public static SoundPlayer song = new SoundPlayer("Pics//SongForGame.wav");

        public Form1()
        {
            InitializeComponent();
            buttonPlay.FlatAppearance.BorderSize = 0; buttonPlay.FlatStyle = FlatStyle.Flat;
            buttonSettings.FlatAppearance.BorderSize = 0; buttonSettings.FlatStyle = FlatStyle.Flat;
            buttonExit.FlatAppearance.BorderSize = 0; buttonExit.FlatStyle = FlatStyle.Flat;
            song.PlayLooping();

            Load += (sender, args) => OnSizeChanged(EventArgs.Empty);
            SizeChanged += (sender, args) =>
            {
                pictureBox2.Location = new Point(ClientSize.Width * 506 / 1620, ClientSize.Height * 69 / 920);
                buttonPlay.Location = new Point(ClientSize.Width * 652 / 1620, ClientSize.Height * 279 / 920);
                buttonSettings.Location = new Point(ClientSize.Width * 652 / 1620, ClientSize.Height * 470 / 920);
                buttonExit.Location = new Point(ClientSize.Width * 652 / 1620, ClientSize.Height * 665 / 920);
            };
        }

        private void MoveStar(Star star)
        {
            star.Z -= 15;
            if (star.Z < 1)
            {
                star.Z = random.Next(pictureBox1.Width, pictureBox1.Width);
                star.Y = random.Next(-pictureBox1.Height, pictureBox1.Height);
                star.Z = random.Next(1, pictureBox1.Width);
            }
        }

        private void DrawStar(Star star)
        {
            float starSize = Map(star.Z, 0, pictureBox1.Width, 6, 0);
            float x = Map(star.X / star.Z, 0, 1, 0, pictureBox1.Width) + pictureBox1.Width / 2;
            float y = Map(star.Y / star.Z, 0, 1, 0, pictureBox1.Height) + pictureBox1.Height / 2;
            graphics.FillEllipse (Brushes.WhiteSmoke,x,y,starSize, starSize);
        }

        private float Map(float n, float start1, float stop1, float start2, float stop2) =>
            ((n - start1) / (stop1 - start1) * (stop2 - start2) + start2);

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);

            for (int i = 0; i < stars.Length; i++)
            {
                stars[i] = new Star()
                {
                    X = random.Next(-pictureBox1.Width, pictureBox1.Width),
                    Y = random.Next(-pictureBox1.Height, pictureBox1.Height),
                    Z = random.Next(pictureBox1.Width)
                };
            }
            timer.Start();
        }

        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            StarterComic form5 = new StarterComic();
            StarterComicStatic = form5;
            StarterComicStatic.Show();
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            SettingsFromMenu form3 = new SettingsFromMenu();
            SettingsFromMenuStatic = form3;
            SettingsFromMenuStatic.Show();
        }

        public void ButtonExit_Click(object sender, EventArgs e)
        {
            BlackBackground form4 = new BlackBackground();
            BlackBGStatic = form4;
            BlackBGStatic.Show();
            BlackBGStatic.label1.Visible = false;
            ExitFromMenu form2 = new ExitFromMenu();
            ExitStatic = form2;
            ExitStatic.Show();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            graphics.Clear(Color.Black);
            foreach (var star in stars)
            {
                DrawStar(star);
                MoveStar(star);
            }
            pictureBox1.Refresh();
        }
    }
}
