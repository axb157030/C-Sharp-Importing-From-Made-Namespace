using System;
using ADT;

namespace TestProject
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Animal octopus = new Animal("Octopus", 4, AgeUnits.years); 
            octopus.Greetings();
        }
    }
}
