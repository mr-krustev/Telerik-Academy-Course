function checkForEmpty(number) {
    if (number === 0) {
        return false;
    }
    if (number == '' || isNaN(number)) {
        return true;
    }
}

function printToN() {
    var i,
        result = "",
        len = parseFloat(document.getElementById("n").value);

    if (checkForEmpty(len)) {
        document.getElementById("problemOneOutput").innerHTML = "";
        return;
    }

    for (i = 1; i <= len; i++) {
        result += i + " ";
    }

    document.getElementById("problemOneOutput").innerHTML = result;
}

function printNotDivisibleBy3And7() {
    var i,
        result = "",
        len = parseFloat(document.getElementById("pr2N").value);

    if (checkForEmpty(len)) {
        document.getElementById("problemTwoOutput").innerHTML = "";
        return;
    }

    for (i = 1; i <= len; i++) {
        if (i % 7 && i % 3) {
            result += i + " ";
        }
    }

    document.getElementById("problemTwoOutput").innerHTML = result;
}

function biggestAndSmallest() {
    var i,
        result,
        max = -9007199254740991,
        min = Number.MAX_VALUE,
        allNumbersArr = document.getElementById("sequence").value.split(/\D/).filter(Number),
        len = allNumbersArr.length;

    if (checkForEmpty(parseFloat(allNumbersArr.join('')))) {
        document.getElementById("problemThreeOutput").innerHTML = "";
        return;
    }

    for (i = 0; i < len; i++) {

        if (+allNumbersArr[i] > max) {
            max = +allNumbersArr[i];
        }

        if (+allNumbersArr[i] < min) {
            min = +allNumbersArr[i];
        }
    }

    result = "Min number: " + min + "; Max number: " + max;

    document.getElementById("problemThreeOutput").innerHTML = result;
}

function displayMinAndMaxProperties(){
    document.getElementById("problemFourOutput").innerHTML = getProperties(document) + ' (for document)<br>' +
        getProperties(window) + '(for window)<br>' + getProperties(navigator) + '(for navigator)';
}


// Thanks to dentia.
function getProperties(obj) {
    var smallest = 0, largest = 0;

    for (var property in obj) {
        if (!smallest) {
            smallest = property;
        }
        if (!largest) {
            largest = property;
        }

        if (property < smallest) {
            smallest = property;
        }

        if (property > largest) {
            largest = property;
        }
    }

    return 'Smallest property: ' + smallest + '; Largest property: ' + largest;
}

function superSecretStuff() {
    var wantsToVisit = confirm('Do you feel like a hacker?');
    if (wantsToVisit) {
        var win = window.open('https://www.hackerrank.com/', '_blank');
        win.focus();
    }
}


