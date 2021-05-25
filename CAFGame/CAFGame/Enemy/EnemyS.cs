using System.Collections.Generic;
using System.Drawing;
using System.Numerics;

namespace CAFGame
{
    public class EnemyS : Enemy
    {
        public EnemyS(float startX, float startY, Player target, int hp, Vector2 zoneCentre) : base(startX, startY,
            target, hp, zoneCentre)
        {
            ShootDelay = 6000;
            ShootDelayTimer = 0;
            Speed = 1;
            MoveDelayTimer = MoveDelay;
            Sprite = new Bitmap("Assets\\Sprites\\EnemyS.png");
        }

        public override void Update(List<Bullet> bulletsPlayer, List<CannonProjectile> projPlayer)
        {
            MoveTowardsPoint();

            base.Update(bulletsPlayer, projPlayer);
        }

        protected override void Shoot()
        {
            Target.TakeDmg();
        }
    }
}