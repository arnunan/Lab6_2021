using System.Drawing;
using System.Media;
using System.Numerics;
using System.Windows.Forms;

namespace CAFGame
{
    public class Button : GameObject
    {
        private readonly SoundPlayer clickSound;
        private readonly float scaleMultiplier = 1.2f;
        protected Size BaseSize = new Size(178, 50);
        protected Size CurrSize;
        protected Image Img;

        protected bool MouseDown;

        protected Button(Vector2 pos)
        {
            Pos = pos;
            CurrSize = BaseSize;
            clickSound = new SoundPlayer("Assets\\Sounds\\Blip_Select34.wav");
        }

        public void Update()
        {
            CheckMouseStay();
            CheckClickOnButton();
        }

        private void CheckClickOnButton()
        {
            if ((Control.MouseButtons & MouseButtons.Left) != 0 && MouseOnButton())
                ExecuteFunctionality();
            else MouseDown = false;
        }

        protected virtual void ExecuteFunctionality()
        {
            if (Settings.SoundEnabled) clickSound.Play();
        }

        private void CheckMouseStay()
        {
            if (MouseOnButton()) ScaleButtonUp();
            else if (!MouseOnButton()) ScaleButtonDown();
        }

        private void ScaleButtonUp()
        {
            CurrSize = new Size((int) (BaseSize.Width * scaleMultiplier), (int) (BaseSize.Height * scaleMultiplier));
            Sprite = new Bitmap(Img, CurrSize);
        }

        private void ScaleButtonDown()
        {
            CurrSize = BaseSize;
            Sprite = new Bitmap(Img, CurrSize);
        }

        private bool MouseOnButton()
        {
            return Control.MousePosition.X - Form1.desktopLocation.X < Pos.X + CurrSize.Width / 2f &&
                   Control.MousePosition.X - Form1.desktopLocation.X > Pos.X - CurrSize.Width / 2f &&
                   Control.MousePosition.Y - Form1.desktopLocation.Y < Pos.Y + CurrSize.Height / 2f &&
                   Control.MousePosition.Y - Form1.desktopLocation.Y > Pos.Y - CurrSize.Height / 2f;
        }
    }
}