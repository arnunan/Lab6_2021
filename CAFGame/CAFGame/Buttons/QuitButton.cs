using System.Drawing;
using System.Numerics;

namespace CAFGame
{
    public class QuitButton : Button
    {
        public QuitButton(Vector2 pos) : base(pos)
        {
            Img = new Bitmap("Assets\\Sprites\\QuitButton.png");
            Sprite = new Bitmap(Img, CurrSize);
        }

        protected override void ExecuteFunctionality()
        {
            base.ExecuteFunctionality();
            Form1.NeedToBeClosed = true;
        }
    }
}