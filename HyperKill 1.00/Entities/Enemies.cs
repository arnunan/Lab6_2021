using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HyperKill.Entities
{
    enum directions
    { 
        left = 0,
        up = 1,
        right = 2,
        down = 3
    }  

    class Enemies
    {
        public static int enemySpeed = 3;
        private static Random random = new Random();
        public static List<PictureBox> enemiesList = new List<PictureBox>();      

        public static void CreateEnemiesOnField(Form form)
        {           
            PictureBox enemy = new PictureBox();
            enemy.Tag = "enemy";            
            enemy.Image = Properties.Resources.enemyDown;
            enemy.BackColor = Color.Transparent;
            var rnd = random.Next(0, 4);
            CreateLocation(form, enemy);            

            enemy.SizeMode = PictureBoxSizeMode.AutoSize;
            enemiesList.Add(enemy);
            form.Controls.Add(enemy);
            enemy.SendToBack();
        }

        private static void CreateLocation(Form form, PictureBox enemy)
        {
            var rnd = random.Next(0, 4);

            if (rnd == (int)directions.left)
            { enemy.Left = -50; enemy.Top = random.Next(0, form.Height); }
            else if (rnd == (int)directions.up)
            { enemy.Left = random.Next(0, form.Width); enemy.Top = -50; }
            else if (rnd == (int)directions.right)
            { enemy.Left = form.Width + 50; enemy.Top = random.Next(0, form.Height); }
            else if (rnd == (int)directions.down)
            { enemy.Left = random.Next(0, form.Width); enemy.Top = form.Height + 50; }
        }
    }   
}
