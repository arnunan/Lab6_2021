using System.Drawing;
using System.Numerics;

namespace CAFGame
{
    public class PlayButton : Button
    {
        public PlayButton(Vector2 pos) : base(pos)
        {
            Img = new Bitmap("Assets\\Sprites\\PlayButton.png");

            Sprite = new Bitmap(Img, CurrSize);
        }

        protected override void ExecuteFunctionality()
        {
            Form1.StartGame();
            base.ExecuteFunctionality();
        }
    }
}