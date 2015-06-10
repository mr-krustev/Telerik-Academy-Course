using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GroupNumber
{
    public class Student
    {
        public int GroupNumber { get; set; }

        public string FirstName { get; set; }

        public Student(string firstName, int groupNumber)
        {
            this.FirstName = firstName;
            this.GroupNumber = groupNumber;
        }
    }
}
