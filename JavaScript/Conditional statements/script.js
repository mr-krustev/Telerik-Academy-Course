// The code is rather to be showing on the pseudo-site than to be working on it's own. I know I should return values and then use them!


function checkForEmpty(number) {
    if (number === 0) {
        return false;
    }
    if (number == '' || isNaN(number)) {
        return true;
    }
}

function exchangeIfGreater() {
    var temp,
        result,
        firstNumber = parseFloat(document.getElementById("a").value),
        secondNumber = parseFloat(document.getElementById("b").value);

    if (checkForEmpty(firstNumber) && checkForEmpty(secondNumber)) {
        document.getElementById("problemOneOutput").innerHTML = "";
        return;
    }
    else if (checkForEmpty(firstNumber) || checkForEmpty(secondNumber)) {
        document.getElementById("problemOneOutput").innerHTML = "One of the numbers is empty.";
        return;
    }

    if (firstNumber > secondNumber) {
        temp = secondNumber;
        secondNumber = firstNumber;
        firstNumber = temp;
    }

    result = firstNumber + " " + secondNumber;

    document.getElementById("problemOneOutput").innerHTML = result.toString();

}

function checkForSign() {
    var result,
        firstNumber = parseFloat(document.getElementById("pr2ANumber").value),
        secondNumber = parseFloat(document.getElementById("pr2BNumber").value),
        thirdNumber = parseFloat(document.getElementById("pr2CNumber").value);

    if (checkForEmpty(firstNumber) && checkForEmpty(secondNumber) && checkForEmpty(thirdNumber)) {
        document.getElementById("problemTwoOutput").innerHTML = "";
        return;
    }
    else if (checkForEmpty(firstNumber) || checkForEmpty(secondNumber) || checkForEmpty(thirdNumber)) {
        document.getElementById("problemTwoOutput").innerHTML = "One of the numbers is empty.";
        return;
    }


    if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0) {
        result = 0;
    }
    else {
        if (firstNumber < 0) {
            if (secondNumber < 0) {
                if (thirdNumber < 0) {
                    result = "-";
                }
                else {
                    result = "+";
                }
            }
            else {
                if (thirdNumber < 0) {
                    result = "+";
                }
                else {
                    result = "-";
                }
            }
        }
        else {
            if (secondNumber < 0) {
                if (thirdNumber < 0) {
                    result = "+";
                }
                else {
                    result = "-";
                }
            }
            else {
                if (thirdNumber < 0) {
                    result = "-";
                }
                else {
                    result = "+";
                }
            }
        }
    }
    document.getElementById("problemTwoOutput").innerHTML = result.toString();
}

function theBiggestOfThree() {
    var result,
        firstNumber = parseFloat(document.getElementById("aNumber").value),
        secondNumber = parseFloat(document.getElementById("bNumber").value),
        thirdNumber = parseFloat(document.getElementById("cNumber").value);

    if (checkForEmpty(firstNumber) && checkForEmpty(secondNumber) && checkForEmpty(thirdNumber)) {
        document.getElementById("problemThreeOutput").innerHTML = "";
        return;
    }

    //Longest and most nested check. See biggestOfFive for shorter;
    if (firstNumber > secondNumber) {
        if (firstNumber > thirdNumber) {
            result = firstNumber;
        }
        else {
            result = thirdNumber;
        }
    }
    else {
        if (secondNumber > thirdNumber) {
            result = secondNumber;
        }
        else {
            result = thirdNumber;
        }
    }

    document.getElementById("problemThreeOutput").innerHTML = result;
}

