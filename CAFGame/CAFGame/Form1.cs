using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Numerics;
using System.Windows.Forms;

namespace CAFGame
{
    public sealed partial class Form1 : Form
    {
        public static bool IsAdown;
        public static bool IsDdown;
        public static bool IsSdown;
        public static bool IsWdown;
        private static Timer timer;


        private static readonly string path = "SavedBestScore.txt";

        public static int BestScore;
        public static int Score;

        private static readonly EnemySpawner EnemySpawner = new EnemySpawner();
        private static readonly GenreChanger genreChanger = new GenreChanger();

        public static bool NeedToBeClosed;

        public static Point desktopLocation;

        public Form1()
        {
            InitializeComponent();
            timer = new Timer {Interval = 10};
            timer.Tick += Update;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            DoubleBuffered = true;

            ReadBestScore();

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            timer.Start();

            StartMenu();
        }

        private static void ReadBestScore()
        {
            if (File.Exists(path))
                using (var sr = File.OpenText(path))
                {
                    var s = "";
                    while ((s = sr.ReadLine()) != null) BestScore = int.Parse(s);
                }
        }

        private static void StartMenu()
        {
            Environment.ClearSpaceFromButtons();
            Environment.GameState = GameState.MainMenu;

            Environment.MenuButtons.Add(new PlayButton(new Vector2(124 + (1920 - 124 - 436) / 2f, 1080 / 2f + 100)));
            Environment.MenuButtons.Add(new QuitButton(new Vector2(124 + (1920 - 124 - 436) / 2f, 1080 / 2f + 175)));
            Environment.MenuButtons.Add(new MuteSoundButton(new Vector2(Environment.PosRangeBottomRight.X - 50,
                Environment.PosRangeTopLeft.Y + 40)));
        }

        public static void StartGame()
        {
            Environment.GameState = GameState.Game;
            Score = 0;
            Environment.CurrentGenre = CurrentGenre.Tds;
            var playerPos = new Vector2(124 + (1920 - 124 - 436) / 2f, 1080 / 2f);
            CreatePlayer((int) playerPos.X, (int) playerPos.Y);
        }

        public static void OnPlayersDeath()
        {
            Environment.ClearSpaceFromBullets();
            EnemySpawner.MakeAllSpotsEmpty();
            GenreChanger.GenreChangeTimer = 0;
            Cursor.Show();
            if (Score > BestScore)
            {
                BestScore = Score;
                using (var sw = File.CreateText(path))
                {
                    sw.WriteLine(BestScore);
                }
            }

            Score = 0;
            StartMenu();
        }

        private void Update(object sender, EventArgs e)
        {
            desktopLocation = DesktopLocation;
            Environment.Update();
            if (Environment.GameState == GameState.Game)
            {
                var tempEnemies = new List<Enemy>();
                foreach (var item in Environment.Enemies)
                    tempEnemies.Add(item);

                var tempBulletsPlayer = new List<Bullet>();
                foreach (var b in Environment.BulletsPlayer)
                    tempBulletsPlayer.Add(b);

                var tempBulletsEnemy = new List<Bullet>();
                foreach (var b in Environment.BulletsEnemy)
                    tempBulletsEnemy.Add(b);

                var tempCannonProjectilePlayer = new List<CannonProjectile>();
                foreach (var b in Environment.CannonProjectilePlayer)
                    tempCannonProjectilePlayer.Add(b);

                var tempCannonProjectileEnemy = new List<CannonProjectile>();
                foreach (var b in Environment.CannonProjectileEnemy)
                    tempCannonProjectileEnemy.Add(b);

                Environment.Player.Update(tempBulletsEnemy, tempEnemies, tempCannonProjectileEnemy);
                foreach (var enemy in tempEnemies) enemy.Update(tempBulletsPlayer, tempCannonProjectilePlayer);
                foreach (var bullet in tempBulletsEnemy) bullet.Update();
                foreach (var bullet in tempBulletsPlayer) bullet.Update();
                foreach (var proj in tempCannonProjectilePlayer)
                    proj.Update(tempCannonProjectilePlayer, tempCannonProjectileEnemy);
                foreach (var proj in tempCannonProjectileEnemy)
                    proj.Update(tempCannonProjectilePlayer, tempCannonProjectileEnemy);
                EnemySpawner.Update();
                genreChanger.Update();
            }

            if (Environment.GameState == GameState.MainMenu)
                foreach (var button in Environment.MenuButtons)
                    button.Update();

            if (NeedToBeClosed) Close();

            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) IsWdown = true;
            if (e.KeyCode == Keys.A) IsAdown = true;
            if (e.KeyCode == Keys.S) IsSdown = true;
            if (e.KeyCode == Keys.D) IsDdown = true;

            if (e.KeyCode == Keys.Escape)
            {
                if (Environment.GameState == GameState.MainMenu) Close();
                if (Environment.GameState == GameState.Game) OnPlayersDeath();
            }

