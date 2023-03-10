using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class GameState
    {
        public int cookieTotal { get; set; }

        public const int wormholeGives = 2000;
        public const int factoryGives = 20;
        public const int clickerGives = 1;
        public int cookiesPerTick()
        {
            return (clickerTotal * GameState.clickerGives) +
                    (factoryTotal * GameState.factoryGives) +
                    (wormholeTotal * GameState.wormholeGives);
        }


        public int clickerTotal { get; set; }
        [JsonIgnore]
        public int clickerCost
        {
            get => ClickerCostFromTotal();
        }

        private int ClickerCostFromTotal()
        {
            return (int)(((clickerTotal * clickerTotal) + 1.7) * 30);
        }
        public int factoryTotal { get; set; }
        [JsonIgnore]
        public int factoryCost
        {
            get => FactoryCostFromTotal();
        }

        private int FactoryCostFromTotal()
        {
            return (int)(((factoryTotal * factoryTotal) + 10.7) * 300);
        }
        public int wormholeTotal { get; set; }
        [JsonIgnore]
        public int wormholeCost
        {
            get => WormholeCostFromTotal();
        }

        private int WormholeCostFromTotal()
        {
            return (int)(((wormholeTotal * wormholeTotal) + 23.4) * 20000);
        }
        



        public GameState() {
            cookieTotal = 0;
            clickerTotal = 0;
        }
        public bool CanBuy(int cost)
        {
            return cookieTotal >= cost;
        }
    }
}
