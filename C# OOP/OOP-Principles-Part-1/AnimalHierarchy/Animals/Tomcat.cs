using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy.Animals
{
    using Interfaces;

    public class Tomcat : Cat, ISound
    {
         public Tomcat()
        {
        }

        public Tomcat(string name, int age)
            :base(name,age,Gender.Male)
        {
        }

        public Tomcat(int age)
            :base(age,Gender.Male)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Manly little mew.");
        }
    }
}
