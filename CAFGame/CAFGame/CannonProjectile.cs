using System.Collections.Generic;
using System.Drawing;
using System.Numerics;

namespace CAFGame
{
    public class CannonProjectile : GameObject
    {
        public static float StartSpeed = 10;
        private readonly int destroyDelay = 10000;

        private readonly bool enemyProjectile;

        private int destroyDelayTimer;
        private Vector2 moveDir;

        public CannonProjectile(Vector2 dirVector, Vector2 startPos, string spriteName, bool enemyProjectile)
        {
            Size = 16;
            moveDir = Vector2.Normalize(dirVector) * StartSpeed;
            Pos = startPos;
            this.enemyProjectile = enemyProjectile;
            Sprite = new Bitmap("Assets\\Sprites\\" + spriteName + ".png");
        }

        public void Update(List<CannonProjectile> projplayer, List<CannonProjectile> projenemy)
        {
            ChangeMoveDir();
            CheckCollision(projplayer, projenemy);
            Move();

            destroyDelayTimer += Environment.DeltaTime.Milliseconds;
            if (destroyDelayTimer >= destroyDelay)
            {
                if (enemyProjectile)
                    Environment.CannonProjectileEnemy.Remove(this);
                if (!enemyProjectile)
                    Environment.CannonProjectilePlayer.Remove(this);
            }
        }

        private void Move()
        {
            Pos += moveDir;
        }

        private void ChangeMoveDir()
        {
            var deltaTimeMilliseconds = Environment.DeltaTime.Milliseconds / 1000f;
            moveDir.Y += (float) Environment.Gravity * deltaTimeMilliseconds;
        }

        private void CheckCollision(List<CannonProjectile> projsPlayer, List<CannonProjectile> projsEnemy)
        {
            foreach (var p in projsPlayer)
                if (Environment.CheckCollision(this, p))
                    CollisionWithPlayerProj(p);
            foreach (var p in projsEnemy)
                if (Environment.CheckCollision(this, p))
                    CollisionWithEnemyProj(p);
        }

        private void CollisionWithEnemyProj(CannonProjectile proj)
        {
            Environment.CannonProjectileEnemy.Remove(this);
            Environment.CannonProjectileEnemy.Remove(proj);
        }

        private void CollisionWithPlayerProj(CannonProjectile proj)
        {
            Environment.CannonProjectilePlayer.Remove(proj);
            Environment.CannonProjectileEnemy.Remove(this);
        }
    }
}