function sortThreeNumbers() {
    var result,
        firstNumber = parseFloat(document.getElementById("numberA").value),
        secondNumber = parseFloat(document.getElementById("numberB").value),
        thirdNumber = parseFloat(document.getElementById("numberC").value);

    if (checkForEmpty(firstNumber) && checkForEmpty(secondNumber) && checkForEmpty(thirdNumber)) {
        document.getElementById("problemFourOutput").innerHTML = "";
        return;
    }
    else if (checkForEmpty(firstNumber) || checkForEmpty(secondNumber) || checkForEmpty(thirdNumber)) {
        document.getElementById("problemFourOutput").innerHTML = "One of the numbers is empty.";
        return;
    }


    if (firstNumber > secondNumber) {
        if (firstNumber > thirdNumber) {
            if (secondNumber > thirdNumber) {
                result = firstNumber + " " + secondNumber + " " + thirdNumber;
            }
            else {
                result = firstNumber + " " + thirdNumber + " " + secondNumber;
            }
        }
        else {
            result = thirdNumber + " " + firstNumber + " " + secondNumber;
        }
    }
    else {
        if (secondNumber > thirdNumber) {
            if (firstNumber > thirdNumber) {
                result = secondNumber + " " + firstNumber + " " + thirdNumber;
            }
            else {
                result = secondNumber + " " + thirdNumber + " " + firstNumber;
            }
        }
        else {
            result = thirdNumber + " " + secondNumber + " " + firstNumber;
        }
    }

    document.getElementById("problemFourOutput").innerHTML = result;
}

function digitAsWord() {
    var result,
        number = document.getElementById("digit").value;

    // Special check just for this one, since it is expected to return no digit if it's string. Still want to remove if empty! :)
    if (number === '') {
        document.getElementById("problemFiveOutput").innerHTML = "";
        return;
    }

    result = getHundredsAndOnes(number);

    document.getElementById("problemFiveOutput").innerHTML = result;
}

function solveQuadraticEquation() {
    var result,
        discriminant,
        a = parseFloat(document.getElementById("coefficientA").value),
        b = parseFloat(document.getElementById("coefficientB").value),
        c = parseFloat(document.getElementById("coefficientC").value);

    if (checkForEmpty(a) && checkForEmpty(b) && checkForEmpty(c)) {
        document.getElementById("problemSixOutput").innerHTML = "";
        return;
    }
    else if (checkForEmpty(a) || checkForEmpty(b) || checkForEmpty(c)) {
        document.getElementById("problemSixOutput").innerHTML = "One of the numbers is empty or wrong.";
        return;
    }

    discriminant = b * b - (4 * a * c);

    if (discriminant < 0) {
        result = "no real roots";
        document.getElementById("problemSixOutput").innerHTML = result;
        return;
    }
    else if (discriminant == 0) {
        result = "x1=x2=" + -b / (2 * a);
        document.getElementById("problemSixOutput").innerHTML = result;
    }
    else {
        result = "x1=" + ((-b - Math.sqrt(discriminant)) / (2 * a)) + "; x2=" + ((-b + Math.sqrt(discriminant)) / (2 * a));
        document.getElementById("problemSixOutput").innerHTML = result;
    }
}

