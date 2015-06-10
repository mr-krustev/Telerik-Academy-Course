using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    using Animals;

    class Start
    {
        static void Main()
        {
            var listOfAnimals = new Animal[]
                {
                    new Kitten("Pisa",1),
                    new Tomcat("Maiki", 2),
                    new Cat("Crookshanks",6, Gender.Male),
                    new Dog("Lasi",7, Gender.Female),
                    new Frog("Skokla",3, Gender.Female),
                    new Frog("Skoklio", 4, Gender.Male),
                };

            Console.WriteLine("(listOfAnimals)Sum of ages = {0}\n", listOfAnimals.Sum(an => an.Age));
            
            foreach (var animal in listOfAnimals)
            {
                Console.Write(animal.Name + " says: ");
                animal.ProduceSound();
            }
            Console.WriteLine();
            var anotherListOfAnimals = new Animal[]
                {
                    new Kitten(3),
                    new Tomcat(1),
                    new Cat(8, Gender.Female),
                    new Dog(11, Gender.Male),
                    new Frog(7, Gender.Female),
                    new Frog(2, Gender.Male),
                };

            var yetAnotherListOfAnimals = new Animal[]
                {
                    new Kitten(0),
                    new Tomcat(1),
                    new Cat(4, Gender.Female),
                    new Dog(8, Gender.Male),
                    new Frog(9, Gender.Female),
                    new Frog(6, Gender.Male),
                };



            Console.WriteLine("(anotherListOfAnimals)Sum of ages = {0}\n", anotherListOfAnimals.Sum(an => an.Age));

            Console.WriteLine("(yetAnotherListOfAnimals)Sum of ages = {0}\n", yetAnotherListOfAnimals.Sum(an => an.Age));

            //This is working. Feel free to create your own arrays.
        }
    }
}
