/*
 Problem 1. English digit

 Write a function that returns the last digit of given integer as an English word.
 */

function checkForEmpty(text) {
    if (text === 0) {
        return false;
    }
    if (text == '') {
        return true;
    }
}

function IntToWord(number) {

    if (checkForEmpty(number)) {
        return '';
    }

    var lastDigit = +number % 10,
        numbers = ['Zero', 'One', 'Two', 'Three', 'Four', 'Five', 'Six', 'Seven', 'Eight', 'Nine'];

    return numbers[lastDigit];
}

function solveFirst() {
    var input = document.getElementById('problem1Integer').value,
        result = IntToWord(input);

    document.getElementById("problemOneOutput").innerHTML = result;
}

/*
 Problem 2. Reverse number

 Write a function that reverses the digits of given decimal number.
 */

function reverseDecimal(number) {

    if (checkForEmpty(number) || number[number.length - 1] == '.') {
        return '';
    }

    return number.split('').reverse().join('');
}

function solveSecond() {
    var input = document.getElementById('decimalNumber').value,
        result = reverseDecimal(input);

    document.getElementById("problemTwoOutput").innerHTML = result;
}

/*
 Problem 3. Occurrences of word

 Write a function that finds all the occurrences of word in a text.
 The search can be case sensitive or case insensitive.
 Use function overloading.
 */

function findWordInText(text, searchedWord, isCaseSensitive) {
    var i,
        count = 0,
        len = text.length - searchedWord.length;

    if (checkForEmpty(text) && checkForEmpty(searchedWord)) {
        return '';
    } else if (checkForEmpty(text) || checkForEmpty(searchedWord)) {
        return 'There is either no text or searched word';
    }

    if (isCaseSensitive) {
        for (i = 0; i <= len; i += 1) {
            if (text.substr(i, searchedWord.length) === searchedWord) {
                if (i == 0) {
                    if (text[i + searchedWord.length].match(/\W/)) {
                        count += 1;
                    }

                } else if (i == len) {
                    if (text[i - 1].match(/\W/)) {
                        count += 1;
                    }
                } else {
                    if (text[i - 1].match(/\W/) && text[i + searchedWord.length].match(/\W/)) {
                        count += 1;
                    }
                }
            }
        }
    } else {
        for (i = 0; i <= len; i += 1) {
            if (text.substr(i, searchedWord.length).toLowerCase() === searchedWord.toLowerCase()) {
                if (i == 0) {
                    if (text[i + searchedWord.length].match(/\W/)) {
                        count += 1;
                    }

                } else if (i == len) {
                    if (text[i - 1].match(/\W/)) {
                        count += 1;
                    }
                } else {
                    if (text[i - 1].match(/\W/) && text[i + searchedWord.length].match(/\W/)) {
                        count += 1;
                    }
                }
            }
        }
    }

    return count;
}

function solveThird() {

    var inputText = document.getElementById('textToCheck').value,
        inputSearchedWord = document.getElementById('searchedWord').value.trim(),
        inputIsCaseSensitive = document.getElementById('caseSensitive').checked,
        result = findWordInText(inputText, inputSearchedWord, inputIsCaseSensitive);

    document.getElementById("problemThreeOutput").innerHTML = result;
}

/*
 Problem 4. Number of elements

 Write a function to count the number of div elements on the web page
 */

function solveFourth() {
    var result = document.getElementsByTagName('div').length;

    document.getElementById("problemFourOutput").innerHTML = result.toString();
}

function hideFourth() {
    document.getElementById("problemFourOutput").innerHTML = "";
}

/*
 Problem 5. Appearance count

 Write a function that counts how many times given number appears in given array.
 Write a test function to check if the function is working correctly.
 */

function countAppearence(arrayOfNumbers, searchedNumber) {
    var i,
        count = 0,
        len = arrayOfNumbers.length;

    if (checkForEmpty(arrayOfNumbers) && checkForEmpty(searchedNumber)) {
        return '';
    } else if (checkForEmpty(arrayOfNumbers) || checkForEmpty(searchedNumber)) {
        return 'There is either no array of numbers or searched number';
    }

    for (i = 0; i < len; i += 1) {
        if (arrayOfNumbers[i] === searchedNumber) {
            count += 1;
        }
    }

    return 'Number appears ' + count + ' times!';
}

