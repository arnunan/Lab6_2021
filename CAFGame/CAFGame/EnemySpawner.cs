using System;
using System.Collections.Generic;
using System.Numerics;

namespace CAFGame
{
    public class EnemySpawner
    {
        private static int spawnedCount;

        private static readonly Vector2[] SpawnPoints =
        {
            new Vector2(801, 0), // Up
            new Vector2(801, 1080), // Down
            new Vector2(1605, 540), // Right
            new Vector2(0, 540) // Left
        };

        public static Tuple<Vector2, Vector2, Enemy, bool>[] EnemySpots =
        {
            new Tuple<Vector2, Vector2, Enemy, bool>(new Vector2(400, 300), SpawnPoints[3], null, false), //UpLeft
            new Tuple<Vector2, Vector2, Enemy, bool>(new Vector2(800, 300), SpawnPoints[0], null, false), //Up
            new Tuple<Vector2, Vector2, Enemy, bool>(new Vector2(1250, 300), SpawnPoints[0], null, false), //UpRight
            new Tuple<Vector2, Vector2, Enemy, bool>(new Vector2(1250, 545), SpawnPoints[2], null, false), //Right
            new Tuple<Vector2, Vector2, Enemy, bool>(new Vector2(1250, 830), SpawnPoints[2], null, false), //DownRight
            new Tuple<Vector2, Vector2, Enemy, bool>(new Vector2(800, 830), SpawnPoints[1], null, false), //Down
            new Tuple<Vector2, Vector2, Enemy, bool>(new Vector2(400, 830), SpawnPoints[1], null, false), //DownLeft
            new Tuple<Vector2, Vector2, Enemy, bool>(new Vector2(400, 545), SpawnPoints[3], null, false) //Left
        };

        private readonly float makeItHarderDelay = 40000;
        private float makeItHarderTimer;

        private float spawnDelay = 7000;
        private float spawnTimer = 6000;

        public EnemySpawner()
        {
            MakeAllSpotsEmpty();
        }

        public void Update()
        {
            spawnTimer += Environment.DeltaTime.Milliseconds;
            if (spawnTimer >= spawnDelay)
            {
                spawnTimer -= spawnDelay;

                SpawnEnemy();
            }

            makeItHarderTimer += Environment.DeltaTime.Milliseconds;
            if (makeItHarderTimer >= makeItHarderDelay)
            {
                makeItHarderTimer -= makeItHarderDelay;
                Enemy.EnemyCost += 5;
                if (spawnDelay > 2500) spawnDelay -= 1000;
            }
        }

        public void SpawnEnemy()
        {
            if (Environment.Enemies.Count == EnemySpots.Length) return;
            var emptySpots = FindEmptySpots();
            if (emptySpots.Count == 0) return;

            var rand = new Random();
            var index0 = rand.Next(0, EnemySpots.Length);

            while (!emptySpots.Contains(index0)) index0 = spawnedCount++ % 8;

            if (Environment.CurrentGenre == CurrentGenre.Tds)
            {
                var newEnemyTds = new EnemyTDS(EnemySpots[index0].Item2.X, EnemySpots[index0].Item2.Y,
                    Environment.Player, 3, EnemySpots[index0].Item1);

                Environment.Enemies.Add(newEnemyTds);

                EnemySpots[index0] = new Tuple<Vector2, Vector2, Enemy, bool>(EnemySpots[index0].Item1,
                    EnemySpots[index0].Item2, newEnemyTds, true);
            }
            else if (Environment.CurrentGenre == CurrentGenre.Pt)
            {
                var newEnemyPt = new EnemyPT(EnemySpots[index0].Item2.X, EnemySpots[index0].Item2.Y,
                    Environment.Player, 3, EnemySpots[index0].Item1, true);

                Environment.Enemies.Add(newEnemyPt);

                EnemySpots[index0] = new Tuple<Vector2, Vector2, Enemy, bool>(EnemySpots[index0].Item1,
                    EnemySpots[index0].Item2, newEnemyPt, true);
            }
            else if (Environment.CurrentGenre == CurrentGenre.S)
            {
                var newEnemyS = new EnemyS(EnemySpots[index0].Item2.X, EnemySpots[index0].Item2.Y,
                    Environment.Player, 3, EnemySpots[index0].Item1);

                Environment.Enemies.Add(newEnemyS);

                EnemySpots[index0] = new Tuple<Vector2, Vector2, Enemy, bool>(EnemySpots[index0].Item1,
                    EnemySpots[index0].Item2, newEnemyS, true);
            }

            spawnedCount++;
        }

        public List<int> FindEmptySpots()
        {
            var result = new List<int>();
            for (var i = 0; i < EnemySpots.Length; i++)
                if (!EnemySpots[i].Item4)
                    result.Add(i);

            return result;
        }

        public static void MakeSpotEmpty(Enemy enemy)
        {
            var i = FindEnemiesSpot(enemy);

            EnemySpots[i] = new Tuple<Vector2, Vector2, Enemy, bool>(EnemySpots[i].Item1,
                EnemySpots[i].Item2, null, false);
        }

        public void MakeAllSpotsEmpty()
        {
            Environment.ClearSpaceFromEnemies();
            for (var i = 0; i < EnemySpots.Length; i++)
                EnemySpots[i] =
                    new Tuple<Vector2, Vector2, Enemy, bool>(EnemySpots[i].Item1, EnemySpots[i].Item2, null, false);
        }

        public static int FindEnemiesSpot(Enemy enemy)
        {
            for (var i = 0; i < EnemySpots.Length; i++)
                if (EnemySpots[i].Item3 == enemy)
                    return i;

            return -1;
        }
    }
}