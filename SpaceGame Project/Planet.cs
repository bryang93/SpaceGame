using System;

namespace SpaceGame_Project
{
    
    public class Planet
    {
        public void welcomeToEarth(Currency currency, Player player)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Traveling to Earth.....");
            Console.ResetColor();
            player.myLocation = "Earth";
            Console.ReadLine();
            Console.Clear();

             string Title = @"



              +=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+
              +   __        __   _                            _          _____           _   _        +
              +   \ \      / /__| | ___ ___  _ __ ___   ___  | |_ ___   | ____|__ _ _ __| |_| |__     +
              +    \ \ /\ / / _ \ |/ __/ _ \| '_ ` _ \ / _ \ | __/ _ \  |  _| / _` | '__| __| '_ \    +
              +     \ V  V /  __/ | (_| (_) | | | | | |  __/ | || (_) | | |__| (_| | |  | |_| | | |   +
              +      \_/\_/ \___|_|\___\___/|_| |_| |_|\___|  \__\___/  |_____\__,_|_|   \__|_| |_|   +
              +                                                                                       +
              +=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+
                                                                                  
            ";
                       
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Title);
            Console.WriteLine($"\t\t\t\t\t\tMerchant {player.name}");
            Console.ResetColor();
            Console.ReadKey();
            
        }
        public void welcomeToAthena(Currency currency, Player player)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Traveling to Athena.....");
            Console.ResetColor();
            player.myLocation = "Athena";
            Console.ReadLine();
            Console.Clear();

            string Title = @"

              
              +=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+
              +  __        __   _                            _             _   _   _                        +
              +  \ \      / /__| | ___ ___  _ __ ___   ___  | |_ ___      / \ | |_| |__   ___ _ __   __ _   +
              +   \ \ /\ / / _ \ |/ __/ _ \| '_ ` _ \ / _ \ | __/ _ \    / _ \| __| '_ \ / _ \ '_ \ / _` |  +
              +    \ V  V /  __/ | (_| (_) | | | | | |  __/ | || (_) |  / ___ \ |_| | | |  __/ | | | (_| |  + 
              +     \_/\_/ \___|_|\___\___/|_| |_| |_|\___|  \__\___/  /_/   \_\__|_| |_|\___|_| |_|\__,_|  +
              +                                                                                             +
              +=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+   ";

                                                                    
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Title);
            Console.WriteLine($"\t\t\t\t\t\tMerchant {player.name}");
            Console.ResetColor();
            Console.ReadKey();
        }
        public void welcomeToAlphaC(Currency currency, Player player)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Traveling to Alpha Centauri.....");
            Console.ResetColor();
            player.myLocation = "Alpha Centauri";
            Console.ReadLine();
            Console.Clear();

            string Title = @"
                         +=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+               
                         +    __        __   _                                                       +
                         +    \ \      / /__| | ___ ___  _ __ ___   ___                              +
                         +     \ \ /\ / / _ \ |/ __/ _ \| '_ ` _ \ / _ \                             +
                         +      \ V  V /  __/ | (_| (_) | | | | | |  __/                             +
                         +       \_/\_/ \___|_|\___\___/|_| |_| |_|\___|                             +
                         +                           _                                               +
                         +                          | |_ ___                                         +
                         +                          | __/ _ \                                        +
                         +                          | || (_) |                                       +
                         +                           \__\___/                                        +
                         +       _    _       _              ____           _                   _    +   
                         +      / \  | |_ __ | |__   __ _   / ___|___ _ __ | |_ __ _ _   _ _ __(_)   +
                         +     / _ \ | | '_ \| '_ \ / _` | | |   / _ \ '_ \| __/ _` | | | | '__| |   +
                         +    / ___ \| | |_) | | | | (_| | | |__|  __/ | | | || (_| | |_| | |  | |   +
                         +   /_/   \_\_| .__/|_| |_|\__,_|  \____\___|_| |_|\__\__,_|\__,_|_|  |_|   +
                         +             |_|                                                           +
                         +=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+                         
                          ";                                                                      
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Title);
            Console.WriteLine($"\t\t\t\t\t\t\tMerchant {player.name}");
            Console.ResetColor();
            Console.ReadKey();
        }


        public void travelOptionAthena(Currency currency, Player player, Ship ship)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(
                  "Where would you like to travel next?\n\t" +
                  "1 = Earth\n\t" +
                  "2 = Alpha Centauri");
            Console.ResetColor();
            int planetSelection;
            string decision = Console.ReadLine();
            bool boolPlanetSelection = int.TryParse(decision, out planetSelection);

