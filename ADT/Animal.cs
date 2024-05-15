using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADT
{
    public class Animal
    {
        public Animal() {}
        public Animal(string name, int age, AgeUnits ageUnit) {
            this.Name = name;
            this.Age = age;
            this.AgeUnit = ageUnit;
        }

        public string Name {get; set;}
        public int Age {get; set;}
        public AgeUnits AgeUnit {get; set;}

        public void Greetings() {
            Console.WriteLine("The animal is an , " + this.Name + " that is " + this.Age + " " + this.AgeUnit + " old.");
        }
    }



}