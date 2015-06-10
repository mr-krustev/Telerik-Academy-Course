/*
 Problem 1. Increase array members

 Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5.
 Print the obtained array on the console.
 */

function checkForEmpty(text) {
    if (text === 0) {
        return false;
    }
    if (text == '') {
        return true;
    }
}

function increaseArrayMembers() {
    var i,
        len = 20,
        arrOfIntegers = [];

    for (i = 0; i < len; i += 1) {
        arrOfIntegers[i] = i * 5;
    }

    return arrOfIntegers;
}

function solveFirst() {
    var result = increaseArrayMembers();
    console.log(result);
    document.getElementById("problemOneOutput").innerHTML = result.join() + '<br>' + 'Note: It is also on the console.';
}

function hideFirst() {
    document.getElementById("problemOneOutput").innerHTML = "";
}

/*
 Problem 2. Lexicographically comparison

 Write a script that compares two char arrays lexicographically (letter by letter).
 */

function compareTwoCharArrays(firstCharArr, secondCharArr) {
    var i,
        result = true,
        maxLenToComp = firstCharArr.length < secondCharArr.length ? firstCharArr.length : secondCharArr.length;

    if (checkForEmpty(firstCharArr) && checkForEmpty(secondCharArr)) {
        return result = '';
    }
    else if (checkForEmpty(firstCharArr) || checkForEmpty(secondCharArr)) {
        return result = "One of the arrays is empty.";
    }

    for (i = 0; i < maxLenToComp; i += 1) {
        if (firstCharArr[i] !== secondCharArr[i]) {
            result = false;
            break;
        }
    }
    return result;
}

function solveSecond() {
    var firstInput = document.getElementById('firstCharArr').value,
        secondInput = document.getElementById('secondCharArr').value,
        result = compareTwoCharArrays(firstInput, secondInput);

    if ((result != true && result != false) || result === '') {
        document.getElementById("problemTwoOutput").innerHTML = result;
    } else {
        document.getElementById("problemTwoOutput").innerHTML = 'Are the arrays lexicographically equivalent? ' + result;
    }
}

/*
 Problem 3. Maximal sequence

 Write a script that finds the maximal sequence of equal elements in an array.
 */

function findMaxSequence(arrayOfElements) {
    var i,
        j,
        array,
        element,
        tempElem,
        result = [],
        maxLen = 0,
        tempCount = 0,
        len = arrayOfElements.length;

    if (checkForEmpty(arrayOfElements)) {
        return result = '';
    }

    for (i = 0; i < len; i += 1) {
        tempElem = arrayOfElements[i];
        tempCount++;
        for (j = i + 1; j < len; j += 1) {
            if (+arrayOfElements[j] !== +tempElem) {
                if (maxLen < tempCount) {
                    maxLen = tempCount;
                    element = arrayOfElements[i];
                }
                tempCount = 0;
                break;
            }
            tempCount++;
        }
    }

    for (i = 0; i < maxLen; i += 1) {
        result[i] = element;
    }

    return result.join(', ');
}

function solveThird() {
    var input = document.getElementById('sequence').value.split(/\D/).filter(Number),
        result = findMaxSequence(input);

    document.getElementById("problemThreeOutput").innerHTML = result;
}

/*
 Problem 4. Maximal increasing sequence

 Write a script that finds the maximal increasing sequence in an array.
 */

function findMaxIncreasing(arrayOfNumbers) {
    var i,
        j,
        tempElem,
        beginIndex,
        result = [],
        maxLen = 0,
        tempCount = 0,
        len = arrayOfNumbers.length;

    if (checkForEmpty(arrayOfNumbers)) {
        return result = '';
    }

    for (i = 0; i < len; i += 1) {
        tempElem = arrayOfNumbers[i];
        tempCount++;
        for (j = i + 1; j < len; j += 1) {

            if (+arrayOfNumbers[j] < +tempElem || +arrayOfNumbers[j] == +tempElem) {
                if (maxLen < tempCount) {
                    maxLen = tempCount;
                    beginIndex = i;
                }
                tempCount = 0;
                break;
            }
            tempElem = arrayOfNumbers[j];
            tempCount++;
        }

    }

    for (i = 0; i < maxLen; i += 1) {
        result[i] = arrayOfNumbers[beginIndex + i];
    }

    return result.join();
}

