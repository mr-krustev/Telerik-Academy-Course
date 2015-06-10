/*
Problem 18. Grouped by GroupNumber

Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
Use LINQ.
*/
namespace GroupNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class GroupByNumber
    {
        static void Main()
        {
            List<Student> allStudents = new List<Student>()
                {
                    new Student("Pesho", 3),
                    new Student("Ivan", 1),
                    new Student("Mario", 2),
                    new Student("Martin", 1),
                    new Student("Cesar", 2),
                };

            #region Problem 18. Grouped by GroupNumber
            var groupedByGroupNumber =
                from student in allStudents
                orderby student.GroupNumber
                group student by student.GroupNumber;

            foreach (var group in groupedByGroupNumber)
            {
                Console.WriteLine(new string('-',40));
                Console.WriteLine(group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine(student.FirstName);
                }
            }
            Console.WriteLine(new string('-', 40));
            #endregion

            #region Problem 19. Grouped by GroupName extensions
            allStudents.GroupStudents();
            #endregion
        }
    }
}