function solveFifth() {
    var input = document.getElementById('pr5ArrayOfNumbers').value.split(/\D/).filter(Number),
        searchedNumber = document.getElementById('pr5SearchedNumber').value,
        result = countAppearence(input, searchedNumber);

    document.getElementById("problemFiveOutput").innerHTML = result;
}

function solveFifthMyFunction() {
    var array = [2, 3, 4, 6, 2, 1, 2, 4, 5, 6, 7, 2, 2, 1, 3],
        searchedNumber = 2,
        result = countAppearence(array, searchedNumber);

    document.getElementById("problemFiveOutputMyFunct").innerHTML =
        'Array: [2, 3, 4, 6, 2, 1, 2, 4, 5, 6, 7, 2, 2, 1, 3] <br>' +
        'Searched number: 2 <br>' +
        'Result: ' + result;
}

function hideFifthMyFunction() {

    document.getElementById("problemFiveOutputMyFunct").innerHTML = '';
}
/*
 Problem 6. Larger than neighbours

 Write a function that checks if the element at given position in given array of integers
 is bigger than its two neighbours (when such exist).
 */

function largerThanNeighbours(arrayOfNumbers, indexOfNumber) {

    if (checkForEmpty(arrayOfNumbers) && checkForEmpty(indexOfNumber)) {
        return '';
    } else if (checkForEmpty(arrayOfNumbers) || checkForEmpty(indexOfNumber)) {
        return 'There is either no array of numbers or index';
    }

    if (indexOfNumber >= arrayOfNumbers.length) {
        return 'The index is outside the given array length.'
    }

    if (arrayOfNumbers[+indexOfNumber - 1] != undefined && arrayOfNumbers[+indexOfNumber + 1] != undefined) {

        if (arrayOfNumbers[+indexOfNumber] > arrayOfNumbers[+indexOfNumber - 1] &&
            arrayOfNumbers[+indexOfNumber] > arrayOfNumbers[+indexOfNumber + 1]) {
            return 'The number at position (' + indexOfNumber + ') is bigger than it\'s neighbours';
        }
        else {
            return 'The number at position (' + indexOfNumber + ') is not bigger than it\'s neighbours';
        }
    }
    else {
        return 'One of the neighbours is either undefined or outside the array(again undefined).';
    }
}

function solveSixth() {
    var input = document.getElementById('pr6ArrayOfNumbers').value.split(/\D/).filter(Number),
        inputIndex = document.getElementById('pr6Index').value,
        result = largerThanNeighbours(input, inputIndex);

    document.getElementById("problemSixOutput").innerHTML = result;
}

/*
 Problem 7. First larger than neighbours

 Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there’s no such element.
 Use the function from the previous exercise.
 */

function firstLarger(arrayOfNumbers) {
    var i,
        len = arrayOfNumbers.length;

    if (checkForEmpty(arrayOfNumbers)) {
        return '';
    }

    for (i = 0; i < len; i += 1) {

        if (arrayOfNumbers[+i - 1] != undefined && arrayOfNumbers[+i + 1] != undefined) {
            if (arrayOfNumbers[+i] > arrayOfNumbers[+i - 1] &&
                arrayOfNumbers[+i] > arrayOfNumbers[+i + 1]) {
                return 'The number at position (' + i + ') is bigger than it\'s neighbours';
            }
        }
    }

    return 'All numbers are not bigger than their neighbours!';
}

function solveSeventh() {
    var input = document.getElementById('pr7ArrayOfNumbers').value.split(/\D/).filter(Number),
        result = firstLarger(input);

    document.getElementById("problemSevenOutput").innerHTML = result;
}


function superSecretStuff() {
    var wantsToVisit = confirm("Is philosophy important?");
    if (wantsToVisit) {
        var win = window.open('https://www.youtube.com/watch?v=pQ33gAyhg2c', '_blank');
        win.focus();
    }
}