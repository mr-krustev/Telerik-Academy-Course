namespace StudentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Start
    {
        static void Main()
        {
            var allStudents = new List<Student>()
            {
                new Student("Pesho", "Ivanov", 134506, "02873963", "pesho@abv.bg", new List<double>(){3.25, 4.50, 6.00}, 3),
                new Student("Ivan", "Petrov", 112345, "02893859", "ivan.petrov@gmail.com", new List<double>(){2.00, 2.00, 4.30}, 1),
                new Student("Mario", "Jelqzkov", 167123, "04411858938", "geparda@abv.bg", new List<double>(){4.25, 2.00, 6.00}, 2),
                new Student("Martin", "Bagrqnov", 143106, "06498868389", "magrqnov@abv.bg", new List<double>(){5.25, 5.50, 5.00}, 1),
                new Student("Cesar", "Justinian", 156731, "06395070384", "cesar@rome.org", new List<double>(){6.00, 6.00, 6.00}, 2),
            };

            #region Problem 09. Student groups
            var groupTwoStudents =
                from st in allStudents
                where st.GroupNumber == 2
                orderby st.FirstName
                select st;
            Print(groupTwoStudents);
            #endregion

            #region Problem 10. Student groups extensions
            var studentsFromGroup = allStudents.GetStudentsFromGroup(2);
            Print(studentsFromGroup);
            #endregion

            #region Problem 11. Extract students by email
            Console.WriteLine("All @abv.bg accounts: \n");
            var allABVStudents = allStudents.Where(st => st.EMail.Substring(st.EMail.IndexOf('@')) == "@abv.bg");
            Print(allABVStudents);
            #endregion

            #region Problem 12. Extract students by phone
            Console.WriteLine("All students with sofia phones: \n");
            var allSofiaStudents = allStudents.Where(st => st.Telephone.Substring(0, 2) == "02");
            Print(allSofiaStudents);
            #endregion

            #region Problem 13. Extract students by marks
            Console.WriteLine("Students with at least one excellent mark: \n");
            var allStudentsWithExcellMark = allStudents.Where(st => st.Marks.Contains(6.00));
            Print(allStudentsWithExcellMark);
            #endregion

            #region Problem 14. Extract students with two marks
            Console.WriteLine("All students with 2 marks equal to 2: \n");
            var exactMarkTwoTimes = allStudents.GetStudentWithMarkExactTimes(2.00, 2);
            Print(exactMarkTwoTimes);    
            #endregion

            #region Problem 15. Extract marks
            Console.WriteLine("Marks of students who studied in 2006: \n");
            var allTwoThousandAndSixStudents = allStudents.Where(st => st.FacultyNumber.ToString().Substring(4) == "06");

            foreach (var st in allTwoThousandAndSixStudents)
            {
                Console.WriteLine(string.Join(", ", st.Marks));
            }
            #endregion
        }

        private static void Print(IEnumerable<Student> students)
        {
            foreach (var st in students)
            {
                Console.WriteLine(st);
                Console.WriteLine(new string('-', 40));
            }
        }
    }
}
