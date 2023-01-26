using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WindowsFormsApp1
{



    public partial class Form1 : Form
    {
        int wormholecost;
 
        int factorycost;
    
        int clickercost = 50;
        int pastclickercost = 50;
    
        int cookies = 0;
        int clickers = 0;
        int factories = 0;
        int wormholes = 0;
       

        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cookies = cookies + 1;
            label1.Text = cookies.ToString();

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
            if (cookies >= 50){
                clickers = clickers + 1;
                cookies = cookies - clickercost;
                ClickerCost.Text = clickers.ToString();
                clickercost = pastclickercost * 2 + pastclickercost;
                ClickerAmount.Text = clickercost.ToString();
               

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
            cookies = cookies + (clickers * 5) + (factories * 100) + (wormholes * 10000);
            label1.Text = cookies.ToString();

        }
    }
}
