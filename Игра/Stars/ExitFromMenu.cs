using System;
using Game;
using System.Windows.Forms;

namespace Stars
{
    public partial class ExitFromMenu : Form
    {
        public ExitFromMenu()
        {
            InitializeComponent();
            buttonYes.FlatAppearance.BorderSize = 0; buttonYes.FlatStyle = FlatStyle.Flat;
            buttonNo.FlatAppearance.BorderSize = 0; buttonNo.FlatStyle = FlatStyle.Flat;
        }

        private void ButtonYes_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void ButtonNo_Click(object sender, EventArgs e)
        {
            Form1.BlackBGStatic.Close();
            Form1.ExitStatic.Close(); 
            Close();
        }
    }
}
