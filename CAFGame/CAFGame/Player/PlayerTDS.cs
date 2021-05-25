using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Numerics;
using System.Windows.Forms;

namespace CAFGame
{
    public class PlayerTDS : Player
    {
        private static readonly int bulletSpeed = 4;
        private readonly SoundPlayer shootSound;
        private readonly int speed;

        public PlayerTDS(float startX, float startY, int hp) : base(startX, startY)
        {
            Hp = hp;
            speed = 7;
            ShootDelay = 1500;
            ShootDelayTimer = 0;
            Sprite = new Bitmap("Assets\\Sprites\\PlayerTDS.png");
            shootSound = new SoundPlayer("Assets\\Sounds\\Laser_Shoot9.wav");
        }

        public override void Update(List<Bullet> bulletEnemy, List<Enemy> enemies, List<CannonProjectile> projs)
        {
            CheckMovement();
            base.Update(bulletEnemy, enemies, projs);
        }

        protected override void Shoot()
        {
            if (Settings.SoundEnabled) shootSound.Play();
            Environment.BulletsPlayer.Add(new Bullet(
                new Vector2(Control.MousePosition.X - Form1.desktopLocation.X,
                    Control.MousePosition.Y - Form1.desktopLocation.Y) - Pos, Pos, "BulletPlayer", bulletSpeed, false));
        }

        private void CheckMovement()
        {
            var moveDir = new Vector2(0, 0);

            if (Form1.IsWdown) moveDir.Y = -1;
            if (Form1.IsAdown) moveDir.X = -1;
            if (Form1.IsSdown) moveDir.Y = 1;
            if (Form1.IsDdown) moveDir.X = 1;

            if (moveDir.X != 0 || moveDir.Y != 0)
                Move(moveDir);
        }

        public void Move(Vector2 moveDir)
        {
            var deltaPos = Vector2.Normalize(moveDir) * speed * 100 /
                           (1000 / (Environment.DeltaTime.Milliseconds == 0
                                ? 15f
                                : Environment.DeltaTime.Milliseconds));
            var newPos = Pos + deltaPos;

            if (newPos.X + Size > Environment.PosRangeBottomRight.X ||
                newPos.X - Size < Environment.PosRangeTopLeft.X)
                deltaPos.X = 0;
            if (newPos.Y + Size > Environment.PosRangeBottomRight.Y ||
                newPos.Y - Size < Environment.PosRangeTopLeft.Y)
                deltaPos.Y = 0;
            Pos += deltaPos;
        }
    }
}