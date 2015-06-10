using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupNumber
{
    public static class StudentExtensions
    {
        public static void GroupStudents(this List<Student> student)
        {
            var groupedByGroupNumber =
                from st in student
                orderby st.GroupNumber
                group st by st.GroupNumber;

            foreach (var group in groupedByGroupNumber)
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine(group.Key);
                foreach (var st in group)
                {
                    Console.WriteLine(st.FirstName);
                }
            }
            Console.WriteLine(new string('-', 40));
        }

    }
}
