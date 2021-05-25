using System.Numerics;
using CAFGame;
using NUnit.Framework;

namespace TestProject1
{
    public class GameFieldBorders
    {
        [Test]
        public void RightBorder()
        {
            var player = new PlayerTDS(0, 0, 3);
            var startPos = new Vector2(Environment.PosRangeBottomRight.X - player.Size, 500);
            player.Pos = startPos;
            player.Move(new Vector2(1, 0));
            Assert.AreEqual(startPos, player.Pos);
        }

        [Test]
        public void LeftBorder()
        {
            var player = new PlayerTDS(0, 0, 3);
            var startPos = new Vector2(Environment.PosRangeTopLeft.X + player.Size, 500);
            player.Pos = startPos;
            player.Move(new Vector2(-1, 0));
            Assert.AreEqual(startPos, player.Pos);
        }

        [Test]
        public void TopBorder()
        {
            var player = new PlayerTDS(0, 0, 3);
            var startPos = new Vector2(500, Environment.PosRangeTopLeft.Y + player.Size);
            player.Pos = startPos;
            player.Move(new Vector2(0, -1));
            Assert.AreEqual(startPos, player.Pos);
        }

        [Test]
        public void BottomBorder()
        {
            var player = new PlayerTDS(0, 0, 3);
            var startPos = new Vector2(500, Environment.PosRangeBottomRight.Y - player.Size);
            player.Pos = startPos;
            player.Move(new Vector2(0, 1));
            Assert.AreEqual(startPos, player.Pos);
        }

        [Test]
        public void BottomRightCorner()
        {
            var player = new PlayerTDS(0, 0, 3);
            var startPos = new Vector2(Environment.PosRangeBottomRight.X - player.Size,
                Environment.PosRangeBottomRight.Y - player.Size);
            player.Pos = startPos;
            player.Move(new Vector2(1, 1));
            Assert.AreEqual(startPos, player.Pos);
        }

        [Test]
        public void BottomLeftCorner()
        {
            var player = new PlayerTDS(0, 0, 3);
            var startPos = new Vector2(Environment.PosRangeTopLeft.X + player.Size,
                Environment.PosRangeBottomRight.Y - player.Size);
            player.Pos = startPos;
            player.Move(new Vector2(-1, 1));
            Assert.AreEqual(startPos, player.Pos);
        }

        [Test]
        public void TopLeftCorner()
        {
            var player = new PlayerTDS(0, 0, 3);
            var startPos = new Vector2(Environment.PosRangeTopLeft.X + player.Size,
                Environment.PosRangeTopLeft.Y + player.Size);
            player.Pos = startPos;
            player.Move(new Vector2(-1, -1));
            Assert.AreEqual(startPos, player.Pos);
        }

        [Test]
        public void TopRightCorner()
        {
            var player = new PlayerTDS(0, 0, 3);
            var startPos = new Vector2(Environment.PosRangeBottomRight.X - player.Size,
                Environment.PosRangeTopLeft.Y + player.Size);
            player.Pos = startPos;
            player.Move(new Vector2(1, -1));
            Assert.AreEqual(startPos, player.Pos);
        }
    }
}