namespace StudentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Extensions
    {
        public static IEnumerable<Student> GetStudentsFromGroup(this IEnumerable<Student> students, int group)
        {
            var studentsInGivenGroup = students
                .Where(st => st.GroupNumber == group)
                .OrderBy(st => st.FirstName);
            return studentsInGivenGroup;
        }

        public static IEnumerable<Student> GetStudentWithMarkExactTimes(this IEnumerable<Student> students, double mark, int countMark)
        {
            var studentsWithMark = students
                .Where(st => st.Marks.Count(x => x == mark) == countMark);
            return studentsWithMark;
        }
    }
}
