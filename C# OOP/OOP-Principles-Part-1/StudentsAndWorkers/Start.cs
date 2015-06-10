namespace StudentsAndWorkers
{
//    Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
//    Initialize a list of 10 workers and sort them by money per hour in descending order.

//    Merge the lists and sort them by first name and last name.
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Start
    {
        static void Main()
        {
            var students = new List<Student>()
                {
                    new Student("Ivan", "Petrov", 2.00),
                    new Student("Petar", "Qnakiev", 3.00),
                    new Student("Hipopotam", "Slonov", 6.00),
                    new Student("Martin", "Ivanov", 4.00),
                    new Student("Mario", "Mitov", 6.00),

                    new Student("Stefan", "Punevski", 5.00),
                    new Student("Hristiqn", "Haralampiev", 2.00),
                    new Student("Hristo", "Hristov", 4.00),
                    new Student("Mikola", "Ohotnik", 5.00),
                    new Student("Boris", "Rangelov", 2.00)
                };

            var workers = new List<Worker>()
            {
               new Worker("Georgi", "Purvanov", 2000.00, 1),
               new Worker("Chesten", "Rabotnikov", 250.00, 8),
               new Worker("Predpriemach", "Inovativnikov", 1000.00, 6),
               new Worker("Justin", "Timberlake", 3000.00, 4),
               new Worker("Mihail", "Jivotinski", 400.00, 8),

               new Worker("Atanas", "Vidinov", 350.00, 8),
               new Worker("Martin", "Chorbadjiiski", 500.00, 6),
               new Worker("Mitko", "Programistki", 1000.00, 24),
               new Worker("Ivan", "AiTiTo", 2000.00, 6),
               new Worker("Pesho", "Bezparichnev", 0.00, 0)
            };

            var orderedStudents = students.OrderBy(st => st.Grade);
            var orderedWorkers = workers.OrderByDescending(w => w.MoneyPerHour());

            Print(orderedStudents);
            Print(orderedWorkers);

            var concatGroups = orderedStudents
                .Concat<Human>(orderedWorkers)
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName);

            Print(concatGroups);
        }

        private static void Print<T>(IOrderedEnumerable<T> collection)
        {
            foreach (var line in collection)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine();
        }
    }
}
