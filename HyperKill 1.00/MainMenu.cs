using System;
using System.Drawing;
using System.Windows.Forms;

namespace HyperKill
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {                    
            InitializeComponent();
            MaximumSize = Screen.PrimaryScreen.Bounds.Size;
        }

        private void PlayButton(object sender, EventArgs e)
        {           
            var gameField = new GameForm();
            Hide();
            gameField.Show();                        
        }

        private void ExitButton(object sender, EventArgs e) => Application.Exit();        
    }
}
