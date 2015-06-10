function checkForEmpty(number) {
    if(number === 0){
        return false;
    }
    if (isNaN(number)) {
        return true;
    }
}

function checkIfOdd(number) {
    
    if (checkForEmpty(parseFloat(number))) {
        document.getElementById("problemOneOutput").innerHTML = "";
        return;
    }
	
	var result = number % 2 == 0 ? "Even" : "Odd";
    document.getElementById("problemOneOutput").innerHTML = result;
}

function checkRemainder(number) {
    
    if (checkForEmpty(+number)) {
        document.getElementById("problemTwoOutput").innerHTML = "";
        return;
    }

	var result = number % 5 == 0 && number % 7 == 0 ? "Has no remainder." : "Has remainder divided by at least one of the numbers";
	
    document.getElementById("problemTwoOutput").innerHTML = result;
}

function calculateRectangle() {
    var width = +document.getElementById("sideA").value;
    var height = +document.getElementById("sideB").value;
    if (checkForEmpty(width) && checkForEmpty(height)) {
        document.getElementById("problemThreeOutput").innerHTML = "";
        return;
    }
    else if (checkForEmpty(width) ^ checkForEmpty(height)) {
        document.getElementById("problemThreeOutput").innerHTML = "One of the sides is empty.";
        return;
    }

    var result = width * height;

    document.getElementById("problemThreeOutput").innerHTML = result.toString();

}

function checkThirdDigit(number) {

    if (checkForEmpty(parseFloat(number))) {
        document.getElementById("problemFourOutput").innerHTML = "";
        return;
    }

    if (number.length < 3) {
        document.getElementById("problemFourOutput").innerHTML = "Number too short.";
        return;
    }
    var tempNumber = Math.floor(number / 100);
    var result = tempNumber % 10 == 7 ? "Number is seven." : "Other number.";


    document.getElementById("problemFourOutput").innerHTML = result;
}

function checkThirdBit(number) {
    if (checkForEmpty(parseFloat(number))) {
        document.getElementById("problemFiveOutput").innerHTML = "";
        return;
    }

    var mask = 1 << 3;
    var checkedNumber = number & mask;
    var thirdBIt = Math.floor(checkedNumber >> 3);

    document.getElementById("problemFiveOutput").innerHTML = "Third bit is: " + thirdBIt;
}

//(x - center_x)^2 + (y - center_y)^2 < radius^2.

function checkIfInCircle(){
    var x = parseFloat(document.getElementById("dotX").value);
    var y = parseFloat(document.getElementById("dotY").value);
    if (checkForEmpty(x) && checkForEmpty(y)) {
        document.getElementById("problemSixOutput").innerHTML = "";
        return;
    }
    else if (checkForEmpty(x) ^ checkForEmpty(y)) {
        document.getElementById("problemSixOutput").innerHTML = "One of the coordinates is empty.";
        return;
    }

    var circle = [0,0];
    var r = 5;

    var result = (x - circle[0])*(x-circle[0]) +
                 (y - circle[1])*(y-circle[1]) < r*r ? "Is in circle." : "Is not in circle.";

    document.getElementById("problemSixOutput").innerHTML = result;
}


function checkIfPrime(number) {
    if (checkForEmpty(parseFloat(number))) {
        document.getElementById("problemSevenOutput").innerHTML = "";
        return;
    }

    if(number > 100){
        document.getElementById("problemSevenOutput").innerHTML = "Too big number.";
        return;
    }

    if(number <= 1){
        document.getElementById("problemSevenOutput").innerHTML = "0, 1 and negatives are not prime.";
        return;
    }

    var isPrime = true;

    for(var i = 2; i < number; i++) {
        if(number % i == 0){
            isPrime = false;
        }
    }

    var result = isPrime ? "The number is prime." : "The number is not prime.";

    document.getElementById("problemSevenOutput").innerHTML = result;
}

function findTrapezoidArea() {
    var a = parseFloat(document.getElementById("trapSideA").value);
    var b =  parseFloat(document.getElementById("trapSideB").value);
    var h = parseFloat(document.getElementById("trapHeight").value);
    if (checkForEmpty(a) && checkForEmpty(b) && checkForEmpty(h)) {
        document.getElementById("problemEightOutput").innerHTML = "";
        return;
    }
    else if ((checkForEmpty(a) ^ checkForEmpty(b)) || (checkForEmpty(a) ^ checkForEmpty(h)) || (checkForEmpty(b) ^ checkForEmpty(h))) {
        document.getElementById("problemEightOutput").innerHTML = "At least one of the numbers is empty.";
        return;
    }

    var result = (a + b) / 2 * h;

    document.getElementById("problemEightOutput").innerHTML = result.toString();
}

function checkIfInCircleOrSquare() {
    var x = parseFloat(document.getElementById("pointX").value);
    var y = parseFloat(document.getElementById("pointY").value);
    if (checkForEmpty(x) && checkForEmpty(y)) {
        document.getElementById("problemNineOutput").innerHTML = "";
        return;
    }
    else if (checkForEmpty(x) ^ checkForEmpty(y)) {
        document.getElementById("problemNineOutput").innerHTML = "One of the coordinates is empty.";
        return;
    }

    var circle = [1,1];
    var r = 3;

    var resultCircle = (x - circle[0])*(x-circle[0]) +
    (y - circle[1])*(y-circle[1]) < r*r;

    var square = [-1,1,5,-1];
    var resultSquare = x >= square[0] && x <= square[2] && y <= square[1] && y >= square[3];

    var result = resultCircle && !resultSquare ?     "Is in the circle and out of the square." : "Is ether in the square or out of the circle.";

    document.getElementById("problemNineOutput").innerHTML = result;
}

function secretStuff() {
    window.open("https://www.youtube.com/watch_popup?v=6-HUgzYPm9g");
}