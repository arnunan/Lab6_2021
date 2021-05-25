using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Numerics;

namespace CAFGame
{
    public class EnemyTDS : Enemy
    {
        private static readonly int bulletSpeed = 3;
        private readonly SoundPlayer shootSound;

        public EnemyTDS(float startX, float startY, Player target, int hp, Vector2 zoneCentre) : base(startX, startY,
            target, hp, zoneCentre)
        {
            ShootDelay = 2000;
            ShootDelayTimer = 0;
            MoveDelayTimer = MoveDelay;
            Speed = 1;
            Sprite = new Bitmap("Assets\\Sprites\\EnemyTDS.png");
            shootSound = new SoundPlayer("Assets\\Sounds\\Laser_Shoot10.wav");
        }

        public override void Update(List<Bullet> bulletsPlayer, List<CannonProjectile> projPlayer)
        {
            MoveTowardsPoint();
            CheckCollision(bulletsPlayer, projPlayer);

            base.Update(bulletsPlayer, projPlayer);
        }

        protected override void Shoot()
        {
            if (Settings.SoundEnabled) shootSound.Play();
            Environment.BulletsEnemy.Add(new Bullet(Target.Pos - Pos, Pos, "BulletEnemy", bulletSpeed, true));
        }
    }
}