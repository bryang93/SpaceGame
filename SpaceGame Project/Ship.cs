using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame_Project
{
    public class Ship
    {
        public string shipName;
        public uint fuel;
        public double warpSpeed;
        public double speedOfLight;

        public uint fuelBurnSpeed(double distance)
        {
            uint burnSpeed = (Convert.ToUInt32(warpSpeed) * 3) + (Convert.ToUInt32(distance) * 5);
            return burnSpeed;
        }



        public void enterName()
        {
            Console.Write("\nEnter your ships name: ");
            shipName = Console.ReadLine();
        }

        public void returnToShip(Player player)
        {
            Console.WriteLine($"Welcome!\n\nWhere would you like to travel?");
            player.myLocation = shipName;
        }

        // Elliot's warp formula
        public double warpFormula(double w)
        {
            return Math.Pow(w, 10.0 / 3) + Math.Pow(10 - w, -11.0 / 3);
        }

        public void speedInput()
        {
            double speed;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("+=+=+=+=+=+=+");
                Console.WriteLine("+ Attention +");
                Console.WriteLine("+=+=+=+=+=+=+");
                Console.ResetColor();
                
                Console.WriteLine("The faster you travel, the more fule you'll burn!" +
                                  "\nThe more fuel you'll burn, the more money you'll need to spend on fuel" +
                                  "\nHowever, Slower travel will age you faster.\n");
                Console.WriteLine("Warp Speed 1 = slowest\n");
                Console.WriteLine("Enter Warp Speed (1 - 9.5)\n");
                string s = Console.ReadLine();
                bool boolWarp = double.TryParse(s, out speed);
                if (s == "")
                {
                    Console.Clear();
                    Console.WriteLine("No Entry");
                    speed = 0.5;
                }
            } while (speed < 1 || speed > 9.5);
            warpSpeed = speed;
        }

        public void speedCalculation()
        {
            speedInput();
            speedOfLight = warpFormula(warpSpeed);
        }
    }
}
