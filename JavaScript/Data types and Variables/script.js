var justString = "Chew, baka!",
    randomNumber = 4,
    randomFloat = 4.5,
    myArray = ['empty','array'],
    myObject = {},// It's a joke from one of Evlogi's lectures. Never make this kind of variable!
    isTrue = true,
    joeyPickUp = '\'How you doin\'?\', Joey said.',
    imNull = null,
    imUndefined;

function solveFirst() {
    document.getElementById("outputOne").innerHTML = justString + '<br>' + randomNumber + '<br>' + randomFloat +
        '<br>' + myArray + '<br>' + myObject + '<br>' + isTrue;

};
// Very noobish approach but still works.
function hideFirst() {
    document.getElementById("outputOne").innerHTML = "";
}

function solveSecond() {
    document.getElementById("outputTwo").innerHTML = joeyPickUp;
};

function hideSecond() {
    document.getElementById("outputTwo").innerHTML = "";
}

function solveThird() {
    document.getElementById("outputThree").innerHTML = justString + ' has typeof: ' + typeof justString + '<br>' +
        randomNumber + ' has typeof: ' + typeof randomNumber + '<br>' + randomFloat + ' has typeof: ' + typeof randomFloat + '<br>' +
        myArray + ' has typeof: ' + typeof myArray + '<br>' + myObject + ' has typeof: ' + typeof myObject + '<br>'
        + isTrue + ' has typeof: ' + typeof isTrue;
};

function hideThird() {
    document.getElementById("outputThree").innerHTML = "";
}


function solveFourth() {
    document.getElementById("outputFour").innerHTML = imNull + ' has typeof: ' + typeof imNull + '<br>' +
        imUndefined + ' has typeof: ' + typeof imUndefined;
};

function hideFourth() {
    document.getElementById("outputFour").innerHTML = "";
}

function superSecretStuff() {
    window.open("https://www.youtube.com/watch?v=Xu3FTEmN-eg")
}
