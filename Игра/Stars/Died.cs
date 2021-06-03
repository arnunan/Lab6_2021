using Game;
using System;
using System.Windows.Forms;

namespace Stars
{
    public partial class Died : Form
    {
        public Died()
        {
            InitializeComponent();
            button1.FlatAppearance.BorderSize = 0; button1.FlatStyle = FlatStyle.Flat;
        }
        private void CloseDied()
        {
            Close();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (Level1.currentLevelStatic == 1)
                CloseLevel(1);
            if (Level1.currentLevelStatic == 2)
                CloseLevel(2);
            if (Level1.currentLevelStatic == 3)
                CloseLevel(3);
            if (Level1.currentLevelStatic == 4)
                CloseLevel(4);
        }

        public void CloseLevel(int number)
        {
            CloseDied();
            Form1.BlackBGStatic.Close();

            if (number == 1)
                StarterComic.level1Static.RestartGame();
            if (number == 2)
                Level1.level2Static.RestartGame();
            if (number == 3)
                Level2.level3Static.RestartGame();
            if (number == 4)
                Level3.level4Static.RestartGame();
        }
    }
}
