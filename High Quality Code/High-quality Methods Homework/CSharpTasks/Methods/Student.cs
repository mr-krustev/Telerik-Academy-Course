namespace Methods
{
    using System;

    public class Student
    {
        public Student(string firstName, string lastName, DateTime dateOfBirth, string otherInfo = "")
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.OtherInfo = otherInfo;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; private set; }

        public string OtherInfo { get; set; }

        public bool IsOlderThan(Student other)
        {
            DateTime firstDate =
                DateTime.Parse(this.OtherInfo.Substring(this.OtherInfo.Length - 10));
            DateTime secondDate =
                DateTime.Parse(other.OtherInfo.Substring(other.OtherInfo.Length - 10));
            return firstDate > secondDate;
        }
    }
}