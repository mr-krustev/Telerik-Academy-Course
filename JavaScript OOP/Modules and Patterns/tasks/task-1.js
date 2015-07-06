/* Task Description */
/* 
 * Create a module for a Telerik Academy course

 * The course has a title and presentations
 * Each presentation also has a title
 * There is a homework for each presentation

 * There is a set of students listed for the course
 * Each student has firstname, lastname and an ID
 * IDs must be unique integer numbers which are at least 1
 * Each student can submit a homework for each presentation in the course

 * Create method init
 * Accepts a string - course title
 * Accepts an array of strings - presentation titles
 * Throws if there is an invalid title
 * Titles do not start or end with spaces
 * Titles do not have consecutive spaces
 * Titles have at least one character
 * Throws if there are no presentations

 * Create method addStudent which lists a student for the course
 * Accepts a string in the format 'Firstname Lastname'
 * Throws if any of the names are not valid
 * Names start with an upper case letter
 * All other symbols in the name (if any) are lowercase letters
 * Generates a unique student ID and returns it

 * Create method getAllStudents that returns an array of students in the format:
 * {firstname: 'string', lastname: 'string', id: StudentID}

 * Create method submitHomework
 * Accepts studentID and homeworkID
 * homeworkID 1 is for the first presentation
 * homeworkID 2 is for the second one
 * ...
 * Throws if any of the IDs are invalid

 * Create method pushExamResults
 * Accepts an array of items in the format {StudentID: ..., Score: ...}
 * StudentIDs which are not listed get 0 points
 * Throw if there is an invalid StudentID
 * Throw if same StudentID is given more than once ( he tried to cheat (: )
 * Throw if Score is not a number

 * Create method getTopStudents which returns an array of the top 10 performing students
 * Array must be sorted from best to worst
 * If there are less than 10, return them all
 * The final score that is used to calculate the top performing students is done as follows:
 * 75% of the exam result
 * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
 */

function solve() {
    var lastId = 0;
    // private methods
    function getNextId() {
        return ++lastId;
    }

    function checkStudentId(obj, studentID) {
        var i, len;

        for (i = 0, len = obj.students.length; i < len; i += 1) {
            if (obj.students[i].id === studentID) {
                return true;
            }
        }
        return false;
    }

    function checkHomeworkID(obj, homeworkID) {
        return obj.presentations.length >= homeworkID && homeworkID !== 0;
    }

    function checkIfUsed(ID, arrayOfIDs) {
        var result;

        arrayOfIDs.forEach(function (id) {
            if (id === ID) {
                result = true;
            }
        });

        return !!result;
    }

    var Course = {
        get title() {
            return this._title;
        },
        set title(value) {
            var regExp = new RegExp('\\w[ ]{2,}\\w', 'g');
            if (typeof value !== 'string') {
                throw new Error('Title must be string!');
            }

            if (value[0] === ' ' || value[value.length - 1] === ' ') {
                throw new Error('Title cannot start or end with a space!');
            }

            if (regExp.test(value)) {
                throw new Error('There shouldn\'t be any consecutive spaces in the Course title!');
            }

            this._title = value;
        },
        get presentations() {
            return this._presentations;
        },
        set presentations(value) {
            var i, len,
                regExp = new RegExp('\\w[ ]{2,}\\w', 'g');

            if (!(Array.isArray(value))) {
                throw new Error('Invalid presentations input.');
            }

            if (value.length === 0) {
                throw new Error('Empty array of presentations!');
            }

            for (i = 0, len = value.length; i < len; i += 1) {
                if (regExp.test(value[i])) {
                    throw new Error('There shouldn\'t be any consecutive spaces in the presentations\' titles!');
                }

                if (!value[i]) {
                    throw new Error('Presentations\' titles must not be empty!');
                }
            }
            this._presentations = value;
        },

        //Constructor
        init: function (title, presentations) {
            this.title = title;
            this.presentations = presentations;
            this.students = [];

            return this;
        },

        //Methods
        addStudent: function (name) {
            var i, len,
                regExp = new RegExp('[^A-Za-z]'),
                student = {},
                names = name.split(' ');
            //Validate!
            if (typeof name !== 'string') {
                throw new Error('Name must be string!');
            }

            if (names.length !== 2) {
                throw new Error('Must provide First and Last name');
            }

            for (i = 0, len = names.length; i < len; i += 1) {
                if (names[i][0] !== names[i][0].toUpperCase()) {
                    throw new Error('Invalid name! First letters must be capitalized!');
                }

                if (regExp.test(names[i])) {
                    throw new Error('Invalid name! Must contain only letters!');
                }
            }

            student.firstname = names[0];
            student.lastname = names[1];
            student.id = getNextId();
            student.score = 0;
            this.students.push(student);
            return student.id;
        },
        getAllStudents: function () {
            return this.students.slice();
        },
        submitHomework: function (studentID, homeworkID) {
            if (!(checkStudentId(this, studentID) && checkHomeworkID(this, homeworkID))) {
                throw new Error('Either student ID or homework ID is invalid');
            }
        },
        pushExamResults: function (results) {
            var i, len, currentId, usedStudIds = [];

            if (!Array.isArray(results)) {
                throw new Error('Invalid results!');
            }


            for (i = 0, len = results.length; i < len; i += 1) {
                currentId = results[i].StudentID;
                if (usedStudIds.length === 0 || !checkIfUsed(currentId, usedStudIds)) {
                    usedStudIds.push(results[i].StudentID);
                } else {
                    throw new Error('Used ID!');
                }

                if (isNaN(results[i].score)) {
                    throw new Error('Score must be provided!');
                }

                if (currentId > this.students.length || currentId < 1) {
                    throw new Error('There is no student with such ID.');
                }

                if (isNaN(currentId)) {
                    throw new Error('Invalid ID!');
                }

                this.students[currentId - 1].score = results[i].score;
            }
            this.students.sort(function (studentA, studentB) {
                return studentB.score - studentA.score;
            });
        },
        getTopStudents: function () {
            if (!this.students.length) {
                throw new Error('There are no students.');
            }

            if (this.students.length <= 10) {
                return this.students.slice(0);
            }

           return this.students.slice(0,10);
        }
    };
    return Course;
}


module.exports = solve;
