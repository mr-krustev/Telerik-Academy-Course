using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy.Animals
{
    using Interfaces;

    public class Kitten : Cat, ISound   
    {
        public Kitten()
        {
        }

        public Kitten(string name, int age)
            :base(name,age, Gender.Female)
        {
        }

        public Kitten(int age)
            :base(age,Gender.Female)
        {
        }


        public override void ProduceSound()
        {
            Console.WriteLine("Sweet little mew");
        }
    }
}
