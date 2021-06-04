using System;
using System.Windows.Forms;
using HyperKill.Player;
using HyperKill.Entities;
using System.Threading;
using System.IO;

namespace HyperKill
{
    public partial class GameForm : Form
    {       
        private PlayerData playerInfo = new PlayerData();        
        private bool overHeatFlag  = false;
        private bool noShootTimeFlag = false;
        private int counterBigMagazine = 0;
        private int killScore;     

        public GameForm()
        {   
            DoubleBuffered = true;
            InitializeComponent();
            MaximumSize = Screen.PrimaryScreen.Bounds.Size;
            GameRestart();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }        

        private void TimerEvent(object sender, EventArgs e)
        {                
            if (playerInfo.HeroHealth > 1) HealthBar.Value = playerInfo.HeroHealth;
            else { playerInfo.EndGame = true; Hero.Image = Properties.Resources.death; MainTimer.Stop(); } 

            KillCounter.Text = "K I L L S \n" + killScore;

            if (playerInfo.Left == true && Hero.Left > 10) Hero.Left -= playerInfo.Speed;
            if (playerInfo.Up == true && Hero.Top > 50)    Hero.Top  -= playerInfo.Speed;
            if (playerInfo.Right == true && Hero.Left + Hero.Width < ClientSize.Width - 10) Hero.Left += playerInfo.Speed;            
            if (playerInfo.Down == true && Hero.Top + Hero.Height < ClientSize.Height - 10) Hero.Top  += playerInfo.Speed;

            foreach (Control ctrl in Controls)
            {
                CreateCollision(ctrl, "fewHealth", 20);
                CreateCollision(ctrl, "fewAmmo", 25);
                CreateCollision(ctrl, "bigMagazine", -25);

                if (ctrl is PictureBox && (string)ctrl.Tag == "enemy")
                {
                    if (Hero.Bounds.IntersectsWith(ctrl.Bounds)) playerInfo.HeroHealth -= 1;                    

                    if (ctrl.Left > Hero.Left)
                    { ctrl.Left -= Enemies.enemySpeed; ((PictureBox)ctrl).Image = Properties.Resources.enemyLeft; }
                    if (ctrl.Left < Hero.Left)
                    { ctrl.Left += Enemies.enemySpeed; ((PictureBox)ctrl).Image = Properties.Resources.enemyRight; }
                    if (ctrl.Top > Hero.Top)
                    { ctrl.Top -= Enemies.enemySpeed; ((PictureBox)ctrl).Image  = Properties.Resources.enemyUp; }
                    if (ctrl.Top < Hero.Top)
                    { ctrl.Top += Enemies.enemySpeed; ((PictureBox)ctrl).Image  = Properties.Resources.enemyDown; }
                }

                foreach (Control control in Controls)                
                    if (control is PictureBox && (string)control.Tag == "bullet" && ctrl is PictureBox && (string)ctrl.Tag == "enemy")
                        if (ctrl.Bounds.IntersectsWith(control.Bounds))
                        {
                            ++killScore;

                            if (killScore % 20 == 0) SpawnFewHealth();
                            if (killScore % 30 == 0) Enemies.enemySpeed += 1;

                            Controls.Remove(control);
                            ((PictureBox)control).Dispose();
                            Controls.Remove(ctrl);
                            ((PictureBox)ctrl).Dispose();
                            Enemies.enemiesList.Remove(((PictureBox)control));
                            Enemies.CreateEnemiesOnField(this);
                        }                                    
            }
        }       

        private void ChangeAmmoBar(int barValue, string nameTag, int value)
        {
            if (OverHeatBar.Value <= 50 + value)
                OverHeatBar.Value += 50 - value;
            else if (nameTag == "bigMagazine")
                OverHeatBar.Value = 100;

            noShootTimeFlag = true;
            new Action(ThreadOverHeat).BeginInvoke(null, null);
            overHeatFlag = false;
        }

        private void ChangeHealthBar(int barValue, int value)
        {
            if (playerInfo.HeroHealth <= 80)
                playerInfo.HeroHealth += value;
            else
                playerInfo.HeroHealth = 100;
        }

        private void CreateCollision(Control ctrl, string nameTag, int value)
        {
            if (ctrl is PictureBox && (string)ctrl.Tag == nameTag)
                if (Hero.Bounds.IntersectsWith(ctrl.Bounds))
                {
                    Controls.Remove(ctrl);
                    ((PictureBox)ctrl).Dispose();

                    if (nameTag == "fewAmmo" || nameTag == "bigMagazine")
                        ChangeAmmoBar(OverHeatBar.Value, nameTag, value);
                    else if (nameTag == "fewHealth")
                        ChangeHealthBar(playerInfo.HeroHealth, value);                                                            
                }
        }       

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (playerInfo.EndGame == true) return;

