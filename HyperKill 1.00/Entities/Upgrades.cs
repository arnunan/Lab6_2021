using System;
using System.Drawing;
using System.Windows.Forms;

namespace HyperKill.Entities
{
    class Upgrades
    {        
        public void CreateFewAmmo(Form form)
        {
            PictureBox fewAmmo = new PictureBox();          
           
            fewAmmo.Tag = "fewAmmo";
            fewAmmo.Image = Properties.Resources.FullAmmo;
            CreateUpgradeType(fewAmmo, form);
            form.Controls.Add(fewAmmo);                       
        }

        public void CreateFewHealth(Form form)
        {
            PictureBox fewHealth = new PictureBox();

            fewHealth.Tag = "fewHealth";
            fewHealth.Image = Properties.Resources.Heart;
            fewHealth.BackColor = Color.Transparent;
            CreateUpgradeType(fewHealth, form);
            form.Controls.Add(fewHealth);
        }

        public static void CreateUpgradeType(PictureBox upgradeType, Form form)
        {
            var random = new Random();

            upgradeType.SizeMode = PictureBoxSizeMode.AutoSize;
            upgradeType.Left = random.Next(10, form.ClientSize.Width - upgradeType.Width);
            upgradeType.Top = random.Next(100, form.ClientSize.Height - upgradeType.Height);            
            upgradeType.SendToBack();
        }
    }
}
