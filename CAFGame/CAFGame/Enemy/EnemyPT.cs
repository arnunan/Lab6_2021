using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Numerics;

namespace CAFGame
{
    public class EnemyPT : Enemy
    {
        private readonly bool justSpawned;
        private readonly SoundPlayer shootSound;
        private Vector2 DirToShoot;

        public EnemyPT(float startX, float startY, Player target, int hp, Vector2 zoneCentre, bool justSpawned) : base(
            startX, startY, target, hp, zoneCentre)
        {
            var rand = new Random();

            ShootDelay = rand.Next(5000, 9000);
            ShootDelayTimer = 0;
            Speed = 1;
            DirToShoot = target.Pos - Pos;
            Sprite = new Bitmap("Assets\\Sprites\\EnemyPT.png");
            shootSound = new SoundPlayer("Assets\\Sounds\\Laser_Shoot14.wav");
            this.justSpawned = justSpawned;
            if (justSpawned)
            {
                MoveDelay = int.MaxValue;
                MoveDelayTimer = MoveDelay - 20;
            }
        }

        public override void Update(List<Bullet> bulletsPlayer, List<CannonProjectile> projPlayer)
        {
            CheckCollision(bulletsPlayer, projPlayer);
            if (justSpawned)
            {
                DirToShoot = Target.Pos - Pos;
                MoveTowardsPoint();
            }

            base.Update(bulletsPlayer, projPlayer);
        }

        protected override void Shoot()
        {
            var angle = CalculateAngle(CannonProjectile.StartSpeed);
            var multiplier = DirToShoot.X > 0 ? 1 : -1;

            if (double.IsNaN(angle)) return;
            var dir1 = new Vector2((float) Math.Cos(angle) * multiplier, (float) -Math.Sin(angle) * multiplier);

            if (Settings.SoundEnabled) shootSound.Play();
            Environment.CannonProjectileEnemy.Add(new CannonProjectile(dir1, Pos, "CannonProjEnemy", true));
        }

        public double CalculateAngle(double v)
        {
            var gravity = Environment.Gravity /
                          (1000 / (Environment.DeltaTime.Milliseconds == 0 ? 15f : Environment.DeltaTime.Milliseconds));
            var root = Math.Sqrt(v * v * v * v - gravity *
                                 (gravity * DirToShoot.X * DirToShoot.X +
                                  2 * -DirToShoot.Y * v * v));
            var angle1 = Math.Atan((v * v + root) / (gravity * DirToShoot.X));
            var angle2 = Math.Atan((v * v - root) / (gravity * DirToShoot.X));
            return Math.Abs(angle1) > Math.Abs(angle2) ? angle1 : angle2;
        }
    }
}