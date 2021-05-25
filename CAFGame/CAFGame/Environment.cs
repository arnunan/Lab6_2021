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

        public static GameObject BG = new GameObject(new Vector2(),
            new Bitmap("Assets\\Sprites\\BG.png"));

        public static GameObject TDSBG = new GameObject(new Vector2(),
            new Bitmap("Assets\\Sprites\\TDSBG.png"));

        public static GameObject PTBG = new GameObject(new Vector2(),
            new Bitmap("Assets\\Sprites\\PTBG.png"));

        public static GameObject SBG = new GameObject(new Vector2(),
            new Bitmap("Assets\\Sprites\\SBG.png"));

        public static GameObject MenuBG = new GameObject(new Vector2(),
            new Bitmap("Assets\\Sprites\\MenuBG.png"));

        public static GameObject Logo = new GameObject(new Vector2(),
            new Bitmap("Assets\\Sprites\\Logo.png"));

        public static GameObject Heart = new GameObject(new Vector2(),
            new Bitmap("Assets\\Sprites\\Heart.png"));

        public static GameObject Platform = new GameObject(new Vector2(),
            new Bitmap("Assets\\Sprites\\Platform.png"));

        public static GameObject RevolverDrum = new GameObject(new Vector2(),
            new Bitmap("Assets\\Sprites\\RevolverDrum.png"));

        public static GameObject RevolverBullet = new GameObject(new Vector2(),
            new Bitmap("Assets\\Sprites\\RevolverBullet.png"));


        public static TimeSpan DeltaTime;
        private static DateTime time = DateTime.Now;

        public static Vector2 PosRangeTopLeft = new Vector2(0 + 130, 0 + 125);
        public static Vector2 PosRangeBottomRight = new Vector2(1920 - 440, 1080 - 110);

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