using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        GameState gameState = new GameState();

        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameState.cookieTotal = gameState.cookieTotal + 1;
            label1.Text = gameState.cookieTotal.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        { }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (cookies >= clickercost)
            //{
            //    clickers = clickers + 1;
            //    cookies = cookies - clickercost;
            //    ClickerCost.Text = clickers.ToString();
            //    clickercost = pastclickercost * 2 + 25;
            //    ClickerAmount.Text = clickercost.ToString();
            //    pastclickercost = clickercost;
            //}
            if (gameState.CanBuy(gameState.clickerCost))
            {
                gameState.clickerTotal= gameState.clickerTotal + 1;
                ClickerCostLabel.Text= gameState.clickerCost.ToString();
                ClickerAmountLabel.Text= gameState.clickerTotal.ToString();

            }



        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void BuyWormhole_Click(object sender, EventArgs e)
        {

        }

        private void BuyFactory_Click(object sender, EventArgs e)
        {

        }

        private void WormholeAmount_Click(object sender, EventArgs e)
        {

        }

        private void ClickerCost_Click(object sender, EventArgs e)
        {

        }

        private void ClickerAmount_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gameState.cookieTotal = gameState.cookieTotal + 
                (gameState.clickerTotal * GameState.clickerGives) +
                (gameState.factoryTotal * GameState.factoryGives) +
                (gameState.wormholeTotal * GameState.wormholeGives);
            label1.Text = gameState.cookieTotal.ToString();

        }

        private void Loadbutton_Click(object sender, EventArgs e)
        {

            OpenFileDialog loadFileDialog1 = new OpenFileDialog
            {
                Filter = "Save Game (*.cookie)|*.cookie",
                FilterIndex = 1,
                RestoreDirectory = true,
                FileName = "cookieclickersave.cookie"
            };

            if (loadFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string jsonString = File.ReadAllText(loadFileDialog1.FileName);
                gameState = JsonSerializer.Deserialize<GameState>(jsonString);
            }
        }
        private void Savebutton_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = "Save Game (*.cookie)|*.cookie",
                FilterIndex = 1,
                RestoreDirectory = true,
                FileName = "cookieclickersave.cookie"
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string jsonString = JsonSerializer.Serialize(gameState);
                File.WriteAllText(saveFileDialog1.FileName, jsonString);
            }
        }
    }
}
