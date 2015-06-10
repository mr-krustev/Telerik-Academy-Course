using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy.Animals
{
    using Interfaces;

    public class Cat : Animal, ISound
    {
        public Cat()
        {
        }

        public Cat(string name, int age, Gender gender)
            :base(name,age,gender)
        {        
        }

        public Cat(int age, Gender gender)
            :base(age,gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Mew,Bitch!");
        }
    }
}