            if (planetSelection == 1)
            {
                Console.Clear();
                double distance = 2.1835;
                while (ship.fuelBurnSpeed(distance) > ship.fuel)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Uh Oh!\nIt Looks like your {ship.shipName} does not have enough fuel!");
                    Console.ResetColor();
                    currency.athenaBuyMenu(player, ship);
                }
                ship.speedCalculation();
                player.age += distance / ship.speedOfLight;
                ship.fuel -= ship.fuelBurnSpeed(distance);
                welcomeToEarth(currency, player);
            }
            else if (planetSelection == 2)
            {
                Console.Clear();
                double distance = 2.1835;
                while (ship.fuelBurnSpeed(distance) > ship.fuel)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{ship.shipName} needs more fuel\nRemember fuel is cheaper on Earth!");
                    Console.ResetColor();
                    currency.athenaBuyMenu(player, ship);
                }
                ship.speedCalculation();
                player.age += distance / ship.speedOfLight;
                ship.fuel -= ship.fuelBurnSpeed(distance);
                welcomeToAlphaC(currency, player);
            }
            else
            {
                Console.Clear();
                travelOptionAthena(currency, player, ship);
            }
        }
        public void travelOptionAlpha(Currency currency, Player player, Ship ship)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(
                       "Where would you like to travel next?\n\t" +
                       "1 = Earth\n\t" +
                       "2 = Athena");
            Console.ResetColor();
            int planetSelection;
            string decision = Console.ReadLine();
            bool boolPlanetSelection = int.TryParse(decision, out planetSelection);

            if (planetSelection == 1)
            {
                Console.Clear();
                double distance = 4.367;
                while (ship.fuelBurnSpeed(distance) > ship.fuel)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Uh oh! {ship.shipName} doesn't have enough fuel!\nSelcet the fuel option to refill");
                    Console.ResetColor();
                    currency.alphaBuyMenu(player, ship);
                }
                ship.speedCalculation();
                player.age += distance / ship.speedOfLight;
                ship.fuel -= ship.fuelBurnSpeed(distance);
                welcomeToEarth(currency, player);
            }
            else if (planetSelection == 2)
            {
                Console.Clear();
                double distance = 2.1835;
                while (ship.fuelBurnSpeed(distance) > ship.fuel)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{ship.shipName} needs more fuel!");
                    Console.ResetColor();
                    currency.alphaBuyMenu(player, ship);
                }
                ship.speedCalculation();
                player.age += distance / ship.speedOfLight;
                ship.fuel -= ship.fuelBurnSpeed(distance);
                welcomeToAthena(currency, player);
            }
            else
            {
                Console.Clear();
                travelOptionAlpha(currency, player, ship);
            }
        }
        public void travelOptionEarth(Currency currency, Player player, Ship ship)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(
                        "Where would you like to travel next?\n\t" +
                        "1 = Alpha Centouri\n\t" +
                        "2 = Athena");
            Console.ResetColor();
            int planetSelection;
            string decision = Console.ReadLine();
            bool boolPlanetSelection = int.TryParse(decision, out planetSelection);

            if (planetSelection == 1)
            {
                Console.Clear();
                double distance = 4.367;
                while (ship.fuelBurnSpeed(distance) > ship.fuel)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Oh No! It looks like {ship.shipName} is running out of fuel.\nPlease buy more fuel!");
                    Console.ResetColor();
                    currency.earthBuyMenu(player, ship);
                }
                ship.speedCalculation();
                player.age += distance / ship.speedOfLight;
                ship.fuel -= ship.fuelBurnSpeed(distance);
                welcomeToAlphaC(currency, player);
            }
            else if (planetSelection == 2)
            {
                Console.Clear();
                double distance = 2.1835;
                while (ship.fuelBurnSpeed(distance) > ship.fuel)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Uh Oh!\nIt Looks like your {ship.shipName} does not have enough fuel!\nTo resume your journey you must purchase more fuel");
                    Console.ResetColor();
                    currency.earthBuyMenu(player, ship);
                }
                ship.speedCalculation();
                player.age += distance / ship.speedOfLight;
                ship.fuel -= ship.fuelBurnSpeed(distance);
                welcomeToAthena(currency, player);
            }
            else
            {
                Console.Clear();
                travelOptionEarth(currency, player, ship);
            }
        }


        public void travelMenu(Currency currency, Player player, Ship ship)
        {
            if (player.myLocation == "Earth")
            {
                travelOptionEarth(currency, player, ship);
            }
            else if (player.myLocation == "Athena")
            {
                travelOptionAthena(currency, player, ship);
            }
            else if (player.myLocation == "Alpha Centauri")
            {
                travelOptionAlpha(currency, player, ship);
            }
            else
            {
                ship.returnToShip(player);
            }
        }

    }
}
