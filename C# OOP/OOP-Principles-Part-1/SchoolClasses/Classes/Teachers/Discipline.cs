namespace SchoolClasses.Classes.Teachers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Discipline
    {
        private string name;
        private int lectures;
        private int exercises;

        public Discipline(string name, int lectures, int exercises)
        {
            this.Name = name;
            this.Lectures = lectures;
            this.Exercises = exercises;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Lectures
        {
            get { return this.lectures; }
            set { this.lectures = value; }
        }

        public int Exercises
        {
            get { return this.exercises; }
            set { this.exercises = value; }
        }
    }
}
