using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;

namespace CAFGame
{
    public static class Environment
    {
        public static readonly double Gravity = 10;

        public static List<Enemy> Enemies = new List<Enemy>();
        public static List<Bullet> BulletsEnemy = new List<Bullet>();
        public static List<Bullet> BulletsPlayer = new List<Bullet>();
        public static List<CannonProjectile> CannonProjectilePlayer = new List<CannonProjectile>();
        public static List<CannonProjectile> CannonProjectileEnemy = new List<CannonProjectile>();
        public static List<Button> MenuButtons = new List<Button>();

        public static Player Player;

        public static CurrentGenre CurrentGenre = CurrentGenre.Tds;
        public static GameState GameState;

        public static Point desktopLocation;

        public static Rectangle ScreenResolution = new Rectangle {Width = 1280, Height = 720};
        public static Vector2 BaseScreenResolution = new Vector2(1920, 1080);

        public static Vector2 ScreenResolutionMultiplier = new Vector2(ScreenResolution.Width / BaseScreenResolution.X,
            ScreenResolution.Height / BaseScreenResolution.Y);


        public static GameObject BG;
        public static GameObject TDSBG;
        public static GameObject PTBG;
        public static GameObject SBG;
        public static GameObject MenuBG;
        public static GameObject Logo;
        public static GameObject Heart;
        public static GameObject Platform;
        public static GameObject RevolverDrum;
        public static GameObject RevolverBullet;


        public static TimeSpan DeltaTime;
        private static DateTime time = DateTime.Now;

        public static Vector2 PosRangeTopLeft =
            new Vector2(0 + 130 * ScreenResolutionMultiplier.X, 0 + 125 * ScreenResolutionMultiplier.Y);

        public static Vector2 PosRangeBottomRight =
            new Vector2(ScreenResolution.Width - 440 * ScreenResolutionMultiplier.X,
                ScreenResolution.Height - 110 * ScreenResolutionMultiplier.Y);

        public static void RecalculateScreenParameters(Rectangle resolution)
        {
            ScreenResolution = resolution;
            ScreenResolutionMultiplier = new Vector2(ScreenResolution.Width / BaseScreenResolution.X,
                (ScreenResolution.Height + 40) / BaseScreenResolution.Y);
            PosRangeTopLeft = new Vector2(0 + 130 * ScreenResolutionMultiplier.X,
                0 + 125 * ScreenResolutionMultiplier.Y);
            PosRangeBottomRight = new Vector2(ScreenResolution.Width - 440 * ScreenResolutionMultiplier.X,
                ScreenResolution.Height - 110 * ScreenResolutionMultiplier.Y);
        }

        public static void InitializeGameObjects()
        {
            BG = new GameObject(new Vector2(), new Bitmap("Assets\\Sprites\\BG.png"));
            TDSBG = new GameObject(new Vector2(), new Bitmap("Assets\\Sprites\\TDSBG.png"));
            PTBG = new GameObject(new Vector2(), new Bitmap("Assets\\Sprites\\PTBG.png"));
            SBG = new GameObject(new Vector2(), new Bitmap("Assets\\Sprites\\SBG.png"));
            MenuBG = new GameObject(new Vector2(), new Bitmap("Assets\\Sprites\\MenuBG.png"));
            Logo = new GameObject(new Vector2(), new Bitmap("Assets\\Sprites\\Logo.png"));
            Heart = new GameObject(new Vector2(), new Bitmap("Assets\\Sprites\\Heart.png"));
            Platform = new GameObject(new Vector2(), new Bitmap("Assets\\Sprites\\Platform.png"));
            RevolverDrum = new GameObject(new Vector2(), new Bitmap("Assets\\Sprites\\RevolverDrum.png"));
            RevolverBullet = new GameObject(new Vector2(), new Bitmap("Assets\\Sprites\\RevolverBullet.png"));
        }


        public static void Update()
        {
            DeltaTime = DateTime.Now - time;
            time = DateTime.Now;
        }

        public static void ClearSpaceFromBullets()
        {
            CannonProjectileEnemy.Clear();
            CannonProjectilePlayer.Clear();
            BulletsEnemy.Clear();
            BulletsPlayer.Clear();
        }

        public static void ClearSpaceFromButtons()
        {
            MenuButtons.Clear();
        }

        public static void ClearSpaceFromEnemies()
        {
            Enemies.Clear();
        }

        public static bool CheckCollision(GameObject thisObj, GameObject otherObj)
        {
            return Math.Sqrt(Math.Pow(otherObj.Pos.X - thisObj.Pos.X, 2) +
                             Math.Pow(otherObj.Pos.Y - thisObj.Pos.Y, 2)) < thisObj.Size + otherObj.Size &&
                   otherObj != thisObj;
        }
    }
}