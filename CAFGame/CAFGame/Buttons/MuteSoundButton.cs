using System.Drawing;
using System.Numerics;

namespace CAFGame
{
    public class MuteSoundButton : Button
    {
        private readonly Image ImgMute = new Bitmap("Assets\\Sprites\\SoundButtonMute.png");
        private readonly Image ImgUnmute = new Bitmap("Assets\\Sprites\\SoundButtonUnmute.png");

        public MuteSoundButton(Vector2 pos) : base(pos)
        {
            BaseSize = new Size(50, 50);
            Img = ImgUnmute;
            Sprite = new Bitmap(Img, CurrSize);
        }

        protected override void ExecuteFunctionality()
        {
            if (MouseDown) return;
            Img = Settings.SoundEnabled ? ImgMute : ImgUnmute;
            Settings.SoundEnabled = !Settings.SoundEnabled;
            MouseDown = true;
            base.ExecuteFunctionality();
        }
    }
}