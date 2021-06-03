using System;
using Game;
using System.Windows.Forms;
using System.Drawing;

namespace Stars
{
    public partial class SettingsFromMenu : Form
    {
        public SettingsFromMenu()
        {
            InitializeComponent();
            buttonExit.FlatAppearance.BorderSize = 0; buttonExit.FlatStyle = FlatStyle.Flat;
            buttonOn.FlatAppearance.BorderSize = 0; buttonOn.FlatStyle = FlatStyle.Flat;
            buttonOff.FlatAppearance.BorderSize = 0; buttonOff.FlatStyle = FlatStyle.Flat;

            if (Form1.musicOnOff == "on")
            {
                buttonOn.Visible = true;
                buttonOff.Visible = false;
            }
            else
            {
                buttonOn.Visible = false;
                buttonOff.Visible = true;
            }

            Load += (sender, args) => OnSizeChanged(EventArgs.Empty);
            SizeChanged += (sender, args) =>
            {
                pictureBoxNameSettings.Location = new Point(ClientSize.Width * 515 / 1620, ClientSize.Height * 48 / 920);
                pictureBoxSound.Location = new Point(ClientSize.Width * 515 / 1620, ClientSize.Height * 396 / 920);
                buttonExit.Location = new Point(ClientSize.Width * 640 / 1620, ClientSize.Height * 693 / 920);
                buttonOff.Location = new Point(ClientSize.Width * 931 / 1620, ClientSize.Height * 401 / 920);
                buttonOn.Location = new Point(ClientSize.Width * 931 / 1620, ClientSize.Height * 401 / 920);
            };
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonOn_Click(object sender, EventArgs e)
        {
            buttonOff.Visible = true;
            buttonOn.Visible = false;            
            Form1.song.Stop();
            Form1.musicOnOff = "off";
        }

        private void ButtonOff_Click(object sender, EventArgs e)
        {
            buttonOn.Visible = true;
            buttonOff.Visible = false;
            Form1.song.Play();
            Form1.musicOnOff = "on";
        }
    }
}
