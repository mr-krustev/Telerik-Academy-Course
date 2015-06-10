using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy.Animals
{
    using Interfaces;

    public class Frog : Animal, ISound
    {
        public Frog()
        {
        }

        public Frog(string name, int age, Gender gender)
            :base(name,age,gender)
        {
        }

        public Frog(int age, Gender gender)
            :base(age,gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Rebit");
        }
    }
}
