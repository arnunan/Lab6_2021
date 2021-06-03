using System;
using System.Windows.Forms;

namespace Stars
{
    public partial class BlackBackground : Form
    {
        public BlackBackground()
        {
            InitializeComponent();

            Load += (sender, args) => OnSizeChanged(EventArgs.Empty);
            SizeChanged += (sender, args) =>
            {
                label1.Location = new System.Drawing.Point(ClientSize.Width * 12 / 1620, ClientSize.Height * 862 / 920);
            };
        }
    }
}
