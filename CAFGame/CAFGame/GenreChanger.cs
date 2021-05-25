using System;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;

namespace CAFGame
{
    public class GenreChanger
    {
        public static float GenreChangeTimer;
        private readonly float genreChangeDelay = 20_000;


        public void Update()
        {
            GenreChangeTimer += Environment.DeltaTime.Milliseconds;
            if (GenreChangeTimer >= genreChangeDelay)
            {
                GenreChangeTimer -= genreChangeDelay;
                ChangeGenre();
            }
        }

        private void ChangeGenre()
        {
            Environment.Player.Hp++;
            if (Environment.CurrentGenre == CurrentGenre.Tds) SwitchToS();
            else if (Environment.CurrentGenre == CurrentGenre.S) SwitchToPT();
            else if (Environment.CurrentGenre == CurrentGenre.Pt) SwitchToTDS();
        }

        public void SwitchToTDS()
        {
            Environment.CurrentGenre = CurrentGenre.Tds;
            Cursor.Show();
            Environment.Player =
                new PlayerTDS(Environment.Player.Pos.X, Environment.Player.Pos.Y, Environment.Player.Hp);

            Environment.ClearSpaceFromBullets();

            for (var i = 0; i < Environment.Enemies.Count; i++)
            {
                var j = EnemySpawner.FindEnemiesSpot(Environment.Enemies[i]);

                Environment.Enemies[i] = new EnemyTDS(Environment.Enemies[i].Pos.X, Environment.Enemies[i].Pos.Y,
                    Environment.Player, Environment.Enemies[i].Hp, Environment.Enemies[i].ZoneCentre);

                EnemySpawner.EnemySpots[j] = new Tuple<Vector2, Vector2, Enemy, bool>(EnemySpawner.EnemySpots[j].Item1,
                    EnemySpawner.EnemySpots[j].Item2, Environment.Enemies[i], true);
            }
        }

        public void SwitchToPT()
        {
            Environment.CurrentGenre = CurrentGenre.Pt;
            Cursor.Show();
            Environment.Player =
                new PlayerPT(Environment.Player.Pos.X, Environment.Player.Pos.Y, Environment.Player.Hp);

            Environment.ClearSpaceFromBullets();

            for (var i = 0; i < Environment.Enemies.Count; i++)
            {
                var j = EnemySpawner.FindEnemiesSpot(Environment.Enemies[i]);

                Environment.Enemies[i] = new EnemyPT(Environment.Enemies[i].Pos.X, Environment.Enemies[i].Pos.Y,
                    Environment.Player, Environment.Enemies[i].Hp, Environment.Enemies[i].ZoneCentre, false);

                EnemySpawner.EnemySpots[j] = new Tuple<Vector2, Vector2, Enemy, bool>(EnemySpawner.EnemySpots[j].Item1,
                    EnemySpawner.EnemySpots[j].Item2, Environment.Enemies[i], true);
            }
        }

        public void SwitchToS()
        {
            Environment.CurrentGenre = CurrentGenre.S;
            Cursor.Hide();
            Cursor.Position = new Point((int) Environment.Player.Pos.X, (int) Environment.Player.Pos.Y);

            Environment.Player = new PlayerS(Environment.Player.Pos.X, Environment.Player.Pos.Y, Environment.Player.Hp);

            Environment.ClearSpaceFromBullets();

            for (var i = 0; i < Environment.Enemies.Count; i++)
            {
                var j = EnemySpawner.FindEnemiesSpot(Environment.Enemies[i]);

                Environment.Enemies[i] = new EnemyS(Environment.Enemies[i].Pos.X, Environment.Enemies[i].Pos.Y,
                    Environment.Player, Environment.Enemies[i].Hp, Environment.Enemies[i].ZoneCentre);

                EnemySpawner.EnemySpots[j] = new Tuple<Vector2, Vector2, Enemy, bool>(EnemySpawner.EnemySpots[j].Item1,
                    EnemySpawner.EnemySpots[j].Item2, Environment.Enemies[i], true);
            }
        }
    }
}