function solveFourth() {
    var input = document.getElementById('maxIncreasingSequence').value.split(/\D/).filter(Number),
        result = findMaxIncreasing(input);

    document.getElementById("problemFourOutput").innerHTML = result;
}

/*
 Sorting an array means to arrange its elements in increasing order.
 Write a script to sort an array.
 Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
 */

function selectionSort(arrayOfNumbers) {
    var i,
        j,
        currentSmallest,
        currentSmallestIndex,
        tempNumb,
        len = arrayOfNumbers.length,
        result = [];

    if (checkForEmpty(arrayOfNumbers)) {
        return result = '';
    }

    for (i = 0; i < len; i += 1) {
        currentSmallest = arrayOfNumbers[i];
        for (j = i + 1; j < len; j += 1) {
            if (+arrayOfNumbers[j] < +currentSmallest) {
                currentSmallest = arrayOfNumbers[j];
                currentSmallestIndex = j;
            }
        }
        tempNumb = arrayOfNumbers[i];
        arrayOfNumbers[i] = currentSmallest;
        arrayOfNumbers[currentSmallestIndex] = tempNumb;
    }

    result = arrayOfNumbers;

    return result.join();
}

function solveFifth() {
    var input = document.getElementById('sortSequence').value.split(/\D/).filter(Number),
        result = selectionSort(input);

    document.getElementById("problemFiveOutput").innerHTML = result;
}

/*
 Problem 6. Most frequent number

 Write a script that finds the most frequent number in an array.
 */

function mostFrequentNumb(arrayOfNumbers) {
    var i,
        j,
        count,
        mostFrequent,
        tempNumb,
        result,
        maxLen = 0,
        len = arrayOfNumbers.length;

    if (checkForEmpty(arrayOfNumbers)) {
        return result = '';
    }

    for (i = 0; i < len; i += 1) {
        count = 0;
        tempNumb = arrayOfNumbers[i];
        count++;
        for (j = i + 1; j < len; j += 1) {
            if (arrayOfNumbers[j] === tempNumb) {
                count++;
            }
        }
        if (count > maxLen) {
            maxLen = count;
            mostFrequent = tempNumb;
        }
    }

    result = mostFrequent + ' (' + maxLen + ' times)';

    return result;
}

function solveSixth() {
    var input = document.getElementById('frequentSequence').value.split(/\D/).filter(Number),
        result = mostFrequentNumb(input);

    document.getElementById("problemSixOutput").innerHTML = result;
}

/*
 Problem 7. Binary search

 Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.
 */

function binarySearch(arrayOfNumbers, searchedNumber) {
    var result,
        midPos,
        minPos = 0,
        maxPos = arrayOfNumbers.length;

    if (checkForEmpty(arrayOfNumbers)) {
        return result = '';
    }

    arrayOfNumbers.sort();

    while (maxPos >= minPos) {
        midPos = parseInt(((maxPos - minPos) / 2) + minPos);

        if (+arrayOfNumbers[midPos] == +searchedNumber) {
            return result = 'Key was found at position: ' + midPos;
        }
        else if (+arrayOfNumbers[midPos] < +searchedNumber) {
            minPos = midPos + 1;
        }
        else {
            maxPos = midPos - 1;
        }

        if (+minPos >= +maxPos) {
            return result = 'Key was not found.';
        }
    }
}

function solveSeventh() {
    var input = document.getElementById('binarySequence').value.split(/\D/).filter(Number),
        searchedNum = document.getElementById('searchedNumber').value,
        result = binarySearch(input,searchedNum);

    document.getElementById("problemSevenOutput").innerHTML = result;
}


function superSecretStuff() {
    var wantsToVisit = confirm("Are you a fighter?");
    if (wantsToVisit) {
        var win = window.open('https://codefights.com/', '_blank');
        win.focus();
    }
}