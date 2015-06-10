/*
Problem 1. Student class

Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.
Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=. 
*/
namespace StudentClass.Students
{
    using System;
    using System.Linq;
    using System.Text;

    using StudentClass.Common;

    public class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string socialSecurityNumber;
        private string permanentAdress;
        private string mobilePhone;

        public Student()
        {
        }

        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Student(string firstName, string middleName, string lastName)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
        }

        public Student(string firstName, string middleName, string lastName, string socialSecurityNumber, string permanentAdress, string mobilePhone,
            int course, SpecialtyType specialty, UniversityName university, FacultyName faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SocialSecurtiyNumber = socialSecurityNumber;
            this.PermanentAdress = permanentAdress;
            this.MobilePhone = mobilePhone;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }   // Problem 2.IClonable constructor

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "FirstName", "First name cannot be null or empty.");
                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }

            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "MiddleName", "Middle name cannot be null or empty.");
                this.middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "LastName", "Last name cannot be null or empty.");
                this.lastName = value;
            }
        }

        public string SocialSecurtiyNumber
        {
            get
            {
                return this.socialSecurityNumber;
            }

            set
            {
                if (value.Any(s => Char.IsLetter(s)))
                {
                    throw new ArgumentException("SocialSecurityNumber", "Social security number cannot contain letters."); // Let's hope no one enters question marks! :D
                }
                this.socialSecurityNumber = value;
            }
        }

        public string PermanentAdress
        {
            get { return this.permanentAdress; }
            set { this.permanentAdress = value; }
        }

        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }
            set
            {
                if (value.Any(s => Char.IsLetter(s)))
                {
                    throw new ArgumentException("MobilePhone", "Mobile phone cannot contain letters.");
                }
                this.mobilePhone = value;
            }
        }

        public string EMail { get; set; }

        public int Course { get; set; }

        public SpecialtyType Specialty { get; set; }

        public UniversityName University { get; set; }

        public FacultyName Faculty { get; set; }

        public override string ToString()
        {
            var result = new StringBuilder();
            
            result.AppendLine("Name: " + string.Join(" ", this.firstName, this.middleName, this.lastName));
            result.AppendLine("Permanent adress: " + this.permanentAdress);
            result.AppendLine("University: " + this.University);
            result.AppendLine("Faculty: " + this.Faculty);
            result.AppendLine("Specialty: " + this.Specialty);

            return result.ToString();
        }

        public override bool Equals(object obj)
        {
            var st = obj as Student;    // Checks if 2 students have the same 3 names
            return this.firstName.Length.Equals(st.firstName.Length);
        }

        public override int GetHashCode()
        {
            return this.firstName.GetHashCode()*17+this.lastName.GetHashCode()*17+this.permanentAdress.GetHashCode()*17;
        }

        public static bool operator ==(Student firstStudent,Student secondStudent)
        {
            return firstStudent.firstName.Length == secondStudent.firstName.Length;
        }

        public static bool operator !=(Student firstStudent,Student secondStudent)
        {
            return firstStudent.firstName.Length != secondStudent.firstName.Length;
        }

        public object Clone()
        {
            Student temp = new Student(this.firstName, this.middleName, this.lastName, this.socialSecurityNumber, this.permanentAdress, this.mobilePhone,
                this.Course, this.Specialty, this.University, this.Faculty);

            return temp;
        }               // Problem 2. IClonable



        public int CompareTo(Student other)
        {
            var result = string.Join(" ", this.firstName, this.middleName, this.lastName).CompareTo(string.Join(" ", other.firstName, other.middleName, other.lastName));
            if (result == 0)    // If the names are the same will enter the second check
            {
                result = this.socialSecurityNumber.CompareTo(other.socialSecurityNumber);
            }

            return result;
        }

    }
}
