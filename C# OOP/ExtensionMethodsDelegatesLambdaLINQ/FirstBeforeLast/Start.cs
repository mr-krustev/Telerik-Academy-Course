/*
Problem 3. First before last

Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
Use LINQ query operators.
----------------------------------------
Problem 4. Age range

Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
----------------------------------------
Problem 5. Order students

Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
Rewrite the same with LINQ.
*/

namespace FirstBeforeLast
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
                new Student() {FirstName = "Gosho", LastName = "Ivanov", Age = 18},
                new Student() {FirstName = "Petran", LastName = "Petrov", Age = 22},
                new Student() {FirstName = "Stefan", LastName = "Kirqkov", Age = 25},
                new Student() {FirstName = "Stamat", LastName = "Pirinkov", Age = 16},
                new Student() {FirstName = "Kiril", LastName = "Ribarov", Age = 21},
            };

            #region Problem 3. First before last
            var coolStudents =
                from st in allStudents
                where st.FirstName.CompareTo(st.LastName) < 0
                select st;
            Print(coolStudents);

            var lambdaCoolStudents = allStudents.Where(st => st.FirstName.CompareTo(st.LastName) < 0);
            Print(lambdaCoolStudents);
            #endregion

            #region Problem 4. Age range
            var coolAge =
                from st in allStudents
                where st.Age < 24 && st.Age > 18
                select st;
            Print(coolAge);

            var lambdaCoolAge = allStudents.Where(st => st.Age < 24 && st.Age > 18);
            Print(lambdaCoolAge);
            #endregion

            #region Problem 05. Order students
            var sortedCoolStudents = allStudents.OrderByDescending(st => st.FirstName).ThenByDescending(st => st.LastName);
            Print(sortedCoolStudents);

            var linqSortedCoolStudents =
                from st in allStudents
                orderby st.FirstName descending,
                st.LastName descending
                select st;
            Print(linqSortedCoolStudents);
            #endregion
        }

        private static void Print(IEnumerable<Student> coolStudents)
        {
            foreach (var student in coolStudents)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine();
        }
    }
}
