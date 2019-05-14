using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame_Project
{
    public class Spaceship : Player
    {
        public string spaceshipName()
        {
            Console.Write("Enter your Ships name: ");
            string shipName = Console.ReadLine();
            return shipName;
        }

        public string actualShipName()
        {
            string shipName = spaceshipName();
            return shipName;
        }

        public void returnToShip()
        {
            Console.WriteLine($"Welcome {name}!\n\nWhere would you like to travel?");
            myLocation = actualShipName();
        }


    }
}