            if (e.KeyCode == Keys.A) 
            { playerInfo.Left = true; playerInfo.GazeDirection = "left"; Hero.Image = Properties.Resources.MoveGifLeft; }

            if (e.KeyCode == Keys.D)
            { playerInfo.Right = true; playerInfo.GazeDirection = "right"; Hero.Image = Properties.Resources.MoveGifRight; } 

            if (e.KeyCode == Keys.W)
            { playerInfo.Up = true; playerInfo.GazeDirection = "up"; Hero.Image = Properties.Resources.MoveGifUp; }

            if (e.KeyCode == Keys.S)
            { playerInfo.Down = true; playerInfo.GazeDirection = "down"; Hero.Image = Properties.Resources.MoveGifDown; }                        
        }

        private void GameField_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
                if (form.Name == "MainMenu")
                { Hide(); form.Show(); }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {            
            if (e.KeyCode == Keys.A) playerInfo.Left  = false;
            if (e.KeyCode == Keys.D) playerInfo.Right = false;
            if (e.KeyCode == Keys.W) playerInfo.Up    = false;
            if (e.KeyCode == Keys.S) playerInfo.Down  = false;
                        
            if (e.KeyCode == Keys.Enter && overHeatFlag == false && playerInfo.EndGame == false) 
            {
                if (OverHeatBar.Value == 0)
                {                                         
                    overHeatFlag = true;              
                    Upgrades ammo = new Upgrades();
                    ammo.CreateFewAmmo(this);
                    
                    new Action(ThreadOverHeat).BeginInvoke(null, null);

                    ++counterBigMagazine;
                    if (counterBigMagazine == 3)
                    { new Action(SpawnBigMagazine).BeginInvoke(null, null); counterBigMagazine = 0; }                    
                }
                else if (OverHeatBar.Value != 0 && noShootTimeFlag == false) 
                { FireShoot(playerInfo.GazeDirection); OverHeatBar.Value -= 5; }                                                 
            }
            
            if (e.KeyCode == Keys.Enter && playerInfo.EndGame == true)         
                foreach (Form form in Application.OpenForms)
                    if (form.Name == "MainMenu")
                    { Hide(); form.Show(); }            
        }

        private void SpawnFewHealth()
        {
            var fewHealth = new Upgrades();
            fewHealth.CreateFewHealth(this);
        }

        private void SpawnBigMagazine()
        {
            var random = new Random();
            PictureBox bigMagazine = new PictureBox();
            bigMagazine.Tag = "bigMagazine";
            bigMagazine.Image = Properties.Resources.BigMagazine;
            Upgrades.CreateUpgradeType(bigMagazine, this);

            Thread.Sleep(random.Next(5000, 15000));                     
            BeginInvoke(new Action(() => Controls.Add(bigMagazine)));
            

            noShootTimeFlag = false;
        }

        private void ThreadOverHeat()
        {            
            Thread.Sleep(750);
            BeginInvoke(new Action(() => FireShoot(null)));
            noShootTimeFlag = false;
        }        

        private void FireShoot(string route)
        {
            if (route != null)
            {
                Bullet bullet = new Bullet { Route = route };

                CreateDirection(bullet, "up", 1.455);
                CreateDirection(bullet, "left", 3.455);
                CreateDirection(bullet, "down", 4);
                CreateDirection(bullet, "right", 1.5);               

                bullet.CreateBullet(this);
            }
        }

        private void CreateDirection(Bullet bullet, string direction, double coef)
        {
            if (playerInfo.GazeDirection == direction)
            {
                bullet.BulletUp = Hero.Top + (Hero.Height / coef);
                bullet.BulletLeft = Hero.Left + (Hero.Width / coef);
            }            
        }

        private void GameRestart()
        {            
            Hero.Image = Properties.Resources.MoveGifUp;

            foreach (PictureBox enemy in Enemies.enemiesList)            
                Controls.Remove(enemy);            

            Enemies.enemiesList.Clear();
            
                for (int i = 0; i < 4; i++)            
                    Enemies.CreateEnemiesOnField(this);                    

            playerInfo.Up = false;
            playerInfo.Down = false;
            playerInfo.Right = false;
            playerInfo.Left = false;
            playerInfo.EndGame = false;
            overHeatFlag = false;            

            Enemies.enemySpeed = 3;
            playerInfo.HeroHealth = 100;          
            OverHeatBar.Value = 100;
            killScore = 0;            

            MainTimer.Start();
        }        
    }   
}
