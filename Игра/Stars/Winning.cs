using System;
using Game;
using System.Drawing;
using System.Windows.Forms;

namespace Stars
{
    public partial class Winning : Form
    {
        int score = Level1.scoreStatic;
        int time = Level1.timeStatic;

        public Bitmap picLevel1 = new Bitmap("Pics//picLevel1.jpg");
        public Bitmap picLevel2 = new Bitmap("Pics//picLevel2.jpg");
        public Bitmap picLevel3 = new Bitmap("Pics//picLevel3.jpg");
        public Bitmap picLevel4 = new Bitmap("Pics//picLevel4.jpg");

        public Winning()
        {
            InitializeComponent();
            labelPoints.Text = "- " + score.ToString() + " poins";
            labelSeonds.Text = "- " + time.ToString() + " sec";
            buttonGoToNextLevel.FlatAppearance.BorderSize = 0; buttonGoToNextLevel.FlatStyle = FlatStyle.Flat;
            buttonFinishGame.FlatAppearance.BorderSize = 0; buttonFinishGame.FlatStyle = FlatStyle.Flat;


            if (Level1.wonLevelStatic == 1)
            {
                BackgroundImage = picLevel1;
            }
            if (Level1.wonLevelStatic == 2)
            {
                BackgroundImage = picLevel2;
            }
            if (Level1.wonLevelStatic == 3)
            {
                BackgroundImage = picLevel3;
            }
            if (Level1.wonLevelStatic == 4)
            {
                buttonGoToNextLevel.Visible = false;
                buttonFinishGame.Visible = true;
                BackgroundImage = picLevel4;
            }
        }

        public void CloseThisLevel()
        {
            if (Level1.wonLevelStatic == 1)
                StarterComic.level1Static.Close();
            if (Level1.wonLevelStatic == 2)
                Level1.level2Static.Close();
            if (Level1.wonLevelStatic == 3)
                Level2.level3Static.Close();
            if (Level1.wonLevelStatic == 4)
                Level3.level4Static.Close();
        }

        public void OpenNewLevel()
        {
            if (Level1.wonLevelStatic == 1)
            {
                Level2 level2 = new Level2();
                Level1.level2Static = level2;
                Level1.level2Static.Show();
                Level1.currentLevelStatic = 2;
            }

            if (Level1.wonLevelStatic == 2)
            {
                Level3 level3 = new Level3();
                Level2.level3Static = level3;
                Level2.level3Static.Show();
                Level1.currentLevelStatic = 3;
            }

            if (Level1.wonLevelStatic == 3)
            {
                Level4 level4 = new Level4();
                Level3.level4Static = level4;
                Level3.level4Static.Show();
                Level1.currentLevelStatic = 4;
            }
        }
        private void ButtonGoToNextLevel_Click(object sender, EventArgs e)
        {
            Close();
            Form1.BlackBGStatic.Close();

            CloseThisLevel();
            OpenNewLevel();
        }

        private void ButtonFinishGame_Click(object sender, EventArgs e)
        {
            Close();
            Form1.BlackBGStatic.Close();

            CloseThisLevel();
            FinalComic finalComic = new FinalComic();
            Level4.finalComicStatic = finalComic;
            Level4.finalComicStatic.Show();
        }
    }
}
