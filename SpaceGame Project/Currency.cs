using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame_Project
{
    public class Currency //Trading
    {
        public double fuelPrice;

        public void cashToGold(Player player)
        {
            bool cashToGold = true;
            do
            {
                Console.Write($"You have {player.myCash:C0} Cash!\n\n" +
                $"1 Gold = $1500 Cash\n\nEnter amount of Gold you wish to purchace: ");
                int goldAmount;
                string Amount = Console.ReadLine();
                bool boolCashToGold = int.TryParse(Amount, out goldAmount);

                int cashAmount = goldAmount;
                cashAmount = goldAmount * 1500;

                if (cashAmount > player.myCash)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"***NOT ENOUGH CASH***\nYou only have {player.myCash} Cash!");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                player.myCash = player.myCash - cashAmount;
                player.myGold = player.myGold + goldAmount;
                cashToGold = false;

            } while (cashToGold == true);
        }
        public void cashToFuel(Player player, Ship ship)
        {
            if (ship.fuel == 100)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Your fuel tanks is 100% full");
                Console.ResetColor();  
            }
            else
            fuelPrice = (100-Convert.ToDouble(ship.fuel))/100*player.age * 1.5 * 500;
            Console.WriteLine($"You spent {fuelPrice:C2} on fuel");
            player.myCash -= fuelPrice;
            ship.fuel = 100;
            Console.ReadLine();
        }
        public void orderFuel(Player player, Ship ship)
        {
            if (ship.fuel == 100)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Your fuel tanks is 100% full");
                Console.ResetColor();
            }
            else
            fuelPrice = (100 - Convert.ToDouble(ship.fuel)) / 100 * player.age * 2.25 * 500;
            Console.WriteLine($"You spent {fuelPrice:C2} on fuel");
            player.myCash -= fuelPrice;
            ship.fuel = 100;
            Console.ReadLine();
        }

        public void goldToTellerium(Player player)
        {
            bool goldToTellerium = true;
            do
            {
                Console.Write($"You have {player.myGold} Gold!\n\n" +
                $"1 Tellerium = 5 Gold ($7,500)\n\nEnter amount of Tellerium you wish to purchace: ");
                int telleriumAmount;
                string Amount = Console.ReadLine();
                bool boolGoldToTellerium = int.TryParse(Amount, out telleriumAmount);

                int goldAmount = telleriumAmount * 5;

                if (goldAmount > player.myGold)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"***NOT ENOUGH CASH***\nYou only have {player.myGold} Cash!");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                else
                {
                    player.myGold = player.myGold - goldAmount;
                    player.myTellerium = player.myTellerium + telleriumAmount;
                    goldToTellerium = false;
                }
            } while (goldToTellerium == true);
        }


        public void goldToOsmium(Player player)
        {
            bool goldToOsmium = true;
            do
            {
                Console.Write($"You have {player.myGold} Gold!\n\n" +
                $"1 Osmium = 15 Gold ($22,500)\n\nEnter amount of Osmium you wish to purchace: ");
                int osmiumAmount;
                string Amount = Console.ReadLine();
                bool boolGoldToOsmium = int.TryParse(Amount, out osmiumAmount);

                int goldAmount = osmiumAmount * 15;

                if (goldAmount > player.myGold)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"***NOT ENOUGH CASH***\nYou only have {player.myGold} Cash!");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                else
                {
                    player.myGold = player.myGold - goldAmount;
                    player.myOsmium = player.myOsmium + osmiumAmount;
                    goldToOsmium = false;
                }
            } while (goldToOsmium == true);
        }

        public void goldToCash(Player player)
        {
            bool goldToCash = true;
            do
            {
                Console.Write($"You have {player.myGold} gold!\n\n" +
                $"1 Gold = $1,500\nEnter amount of gold you want to sell: ");

                int amount;
                string goldAmount = Console.ReadLine();
                bool boolGoldToCash = int.TryParse(goldAmount, out amount);

                if (amount > player.myGold)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"***NOT ENOUGH CASH***\nYou only have {player.myGold} Cash!");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    player.myCash = (amount * 1500) + player.myCash;
                    player.myGold = player.myGold - amount;
                    goldToCash = false;
                }
            } while (goldToCash == true);
        }
        public void osmiumToCash(Player player)
        {
            bool osmiumToCash = true;
            do
            {
                Console.Write($"You have {player.myOsmium} Osmium!\n\n" +
                $"1 Osmium = $22,500\nEnter amount of Osmium you want to sell: ");

                int amount;
                string osmiumAmount = Console.ReadLine();
                bool boolOsmiumToCash = int.TryParse(osmiumAmount, out amount);

                if (amount > player.myOsmium)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"***NOT ENOUGH CASH***\nYou only have {player.myOsmium} Cash!");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    player.myCash = (amount * 25500) + player.myCash;
                    player.myOsmium = player.myOsmium - amount;
                    osmiumToCash = false;
                }
            } while (osmiumToCash == true);
        }
        public void telleriumToCash(Player player)
        {
            bool telleriumToCash = true;
            do
            {
                Console.Write($"You have {player.myTellerium} Tellerium!\n\n" +
                $"1 Tellerium = $7,500\nEnter amount of Tellerium you want to sell: ");

                int amount;
                string telleriumAmount = Console.ReadLine();
                bool boolTelleriumToCash = int.TryParse(telleriumAmount, out amount);

                if (amount > player.myTellerium)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"***NOT ENOUGH CASH***\nYou only have {player.myTellerium} Cash!");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    player.myCash = (amount * 7500) + player.myCash;
                    player.myTellerium = player.myTellerium - amount;
                    telleriumToCash = false;
                }
            } while (telleriumToCash == true);
        }

        public void purchaseMenu(Player player, Ship ship)
        {
            if (player.myLocation == "Earth")
            {
                earthBuyMenu(player, ship);
            }
            else if(player.myLocation == "Athena")
            {
                athenaBuyMenu(player, ship);
            }
            else if (player.myLocation == "Alpha Centauri")
            {
                alphaBuyMenu(player, ship);
            }
        }
        public void sellMenu(Player player)
        {
            if (player.myLocation == "Earth")
            {
                earthSellMenu(player);
            }
            else if (player.myLocation == "Athena")
            {
                Console.WriteLine("Selling not currently available");
            }
            else if (player.myLocation == "Alpha Centauri")
            {
                Console.WriteLine("Selling not currently available");
            }
        }
        public void earthSellMenu(Player player)
        {
            Console.WriteLine("Select item you want to Sell\n\n1.) Gold\n2.) Tellerium\n3.)Osmium");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    goldToCash(player);
                    break;
                case "2":
                    telleriumToCash(player);
                    break;
                case "3":
                    osmiumToCash(player);
                    break;
            }
        }


        public void earthBuyMenu(Player player, Ship ship)
        {
            Console.WriteLine("Select item you want to Buy\n\n1.) Gold\n2.) Fuel");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    cashToGold(player);
                    break;
                case "2":
                    fuelPrice = (100 - Convert.ToDouble(ship.fuel)) / 100 * player.age * 1.5 * 500;
                    if (fuelPrice > player.myCash)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Not enough Cash!");
                        Console.ResetColor();
                        player.myCash -= 0;
                        Console.ReadLine();
                    }
                    else
                    cashToFuel(player, ship);
                    break;
            }
        }
        public void athenaBuyMenu(Player player, Ship ship)
        {
            Console.WriteLine("Select item you want to Buy\n\n1.) Tellerium\n2.) Fuel");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    goldToTellerium(player);
                    break;
                case "2":
                    fuelPrice = (100 - Convert.ToDouble(ship.fuel)) / 100 * player.age * 2.25 * 500;
                    if (fuelPrice > player.myCash)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Not enough Cash!");
                        Console.ResetColor();
                        player.myCash -= 0;
                        Console.ReadLine();
                    }
                    else
                    orderFuel(player, ship);
                    break;
            }
        }
        public void alphaBuyMenu(Player player, Ship ship)
        {
            Console.WriteLine("Select item you want to Buy\n\n1.) Osmium\n2.) Fuel");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    goldToOsmium(player);
                    break;
                case "2":
                    fuelPrice = (100 - Convert.ToDouble(ship.fuel)) / 100 * player.age * 2.25 * 500;
                    if (fuelPrice > player.myCash)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Not enough Cash!");
                        Console.ResetColor();
                        player.myCash -= 0;
                        Console.ReadLine();
                    }
                    else
                    orderFuel(player, ship);
                    break;
            }
        }
    }
}