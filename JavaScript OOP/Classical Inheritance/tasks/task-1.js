/* Task Description */
/* 
 Create a function constructor for Person. Each Person must have:
 *	properties `firstname`, `lastname` and `age`
 *	firstname and lastname must always be strings between 3 and 20 characters, containing only Latin letters
 *	age must always be a number in the range 0 150
 *	the setter of age can receive a convertible-to-number value
 *	if any of the above is not met, throw Error
 *	property `fullname`
 *	the getter returns a string in the format 'FIRST_NAME LAST_NAME'
 *	the setter receives a string is the format 'FIRST_NAME LAST_NAME'
 *	it must parse it and set `firstname` and `lastname`
 *	method `introduce()` that returns a string in the format 'Hello! My name is FULL_NAME and I am AGE-years-old'
 *	all methods and properties must be attached to the prototype of the Person
 *	all methods and property setters must return this, if they are not supposed to return other value
 *	enables method-chaining
 */
function solve() {
    var Person = (function () {

        function checkName(name) {
            return name.length >= 3 && name.length <= 20&& /[A-z\u00C0-\u00ff\s'\.,-\/#!$%\^&\*;:{}=\-_`~()]/.test(name);
        }

        function checkAge(age) {
            return age >= 0 && age <= 150;
        }

        function Person(firstName, lastName, age) {
            if (checkName(firstName) && checkName(lastName)) {
                this.firstname = firstName;
                this.lastname = lastName;
            } else {
                throw new Error('Invalid name!');
            }

            if (checkAge(age)) {
                this.age = age;
            } else {
                throw new Error('Invalid age!');
            }
        }

        Object.defineProperty(Person.prototype, 'fullname', {
            get: function() {
                return this.firstname + ' ' + this.lastname;
            },
            set: function(value) {
                if (!checkName(value.split(' ')[0]) ||
                    !checkName(value.split(' ')[1])) {
                    throw 'Invalid name!';
                }
                this.firstname = value.split(' ')[0];
                this.lastname = value.split(' ')[1];
            },
            enumerable: true,
            configurable: true
        });

        Person.prototype.introduce = function () {
            return 'Hello! My name is ' + this.fullname + ' and I am ' + this.age + '-years-old';
        };

        return Person;
    }());
    return Person;
}
module.exports = solve;
