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
            this.Loadbutton = new System.Windows.Forms.Button();
            this.Savebutton = new System.Windows.Forms.Button();
            this.Amount = new System.Windows.Forms.Label();
            this.ClickerAmountLabel = new System.Windows.Forms.Label();
            this.FactoryAmountLabel = new System.Windows.Forms.Label();
            this.WormholeAmountLabel = new System.Windows.Forms.Label();
            this.Cost = new System.Windows.Forms.Label();
            this.CookieCount = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WormholeCostLabel = new System.Windows.Forms.Label();
            this.BuyWormhole = new System.Windows.Forms.Button();
            this.FactoryCostLabel = new System.Windows.Forms.Label();
            this.BuyFactory = new System.Windows.Forms.Button();
            this.ClickerCostLabel = new System.Windows.Forms.Label();
            this.BuyClicker = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cps = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.CookieCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // MakeCookie
            // 
            this.MakeCookie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MakeCookie.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MakeCookie.Location = new System.Drawing.Point(29, 358);
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
            this.panel1.Controls.Add(this.cps);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Loadbutton);
            this.panel1.Controls.Add(this.Savebutton);
            this.panel1.Controls.Add(this.Amount);
            this.panel1.Controls.Add(this.ClickerAmountLabel);
            this.panel1.Controls.Add(this.FactoryAmountLabel);
            this.panel1.Controls.Add(this.WormholeAmountLabel);
            this.panel1.Controls.Add(this.Cost);
            this.panel1.Controls.Add(this.CookieCount);
            this.panel1.Controls.Add(this.WormholeCostLabel);
            this.panel1.Controls.Add(this.BuyWormhole);
            this.panel1.Controls.Add(this.FactoryCostLabel);
            this.panel1.Controls.Add(this.BuyFactory);
            this.panel1.Controls.Add(this.ClickerCostLabel);
            this.panel1.Controls.Add(this.BuyClicker);
            this.panel1.Controls.Add(this.MakeCookie);
            this.panel1.Location = new System.Drawing.Point(79, -57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 486);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Loadbutton
            // 
            this.Loadbutton.Location = new System.Drawing.Point(433, 85);
            this.Loadbutton.Name = "Loadbutton";
            this.Loadbutton.Size = new System.Drawing.Size(42, 22);
            this.Loadbutton.TabIndex = 15;
            this.Loadbutton.Text = "Load";
            this.Loadbutton.UseVisualStyleBackColor = true;
            this.Loadbutton.Click += new System.EventHandler(this.Loadbutton_Click);
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(433, 57);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(42, 22);
            this.Savebutton.TabIndex = 14;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(37, 233);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(43, 13);
            this.Amount.TabIndex = 13;
            this.Amount.Text = "Amount";
            this.Amount.Click += new System.EventHandler(this.label10_Click);
            // 
            // ClickerAmountLabel
            // 
            this.ClickerAmountLabel.AutoSize = true;
            this.ClickerAmountLabel.Location = new System.Drawing.Point(76, 311);
            this.ClickerAmountLabel.Name = "ClickerAmountLabel";
            this.ClickerAmountLabel.Size = new System.Drawing.Size(13, 13);
            this.ClickerAmountLabel.TabIndex = 12;
            this.ClickerAmountLabel.Text = "0";
            this.ClickerAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ClickerAmountLabel.Click += new System.EventHandler(this.ClickerCost_Click);
            // 
            // FactoryAmountLabel
            // 
            this.FactoryAmountLabel.AutoSize = true;
            this.FactoryAmountLabel.Location = new System.Drawing.Point(76, 282);
            this.FactoryAmountLabel.Name = "FactoryAmountLabel";
            this.FactoryAmountLabel.Size = new System.Drawing.Size(13, 13);
            this.FactoryAmountLabel.TabIndex = 11;
            this.FactoryAmountLabel.Text = "0";
            this.FactoryAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FactoryAmountLabel.Click += new System.EventHandler(this.FactoryCost_Click);
            // 
            // WormholeAmountLabel
            // 
            this.WormholeAmountLabel.AutoSize = true;
            this.WormholeAmountLabel.Location = new System.Drawing.Point(76, 253);
            this.WormholeAmountLabel.Name = "WormholeAmountLabel";
            this.WormholeAmountLabel.Size = new System.Drawing.Size(13, 13);
            this.WormholeAmountLabel.TabIndex = 10;
            this.WormholeAmountLabel.Text = "0";
            this.WormholeAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Cost
            // 
            this.Cost.AutoSize = true;
            this.Cost.Location = new System.Drawing.Point(259, 233);
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
            this.CookieCount.Location = new System.Drawing.Point(29, 345);
            this.CookieCount.Name = "CookieCount";
            this.CookieCount.Size = new System.Drawing.Size(419, 31);
            this.CookieCount.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 12);
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
            this.label1.Location = new System.Drawing.Point(193, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // WormholeCostLabel
            // 
            this.WormholeCostLabel.Location = new System.Drawing.Point(240, 253);
            this.WormholeCostLabel.Name = "WormholeCostLabel";
            this.WormholeCostLabel.Size = new System.Drawing.Size(65, 13);
            this.WormholeCostLabel.TabIndex = 7;
            this.WormholeCostLabel.Text = "0";
            this.WormholeCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WormholeCostLabel.Click += new System.EventHandler(this.WormholeAmount_Click);
            // 
            // BuyWormhole
            // 
            this.BuyWormhole.Location = new System.Drawing.Point(95, 248);
            this.BuyWormhole.Name = "BuyWormhole";
            this.BuyWormhole.Size = new System.Drawing.Size(139, 23);
            this.BuyWormhole.TabIndex = 6;
            this.BuyWormhole.Text = "Buy Cookie Wormhole";
            this.BuyWormhole.UseVisualStyleBackColor = true;
            this.BuyWormhole.Click += new System.EventHandler(this.BuyWormhole_Click);
            // 
            // FactoryCostLabel
            // 
            this.FactoryCostLabel.Location = new System.Drawing.Point(240, 282);
            this.FactoryCostLabel.Name = "FactoryCostLabel";
            this.FactoryCostLabel.Size = new System.Drawing.Size(65, 13);
            this.FactoryCostLabel.TabIndex = 5;
            this.FactoryCostLabel.Text = "0";
            this.FactoryCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FactoryCostLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // BuyFactory
            // 
            this.BuyFactory.Location = new System.Drawing.Point(95, 277);
            this.BuyFactory.Name = "BuyFactory";
            this.BuyFactory.Size = new System.Drawing.Size(139, 23);
            this.BuyFactory.TabIndex = 4;
            this.BuyFactory.Text = "Buy Cookie Factory";
            this.BuyFactory.UseVisualStyleBackColor = true;
            this.BuyFactory.Click += new System.EventHandler(this.BuyFactory_Click);
            // 
            // ClickerCostLabel
            // 
            this.ClickerCostLabel.Location = new System.Drawing.Point(240, 311);
            this.ClickerCostLabel.Name = "ClickerCostLabel";
            this.ClickerCostLabel.Size = new System.Drawing.Size(65, 13);
            this.ClickerCostLabel.TabIndex = 3;
            this.ClickerCostLabel.Text = "50";
            this.ClickerCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ClickerCostLabel.Click += new System.EventHandler(this.ClickerAmount_Click);
            // 
            // BuyClicker
            // 
            this.BuyClicker.Location = new System.Drawing.Point(95, 306);
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
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(29, 373);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(11, 95);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(437, 373);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(11, 95);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(29, 458);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(419, 10);
            this.panel4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cookies per second:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cps
            // 
            this.cps.AutoSize = true;
            this.cps.Location = new System.Drawing.Point(104, 62);
            this.cps.Name = "cps";
            this.cps.Size = new System.Drawing.Size(35, 13);
            this.cps.TabIndex = 17;
            this.cps.Text = "label4";
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
        private System.Windows.Forms.Label FactoryCostLabel;
        private System.Windows.Forms.Button BuyFactory;
        private System.Windows.Forms.Label ClickerCostLabel;
        private System.Windows.Forms.Button BuyWormhole;
        private System.Windows.Forms.Panel CookieCount;
        private System.Windows.Forms.Label WormholeCostLabel;
        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label ClickerAmountLabel;
        private System.Windows.Forms.Label FactoryAmountLabel;
        private System.Windows.Forms.Label WormholeAmountLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Loadbutton;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cps;
    }
}

