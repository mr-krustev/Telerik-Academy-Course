function clickButton() {
    'use strict';

    var currentEnvironment = window.navigator.appCodeName;

    if(currentEnvironment === 'Mozilla') {
        alert("Yes");
    } else {
        alert("No");
    }
}