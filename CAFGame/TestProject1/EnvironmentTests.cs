using System.Numerics;
using CAFGame;
using NUnit.Framework;

namespace TestProject1
{
    public class EnvironmentTests
    {
        [Test]
        public void Collision()
        {
            var player = new PlayerTDS(0, 0, 3);
            var enemy = new EnemyTDS(0, 0, player, 3, new Vector2(0, 0));
            var result = Environment.CheckCollision(player, enemy);
            Assert.True(result);
        }

        [Test]
        public void NoCollisions()
        {
            var player = new PlayerTDS(0, 0, 3);
            var enemy = new EnemyTDS(1000, 1000, player, 3, new Vector2(0, 0));
            var result = Environment.CheckCollision(player, enemy);
            Assert.False(result);
        }

        [Test]
        public void NoCollisionsVeryClose()
        {
            var player = new PlayerTDS(0, 0, 3);
            var enemy = new EnemyTDS(0, 0, player, 3, new Vector2(0, 0));

            var dist = player.Size + enemy.Size;
            enemy.Pos = new Vector2(dist, 0);

            var result = Environment.CheckCollision(player, enemy);
            Assert.False(result);
        }

        [Test]
        public void CollisionVeryClose()
        {
            var player = new PlayerTDS(0, 0, 3);
            var enemy = new EnemyTDS(0, 0, player, 3, new Vector2(0, 0));

            var dist = player.Size + enemy.Size;
            enemy.Pos = new Vector2(dist - 1, 0);

            var result = Environment.CheckCollision(player, enemy);
            Assert.True(result);
        }
    }
}