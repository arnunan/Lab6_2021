using System;
using System.Numerics;
using CAFGame;
using NUnit.Framework;

namespace TestProject1
{
    public class EnemyPtTests
    {
        [Test]
        public void TargetAbove()
        {
            var player = new PlayerPT(100, 0, 3);
            var enemy = new EnemyPT(100, 50, player, 3, new Vector2(100, 50), false);
            var angle = enemy.CalculateAngle(CannonProjectile.StartSpeed);
            var expected = Math.PI / 2f;
            Assert.AreEqual(expected, Math.Abs(angle));
        }

        [Test]
        public void TargetBelow()
        {
            var player = new PlayerPT(100, 50, 3);
            var enemy = new EnemyPT(100, 0, player, 3, new Vector2(100, 0), false);
            var angle = enemy.CalculateAngle(CannonProjectile.StartSpeed);
            var expected = Math.PI / 2f;
            Assert.AreEqual(expected, Math.Abs(angle));
        }

        [Test]
        public void TargetUnreachable()
        {
            var player = new PlayerPT(0, 0, 3);
            var enemy = new EnemyPT(10000, 0, player, 3, new Vector2(0, 0), false);
            var angle = enemy.CalculateAngle(CannonProjectile.StartSpeed);
            Assert.IsNaN(angle);
        }

        [Test]
        public void LongestDistance()
        {
            var player = new PlayerPT(666, 0, 3);
            var enemy = new EnemyPT(0, 0, player, 3, new Vector2(0, 0), false);
            var angle = enemy.CalculateAngle(CannonProjectile.StartSpeed);
            var expected = 0.80776028080155959366d;

            Assert.AreEqual(expected, Math.Abs(angle));
        }
    }
}