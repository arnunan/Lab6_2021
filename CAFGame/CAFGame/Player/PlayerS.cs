using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;

namespace CAFGame
{
    public class PlayerS : Player

    {
        private Vector2 lastMousePos;

        public PlayerS(float startX, float startY, int hp) : base(startX, startY)
        {
            Hp = hp;
            ShootDelay = 700;
            ShootDelayTimer = 0;
            lastMousePos = new Vector2(Control.MousePosition.X, Control.MousePosition.Y);
            Sprite = new Bitmap("Assets\\Sprites\\Aim.png");
        }

        public override void Update(List<Bullet> bulletEnemy, List<Enemy> enemies, List<CannonProjectile> projs)
        {
            CheckMovement();
            base.Update(new List<Bullet>(), new List<Enemy>(), new List<CannonProjectile>());
        }

        private void CheckMovement()
        {
            var currentMousePos = new Vector2(Control.MousePosition.X, Control.MousePosition.Y);
            var deltaMousePos = currentMousePos - lastMousePos;
            lastMousePos = currentMousePos;
            var newPos = Pos + deltaMousePos;
            if (newPos.X + Size > Environment.PosRangeBottomRight.X ||
                newPos.X - Size < Environment.PosRangeTopLeft.X)
                deltaMousePos.X = 0;
            if (newPos.Y + Size > Environment.PosRangeBottomRight.Y ||
                newPos.Y - Size < Environment.PosRangeTopLeft.Y)
                deltaMousePos.Y = 0;
            Pos += deltaMousePos;
        }

        protected override void Shoot()
        {
            var tempEnemies = new List<Enemy>();
            foreach (var item in Environment.Enemies)
                tempEnemies.Add(item);

            foreach (var e in tempEnemies)
                if (Math.Sqrt(Math.Pow(e.Pos.X - Pos.X, 2) + Math.Pow(e.Pos.Y - Pos.Y, 2)) < e.Size + Size)
                    e.TakeDmg();
        }
    }
}