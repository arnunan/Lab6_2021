using System;
using System.Collections.Generic;
using CAFGame;
using NUnit.Framework;

namespace TestProject1
{
    public class EnemySpawnerTests
    {
        [Test]
        public void ClearAllSpots()
        {
            var es = new EnemySpawner();
            for (var i = 0; i < 8; i++)
                try
                {
                    es.SpawnEnemy();
                }
                catch (Exception e)
                {
                    var s = e.ToString();
                }

            es.MakeAllSpotsEmpty();
            var allSpotsEmpty = true;
            for (var i = 0; i < EnemySpawner.EnemySpots.Length; i++)
                if (EnemySpawner.EnemySpots[i].Item4)
                    allSpotsEmpty = false;

            Assert.True(allSpotsEmpty);
        }

        [Test]
        public void NoEmptySpots()
        {
            var es = new EnemySpawner();
            for (var i = 0; i < 8; i++)
                es.SpawnEnemy();

            Assert.AreEqual(new List<int>(), es.FindEmptySpots());
        }

        [TestCase(7)]
        [TestCase(6)]
        [TestCase(5)]
        [TestCase(4)]
        [TestCase(3)]
        [TestCase(2)]
        [TestCase(1)]
        [TestCase(0)]
        public void SomeEmptySpots(int enemyCount)
        {
            var es = new EnemySpawner();
            for (var i = 0; i < enemyCount; i++)
                es.SpawnEnemy();

            Assert.AreEqual(8 - enemyCount, es.FindEmptySpots().Count);
        }
    }
}