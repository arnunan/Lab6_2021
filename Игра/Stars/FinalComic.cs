using System;
using Game;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace Stars
{
    public partial class FinalComic : Form
    {
        int _charIndex = 0;
        readonly string _text1 = "Спасибо тебе огромное за то, что помог мне собрать \nкосмиеский корабль заново. Только посмотри,\nкакой красивый получился!";
        readonly string _text2 = "За это время, пока я был здесь, я классно повеселился\nсо своими друзьями!\n\nКстати, забыл представить: это #4*@, +?^  и $!%.";
        readonly string _text3 = "А сейчас я должен лететь к себе домой, на Землю. \nНадеюсь, когда я опять сломаю свой космический\nкорабль, мы снова встретимся!";

        public FinalComic()
        {
            InitializeComponent();
            button1Onwards.FlatAppearance.BorderSize = 0; button1Onwards.FlatStyle = FlatStyle.Flat;
            button2Onwards.FlatAppearance.BorderSize = 0; button2Onwards.FlatStyle = FlatStyle.Flat;
            buttonFinishGame.FlatAppearance.BorderSize = 0; buttonFinishGame.FlatStyle = FlatStyle.Flat;
            buttonClose.FlatAppearance.BorderSize = 0; buttonClose.FlatStyle = FlatStyle.Flat;

            Load += (sender, args) => OnSizeChanged(EventArgs.Empty);
            SizeChanged += (sender, args) =>
            {
                pictureBox1.Location = new Point(ClientSize.Width * 78 / 1620, ClientSize.Height * 49 / 920);
                pictureBox2.Location = new Point(ClientSize.Width * 578 / 1620, ClientSize.Height * 49 / 920);
                pictureBox3.Location = new Point(ClientSize.Width * 1078 / 1620, ClientSize.Height * 49 / 920);
                label1.Location = new Point(ClientSize.Width * 78 / 1620, ClientSize.Height * 725 / 920);
                label2.Location = new Point(ClientSize.Width * 78 / 1620, ClientSize.Height * 725 / 920);
                label3.Location = new Point(ClientSize.Width * 78 / 1620, ClientSize.Height * 725 / 920);
                button1Onwards.Location = new Point(ClientSize.Width * 1275 / 1620, ClientSize.Height * 740 / 920);
                button2Onwards.Location = new Point(ClientSize.Width * 1275 / 1620, ClientSize.Height * 740 / 920);
                buttonFinishGame.Location = new Point(ClientSize.Width * 1275 / 1620, ClientSize.Height * 740 / 920);
            };
        }

        private void FinalComic_Load(object sender, EventArgs e)
        {
            _charIndex = 0;
            label1.Text = string.Empty;
            Thread timer = new Thread(new ThreadStart(this.TypewriteTextOne));
            timer.Start();
            label1.Visible = true;
        }

        private void Button1Onwards_Click(object sender, EventArgs e)
        {
            _charIndex = 0;
            label2.Text = string.Empty;
            Thread timer = new Thread(new ThreadStart(this.TypewriteTextTwo));
            timer.Start();

            button1Onwards.Visible = false;
            button2Onwards.Visible = true;
            label1.Visible = false;
            label2.Visible = true;
            pictureBox2.Visible = true;
        }

        private void Button2Onwards_Click(object sender, EventArgs e)
        {
            _charIndex = 0;
            label3.Text = string.Empty;
            Thread timer = new Thread(new ThreadStart(this.TypewriteTextThree));
            timer.Start();

            pictureBox3.Visible = true;
            button2Onwards.Visible = false;
            buttonFinishGame.Visible = true;
            label2.Visible = false;
            label3.Visible = true;
        }
        private void ButtonFinishGame_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TypewriteTextOne()
        {
            while (_charIndex < _text1.Length)
            {
                label1.Invoke(new Action(() =>
                {
                    label1.Text += _text1[_charIndex];
                }));
                _charIndex++;
            }
        }
        private void TypewriteTextTwo()
        {
            while (_charIndex < _text2.Length)
            {
                label2.Invoke(new Action(() =>
                {
                    label2.Text += _text2[_charIndex];
                }));
                _charIndex++;
            }
        }
        private void TypewriteTextThree()
        {
            while (_charIndex < _text3.Length)
            {
                label3.Invoke(new Action(() =>
                {
                    label3.Text += _text3[_charIndex];
                }));
                _charIndex++;
            }
        }
    }
}
