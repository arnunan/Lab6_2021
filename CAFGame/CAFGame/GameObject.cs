using System.Drawing;
using System.Numerics;

namespace CAFGame
{
    public class GameObject
    {
        protected Image Img;
        public Vector2 Pos;
        public int Size;
        public Bitmap Sprite;
        public Size SpriteSize;

        public GameObject(Vector2 position, Bitmap sprite)
        {
            Pos = position;
            Img = sprite;
            ResizeSprite();
        }

        protected GameObject()
        {
        }

        protected void ResizeSprite()
        {
            SpriteSize = Img.Size;
            SpriteSize.Width = (int) (SpriteSize.Width * Environment.ScreenResolutionMultiplier.X);
            SpriteSize.Height = (int) (SpriteSize.Height * Environment.ScreenResolutionMultiplier.Y);
            Sprite = new Bitmap(Img, SpriteSize);
        }
    }
}