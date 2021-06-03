using System;
using Game;
using System.Windows.Forms;

namespace Stars
{
    public partial class Settings : Form
    {        
        public Settings()
        {
            InitializeComponent();
            buttonBackToGame.FlatAppearance.BorderSize = 0; buttonBackToGame.FlatStyle = FlatStyle.Flat;
            buttonExitFromGame.FlatAppearance.BorderSize = 0; buttonExitFromGame.FlatStyle = FlatStyle.Flat;
        }
        private void CloseGame()
        {
            if (Level1.currentLevelStatic == 2)
                Level1.level2Static.Close();
            if (Level1.currentLevelStatic == 3)
                Level2.level3Static.Close();
            if (Level1.currentLevelStatic == 4)
                Level3.level4Static.Close();
        }

        private void ButtonBackToGame_Click(object sender, EventArgs e)
        {
            Level1.settingsStatic.Close();
            Form1.BlackBGStatic.Close();

            if (Level1.currentLevelStatic == 2)
            {
                Level1.level2Static.timer1.Start();
                Level1.level2Static.GameTimer.Start();
            }
            if (Level1.currentLevelStatic == 3)
            {
                Level2.level3Static.timer1.Start();
                Level2.level3Static.GameTimer.Start();
            }
            if (Level1.currentLevelStatic == 4)
            {
                Level3.level4Static.timer1.Start();
                Level3.level4Static.GameTimer.Start();
            }
        }

        private void ButtonExitFromGame_Click(object sender, EventArgs e)
        {
            CloseGame();
            Form1.BlackBGStatic.Close();
            Level1.settingsStatic.Close(); 
        }
    }
}
