using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Player pl = new Player("Lewis", 200);
            while (true)
            {

                Console.WriteLine("Choose from one of the following options\n1:Place a bet.\n2:See account details."
                                  + "\n3:Purchase Chips.\n4:Cash In Chips.");

                int input = Int32.Parse(Console.ReadLine());

                int selection = 0;
                int stake = 0;
                int diceRoll = 0;
                switch (input)
                {
                    case 1:

                        if (pl.chips <= 0)
                        {
                            Console.WriteLine("Insufficient chips to place bet, please purchase more to play.");
                            break;
                        }
                        while (true)
                        {
                            Console.WriteLine("Choose a die roll to bet on.");
                            selection = Int32.Parse(Console.ReadLine());
                            if (selection >= 1 && selection <= 6)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Error, please make sure you enter a number between 1 and 6.");
                            }
                        }
                        while (true)
                        {
                            Console.WriteLine("Enter Stake: ");
                            stake = Int32.Parse(Console.ReadLine());
                            if (stake < pl.chips)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please enter an amount equal to or less than your chips balance");
                            }
                        }
                        Random rnd = new Random();
                        diceRoll = rnd.Next(1, 6);
                        Console.WriteLine("The die rolled :" + diceRoll);

                        if (selection == diceRoll)
                        {
                            pl.chips += stake;
                            Console.WriteLine("Congratulations you've won\nNew balance is :£" + pl.chips);
                        }
                        else
                        {
                            pl.chips -= stake;
                            Console.WriteLine("Unlucky please try again.");
                        }
                        break;
                    case 2:
                        Console.WriteLine(pl.displayDetails());
                        break;
                    case 3:
                        Console.WriteLine("How many chips would you like to purchase?");
                        int purchaseAmount = Int32.Parse(Console.ReadLine());
                        pl.purchaseChips(purchaseAmount);
                        break;
                    case 4:
                        Console.WriteLine("How many chips would you like to cash in?");
                        int cashInAmount = Int32.Parse(Console.ReadLine());
                        pl.cashInChips(cashInAmount);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
