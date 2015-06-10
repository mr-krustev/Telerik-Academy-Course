namespace StudentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        private string firstName;
        private string lastName;
        private int facultyNumber;
        private string telephone;
        private string eMail;
        private List<double> marks;
        private int groupNumber;

        public Student()
        {
        }

        public Student(string firstName, string lastName, int facultyNumber, string telephone, string email, List<double> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FacultyNumber = facultyNumber;
            this.telephone = telephone;
            this.EMail = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public int FacultyNumber
        {
            get { return this.facultyNumber; }
            set { this.facultyNumber = value; }
        }

        public string Telephone
        {
            get { return this.telephone; }
            set { this.telephone = value; }
        }

        public string EMail
        {
            get { return this.eMail; }
            set { this.eMail = value; }
        }

        public List<double> Marks
        {
            get { return this.marks; }
            set { this.marks = value; }
        }

        public int GroupNumber
        {
            get { return this.groupNumber; }
            set { this.groupNumber = value; }
        }

        public void AddMark(double mark)
        {
            this.marks.Add(mark);
        }

        public override string ToString()
        {
            return string.Format(
@"Name: {0} {1}
Faculty number: {2}

Telephone: {3}
e-mail: {4}

Marks: [{5}]
Group: {6}", 
                this.firstName, this.lastName, this.facultyNumber, this.telephone, this.eMail, string.Join(", ",this.marks), this.groupNumber);
        }

        
    }
}