            if (e.KeyCode == Keys.Q) genreChanger.SwitchToPT();
            if (e.KeyCode == Keys.E) genreChanger.SwitchToS();
            if (e.KeyCode == Keys.R) genreChanger.SwitchToTDS();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) IsWdown = false;
            if (e.KeyCode == Keys.A) IsAdown = false;
            if (e.KeyCode == Keys.S) IsSdown = false;
            if (e.KeyCode == Keys.D) IsDdown = false;
        }

        private static void CreatePlayer(int x, int y)
        {
            Environment.Player = new PlayerTDS(x, y, 3);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            DrawBackGround(g);

            if (Environment.GameState == GameState.MainMenu)
            {
                foreach (var t in Environment.MenuButtons) DrawGameObject(g, t);
                DrawBestScore(g);
                var p = new Vector2(124 + (1920 - 124 - 436) / 2f, 1080 / 2f - 200);
                g.DrawImage(Environment.Logo.Sprite, p.X - Environment.Logo.Sprite.Size.Width / 2f,
                    p.Y - Environment.Logo.Sprite.Size.Height / 2f);
            }

            if (Environment.GameState == GameState.Game)
            {
                foreach (var t in Environment.Enemies)
                {
                    DrawGameObject(g, t);
                    for (var i = 0; i < t.Hp; i++) DrawHearts(i, g, t);
                    if (Environment.CurrentGenre == CurrentGenre.Pt) DrawPlatform(t, g);
                    if (Environment.CurrentGenre == CurrentGenre.S)
                    {
                        Environment.RevolverDrum.Pos = new Vector2(t.Pos.X + 35, t.Pos.Y + 30);
                        DrawGameObject(g, Environment.RevolverDrum);
                        DrawRevolverBullets(t, g);
                    }
                }

                foreach (var t in Environment.BulletsEnemy) DrawGameObject(g, t);
                foreach (var t in Environment.BulletsPlayer) DrawGameObject(g, t);
                foreach (var t in Environment.CannonProjectilePlayer) DrawGameObject(g, t);
                foreach (var t in Environment.CannonProjectileEnemy) DrawGameObject(g, t);

                g.DrawImage(Environment.Player.Sprite,
                    Environment.Player.Pos.X - Environment.Player.Sprite.Size.Width / 2f,
                    Environment.Player.Pos.Y - Environment.Player.Sprite.Size.Height / 2f);
                if (Environment.CurrentGenre == CurrentGenre.Pt) DrawPlatform(Environment.Player, g);
                for (var i = 0; i < Environment.Player.Hp; i++) DrawHearts(i, g, Environment.Player);
                DrawSwitchGenreTimer(g);
            }

            g.DrawImage(Environment.BG.Sprite, 0, 0);

            DrawCurrentScore(g);
        }

        private static void DrawRevolverBullets(Enemy t, Graphics g)
        {
            for (var i = 0; i < t.ShootDelayTimer / 1000; i++)
            {
                var angle = Math.PI / 3f * i;
                var r = 7;
                var bulletPos = new Vector2((float) (Environment.RevolverDrum.Pos.X + r * Math.Cos(angle)),
                    (float) (Environment.RevolverDrum.Pos.Y + r * Math.Sin(angle)));
                g.DrawImage(Environment.RevolverBullet.Sprite,
                    new Point((int) bulletPos.X - Environment.RevolverBullet.Sprite.Width / 2,
                        (int) bulletPos.Y - Environment.RevolverBullet.Sprite.Height / 2));
            }
        }

        private void DrawBackGround(Graphics g)
        {
            var pos = new Point(100, 65);
            if (Environment.GameState == GameState.MainMenu) g.DrawImage(Environment.MenuBG.Sprite, pos.X, pos.Y);
            if (Environment.GameState == GameState.Game)
            {
                if (Environment.CurrentGenre == CurrentGenre.Tds)
                    g.DrawImage(Environment.TDSBG.Sprite, pos.X, pos.Y);
                else if (Environment.CurrentGenre == CurrentGenre.Pt)
                    g.DrawImage(Environment.PTBG.Sprite, pos.X, pos.Y);
                else if (Environment.CurrentGenre == CurrentGenre.S) g.DrawImage(Environment.SBG.Sprite, pos.X, pos.Y);
            }
        }

        private void DrawPlatform(GameObject t, Graphics g)
        {
            var xPos = t.Pos.X - Environment.Platform.Sprite.Size.Width / 2f;
            var yPos = t.Pos.Y + 55 - Environment.Platform.Sprite.Size.Height / 2f;
            g.DrawImage(Environment.Platform.Sprite, xPos, yPos);
        }

        private void DrawSwitchGenreTimer(Graphics g)
        {
            var f = new Font("Impact", 100);
            var b = new SolidBrush(Color.FromArgb(170, Color.White));
            var str = (20 - GenreChanger.GenreChangeTimer / 1000f).ToString("00");
            g.DrawString(str, f, b, 124, 121, new StringFormat());
        }

        private void DrawBestScore(Graphics g)
        {
            var f = new Font("Impact", 25);
            var b = new SolidBrush(Color.Black);
            var str = "Best Score: " + BestScore.ToString("0000");
            g.DrawString(str, f, b, 124, 121, new StringFormat());
        }

        private void DrawCurrentScore(Graphics g)
        {
            var f = new Font("Arial", 65);
            var b = new SolidBrush(Color.Black);
            g.DrawString(Score.ToString("0000"), f, b, 1920 - 298, 1080 - 210, new StringFormat());
        }

        private void DrawHearts(int i, Graphics g, GameObject obj)
        {
            var xPos = obj.Pos.X - 30 * ((i + 1) / 2) * (i % 2 == 0 ? 1 : -1) -
                       Environment.Heart.Sprite.Size.Width / 2f;
            var yPos = obj.Pos.Y - 50 - Environment.Heart.Sprite.Size.Height / 2f;
            g.DrawImage(Environment.Heart.Sprite, xPos, yPos);
        }

        private void DrawGameObject(Graphics g, GameObject t)
        {
            g.DrawImage(t.Sprite, t.Pos.X - t.Sprite.Size.Width / 2f,
                t.Pos.Y - t.Sprite.Size.Height / 2f);
        }
    }
}