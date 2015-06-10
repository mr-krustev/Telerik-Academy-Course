/*
 Problem 1. Planar coordinates

 Write functions for working with shapes in standard Planar coordinate system.
 Points are represented by coordinates P(X, Y)
 Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
 Calculate the distance between two points.
 Check if three segment lines can form a triangle.

 */

function checkForEmpty(number) {
    if (number === 0) {
        return false;
    }

    if (number === '') {
        return true;
    }

    if (isNaN(number)) {
        return true;
    }

    return false;
}

function changeInputs(info) {
    return info == 'calculate' ?
        document.getElementById('options').innerHTML = '<em>Ex.: A = 0,0; B = 3,4</em> <br>' +
            '<label for="pointA">Point A: </label><input type="text" id="pointA"/> ' +
            '<label for="pointB">Point B: </label><input type="text" id="pointB"/>' :


        document.getElementById('options').innerHTML = '<em>Ex.: A1 = 0,0; A2 = 1,1, B1= 2,2; B2 = 3,3 etc.</em> <br>' +
            '<label for="lineAP1">Line A point 1:</label>' + '<input type="text" id="lineAP1"/> ' +
            '<label for="lineBP1">Line B point 1:</label>' + '<input type="text" id="lineBP1"/> ' +
            '<label for="lineCP1">Line C point 1:</label>' + '<input type="text" id="lineCP1"/> <br>' +
            '<label for="lineAP2">Line A point 2:</label>' + '<input type="text" id="lineAP2"/> ' +
            '<label for="lineBP2">Line B point 2:</label>' + '<input type="text" id="lineBP2"/> ' +
            '<label for="lineCP2">Line C point 2:</label>' + '<input type="text" id="lineCP2"/>';
}

function Point(x, y) {
    return {
        X: x,
        Y: y
    }
}

function Line(point1, point2) {
    return {
        point1: point1,
        point2: point2
    }
}

function calculateDistance(point1, point2) {
    var result;

    result = Math.sqrt((point2.X - point1.X) * (point2.X - point1.X) + (point2.Y - point1.Y) * (point2.Y - point1.Y))

    return result;
    //d = math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)* (y2-y1))
}

function checkForTriangle(line1, line2, line3) {
    var result,
        line1Length = calculateDistance(line1.point1, line1.point2),
        line2Length = calculateDistance(line2.point1, line2.point2),
        line3Length = calculateDistance(line3.point1, line3.point2);

    if (((line1Length + line2Length) > line3Length) &&
        ((line1Length + line3Length) > line2Length) &&
        ((line2Length + line3Length) > line1Length)) {
        result = 'There COULD be a triangle.';
    }
    else {
        result = 'There can\'t be a triangle.';
    }

    return result;
}

function solveFirst() {
    var result,
        point1Stats, point2Stats,
        point1, point2,
        line1, line2, line3,
        action = document.getElementById('dropDownOptions').value;

    switch (action) {
        case 'calculate':
            point1Stats = document.getElementById('pointA').value.split(/[', =+!]/).filter(function (a) {
                if (!isNaN(a)) {
                    return a;
                }
            });
            point1 = new Point(point1Stats[0], point1Stats[1]);
            point2Stats = document.getElementById('pointB').value.split(/[', =+!]/).filter(function (a) {
                if (!isNaN(a)) {
                    return a;
                }
            });
            point2 = new Point(point2Stats[0], point2Stats[1]);

            if (checkForEmpty(point1.Y) && checkForEmpty(point2.Y)) {
                result = "";
                break;
            }
            else if (checkForEmpty(point1.Y) ^ checkForEmpty(point2.Y)) {
                result = "One of the points is empty or not full.";
                break;
            }

            result = calculateDistance(point1, point2);
            break;
        case 'checkTriangle' :
            point1Stats = document.getElementById('lineAP1').value.split(/[', =+!]/).filter(function (a) {
                if (!isNaN(a)) {
                    return a;
                }
            });
            point1 = new Point(point1Stats[0], point1Stats[1]);
            point2Stats = document.getElementById('lineAP2').value.split(/[', =+!]/).filter(function (a) {
                if (!isNaN(a)) {
                    return a;
                }
            });
            point2 = new Point(point2Stats[0], point2Stats[1]);
            line1 = new Line(point1, point2);

            point1Stats = document.getElementById('lineBP1').value.split(/[', =+!]/).filter(function (a) {
                if (!isNaN(a)) {
                    return a;
                }
            });
            point1 = new Point(point1Stats[0], point1Stats[1]);
            point2Stats = document.getElementById('lineBP2').value.split(/[', =+!]/).filter(function (a) {
                if (!isNaN(a)) {
                    return a;
                }
            });
            point2 = new Point(point2Stats[0], point2Stats[1]);
            line2 = new Line(point1, point2);

            point1Stats = document.getElementById('lineCP1').value.split(/[', =+!]/).filter(function (a) {
                if (!isNaN(a)) {
                    return a;
                }
            });
            point1 = new Point(point1Stats[0], point1Stats[1]);
            point2Stats = document.getElementById('lineCP2').value.split(/[', =+!]/).filter(function (a) {
                if (!isNaN(a)) {
                    return a;
                }
            });
            point2 = new Point(point2Stats[0], point2Stats[1]);
            line3 = new Line(point1, point2);


            result = checkForTriangle(line1, line2, line3);
            break;
    }

    document.getElementById("problemOneOutput").innerHTML = result;
}

