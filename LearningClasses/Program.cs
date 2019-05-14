using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            planet Earth = new planet();
            Earth.name = "Earth";
            Earth.CurrentPosition = Earth.name;

            planet Athena = new planet();
            Athena.name = "Athena";
            Athena.CurrentPosition = Athena.name;

            Console.WriteLine("The ")


            planet AlphaC = new planet();

           



        }

    }

    class planet
    {
        public string name { get; set; }
        public decimal distance { get; set; }
        public string CurrentPosition { get; set; }
       

            
    }

}
