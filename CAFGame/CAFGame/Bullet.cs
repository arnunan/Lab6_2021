using System.Drawing;
using System.Numerics;

namespace CAFGame
{
    public class Bullet : GameObject
    {
        private const int DestroyDelay = 10000;

        private readonly bool enemyBullet;
        private readonly Vector2 moveDir;
        private readonly int speed;

        private int destroyDelayTimer;


        public Bullet(Vector2 dirVector, Vector2 startPos, string spriteName, int speed, bool enemyBullet)
        {
            moveDir = dirVector;
            Pos = startPos;
            this.speed = speed;

            this.enemyBullet = enemyBullet;
            Img = new Bitmap("Assets\\Sprites\\" + spriteName + ".png");
            Size = (Img.Width + Img.Height) / 4;
            ResizeSprite();
        }

        public void Update()
        {
            Move();

            destroyDelayTimer += Environment.DeltaTime.Milliseconds;
            if (destroyDelayTimer >= DestroyDelay)
            {
                if (enemyBullet)
                    Environment.BulletsEnemy.Remove(this);
                if (!enemyBullet)
                    Environment.BulletsPlayer.Remove(this);
            }
        }

        private void Move()
        {
            var deltaPos = Vector2.Normalize(moveDir) * speed * 100 /
                           (1000 / (Environment.DeltaTime.Milliseconds == 0
                                ? 15f
                                : Environment.DeltaTime.Milliseconds));
            deltaPos.X *= Environment.ScreenResolutionMultiplier.X;
            deltaPos.Y *= Environment.ScreenResolutionMultiplier.Y;
            Pos += deltaPos;
        }
    }
}