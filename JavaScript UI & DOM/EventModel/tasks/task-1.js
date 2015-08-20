/* globals $ */

/*
 Create a function that takes an id or DOM element and:

 If an id is provided, select the element
 Finds all elements with class button or content within the provided element
 Change the content of all .button elements with "hide"
 When a .button is clicked:
 Find the topmost .content element, that is before another .button and:
 If the .content is visible:
 Hide the .content
 Change the content of the .button to "show"
 If the .content is hidden:
 Show the .content
 Change the content of the .button to "hide"
 If there isn't a .content element after the clicked .button and before other .button, do nothing
 Throws if:
 The provided DOM element is non-existent
 The id is either not a string or does not select any DOM element
 */

function solve() {
    var validator = {
        checkIfNull: function (value, name) {
            name = name || 'Value';
            if (value === null) {
                throw new Error(name + ' cannot be null.')
            }
        },
        checkIfUndefined: function (value, name) {
            name = name || 'Value';
            if (typeof value === 'undefined') {
                throw new Error(name + ' cannot be undefined.');
            }
        }
    };

    return function (selector) {
        validator.checkIfUndefined(selector, 'Id or dom element');
        validator.checkIfNull(selector,'Id or dom element');
        var i, j, len,
            domElement;

        if (typeof selector === 'string') {
            domElement = document.querySelector('#' + selector);
        } else if (typeof selector === 'object' && selector instanceof HTMLElement) {
            domElement = selector;
        } else {
            throw new Error('Invalid element provided.');
        }

        validator.checkIfUndefined(domElement);
        validator.checkIfNull(domElement);

        var domElements = document.querySelectorAll('.button, .content');

        for(i = 0, len = domElements.length; i< len; i+=1){
            if(domElements[i].className == 'button'){
                domElements[i].innerHTML = 'hide';
                for(j= i + 1; j < len; j+=1){
                    if(domElements[j].className =='button'){
                        break;
                    }
                    if(domElements[j].className == 'content'){
                        domElements[i].connectedContent = domElements[j];
                        break;
                    }
                }
                if(domElements[i].connectedContent){
                    domElements[i].addEventListener('click', function(ev){
                        if(ev.target.innerHTML == 'hide'){
                            ev.target.innerHTML = 'show';
                            ev.target.connectedContent.style.display = 'none';
                        } else {
                            ev.target.innerHTML = 'hide';
                            ev.target.connectedContent.style.display = '';
                        }
                    });
                }
            }
        }
    };
}

module.exports = solve;