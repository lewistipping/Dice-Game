using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    public class Player
    {
        public string name { get; set; }
        public double cash { get; set; }
        public double chips { get; set; }

        public Player()
        {
            this.name = "Default Name";
            this.cash = 0.0;
            this.chips = 0.0;
        }
        public Player(string name, double cash)
        {
            this.name = name;
            this.cash = cash;
            this.chips = 0.0;
        }
        public string displayDetails()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name: " + this.name + "\n");
            sb.Append("Cash Balance: £" + this.cash + "\n");
            sb.Append("Chip Balance: £" + this.chips + "\n");

            return sb.ToString();

        }
        public void purchaseChips(double chips)
        {
            if (this.cash < chips)
            {
                Console.WriteLine("Unable to purchase chips,insufficient funds.");
            }
            else
            {
                this.cash -= chips;
                this.chips += chips;
            }
        }
        public void cashInChips(double chips)
        {
            if (this.chips < chips)
            {
                Console.WriteLine("You do not have this many chips");
            }
            else
            {
                this.cash += chips;
                this.chips -= chips;
            }
        }

    }
}
