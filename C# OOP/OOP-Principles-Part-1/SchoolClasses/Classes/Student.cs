namespace SchoolClasses.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using SchoolClasses.Interfaces;

    public class Student : People, ICommentable
    {
        private string name;
        private string firstName;
        private string lastName;
        private int classNumber;
        private List<string> comments;

        public Student(string firstName, string lastName)
        {
            this.Name = firstName + " " + lastName;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public int ClassNumber  // The class's list of students gives the unique classNumber(which is the index in the list)
        {
            get { return this.classNumber; }
            internal set { this.classNumber = value; } // The classes should be in a library so the Main() should not be able to change student's class number.
        }

        public List<string> Comments
        {
            get { return this.comments; }
        }

        public void AddComment(string comment)
        {
            this.comments.Add(comment);
        }                  // This could also be static and taking argument Student to indentify which student's comments.

        public void ReadComment(int indexOfComment)
        {
            Console.WriteLine(this.comments[indexOfComment]);
        }             // This could also be static and taking argument Student to indentify which student's comments.

        public void ReadAllComments()
        {
            foreach (var com in this.comments)
            {
                Console.WriteLine(com);
            }
        }                           // This could also be static and taking argument Student to indentify which student's comments.




    }
}
