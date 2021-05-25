using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Numerics;
using System.Windows.Forms;

namespace CAFGame
{
    public class PlayerPT : Player
    {
        private readonly SoundPlayer shootSound;
        private bool SpriteOrientationRight = true;


        public PlayerPT(float startX, float startY, int hp) : base(startX, startY)
        {
            Hp = hp;
            ShootDelay = 1500;
            ShootDelayTimer = 0;
            Sprite = new Bitmap("Assets\\Sprites\\PlayerPT.png");
            shootSound = new SoundPlayer("Assets\\Sounds\\Laser_Shoot14.wav");
        }

        public override void Update(List<Bullet> bulletEnemy, List<Enemy> enemies, List<CannonProjectile> projs)
        {
            CheckSpriteOrientation();
            base.Update(bulletEnemy, enemies, projs);
        }

        private void CheckSpriteOrientation()
        {
            if (Pos.X < Control.MousePosition.X && !SpriteOrientationRight)
                ChangeSpriteOrientation();
            else if (Pos.X > Control.MousePosition.X && SpriteOrientationRight)
                ChangeSpriteOrientation();
        }

        private void ChangeSpriteOrientation()
        {
            Sprite.RotateFlip(RotateFlipType.RotateNoneFlipX);
            SpriteOrientationRight = !SpriteOrientationRight;
        }

        protected override void Shoot()
        {
            if (Settings.SoundEnabled) shootSound.Play();
            Environment.CannonProjectilePlayer.Add(new CannonProjectile(
                new Vector2(Control.MousePosition.X, Control.MousePosition.Y) - Pos, Pos, "CannonProjPlayer", false));
        }
    }
}