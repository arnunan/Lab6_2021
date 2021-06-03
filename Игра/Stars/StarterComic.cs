using System;
using Game;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace Stars
{
    public partial class StarterComic : Form
    {
        int _charIndex = 0;
        public static Level1 level1Static = new Level1();
        readonly string _text1 = "Как-то раз мои друзья-инопланетяне позвали меня в гости \nна Луну, и я решил слетать туда на выходные.";
        readonly string _text2 = "Во время посадки на Луну приборы моего космического \nкорабля начали издавать странные звуки, а кнопка \nпреземления перестала работать...";
        readonly string _text3 = "К сожалению, мою ракету разорвало на части, и теперь \nя не могу вернуться к себе домой... Не могли бы вы \nпомочь мне собрать космический корабль заново?";
        public StarterComic()
        {
            InitializeComponent();
            button1Onwards.FlatAppearance.BorderSize = 0; button1Onwards.FlatStyle = FlatStyle.Flat;
            button2Onwards.FlatAppearance.BorderSize = 0; button2Onwards.FlatStyle = FlatStyle.Flat;
            buttonStartGame.FlatAppearance.BorderSize = 0; buttonStartGame.FlatStyle = FlatStyle.Flat;
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
                buttonStartGame.Location = new Point(ClientSize.Width * 1275 / 1620, ClientSize.Height * 740 / 920);
            };
        }

        private void StarterComic_Load(object sender, EventArgs e)
        {
            _charIndex = 0;
            label1.Text = string.Empty;
            Thread timer = new Thread(new ThreadStart(this.TypewriteTextOne));
            timer.Start();
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
            buttonStartGame.Visible = true;
            label2.Visible = false;
            label3.Visible = true; 
        }

        private void ButtonStartGame_Click(object sender, EventArgs e)
        {
            CloseThis();
            Level1 level1 = new Level1();
            level1Static = level1;
            level1Static.Show();
        }

        private void CloseThis()
        {
            Form1.StarterComicStatic.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
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
