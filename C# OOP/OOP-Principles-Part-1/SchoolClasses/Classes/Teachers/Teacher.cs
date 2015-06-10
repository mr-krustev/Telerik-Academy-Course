namespace SchoolClasses.Classes.Teachers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using SchoolClasses.Interfaces;

    public class Teacher : People, ICommentable
    {
        // TODO : Implement teacher
        private string name;
        private List<Discipline> taughtDisciplines;
        private List<string> comments;

        public Teacher(string firstName, string lastName)
        {
            this.Name = firstName + " " + lastName;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public void AddDiscipline(Discipline discipline)
        {
            if (taughtDisciplines.Contains(discipline))
            {
                Console.WriteLine("This discipline is already taught by this teacher.");
                return;
            }
            this.taughtDisciplines.Add(discipline);
        }


        public void AddComment(string comment)
        {
            comments.Add(comment);
        }

        public void ReadComment(int indexOfComment)
        {
            Console.WriteLine( this.comments[indexOfComment]);
        }

        public List<string> Comments
        {
            get
            {
                return this.comments;
            }
        }


        public void ReadAllComments()
        {
            throw new NotImplementedException();
        }
    }
}
