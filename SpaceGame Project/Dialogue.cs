using System;
using System.Threading;

namespace SpaceGame_Project
{
    public class Dialogue
    {

        public void header(Player player, Ship ship)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("+=+=+=+=+=+=+=+=+=+=+=+=+=-+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+");
            
            Console.WriteLine($"    {player.name}  Age: {player.age:F2}  Ship: {ship.shipName}" +
                              $"   Fuel: {ship.fuel}%   Location: {player.myLocation}           ");
            Console.WriteLine($"    Cash: {player.myCash:C}  Gold: {player.myGold}  Osmium: {player.myOsmium}" +
                              $"  Tellerium: {player.myTellerium}            ");

            Console.WriteLine("+=+=+=+=+=+=+=+=+=+=+=+=+=-+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+");
            Console.ResetColor();
        }

        public void gameName()
        {
            string title = @"
           +=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+
           +                _____                         _____                                    +
           +               / ____|                       / ____|                                   +
           +              | (___  _ __   __ _  ___ ___  | |  __  __ _ _ __ ___   ___               + 
           +               \___ \| '_ \ / _` |/ __/ _ \ | | |_ |/ _` | '_ ` _ \ / _ \              +
           +               ____) | |_) | (_| | (_|  __/ | |__| | (_| | | | | | |  __/              +
           +              |_____/| .__/ \__,_|\___\___|  \_____|\__,_|_| |_| |_|\___|              +
           +                     | |                                                               +
           +                     |_|                                                               +
           +=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+
           
           
                 ";

                
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(title);
            Console.ResetColor();
        }
        public void enterName(Player player)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("                                                To begin your journey\n" +
                          "                                        \tplease enter your name:\n\t\t\t\t                       ");
            Console.ResetColor();
            player.name = Console.ReadLine();
            Console.Clear();
        }
        public void introDialogue(Player player, Ship ship)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+");
            Console.WriteLine($"Welcome to Spcae Game Merchant {player.name}");
            Console.WriteLine("+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+");
            Console.ResetColor();
            Thread.Sleep(1000);
            Console.WriteLine("Due to the drastic increase in global warming, the ozone layer of our planet is 80% destroyed.\n" +
                               "Every day we are running out of resources, including food and water, to survive.\n" +
                               "The sun is getting hotter and our oceans and rivers are drying out!\n" +
                               "We have about 100 years to escape our home."+
                               "It is now your resposiability to gather enough resources and escape this planet.\n\n" +
                               "A few decades ago, astronauts discovered a habitable planet called Quinteria.\n" +
                               "Unfortuantly, Quinteria is too far and you do not have enough money to get there.\n" +
                               "You have 50 years to gather enough resources to escape this planet.\n" +
                               "Good Luck!\n\n");

            Console.WriteLine("There are two planets and one galaxy where you will be able to trade:  Planet Earth\n" +
                              "                                                                       Planet Athena\n" +
                              "                                                                       Alpha Centuari");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You currently possess a ship.");
            Thread.Sleep(500);
            ship.enterName();

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+");
            Console.WriteLine("+ RULES!                                                                    +");
            Console.WriteLine("+ 1. Each planet has its own currency                                       +");
            Console.WriteLine("+ 2. You must refuel your spaceship to make more trips                      +");
            Console.WriteLine("+ 3. You will have the option to choose how fast your spaceship can go!     +");
            Console.WriteLine("+ 4. The faster you go, the more fuel you burn                              +");
            Console.WriteLine("+ 5. **Remember Fuel is cheaper on Earth**                                  +");
            Console.WriteLine("+ 6. Enjoy your journey!                                                    +");
            Console.WriteLine("+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+");
            Console.ResetColor();
            Console.ReadLine();

        }

    }
}
