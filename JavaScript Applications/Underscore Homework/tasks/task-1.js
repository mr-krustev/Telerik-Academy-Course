/*
 Create a function that:
 *   Takes an array of students
 *   Each student has a `firstName` and `lastName` properties
 *   **Finds** all students whose `firstName` is before their `lastName` alphabetically
 *   Then **sorts** them in descending order by fullname
 *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
 *   Then **prints** the fullname of founded students to the console
 *   **Use underscore.js for all operations**
 */

function solve() {
    return function (students) {
        function checkFirstAndLastName(student) {
            var i,
                firstName = student.firstName,
                lastName = student.lastName,
                length = firstName.length < lastName.length ? firstName.length : lastName.length;

            for (i = 0; i < length; i += 1) {
                if (firstName[i] < lastName[i]) {
                    return true;
                } else if (firstName[i] > lastName[i]) {
                    return false;
                }
            }
            return true;
        }

        _.chain(students)
            .filter(function (student) {
                var isFirstNameBeforeLast = checkFirstAndLastName(student);
                if (isFirstNameBeforeLast) {
                    return student;
                }
            })
            .each(function (student) {
                student.fullName = student.firstName + ' ' + student.lastName;
            })
            .sortBy('fullName')
            .reverse()
            .each(function (student) {
                console.log(student.fullName);
            });
    };
}

//var students = [{
//    firstName: 'Ester',
//    lastName: 'Reba'
//}, {
//    firstName: 'Abdullo',
//    lastName: 'Vilma'
//}, {
//    firstName: 'Germano',
//    lastName: 'Sabina'
//}, {
//    firstName: 'Naomi',
//    lastName: 'Tichaona'
//}];
//
//var result = solve();
//
//result(students);

module.exports = solve;