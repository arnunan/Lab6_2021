using System;
using System.Windows.Forms;
using System.Drawing;

namespace HyperKill.Entities
{
    class Bullet
    {
        private int BulletSpeed = 15;
        private PictureBox ShootBullet = new PictureBox();
        private Timer TimerBullet = new Timer();         

        public string Route;
        public double BulletLeft, BulletUp;

        public void CreateBullet(Form form)
        {            
            ShootBullet.BackColor = Color.Red;
            ShootBullet.Size = new Size(6, 6);
            ShootBullet.Left = (int)BulletLeft;
            ShootBullet.Top = (int)BulletUp;
            ShootBullet.Tag = "bullet";
            ShootBullet.BringToFront();                     
            form.Controls.Add(ShootBullet);

            TimerBullet.Interval = BulletSpeed;
            TimerBullet.Tick += new EventHandler(BulletEvent);
            TimerBullet.Start();
        }        

        private void BulletEvent(object sender, EventArgs e)
        {
            var outBounds =
                ShootBullet.Left < 10 || ShootBullet.Left > 2560 ||
                ShootBullet.Top  < 10 || ShootBullet.Top  > 1920;

            if (Route == "left")  ShootBullet.Left -= BulletSpeed;
            if (Route == "right") ShootBullet.Left += BulletSpeed;
            if (Route == "up")    ShootBullet.Top  -= BulletSpeed;
            if (Route == "down")  ShootBullet.Top  += BulletSpeed;

            if (outBounds) 
            { 
                TimerBullet.Stop(); 
                TimerBullet.Dispose(); 
                ShootBullet.Dispose(); 
                TimerBullet = null; 
                ShootBullet = null; 
            }
        }
    }
}
