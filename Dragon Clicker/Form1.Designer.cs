namespace Dragon_Clicker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AttackEnemyButton = new System.Windows.Forms.Button();
            this.Dragon1HurtTimer = new System.Windows.Forms.Timer(this.components);
            this.Dragon1DeadTimer = new System.Windows.Forms.Timer(this.components);
            this.HealthLabel = new System.Windows.Forms.Label();
            this.HealthChecker = new System.Windows.Forms.Timer(this.components);
            this.BackgroundMusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.SlapSound = new AxWMPLib.AxWindowsMediaPlayer();
            this.Dragon1AnimationTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SniperCostLabel = new System.Windows.Forms.Label();
            this.SniperCountLabel = new System.Windows.Forms.Label();
            this.BuySniper = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.WheatCostLabel = new System.Windows.Forms.Label();
            this.WheatFieldCountLabel = new System.Windows.Forms.Label();
            this.WheatBuy = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ResearchWheat = new System.Windows.Forms.Button();
            this.ResearchSniper = new System.Windows.Forms.Button();
            this.GoldLabel = new System.Windows.Forms.Label();
            this.GoldChecker = new System.Windows.Forms.Timer(this.components);
            this.GoldGiverDragon1 = new System.Windows.Forms.Timer(this.components);
            this.ResearchSoldierUpgradeBuildingChecker = new System.Windows.Forms.Timer(this.components);
            this.Fusknapp = new System.Windows.Forms.Button();
            this.SniperDamageTimer = new System.Windows.Forms.Timer(this.components);
            this.SniperSound = new AxWMPLib.AxWindowsMediaPlayer();
            this.WheatTimer = new System.Windows.Forms.Timer(this.components);
            this.WheatLabel = new System.Windows.Forms.Label();
            this.WheatPerSecLabel = new System.Windows.Forms.Label();
            this.MachinegunnerCostLabel = new System.Windows.Forms.Label();
            this.MachinegunnerCountLabel = new System.Windows.Forms.Label();
            this.MachinegunBuy = new System.Windows.Forms.Button();
            this.MachinegunnerDamageTimer = new System.Windows.Forms.Timer(this.components);
            this.MachinegunSound = new AxWMPLib.AxWindowsMediaPlayer();
            this.ResearchMachineGunner = new System.Windows.Forms.Button();
            this.MachinegunnerWheatPerSecondLabel = new System.Windows.Forms.Label();
            this.MachinegunnerDamagePerSecondLabel = new System.Windows.Forms.Label();
            this.SniperDamagePerSecondLabel = new System.Windows.Forms.Label();
            this.DoubleClickDamage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlapSound)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SniperSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MachinegunSound)).BeginInit();
            this.SuspendLayout();
            // 
            // AttackEnemyButton
            // 
            this.AttackEnemyButton.Location = new System.Drawing.Point(-17, -17);
            this.AttackEnemyButton.Name = "AttackEnemyButton";
            this.AttackEnemyButton.Size = new System.Drawing.Size(1512, 727);
            this.AttackEnemyButton.TabIndex = 0;
            this.AttackEnemyButton.UseVisualStyleBackColor = true;
            this.AttackEnemyButton.Click += new System.EventHandler(this.AttackEnemyButton_Click);
            // 
            // Dragon1HurtTimer
            // 
            this.Dragon1HurtTimer.Enabled = true;
            this.Dragon1HurtTimer.Tick += new System.EventHandler(this.Dragon1Hurt_Tick);
            // 
            // Dragon1DeadTimer
            // 
            this.Dragon1DeadTimer.Interval = 1000;
            this.Dragon1DeadTimer.Tick += new System.EventHandler(this.Dragon1DeadTimer_Tick);
            // 
            // HealthLabel
            // 
            this.HealthLabel.AutoSize = true;
            this.HealthLabel.BackColor = System.Drawing.Color.Transparent;
            this.HealthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthLabel.ForeColor = System.Drawing.Color.Red;
            this.HealthLabel.Location = new System.Drawing.Point(264, 37);
            this.HealthLabel.Name = "HealthLabel";
            this.HealthLabel.Size = new System.Drawing.Size(98, 24);
            this.HealthLabel.TabIndex = 1;
            this.HealthLabel.Text = "50 Health";
            // 
            // HealthChecker
            // 
            this.HealthChecker.Enabled = true;
            this.HealthChecker.Interval = 10;
            this.HealthChecker.Tick += new System.EventHandler(this.HealthChecker_Tick);
            // 
            // BackgroundMusic
            // 
            this.BackgroundMusic.Enabled = true;
            this.BackgroundMusic.Location = new System.Drawing.Point(491, 447);
            this.BackgroundMusic.Name = "BackgroundMusic";
            this.BackgroundMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("BackgroundMusic.OcxState")));
            this.BackgroundMusic.Size = new System.Drawing.Size(80, 29);
            this.BackgroundMusic.TabIndex = 2;
            this.BackgroundMusic.Visible = false;
            // 
            // SlapSound
            // 
            this.SlapSound.Enabled = true;
            this.SlapSound.Location = new System.Drawing.Point(577, 447);
            this.SlapSound.Name = "SlapSound";
            this.SlapSound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("SlapSound.OcxState")));
            this.SlapSound.Size = new System.Drawing.Size(75, 23);
            this.SlapSound.TabIndex = 3;
            this.SlapSound.Visible = false;
            // 
            // Dragon1AnimationTimer
            // 
            this.Dragon1AnimationTimer.Tick += new System.EventHandler(this.Dragon1AnimationTimer_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(250, 600);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.SniperDamagePerSecondLabel);
            this.tabPage1.Controls.Add(this.MachinegunnerDamagePerSecondLabel);
            this.tabPage1.Controls.Add(this.MachinegunnerWheatPerSecondLabel);
            this.tabPage1.Controls.Add(this.MachinegunnerCostLabel);
            this.tabPage1.Controls.Add(this.MachinegunnerCountLabel);
            this.tabPage1.Controls.Add(this.MachinegunBuy);
            this.tabPage1.Controls.Add(this.SniperCostLabel);
            this.tabPage1.Controls.Add(this.SniperCountLabel);
            this.tabPage1.Controls.Add(this.BuySniper);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(242, 574);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Soldiers";
            // 
            // SniperCostLabel
            // 
            this.SniperCostLabel.AutoSize = true;
            this.SniperCostLabel.Location = new System.Drawing.Point(87, 37);
            this.SniperCostLabel.Name = "SniperCostLabel";
            this.SniperCostLabel.Size = new System.Drawing.Size(52, 13);
            this.SniperCostLabel.TabIndex = 2;
            this.SniperCostLabel.Text = "Cost: 250";
            this.SniperCostLabel.Visible = false;
            // 
            // SniperCountLabel
            // 
            this.SniperCountLabel.AutoSize = true;
            this.SniperCountLabel.Location = new System.Drawing.Point(87, 14);
            this.SniperCountLabel.Name = "SniperCountLabel";
            this.SniperCountLabel.Size = new System.Drawing.Size(51, 13);
            this.SniperCountLabel.TabIndex = 1;
            this.SniperCountLabel.Text = "0 Snipers";
            this.SniperCountLabel.Visible = false;
            // 
            // BuySniper
            // 
            this.BuySniper.Location = new System.Drawing.Point(6, 6);
            this.BuySniper.Name = "BuySniper";
            this.BuySniper.Size = new System.Drawing.Size(75, 75);
            this.BuySniper.TabIndex = 0;
            this.BuySniper.UseVisualStyleBackColor = true;
            this.BuySniper.Visible = false;
            this.BuySniper.Click += new System.EventHandler(this.BuySniper_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.WheatCostLabel);
            this.tabPage2.Controls.Add(this.WheatFieldCountLabel);
            this.tabPage2.Controls.Add(this.WheatBuy);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(242, 574);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Buildings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // WheatCostLabel
            // 
            this.WheatCostLabel.AutoSize = true;
            this.WheatCostLabel.Location = new System.Drawing.Point(86, 37);
            this.WheatCostLabel.Name = "WheatCostLabel";
            this.WheatCostLabel.Size = new System.Drawing.Size(52, 13);
            this.WheatCostLabel.TabIndex = 4;
            this.WheatCostLabel.Text = "Cost: 500";
            this.WheatCostLabel.Visible = false;
            // 
            // WheatFieldCountLabel
            // 
            this.WheatFieldCountLabel.AutoSize = true;
            this.WheatFieldCountLabel.Location = new System.Drawing.Point(87, 10);
            this.WheatFieldCountLabel.Name = "WheatFieldCountLabel";
            this.WheatFieldCountLabel.Size = new System.Drawing.Size(75, 13);
            this.WheatFieldCountLabel.TabIndex = 3;
            this.WheatFieldCountLabel.Text = "0 Wheat fields";
            this.WheatFieldCountLabel.Visible = false;
            // 
            // WheatBuy
            // 
            this.WheatBuy.Location = new System.Drawing.Point(6, 6);
            this.WheatBuy.Name = "WheatBuy";
            this.WheatBuy.Size = new System.Drawing.Size(75, 75);
            this.WheatBuy.TabIndex = 2;
            this.WheatBuy.UseVisualStyleBackColor = true;
            this.WheatBuy.Visible = false;
            this.WheatBuy.Click += new System.EventHandler(this.WheteBuy_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DoubleClickDamage);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(242, 574);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Upgrades";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ResearchMachineGunner);
            this.tabPage4.Controls.Add(this.ResearchWheat);
            this.tabPage4.Controls.Add(this.ResearchSniper);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(242, 574);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Research";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ResearchWheat
            // 
            this.ResearchWheat.Location = new System.Drawing.Point(164, 5);
            this.ResearchWheat.Name = "ResearchWheat";
            this.ResearchWheat.Size = new System.Drawing.Size(75, 75);
            this.ResearchWheat.TabIndex = 2;
            this.ResearchWheat.UseVisualStyleBackColor = true;
            this.ResearchWheat.Visible = false;
            this.ResearchWheat.Click += new System.EventHandler(this.WheteResearch_Click);
            // 
            // ResearchSniper
            // 
            this.ResearchSniper.Location = new System.Drawing.Point(3, 5);
            this.ResearchSniper.Name = "ResearchSniper";
            this.ResearchSniper.Size = new System.Drawing.Size(75, 75);
            this.ResearchSniper.TabIndex = 1;
            this.ResearchSniper.UseVisualStyleBackColor = true;
            this.ResearchSniper.Visible = false;
            this.ResearchSniper.Click += new System.EventHandler(this.ResearchSniper_Click);
            // 
            // GoldLabel
            // 
            this.GoldLabel.AutoSize = true;
            this.GoldLabel.BackColor = System.Drawing.Color.Transparent;
            this.GoldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoldLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.GoldLabel.Location = new System.Drawing.Point(264, 90);
            this.GoldLabel.Name = "GoldLabel";
            this.GoldLabel.Size = new System.Drawing.Size(71, 24);
            this.GoldLabel.TabIndex = 5;
            this.GoldLabel.Text = "0 Gold";
            // 
            // GoldChecker
            // 
            this.GoldChecker.Enabled = true;
            this.GoldChecker.Interval = 10;
            this.GoldChecker.Tick += new System.EventHandler(this.GoldChecker_Tick);
            // 
            // GoldGiverDragon1
            // 
            this.GoldGiverDragon1.Interval = 1;
            this.GoldGiverDragon1.Tick += new System.EventHandler(this.GoldGiverDragon1_Tick);
            // 
            // ResearchSoldierUpgradeBuildingChecker
            // 
            this.ResearchSoldierUpgradeBuildingChecker.Enabled = true;
            this.ResearchSoldierUpgradeBuildingChecker.Interval = 10;
            this.ResearchSoldierUpgradeBuildingChecker.Tick += new System.EventHandler(this.ResearchSoldierUpgradeBuildingChecker_Tick);
            // 
            // Fusknapp
            // 
            this.Fusknapp.Location = new System.Drawing.Point(527, 34);
            this.Fusknapp.Name = "Fusknapp";
            this.Fusknapp.Size = new System.Drawing.Size(75, 23);
            this.Fusknapp.TabIndex = 6;
            this.Fusknapp.Text = "Fusknapp";
            this.Fusknapp.UseVisualStyleBackColor = true;
            this.Fusknapp.Click += new System.EventHandler(this.Fusknapp_Click);
            // 
            // SniperDamageTimer
            // 
            this.SniperDamageTimer.Interval = 1000;
            this.SniperDamageTimer.Tick += new System.EventHandler(this.SniperDamageTimer_Tick);
            // 
            // SniperSound
            // 
            this.SniperSound.Enabled = true;
            this.SniperSound.Location = new System.Drawing.Point(721, 462);
            this.SniperSound.Name = "SniperSound";
            this.SniperSound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("SniperSound.OcxState")));
            this.SniperSound.Size = new System.Drawing.Size(75, 23);
            this.SniperSound.TabIndex = 7;
            this.SniperSound.Visible = false;
            // 
            // WheatTimer
            // 
            this.WheatTimer.Interval = 1000;
            this.WheatTimer.Tick += new System.EventHandler(this.WheatTimer_Tick);
            // 
            // WheatLabel
            // 
            this.WheatLabel.AutoSize = true;
            this.WheatLabel.BackColor = System.Drawing.Color.Transparent;
            this.WheatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WheatLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.WheatLabel.Location = new System.Drawing.Point(1166, 71);
            this.WheatLabel.Name = "WheatLabel";
            this.WheatLabel.Size = new System.Drawing.Size(86, 24);
            this.WheatLabel.TabIndex = 8;
            this.WheatLabel.Text = "0 Wheat";
            this.WheatLabel.Visible = false;
            // 
            // WheatPerSecLabel
            // 
            this.WheatPerSecLabel.AutoSize = true;
            this.WheatPerSecLabel.BackColor = System.Drawing.Color.Transparent;
            this.WheatPerSecLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WheatPerSecLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.WheatPerSecLabel.Location = new System.Drawing.Point(1127, 36);
            this.WheatPerSecLabel.Name = "WheatPerSecLabel";
            this.WheatPerSecLabel.Size = new System.Drawing.Size(125, 24);
            this.WheatPerSecLabel.TabIndex = 9;
            this.WheatPerSecLabel.Text = "0 Wheat/sec";
            this.WheatPerSecLabel.Visible = false;
            // 
            // MachinegunnerCostLabel
            // 
            this.MachinegunnerCostLabel.AutoSize = true;
            this.MachinegunnerCostLabel.Location = new System.Drawing.Point(86, 108);
            this.MachinegunnerCostLabel.Name = "MachinegunnerCostLabel";
            this.MachinegunnerCostLabel.Size = new System.Drawing.Size(52, 13);
            this.MachinegunnerCostLabel.TabIndex = 5;
            this.MachinegunnerCostLabel.Text = "Cost: 500";
            this.MachinegunnerCostLabel.Visible = false;
            // 
            // MachinegunnerCountLabel
            // 
            this.MachinegunnerCountLabel.AutoSize = true;
            this.MachinegunnerCountLabel.Location = new System.Drawing.Point(87, 95);
            this.MachinegunnerCountLabel.Name = "MachinegunnerCountLabel";
            this.MachinegunnerCountLabel.Size = new System.Drawing.Size(95, 13);
            this.MachinegunnerCountLabel.TabIndex = 4;
            this.MachinegunnerCountLabel.Text = "0 Machinegunners";
            this.MachinegunnerCountLabel.Visible = false;
            // 
            // MachinegunBuy
            // 
            this.MachinegunBuy.Location = new System.Drawing.Point(6, 87);
            this.MachinegunBuy.Name = "MachinegunBuy";
            this.MachinegunBuy.Size = new System.Drawing.Size(75, 75);
            this.MachinegunBuy.TabIndex = 3;
            this.MachinegunBuy.UseVisualStyleBackColor = true;
            this.MachinegunBuy.Visible = false;
            this.MachinegunBuy.Click += new System.EventHandler(this.MachinegunBuy_Click);
            // 
            // MachinegunnerDamageTimer
            // 
            this.MachinegunnerDamageTimer.Interval = 200;
            this.MachinegunnerDamageTimer.Tick += new System.EventHandler(this.MachinegunnerDamageTimer_Tick);
            // 
            // MachinegunSound
            // 
            this.MachinegunSound.Enabled = true;
            this.MachinegunSound.Location = new System.Drawing.Point(706, 424);
            this.MachinegunSound.Name = "MachinegunSound";
            this.MachinegunSound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MachinegunSound.OcxState")));
            this.MachinegunSound.Size = new System.Drawing.Size(75, 23);
            this.MachinegunSound.TabIndex = 10;
            this.MachinegunSound.Visible = false;
            // 
            // ResearchMachineGunner
            // 
            this.ResearchMachineGunner.Location = new System.Drawing.Point(3, 86);
            this.ResearchMachineGunner.Name = "ResearchMachineGunner";
            this.ResearchMachineGunner.Size = new System.Drawing.Size(75, 75);
            this.ResearchMachineGunner.TabIndex = 3;
            this.ResearchMachineGunner.UseVisualStyleBackColor = true;
            this.ResearchMachineGunner.Visible = false;
            this.ResearchMachineGunner.Click += new System.EventHandler(this.ResearchMachineGunner_Click);
            // 
            // MachinegunnerWheatPerSecondLabel
            // 
            this.MachinegunnerWheatPerSecondLabel.AutoSize = true;
            this.MachinegunnerWheatPerSecondLabel.Location = new System.Drawing.Point(87, 134);
            this.MachinegunnerWheatPerSecondLabel.Name = "MachinegunnerWheatPerSecondLabel";
            this.MachinegunnerWheatPerSecondLabel.Size = new System.Drawing.Size(70, 13);
            this.MachinegunnerWheatPerSecondLabel.TabIndex = 6;
            this.MachinegunnerWheatPerSecondLabel.Text = "0 Wheat/sec";
            this.MachinegunnerWheatPerSecondLabel.Visible = false;
            // 
            // MachinegunnerDamagePerSecondLabel
            // 
            this.MachinegunnerDamagePerSecondLabel.AutoSize = true;
            this.MachinegunnerDamagePerSecondLabel.Location = new System.Drawing.Point(86, 121);
            this.MachinegunnerDamagePerSecondLabel.Name = "MachinegunnerDamagePerSecondLabel";
            this.MachinegunnerDamagePerSecondLabel.Size = new System.Drawing.Size(78, 13);
            this.MachinegunnerDamagePerSecondLabel.TabIndex = 7;
            this.MachinegunnerDamagePerSecondLabel.Text = "0 Damage/sec";
            this.MachinegunnerDamagePerSecondLabel.Visible = false;
            this.MachinegunnerDamagePerSecondLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // SniperDamagePerSecondLabel
            // 
            this.SniperDamagePerSecondLabel.AutoSize = true;
            this.SniperDamagePerSecondLabel.Location = new System.Drawing.Point(87, 64);
            this.SniperDamagePerSecondLabel.Name = "SniperDamagePerSecondLabel";
            this.SniperDamagePerSecondLabel.Size = new System.Drawing.Size(78, 13);
            this.SniperDamagePerSecondLabel.TabIndex = 8;
            this.SniperDamagePerSecondLabel.Text = "0 Damage/sec";
            this.SniperDamagePerSecondLabel.Visible = false;
            // 
            // DoubleClickDamage
            // 
            this.DoubleClickDamage.Location = new System.Drawing.Point(3, 3);
            this.DoubleClickDamage.Name = "DoubleClickDamage";
            this.DoubleClickDamage.Size = new System.Drawing.Size(75, 75);
            this.DoubleClickDamage.TabIndex = 0;
            this.DoubleClickDamage.UseVisualStyleBackColor = true;
            this.DoubleClickDamage.Visible = false;
            this.DoubleClickDamage.Click += new System.EventHandler(this.DoubleClickDamage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 638);
            this.Controls.Add(this.MachinegunSound);
            this.Controls.Add(this.WheatPerSecLabel);
            this.Controls.Add(this.WheatLabel);
            this.Controls.Add(this.SniperSound);
            this.Controls.Add(this.Fusknapp);
            this.Controls.Add(this.GoldLabel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.SlapSound);
            this.Controls.Add(this.BackgroundMusic);
            this.Controls.Add(this.HealthLabel);
            this.Controls.Add(this.AttackEnemyButton);
            this.Name = "Form1";
            this.Text = "Dragon Clicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlapSound)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SniperSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MachinegunSound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AttackEnemyButton;
        private System.Windows.Forms.Timer Dragon1HurtTimer;
        private System.Windows.Forms.Timer Dragon1DeadTimer;
        private System.Windows.Forms.Label HealthLabel;
        private System.Windows.Forms.Timer HealthChecker;
        private AxWMPLib.AxWindowsMediaPlayer BackgroundMusic;
        private AxWMPLib.AxWindowsMediaPlayer SlapSound;
        private System.Windows.Forms.Timer Dragon1AnimationTimer;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label GoldLabel;
        private System.Windows.Forms.Timer GoldChecker;
        private System.Windows.Forms.Timer GoldGiverDragon1;
        private System.Windows.Forms.Button BuySniper;
        private System.Windows.Forms.Button ResearchSniper;
        private System.Windows.Forms.Timer ResearchSoldierUpgradeBuildingChecker;
        private System.Windows.Forms.Label SniperCostLabel;
        private System.Windows.Forms.Label SniperCountLabel;
        private System.Windows.Forms.Button Fusknapp;
        private System.Windows.Forms.Timer SniperDamageTimer;
        private AxWMPLib.AxWindowsMediaPlayer SniperSound;
        private System.Windows.Forms.Button ResearchWheat;
        private System.Windows.Forms.Button WheatBuy;
        private System.Windows.Forms.Label WheatCostLabel;
        private System.Windows.Forms.Label WheatFieldCountLabel;
        private System.Windows.Forms.Timer WheatTimer;
        private System.Windows.Forms.Label WheatLabel;
        private System.Windows.Forms.Label WheatPerSecLabel;
        private System.Windows.Forms.Label MachinegunnerCostLabel;
        private System.Windows.Forms.Label MachinegunnerCountLabel;
        private System.Windows.Forms.Button MachinegunBuy;
        private System.Windows.Forms.Timer MachinegunnerDamageTimer;
        private AxWMPLib.AxWindowsMediaPlayer MachinegunSound;
        private System.Windows.Forms.Button ResearchMachineGunner;
        private System.Windows.Forms.Label MachinegunnerWheatPerSecondLabel;
        private System.Windows.Forms.Label MachinegunnerDamagePerSecondLabel;
        private System.Windows.Forms.Label SniperDamagePerSecondLabel;
        private System.Windows.Forms.Button DoubleClickDamage;
    }
}