function findBiggestOfFive() {
    var result = -9007199254740991,// Was giving a wrong answer with Number.MIN_VALUE
        firstNumber = parseFloat(document.getElementById("pr7FirstNumber").value),
        secondNumber = parseFloat(document.getElementById("pr7SecondNumber").value),
        thirdNumber = parseFloat(document.getElementById("pr7ThirdNumber").value),
        fourthNumber = parseFloat(document.getElementById("pr7FourthNumber").value),
        fifthNumber = parseFloat(document.getElementById("pr7FifthNumber").value);

    if (checkForEmpty(firstNumber) && checkForEmpty(secondNumber) && checkForEmpty(thirdNumber)
        && checkForEmpty(fourthNumber) && checkForEmpty(fifthNumber)) {
        document.getElementById("problemSevenOutput").innerHTML = "";
        return;
    }
    else if (checkForEmpty(firstNumber) || checkForEmpty(secondNumber) || checkForEmpty(thirdNumber)
        || checkForEmpty(fourthNumber) || checkForEmpty(fifthNumber)) {
        document.getElementById("problemSevenOutput").innerHTML = "One of the numbers is empty or wrong.";
        return;
    }

    if (firstNumber >= result) {
        result = firstNumber;
        if (secondNumber > result) {
            result = secondNumber;
        }

        if (thirdNumber > result) {
            result = thirdNumber;
        }

        if (fourthNumber > result) {
            result = fourthNumber;
        }

        if (fifthNumber > result) {
            result = fifthNumber;
        }
    }


    document.getElementById("problemSevenOutput").innerHTML = result.toString();
}
function numberAsWords() {
    var tempOnes,
        tempTens,
        tempHundreds,
        result = '',
        number = parseFloat(document.getElementById("pr8Number").value);

    if (checkForEmpty(number)) {
        document.getElementById("problemEightOutput").innerHTML = "";
        return;
    }
    else if (number > 999 || number < 0) {
        document.getElementById("problemEightOutput").innerHTML = "Number outside of given range!";
        return;
    }

    tempOnes = parseInt(number % 10);
    number /= 10;
    tempTens = parseInt(number % 10);
    number /= 10;
    tempHundreds = parseInt(number % 10);

    if (tempHundreds > 0) {
        result += getHundredsAndOnes(tempHundreds) + ' hundred ';

        if (tempTens == 1) {
            result += 'and ' + getTeen(tempTens.toString() + tempOnes.toString());

        }
        else if (tempTens) {
            result += 'and ' + getTens(tempTens) + " ";

            if (tempOnes > 0) {
                result += getHundredsAndOnes(tempOnes);
            }
        }
        else {
            if (tempOnes) {
                result += 'and ' + getHundredsAndOnes(tempOnes);
            }
        }
    }
    else {
        if (tempTens == 1) {
            result += getTeen(tempTens.toString() + tempOnes.toString());

        }
        else if (tempTens > 0) {
            result += getTens(tempTens) + " ";

            if (tempOnes > 0) {
                result += getHundredsAndOnes(tempOnes);
            }

        }
        else {
            result += getHundredsAndOnes(tempOnes);

        }
    }

    document.getElementById("problemEightOutput").innerHTML = result;
}

function getHundredsAndOnes(number) {
    switch (parseFloat(number)) {
        case 0:
            return "zero";
            break;
        case 1:
            return "one";
            break;
        case 2:
            return "two";
            break;
        case 3:
            return "three";
            break;
        case 4:
            return "four";
            break;
        case 5:
            return "five";
            break;
        case 6:
            return "six";
            break;
        case 7:
            return "seven";
            break;
        case 8:
            return "eight";
            break;
        case 9:
            return "nine";
            break;
        case undefined: return ""; break;
        default :
            return "not a digit";
            break;
    }
}

function getTens(number) {
    switch (parseFloat(number)) {
        case 2:
            return "twenty";
            break;
        case 3:
            return "thirty";
            break;
        case 4:
            return "forty";
            break;
        case 5:
            return "fifty";
            break;
        case 6:
            return "sixty";
            break;
        case 7:
            return "seventy";
            break;
        case 8:
            return "eighty";
            break;
        case 9:
            return "ninety";
            break;
        default :
            return "";
            break;
    }
}

function getTeen(number) {
    switch (parseFloat(number)) {
        case 10:
            return "ten";
            break;
        case 11:
            return "eleven";
            break;
        case 12:
            return "twelve";
            break;
        case 13:
            return "thirteen";
            break;
        case 14:
            return "fourteen";
            break;
        case 15:
            return "fifteen";
            break;
        case 16:
            return "sixteen";
            break;
        case 17:
            return "seventeen";
            break;
        case 18:
            return "eighteen";
            break;
        case 19:
            return "nineteen";
            break;
    }
}

function superSecretStuff() {
    var wantsToVisit = confirm("If you have succumbed to the previous buttons, you will not regret opening this one.");
    if (wantsToVisit) {
        var win = window.open('http://visualgo.net/', '_blank');
        win.focus();
    }
}