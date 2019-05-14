using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame_Project
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int width = 165;
            int height = 35;
            Console.WindowWidth = width;
            Console.WindowHeight = height;
            

            Player myPlayer = new Player();
            myPlayer.name = "noName";
            myPlayer.age = 20;
            myPlayer.myLocation = "Earth";
            myPlayer.myCash = 10000;
            myPlayer.myGold = 25;
            myPlayer.myOsmium = 0;
            myPlayer.myTellerium = 0;

            Currency gameCurrency = new Currency();
            Planet gamePlanet = new Planet();
            Dialogue gameDialogue = new Dialogue();
            Ship spaceship = new Ship();
            spaceship.fuel = 100;

            gameDialogue.gameName();
            gameDialogue.enterName(myPlayer);
            gameDialogue.introDialogue(myPlayer, spaceship);
            bool gameOver = true;
            do
            {
                Console.Clear();
                gameDialogue.header(myPlayer, spaceship);
                GameOver(myPlayer);
                zeroCash();
                OptionList();
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.Clear();
                        gamePlanet.travelMenu(gameCurrency, myPlayer, spaceship);

                        break;
                    case "2":
                        Console.Clear();
                        gameCurrency.purchaseMenu(myPlayer, spaceship);
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        gameCurrency.sellMenu(myPlayer);
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("GOOD BYE!");
                        Console.ResetColor();
                        Environment.Exit(0);
                        break;
                }

            } while (gameOver == true);

            void GameOver(Player player)
            {
                    string Title = @"

                                        ____    __    ____  _______  __        ______   ______   .___  ___.  _______ 
                                        \   \  /  \  /   / |   ____||  |      /      | /  __  \  |   \/   | |   ____|
                                         \   \/    \/   /  |  |__   |  |     |  ,----'|  |  |  | |  \  /  | |  |__   
                                          \            /   |   __|  |  |     |  |     |  |  |  | |  |\/|  | |   __|  
                                           \    /\    /    |  |____ |  `----.|  `----.|  `--'  | |  |  |  | |  |____ 
                                            \__/  \__/     |_______||_______| \______| \______/  |__|  |__| |_______|                               

                                                                .___________.  ______  
                                                                |           | /  __  \ 
                                                                `---|  |----`|  |  |  |
                                                                    |  |     |  |  |  |
                                                                    |  |     |  `--'  |
                                                                    |__|      \______/ 
                       
                                      ______      __    __   __  .__   __. .___________. _______ .______       __       ___     
                                     /  __  \    |  |  |  | |  | |  \ |  | |           ||   ____||   _  \     |  |     /   \    
                                    |  |  |  |   |  |  |  | |  | |   \|  | `---|  |----`|  |__   |  |_)  |    |  |    /  ^  \   
                                    |  |  |  |   |  |  |  | |  | |  . `  |     |  |     |   __|  |      /     |  |   /  /_\  \  
                                    |  `--'  '--.|  `--'  | |  | |  |\   |     |  |     |  |____ |  |\  \----.|  |  /  _____  \ 
                                     \_____\_____\\______/  |__| |__| \__|     |__|     |_______|| _| `._____||__| /__/     \__\

                                    ";
                if (player.age >= 70)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(Title);
                    Console.ReadKey();
                    Console.ResetColor();
                    Console.WriteLine("Congratulations for finishing your journey.\n" +
                                       "Oh and, Happy 70th Birthday!");                                                                                              
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else if(player.myOsmium <=0 && player.myCash<=0&& player.myGold<=0 && player.myTellerium <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You didnt not acquire enough resources to escape to your Quinteria.\n" +
                                        "Unfortunatly, you will have to live on earth.\n" +
                                        "You only have limited time, make it count!");
                    Console.WriteLine("GAME OVER");
                    Console.ResetColor();
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else
                {
                    gameOver = true;
                }
            }

            void OptionList()
            {
                if (spaceship.fuel <= 50)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    
                    Console.WriteLine($"{spaceship.shipName}'s fuel is less than 50%.\n");
                                        Console.ResetColor();
                    Console.WriteLine("What would you like to do?\n\n1.) Travel\n2.) Purchase" +
                      "\n3.) Sell\n4.) Quit");
                }
                else Console.WriteLine("What would you like to do?\n\n1.) Travel\n2.) Purchase" +
                    "\n3.) Sell\n4.) Quit");
            }

            void zeroCash()
            {
                if (myPlayer.myCash < 0)
                {
                    myPlayer.myCash = 0;
                    Console.WriteLine("You're out of Money!\n\n You need to sell some items");
                }
            }
        }
    }
}

