using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy.Animals
{
    using Interfaces;

    public class Dog : Animal, ISound
    {
        public Dog()
        {
        }

        public Dog(string name, int age, Gender gender)
            :base(name,age,gender)
        {
        }

        public Dog(int age, Gender gender)
            :base(age,gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Bau-bau, motherfucker.");
        }
    }
}
