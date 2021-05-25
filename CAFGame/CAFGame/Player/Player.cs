using System.Collections.Generic;
using System.Media;
using System.Numerics;
using System.Windows.Forms;

namespace CAFGame
{
    public class Player : GameObject
    {
        private readonly SoundPlayer hitSound;
        public int Hp;
        protected float ShootDelay;
        protected float ShootDelayTimer;

        protected Player(float startX, float startY)
        {
            Pos = new Vector2(startX, startY);
            Size = 44;
            Hp = 3;
            hitSound = new SoundPlayer("Assets\\Sounds\\Hit_Hurt9.wav");
        }

        public virtual void Update(List<Bullet> bulletEnemy, List<Enemy> enemies, List<CannonProjectile> projs)
        {
            TryToShoot();
            CheckCollision(bulletEnemy, enemies, projs);
        }

        private void TryToShoot()
        {
            if (ShootDelayTimer < ShootDelay)
                ShootDelayTimer += Environment.DeltaTime.Milliseconds;
            if (ShootDelayTimer >= ShootDelay && (Control.MouseButtons & MouseButtons.Left) != 0)
            {
                Shoot();
                ShootDelayTimer -= ShootDelay;
            }
        }

        protected virtual void Shoot()
        {
        }

        private void CheckCollision(List<Bullet> bullets, List<Enemy> enemies, List<CannonProjectile> projs)
        {
            foreach (var b in bullets)
                if (Environment.CheckCollision(this, b))
                    CollisionWithBullet(b);
            foreach (var e in enemies)
                if (Environment.CheckCollision(this, e))
                    CollisionWithEnemy(e);
            foreach (var p in projs)
                if (Environment.CheckCollision(this, p))
                    CollisionWithEnemyProj(p);
        }

        private void CollisionWithEnemy(Enemy enemy)
        {
            enemy.Destroy();
            TakeDmg();
        }

        private void CollisionWithBullet(Bullet bullet)
        {
            Environment.BulletsEnemy.Remove(bullet);
            TakeDmg();
        }

        private void CollisionWithEnemyProj(CannonProjectile proj)
        {
            Environment.CannonProjectileEnemy.Remove(proj);
            TakeDmg();
        }

        public void TakeDmg()
        {
            Hp--;
            if (Settings.SoundEnabled) hitSound.Play();
            if (Hp <= 0) Form1.OnPlayersDeath();
        }
    }
}