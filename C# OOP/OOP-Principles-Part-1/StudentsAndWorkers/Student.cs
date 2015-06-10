namespace StudentsAndWorkers
{
    //Define a new class Student which is derived from Human and has a new field – grade. 
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student : Human
    {
        private double grade;

        public Student()
        {
        }

        public Student(string firstName, string secondName)
        {
            this.FirstName = firstName;
            this.LastName = LastName;
        }

        public Student(string firstName, string secondName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = LastName;
            this.Grade = grade;
        }

        public double Grade
        {
            get { return this.grade; }
            set { this.grade = value; }
        }
    }
}
