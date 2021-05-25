using System;
using System.Collections.Generic;
using System.Media;
using System.Numerics;

namespace CAFGame
{
    public class Enemy : GameObject
    {
        public static int EnemyCost = 10;
        private readonly SoundPlayer deathSound;
        private readonly int deltaX = 100;
        private readonly int deltaY = 75;

        private readonly SoundPlayer hitSound;

        protected readonly Player Target;
        private Vector2 destPoint;
        public int Hp;

        protected float MoveDelay = 2000;
        protected float MoveDelayTimer;

        protected float ShootDelay;
        public float ShootDelayTimer;
        protected int Speed;

        public Vector2 ZoneCentre;

        protected Enemy(float startX, float startY, Player target, int hp, Vector2 zoneCentre)
        {
            Pos = new Vector2 {X = startX, Y = startY};
            Target = target;
            Size = 44;
            Hp = hp;
            ZoneCentre = zoneCentre;
            hitSound = new SoundPlayer("Assets\\Sounds\\Hit_Hurt3.wav");
            deathSound = new SoundPlayer("Assets\\Sounds\\Explosion16.wav");
        }

        public virtual void Update(List<Bullet> bulletsPlayer, List<CannonProjectile> projplayer)
        {
            TryToShoot();
        }

        private void TryToShoot()
        {
            ShootDelayTimer += Environment.DeltaTime.Milliseconds;
            if (ShootDelayTimer >= ShootDelay)
            {
                Shoot();
                ShootDelayTimer -= ShootDelay;
            }
        }

        protected virtual void Shoot()
        {
        }

        protected void MoveTowardsPoint()
        {
            MoveDelayTimer += Environment.DeltaTime.Milliseconds;
            TryToPickNewPosition();

            if (Math.Sqrt(Math.Pow(destPoint.X - Pos.X, 2) + Math.Pow(destPoint.Y - Pos.Y, 2)) > 5)
            {
                var dirVector = destPoint - Pos;
                Move(dirVector);
            }
        }

        private void TryToPickNewPosition()
        {
            if (MoveDelayTimer >= MoveDelay)
            {
                var rand = new Random();

                destPoint = new Vector2(rand.Next((int) ZoneCentre.X - deltaX, (int) ZoneCentre.X + deltaX),
                    rand.Next((int) ZoneCentre.Y - deltaY, (int) ZoneCentre.Y + deltaY));

                MoveDelayTimer -= MoveDelay;
            }
        }

        private void Move(Vector2 moveDir)
        {
            Pos += Vector2.Normalize(moveDir) * Speed * 100 /
                   (1000 / (Environment.DeltaTime.Milliseconds == 0
                        ? 15f
                        : Environment.DeltaTime.Milliseconds));
        }

        protected void CheckCollision(List<Bullet> bullets, List<CannonProjectile> projs)
        {
            foreach (var b in bullets)
                if (Environment.CheckCollision(this, b))
                    GetHit(b);
            foreach (var p in projs)
                if (Environment.CheckCollision(this, p))
                    GetHit(p);
        }

        private void GetHit(Bullet bullet)
        {
            TakeDmg();
            Environment.BulletsPlayer.Remove(bullet);
        }

        private void GetHit(CannonProjectile proj)
        {
            TakeDmg();
            Environment.CannonProjectilePlayer.Remove(proj);
        }

        public void TakeDmg()
        {
            Hp--;
            ShootDelayTimer -= 2000;
            if (Settings.SoundEnabled) hitSound.Play();
            if (Hp <= 0) Destroy();
        }

        public void Destroy()
        {
            Form1.Score += EnemyCost;
            if (Settings.SoundEnabled) deathSound.Play();
            Environment.Enemies.Remove(this);
            EnemySpawner.MakeSpotEmpty(this);
        }
    }
}