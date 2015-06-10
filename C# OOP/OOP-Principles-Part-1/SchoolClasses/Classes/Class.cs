namespace SchoolClasses.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Teachers;

    public class Class
    {
        private List<Student> students;
        private List<Teacher> teachers;
        private string classIdentifier;

        public Class(string classIdentifier)
        {
            this.students = new List<Student>();
            this.teachers = new List<Teacher>();
            try
            {
                this.ClassIdentifier = classIdentifier;
            }
            catch (NotUniqueException)
            {
                Console.WriteLine("There is already a class with that identifier. ({0})", classIdentifier);
            }
        }

        public Class(string classIdentifier, List<Student> students)
        {
            this.students = students;
            this.teachers = new List<Teacher>();
            try
            {
                this.ClassIdentifier = classIdentifier;
            }
            catch (NotUniqueException)
            {
                Console.WriteLine("There is already a class with that identifier. ({0})", classIdentifier);
            }
            AsssignStudentNumber();
        }

        public Class(string classIdentifier, List<Student> students, List<Teacher> teachers)
        {
            this.students = students;
            this.teachers = teachers;
            try
            {
                this.ClassIdentifier = classIdentifier;
            }
            catch (NotUniqueException)
            {
                Console.WriteLine("There is already a class with that identifier. ({0})", classIdentifier);
            }
            AsssignStudentNumber();
        }

        public List<Student> Students
        {
            get { return this.students; }
        }   // get only

        public List<Teacher> Teachers
        {
            get { return this.teachers; }
        }   // get only

        public string ClassIdentifier
        {
            get { return this.classIdentifier; }
            private set
            {
                if (Start.allClasses.Any(cl => cl.classIdentifier == value))
                {
                    throw new NotUniqueException();
                }
                this.classIdentifier = value;
            }
        }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
            AsssignStudentNumber();   
        }

        public void AddTeacher(Teacher teacher)
        {
            if (this.teachers.Contains(teacher))
            {
                Console.WriteLine("This teacher is already teaching this class.");
                return;
            }
            this.teachers.Add(teacher);
        }

        private void AsssignStudentNumber()
        {
            students.OrderBy(st => st.Name);
            foreach (var st in this.students)
            {
                st.ClassNumber = students.IndexOf(st);
            }
        }   // Gives unique student number after sorting the class by name.
    }
}
