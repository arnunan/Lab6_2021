using System.Drawing;
using System.Numerics;

namespace CAFGame
{
    public class GameObject
    {
        public Vector2 Pos;
        public int Size;
        public Bitmap Sprite;

        public GameObject(Vector2 position, Bitmap sprite)
        {
            Pos = position;
            Sprite = sprite;
        }

        protected GameObject()
        {
        }
    }
}