using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dragon_Clicker
{
    public partial class Form1 : Form
    {
        int HealthDragon1Original = 50;
        int HealthDragon1 = 50;
        int Damage = 1;
        int DeadTimer = 0;
        int Gold;
        int GoldDragon1 = 50;

        int DoubleClickCost = 250;
        int DoubleClickCount;


        int SniperCount;
        int SniperCost = 250;
        int ResearchSniperCount;
        int SniperDamage = 2;
        int SniperDamagePerSecond;

        int MachinegunnerCount;
        int MachinegunnerCost = 500;
        int MachinegunnerWheatPerSecond;
        int MachinegunnerWheat = 2;
        int ResearchMachinegunnerCount;
        int MachinegunDamage = 1;
        int MachinegunnerDamagePerSecond;


        int ResearchWheatCount;
        int WheatFieldCount;
        int WheatCost = 500;
        int WheatPerSecond = 2;
        int Wheat;
            

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            if (HealthDragon1 == HealthDragon1Original)
            {
                AttackEnemyButton.Image = Image.FromFile(@"Image\Dragon Normal.jpg");

            }

            //Image
            BuySniper.Image = Image.FromFile(@"Image\SniperButton Sized.jpg");
            ResearchSniper.Image = Image.FromFile(@"Image\SniperButton Sized.jpg");

            ResearchWheat.Image = Image.FromFile(@"Image\Wheat.jpg");
            WheatBuy.Image = Image.FromFile(@"Image\Wheat.jpg");

            ResearchMachineGunner.Image = Image.FromFile(@"Image\Machinegunner.jpg");
            MachinegunBuy.Image = Image.FromFile(@"Image\Machinegunner.jpg");
            DoubleClickDamage.Image = Image.FromFile(@"Image\Daggers.jpg");


            //Music
            BackgroundMusic.URL = @"Sound\Nightcore - Titanium.mp3";
            
        }

        private void Dragon1Hurt_Tick(object sender, EventArgs e)
        {
            if(HealthDragon1 == HealthDragon1Original)
            {
                AttackEnemyButton.Image = Image.FromFile(@"Image\Dragon Normal.jpg");

            }

            if (HealthDragon1 > HealthDragon1Original /10 * 6 && HealthDragon1 < HealthDragon1Original / 10 * 10)
            {
                AttackEnemyButton.Image = Image.FromFile(@"Image\Dragon 80%.jpg");
            }

            if (HealthDragon1 > HealthDragon1Original / 10 * 4 && HealthDragon1 <= HealthDragon1Original / 10 * 6)
            {
                AttackEnemyButton.Image = Image.FromFile(@"Image\Dragon 60%.jpg");
            }

            if (HealthDragon1 > HealthDragon1Original / 10 * 2 && HealthDragon1 <= HealthDragon1Original / 10 * 4)
            {
                AttackEnemyButton.Image = Image.FromFile(@"Image\Dragon 40%.jpg");
            }

            if (HealthDragon1 > HealthDragon1Original / 10 * 1 && HealthDragon1 <= HealthDragon1Original / 10 * 2)
            {
                AttackEnemyButton.Image = Image.FromFile(@"Image\Dragon 20%.jpg");
            }

            if (HealthDragon1 > HealthDragon1Original / 10 * 0 && HealthDragon1 <= HealthDragon1Original / 10 * 1 && HealthDragon1 != 0)
            {
                AttackEnemyButton.Image = Image.FromFile(@"Image\Dragon 10%.jpg");
            }

            if (HealthDragon1 <= 0)
            {
                AttackEnemyButton.Image = Image.FromFile(@"Image\Dragon Dead.jpg");
                Dragon1DeadTimer.Enabled = true;
                Dragon1HurtTimer.Enabled = false;
                AttackEnemyButton.Visible = false;
                GoldGiverDragon1.Enabled = true;
            }
        }

        private void Dragon1DeadTimer_Tick(object sender, EventArgs e)
        {
            
            AttackEnemyButton.Image = Image.FromFile(@"Image\Dragon Dead.jpg");
            if (DeadTimer == 1)
            {
                GoldDragon1 = GoldDragon1 + GoldDragon1 / 15;
                HealthDragon1Original = HealthDragon1Original + HealthDragon1Original / 10;
                AttackEnemyButton.Visible = true;
                DeadTimer = 0;
                Dragon1DeadTimer.Enabled = false;
                HealthDragon1 = HealthDragon1Original;
                Dragon1HurtTimer.Enabled = true;             

            }
            else
            {
                DeadTimer++;
            }
        }

        private void HealthChecker_Tick(object sender, EventArgs e)
        {
            HealthLabel.Text = HealthDragon1.ToString() + " Health";
        }

        private void AttackEnemyButton_Click(object sender, EventArgs e)
        {
            HealthDragon1 = HealthDragon1 - Damage;
            SlapSound.URL = @"Sound\Slap.mp3";
            Dragon1AnimationTimer.Enabled = true;
        }

        private void Dragon1AnimationTimer_Tick(object sender, EventArgs e)
        {

            if (HealthDragon1 > HealthDragon1Original / 10 * 6 && HealthDragon1 < HealthDragon1Original / 10 * 10)
            {
                AttackEnemyButton.Image = Image.FromFile(@"Image\Dragon 80% Animation.jpg");
            }

            if (HealthDragon1 > HealthDragon1Original / 10 * 4 && HealthDragon1 <= HealthDragon1Original / 10 * 6)
            {
                AttackEnemyButton.Image = Image.FromFile(@"Image\Dragon 60% Animation.jpg");
            }

            if (HealthDragon1 > HealthDragon1Original / 10 * 2 && HealthDragon1 <= HealthDragon1Original / 10 * 4)
            {
                AttackEnemyButton.Image = Image.FromFile(@"Image\Dragon 40% Animation.jpg");
            }

            if (HealthDragon1 > HealthDragon1Original / 10 * 1 && HealthDragon1 <= HealthDragon1Original / 10 * 2)
            {
                AttackEnemyButton.Image = Image.FromFile(@"Image\Dragon 20% Animation.jpg");
            }

            if (HealthDragon1 > HealthDragon1Original / 10 * 0 && HealthDragon1 <= HealthDragon1Original / 10 * 1 && HealthDragon1 != 0)
            {
                AttackEnemyButton.Image = Image.FromFile(@"Image\Dragon 10% Animation.jpg");
            }

            Dragon1AnimationTimer.Enabled = false;

        }

        private void GoldChecker_Tick(object sender, EventArgs e)
        {
            GoldLabel.Text = Gold.ToString() + " Gold";
        }

        private void GoldGiverDragon1_Tick(object sender, EventArgs e)
        {
            Gold = Gold + GoldDragon1;
            GoldGiverDragon1.Enabled = false;
        }

        private void BuySniper_Click(object sender, EventArgs e)
        {
            if (Gold >= SniperCost)
            {
                Gold = Gold - SniperCost;
                SniperCost = SniperCost + SniperCost / 10;
                SniperCount++;
                SniperDamageTimer.Enabled = true;
                SniperDamagePerSecond = SniperDamage * SniperCount;
                SniperDamagePerSecondLabel.Text = SniperDamagePerSecond.ToString() + " Damage/sec";
            }
        }

        private void ResearchSniper_Click(object sender, EventArgs e)
        {
            Gold = Gold - 300;
            ResearchSniper.Visible = false;
            BuySniper.Visible = true;
            SniperCostLabel.Visible = true;
            SniperCountLabel.Visible = true;
            SniperDamagePerSecondLabel.Visible = true;
            ResearchSniperCount++;
            
        }

        private void ResearchSoldierUpgradeBuildingChecker_Tick(object sender, EventArgs e)
        {
            if (Gold >= DoubleClickCost && DoubleClickCount <= 9)
            {
                DoubleClickDamage.Visible = true;
            }
            else
            {
                DoubleClickDamage.Visible = false;
            }

            if (Gold >= 300 && ResearchSniperCount == 0)
            {
                ResearchSniper.Visible = true;
            }
            else
            {
                ResearchSniper.Visible = false;
            }

            if (Gold >= 600 && ResearchWheatCount == 0 && SniperCount >= 5)
            {
                ResearchWheat.Visible = true;
            }
            else
            {
                ResearchWheat.Visible = false;
            }

            if (WheatFieldCount != 1)
            {
                WheatFieldCountLabel.Text = WheatFieldCount.ToString() + " WheatFields";
            }
            else
            {
                WheatFieldCountLabel.Text = WheatFieldCount.ToString() + " WheatField";
            }
            WheatCostLabel.Text = WheatCost.ToString() + " Gold";

            if (SniperCount != 1 )
            {
                SniperCountLabel.Text =  SniperCount.ToString() + " Snipers";
            }
            else
            {
                SniperCountLabel.Text = SniperCount.ToString() + " Sniper";
            }
            SniperCostLabel.Text = SniperCost.ToString() + " Gold";

            if (Gold >= 1000 && ResearchMachinegunnerCount == 0 && WheatFieldCount >= 4)
            {
                ResearchMachineGunner.Visible = true;
            }
            else
            {
                ResearchMachineGunner.Visible = false;
            }

            if (MachinegunnerCount != 1)
            {
                MachinegunnerCountLabel.Text = MachinegunnerCount.ToString() + " Machinegunners";
            }
            else
            {
                MachinegunnerCountLabel.Text = MachinegunnerCount.ToString() + " Machinegunner";
            }
            MachinegunnerCostLabel.Text = MachinegunnerCost.ToString() + " Gold";
            MachinegunnerWheatPerSecondLabel.Text = MachinegunnerWheat.ToString() + " Wheat/sec";

        }

        private void Fusknapp_Click(object sender, EventArgs e)
        {
            Gold = Gold + 6000;
        }

        private void SniperDamageTimer_Tick(object sender, EventArgs e)
        {
            if (Dragon1DeadTimer.Enabled == false)
            {
                HealthDragon1 = HealthDragon1 - SniperDamage * SniperCount;
                SniperDamagePerSecond = SniperDamage * SniperCount;
                SniperDamagePerSecondLabel.Text = SniperDamagePerSecond.ToString() + " Damage/sec";
                SniperSound.URL = @"Sound\Sniper.mp3";
            }
        }

        private void WheteResearch_Click(object sender, EventArgs e)
        {
            Gold = Gold - 600;
            ResearchWheatCount++;
            WheatBuy.Visible = true;
            WheatCostLabel.Visible = true;
            WheatFieldCountLabel.Visible = true;
            WheatPerSecLabel.Visible = true;
            WheatLabel.Visible = true;
        }

        private void WheteBuy_Click(object sender, EventArgs e)
        {
            if (Gold >= WheatCost)
            {
                Gold = Gold - WheatCost;
                WheatCost = WheatCost + WheatCost / 5;
                WheatFieldCount++;
                WheatTimer.Enabled = true;

            }
        }

        private void WheatTimer_Tick(object sender, EventArgs e)
        {
            WheatPerSecond = WheatFieldCount * 2 - MachinegunnerWheatPerSecond;
            WheatPerSecLabel.Text = WheatPerSecond.ToString() + " Wheat/sec";
            Wheat = Wheat + WheatPerSecond;
            WheatLabel.Text = Wheat.ToString() + " Wheat";
            if (Wheat < 0 && MachinegunnerCost > 0)
            {
                MachinegunnerCount--;
                MachinegunnerWheatPerSecond = MachinegunnerWheat * MachinegunnerCount;
            }
        }

        private void MachinegunBuy_Click(object sender, EventArgs e)
        {
            if (Gold >= MachinegunnerCost)
            {
                Gold = Gold - MachinegunnerCost;
                MachinegunnerCost = MachinegunnerCost + MachinegunnerCost / 8;
                MachinegunnerCount++;
                MachinegunnerDamageTimer.Enabled = true;
                MachinegunnerWheatPerSecond = MachinegunnerWheat * MachinegunnerCount;
            }
        }

        private void MachinegunnerDamageTimer_Tick(object sender, EventArgs e)
        {
            if (Dragon1DeadTimer.Enabled == false && MachinegunnerCount > 0)
            {
                HealthDragon1 = HealthDragon1 - MachinegunDamage * MachinegunnerCount;
                MachinegunSound.URL = @"Sound\MachinegunSound.mp3";
                MachinegunnerDamagePerSecond = MachinegunDamage * MachinegunnerCount * 5;
                MachinegunnerDamagePerSecondLabel.Text = MachinegunnerDamagePerSecond.ToString() + " Damage/sec";
            }
        }

        private void ResearchMachineGunner_Click(object sender, EventArgs e)
        {
            Gold = Gold - 1000;
            ResearchMachineGunner.Visible = false;
            MachinegunBuy.Visible = true;
            MachinegunnerCostLabel.Visible = true;
            MachinegunnerCountLabel.Visible = true;
            MachinegunnerWheatPerSecondLabel.Visible = true;
            MachinegunnerDamagePerSecondLabel.Visible = true;
            ResearchMachinegunnerCount++;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DoubleClickDamage_Click(object sender, EventArgs e)
        {
            if (Gold >= DoubleClickCost)
            {
                Gold = Gold - DoubleClickCost;
                DoubleClickCost = DoubleClickCost * 15 / 10;
                Damage = Damage * 2;
                DoubleClickCount++;
            }
        }
    }
}
