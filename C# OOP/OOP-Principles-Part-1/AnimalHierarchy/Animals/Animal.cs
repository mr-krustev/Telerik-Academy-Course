using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy.Animals
{
    using Interfaces;

    public enum Gender 
    {
        Male, Female 
    };

    public abstract class Animal : ISound
    {
        private string name;
        private int age;
        private Gender gender;

        public Animal()
        {
        }

        public Animal(string name)
        {
            this.Name = name;
        }

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age; 
        }

        public Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public Animal(int age, Gender gender)
        {
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public Gender Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }

        public abstract void ProduceSound();
    }
}
