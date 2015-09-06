/* 
 Create a function that:
 *   Takes an array of students
 *   Each student has:
 *   `firstName`, `lastName`, `age` and `marks` properties
 *   `marks` is an array of decimal numbers representing the marks
 *   **finds** the student with highest average mark (there will be only one)
 *   **prints** to the console  'FOUND_STUDENT_FULLNAME has an average score of MARK_OF_THE_STUDENT'
 *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
 *   **Use underscore.js for all operations**
 */

function solve() {
    return function (students) {
        var highestGrade = 0;
        function calculateAvgGrade(marks) {
            var i,
                result = 0,
                len = marks.length;
            for (i = 0; i < len; i += 1) {
                result += marks[i];
            }
            return result / len;
        }

        var result = _.chain(students)
            .each(function (student) {
                student.fullName = student.firstName + ' ' + student.lastName;
                student.avgMark = calculateAvgGrade(student.marks);
                if(highestGrade < student.avgMark){
                    highestGrade = student.avgMark;
                }
            })
            .find(function(student){
                return student.avgMark == highestGrade;
            })
            .value();

        console.log(result.fullName + ' has an average score of ' + result.avgMark);
    };
}

module.exports = solve;