/*
 Problem 2. Remove elements

 Write a function that removes all elements with a given value.
 Attach it to the array type.
 Read about prototype and how to attach methods.
 */


function solveSecond() {
    var result,
        inputArr = document.getElementById('pr2Array').value.split(/[', =+-]/).filter(function (a) {
            if (!isNaN(a)) {
                return a;
            }
        }),
        removedNumb = document.getElementById('pr2Number').value;

    if (!Array.prototype.remove) {
        Array.prototype.remove = function (value) {
            while (this.indexOf(value) >= 0) {
                this.splice(this.indexOf(value), 1);
            }
            return this;
        };
    }

    if (inputArr.join() == '' && checkForEmpty(removedNumb)) {
        result = '';
    } else if (inputArr.join() == '') {
        result = 'Array is empty.';
    } else {
        inputArr = inputArr.remove(removedNumb);
        result = '[' + inputArr.join(', ') + ']';
    }


    document.getElementById("problemTwoOutput").innerHTML = result;
}

/*
 Problem 3. Deep copy

 Write a function that makes a deep copy of an object.
 The function should work for both primitive and reference types.
 */

function createDeepCopy(obj) {
    var cloned = {};
    for (var prop in obj) {
        if (typeof obj[prop] === "Object") {
            cloned[prop] = obj[prop];
            createDeepCopy(obj[prop]);
        } else {
            cloned[prop] = obj[prop];
        }
    }
    return cloned;
}

/*
 Problem 4. Has property

 Write a function that checks if a given object contains a given property.
 */

function checkForProp(obj, propertyName) {
    if (obj.hasOwnProperty(propertyName)) {
        return true;
    }
    return false;
}

function solveFourth() {
    var littleDude = {name: 'John', cool: 'yes', hasMoney: 'always'};

    console.log('littleDude: ' + littleDude);
    console.log('Does little dude have name? ' + checkForProp(littleDude, 'name') + ' ' + (checkForProp(littleDude, 'name') ? littleDude.name : ''));
    console.log('Is little dude cool? ' + checkForProp(littleDude, 'cool') + ' ' + (checkForProp(littleDude, 'cool') ? littleDude.cool : ''));
    console.log('Does little dude have money? ' + checkForProp(littleDude, 'hasMoney') + ' ' + (checkForProp(littleDude, 'hasMoney') ? littleDude.hasMoney : ''));
}

function findYoungestPerson(arrayOfPeople){
    var len = arrayOfPeople.length,
        i,
        youngest = arrayOfPeople[0],
        result = [];

    for (i = 0; i < len; i += 1) {
        if (arrayOfPeople[i].age < youngest.age) {
            youngest = arrayOfPeople[i];
        }
    }

    return youngest.firstname + ' ' + youngest.lastname;
}

var people = [
    { firstname : 'Gosho', lastname: 'Petrov', age: 32 },
    { firstname : 'Bay', lastname: 'Ivan', age: 81}]

console.log(findYoungestPerson(people));

function group(array, property) {
    var i,
        len = array.length,
        prop,
        result = {};

    if (property === 'firstname') {
        for (i = 0; i < len; i += 1) {
            if (result[array[i].firstname]) {
                result[array[i].firstname].push(array[i]);
            } else {
                result[array[i].firstname] = [array[i]];
            }
        }
        return result;
    }
    if (property === 'lastname') {
        for (i = 0; i < len; i += 1) {
            if (result[array[i].lastname]) {
                result[array[i].lastname].push(array[i]);
            } else {
                result[array[i].lastname] = [array[i]];
            }
        }
        return result;
    }
    if (property === 'age') {
        for (i = 0; i < len; i += 1) {
            if (result[array[i].age]) {
                result[array[i].age].push(array[i]);
            } else {
                result[array[i].age] = [array[i]];
            }
        }
        return result;
    }
}

console.log(group(people, 'firstname'));
console.log(group(people, 'lastname'));
console.log(group(people, 'age'));