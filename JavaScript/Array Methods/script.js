/*
 Problem 1. Make person

 Write a function for creating persons.
 Each person must have firstname, lastname, age and gender (true is female, false is male)
 Generate an array with ten person with different names, ages and genders
 */

function Person(firstname, lastname, age, gender) {
    if (firstname == undefined || lastname == undefined || age == undefined || gender == undefined) {
        throw new Error('Cannot create Person with missing properties.');
    }

    if (!(age * 1)) {
        throw new Error('Age cannot be string!');
    }

    if (gender != true && gender != false) {
        //in a real application this won't be this way. :D
        throw new Error('Gender must be false(male) or true(female).')
    }

    return {
        firstName: firstname,
        lastName: lastname,
        age: age,
        gender: gender
    };
}
// If your name is here - I meant no harm! :D
var groupOfPeople = [
    new Person('Pesho', 'Peshovski', 21, false),
    new Person('John', 'Snow', 24, false),
    new Person('Penka', 'Evstatieva', 19, true),
    new Person('Ivka', 'Mivka', 39, true),
    new Person('Petkan', 'Gligan', 40, false),
    new Person('Gergana', 'Zaklana', 25, true),
    new Person('Gospodin', 'Serioznev', 42, false),
    new Person('Mistur', 'Damovidnev', 27, true),
    new Person('Martin', 'Pelin', 72, false),
    new Person('Boiko', 'Barekov', 44, true)
];

console.log(groupOfPeople);

/*
 Problem 2. People of age

 Write a function that checks if an array of person contains only people of age (with age 18 or greater)
 Use only array methods and no regular loops (for, while)
 */

function arePeopleOfAge(arrayOfPeople){
    if(arrayOfPeople.join() == ''){
        throw new Error('Array of people is empty!');
    }

    var result = true;

    arrayOfPeople.forEach(function(person){
        if(person.age < 18){
            result = false;
        }
    })
    return result;
}

console.log('--------------------------------------------');
console.log('Testing arePeopleOfAge!');
console.log('Before :' + arePeopleOfAge(groupOfPeople));
groupOfPeople.push(new Person('Maluk', 'Piklio', 5, false));
console.log('Adding : ' + groupOfPeople[groupOfPeople.length -1].firstName + ' ' + groupOfPeople[groupOfPeople.length -1].lastName);
console.log('After :' + arePeopleOfAge(groupOfPeople));
console.log('Extreme Makeover!');


/*
 Problem 3. Underage people

 Write a function that prints all underaged persons of an array of person
 Use Array#filter and Array#forEach
 Use only array methods and no regular loops (for, while)
 */

function allUnderage(arrayOfPeople){
    if(arrayOfPeople.join() == ''){
        throw new Error('Array of people is empty!');
    }

    arrayOfPeople.filter(function(person){return person.age < 18;})
        .forEach(function (person) {console.log(person);});
}

console.log('--------------------------------------------');
console.log('Testing allUnderage!');
allUnderage(groupOfPeople);
groupOfPeople.push(new Person('Vtori', 'Drebosuk', 5, false));
console.log('Adding : ' + groupOfPeople[groupOfPeople.length -1].firstName + ' ' + groupOfPeople[groupOfPeople.length -1].lastName);
allUnderage(groupOfPeople);
console.log('Extreme Makeover!');

/*
 Problem 4. Average age of females

 Write a function that calculates the average age of all females, extracted from an array of persons
 Use Array#filter
 Use only array methods and no regular loops (for, while)
 */

function averageAgeOfFemales(arrayOfPeople){
    if(arrayOfPeople.join() == ''){
        throw new Error('Array of people is empty!');
    }

    var totalAge = 0,
        numberOfWomen = 0;

    arrayOfPeople.filter(function(person){return person.gender == true;})
        .forEach(function (person) {
            totalAge += person.age*1;
            numberOfWomen += 1;
        });

    return totalAge/numberOfWomen;
}

console.log('--------------------------------------------');
console.log('Testing averageAgeOfFemales!');
console.log('Before :' + averageAgeOfFemales(groupOfPeople));
groupOfPeople.push(new Person('Porednata', 'Jena', 25, true));
console.log('Adding : ' + groupOfPeople[groupOfPeople.length -1].firstName + ' ' + groupOfPeople[groupOfPeople.length -1].lastName);
console.log('After :' + averageAgeOfFemales(groupOfPeople));
console.log('Extreme Makeover!');

/*
 Problem 5. Youngest person

 Write a function that finds the youngest male person in a given array of people and prints his full name
 Use only array methods and no regular loops (for, while)
 Use Array#find
 */

if (!Array.prototype.find) {
    Array.prototype.find = function(predicate) {
        if (this == null) {
            throw new TypeError('Array.prototype.find called on null or undefined');
        }
        if (typeof predicate !== 'function') {
            throw new TypeError('predicate must be a function');
        }
        var list = Object(this);
        var length = list.length >>> 0;
        var thisArg = arguments[1];
        var value;

        for (var i = 0; i < length; i++) {
            value = list[i];
            if (predicate.call(thisArg, value, i, list)) {
                return value;
            }
        }
        return undefined;
    };
}

function getNamesOfYoungestMale (people) {
    var youngestMale =  people.sort(function (a, b) {return a.age - b.age;})
        .find(function(person) {return !person.isFemale;});

    return youngestMale.firstName + ' ' + youngestMale.lastName +
        '(' + youngestMale.age + ', ' + (youngestMale.gender ? 'F' : 'M') + ')';
}

console.log('--------------------------------------------');
console.log('Testing findYoungestPerson!');
console.log('Before : ' + getNamesOfYoungestMale(groupOfPeople));
groupOfPeople.push(new Person('Malko', 'Bebe', 1, false));
console.log('Adding : ' + groupOfPeople[groupOfPeople.length -1].firstName + ' ' + groupOfPeople[groupOfPeople.length -1].lastName);
console.log('After : ' + getNamesOfYoungestMale(groupOfPeople));
console.log('Extreme Makeover!');

/*
 Problem 6. Group people

 Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
 Use Array#reduce
 Use only array methods and no regular loops (for, while)
 */

//Huge thanks to dentia for sharing homework.
var groups = groupOfPeople.reduce(function (gr, person) {
    var letter = person.firstName[0];

    if (gr[letter]) {
        gr[letter].push(person);
    } else {
        gr[letter] = [person];
    }

    return gr;
}, {});

console.log(groups);