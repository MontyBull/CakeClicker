namespace WindowsFormsApp1
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
            this.MakeCookie = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Amount = new System.Windows.Forms.Label();
            this.ClickerCost = new System.Windows.Forms.Label();
            this.FactoryCost = new System.Windows.Forms.Label();
            this.WormholeCost = new System.Windows.Forms.Label();
            this.Cost = new System.Windows.Forms.Label();
            this.CookieCount = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WormholeAmount = new System.Windows.Forms.Label();
            this.BuyWormhole = new System.Windows.Forms.Button();
            this.FactoryAmount = new System.Windows.Forms.Label();
            this.BuyFactory = new System.Windows.Forms.Button();
            this.ClickerAmount = new System.Windows.Forms.Label();
            this.BuyClicker = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.CookieCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // MakeCookie
            // 
            this.MakeCookie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MakeCookie.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MakeCookie.Location = new System.Drawing.Point(29, 336);
            this.MakeCookie.Name = "MakeCookie";
            this.MakeCookie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MakeCookie.Size = new System.Drawing.Size(419, 110);
            this.MakeCookie.TabIndex = 0;
            this.MakeCookie.Text = "Produce cookie";
            this.MakeCookie.UseVisualStyleBackColor = true;
            this.MakeCookie.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.Amount);
            this.panel1.Controls.Add(this.ClickerCost);
            this.panel1.Controls.Add(this.FactoryCost);
            this.panel1.Controls.Add(this.WormholeCost);
            this.panel1.Controls.Add(this.Cost);
            this.panel1.Controls.Add(this.CookieCount);
            this.panel1.Controls.Add(this.WormholeAmount);
            this.panel1.Controls.Add(this.BuyWormhole);
            this.panel1.Controls.Add(this.FactoryAmount);
            this.panel1.Controls.Add(this.BuyFactory);
            this.panel1.Controls.Add(this.ClickerAmount);
            this.panel1.Controls.Add(this.BuyClicker);
            this.panel1.Controls.Add(this.MakeCookie);
            this.panel1.Location = new System.Drawing.Point(79, -57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 486);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(-3, 233);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(43, 13);
            this.Amount.TabIndex = 13;
            this.Amount.Text = "Amount";
            this.Amount.Click += new System.EventHandler(this.label10_Click);
            // 
            // ClickerCost
            // 
            this.ClickerCost.AutoSize = true;
            this.ClickerCost.Location = new System.Drawing.Point(10, 312);
            this.ClickerCost.Name = "ClickerCost";
            this.ClickerCost.Size = new System.Drawing.Size(13, 13);
            this.ClickerCost.TabIndex = 12;
            this.ClickerCost.Text = "0";
            this.ClickerCost.Click += new System.EventHandler(this.ClickerCost_Click);
            // 
            // FactoryCost
            // 
            this.FactoryCost.AutoSize = true;
            this.FactoryCost.Location = new System.Drawing.Point(10, 283);
            this.FactoryCost.Name = "FactoryCost";
            this.FactoryCost.Size = new System.Drawing.Size(13, 13);
            this.FactoryCost.TabIndex = 11;
            this.FactoryCost.Text = "0";
            // 
            // WormholeCost
            // 
            this.WormholeCost.AutoSize = true;
            this.WormholeCost.Location = new System.Drawing.Point(10, 254);
            this.WormholeCost.Name = "WormholeCost";
            this.WormholeCost.Size = new System.Drawing.Size(13, 13);
            this.WormholeCost.TabIndex = 10;
            this.WormholeCost.Text = "0";
            // 
            // Cost
            // 
            this.Cost.AutoSize = true;
            this.Cost.Location = new System.Drawing.Point(169, 234);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(28, 13);
            this.Cost.TabIndex = 9;
            this.Cost.Text = "Cost";
            this.Cost.Click += new System.EventHandler(this.label6_Click);
            // 
            // CookieCount
            // 
            this.CookieCount.Controls.Add(this.label2);
            this.CookieCount.Controls.Add(this.label1);
            this.CookieCount.Location = new System.Drawing.Point(361, 299);
            this.CookieCount.Name = "CookieCount";
            this.CookieCount.Size = new System.Drawing.Size(87, 31);
            this.CookieCount.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "cookies:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // WormholeAmount
            // 
            this.WormholeAmount.AutoSize = true;
            this.WormholeAmount.Location = new System.Drawing.Point(177, 254);
            this.WormholeAmount.Name = "WormholeAmount";
            this.WormholeAmount.Size = new System.Drawing.Size(13, 13);
            this.WormholeAmount.TabIndex = 7;
            this.WormholeAmount.Text = "0";
            this.WormholeAmount.Click += new System.EventHandler(this.WormholeAmount_Click);
            // 
            // BuyWormhole
            // 
            this.BuyWormhole.Location = new System.Drawing.Point(29, 249);
            this.BuyWormhole.Name = "BuyWormhole";
            this.BuyWormhole.Size = new System.Drawing.Size(139, 23);
            this.BuyWormhole.TabIndex = 6;
            this.BuyWormhole.Text = "Buy Cookie Wormhole";
            this.BuyWormhole.UseVisualStyleBackColor = true;
            this.BuyWormhole.Click += new System.EventHandler(this.BuyWormhole_Click);
            // 
            // FactoryAmount
            // 
            this.FactoryAmount.AutoSize = true;
            this.FactoryAmount.Location = new System.Drawing.Point(177, 283);
            this.FactoryAmount.Name = "FactoryAmount";
            this.FactoryAmount.Size = new System.Drawing.Size(13, 13);
            this.FactoryAmount.TabIndex = 5;
            this.FactoryAmount.Text = "0";
            this.FactoryAmount.Click += new System.EventHandler(this.label4_Click);
            // 
            // BuyFactory
            // 
            this.BuyFactory.Location = new System.Drawing.Point(29, 278);
            this.BuyFactory.Name = "BuyFactory";
            this.BuyFactory.Size = new System.Drawing.Size(139, 23);
            this.BuyFactory.TabIndex = 4;
            this.BuyFactory.Text = "Buy Cookie Factory";
            this.BuyFactory.UseVisualStyleBackColor = true;
            this.BuyFactory.Click += new System.EventHandler(this.BuyFactory_Click);
            // 
            // ClickerAmount
            // 
            this.ClickerAmount.AutoSize = true;
            this.ClickerAmount.Location = new System.Drawing.Point(177, 312);
            this.ClickerAmount.Name = "ClickerAmount";
            this.ClickerAmount.Size = new System.Drawing.Size(19, 13);
            this.ClickerAmount.TabIndex = 3;
            this.ClickerAmount.Text = "50";
            this.ClickerAmount.Click += new System.EventHandler(this.ClickerAmount_Click);
            // 
            // BuyClicker
            // 
            this.BuyClicker.Location = new System.Drawing.Point(29, 307);
            this.BuyClicker.Name = "BuyClicker";
            this.BuyClicker.Size = new System.Drawing.Size(139, 23);
            this.BuyClicker.TabIndex = 2;
            this.BuyClicker.Text = "Buy Clicker";
            this.BuyClicker.UseVisualStyleBackColor = true;
            this.BuyClicker.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Form1";
            this.Text = "A thing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.CookieCount.ResumeLayout(false);
            this.CookieCount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MakeCookie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BuyClicker;
        private System.Windows.Forms.Label FactoryAmount;
        private System.Windows.Forms.Button BuyFactory;
        private System.Windows.Forms.Label ClickerAmount;
        private System.Windows.Forms.Button BuyWormhole;
        private System.Windows.Forms.Panel CookieCount;
        private System.Windows.Forms.Label WormholeAmount;
        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label ClickerCost;
        private System.Windows.Forms.Label FactoryCost;
        private System.Windows.Forms.Label WormholeCost;
        private System.Windows.Forms.Timer timer1;
    }
}

