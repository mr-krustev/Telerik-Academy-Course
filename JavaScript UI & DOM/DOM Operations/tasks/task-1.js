/* globals $ */

/* 

 Create a function that takes an id or DOM element and an array of contents

 * if an id is provided, select the element
 * Add divs to the element
 * Each div's content must be one of the items from the contents array
 * The function must remove all previous content from the DOM element provided
 * Throws if:
 * The provided first parameter is neither string or existing DOM element
 * The provided id does not select anything (there is no element that has such an id)
 * Any of the function params is missing
 * Any of the function params is not as described
 * Any of the contents is neither `string` or `number`
 * In that case, the content of the element **must not be** changed
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
        },
        checkIfNumber: function (value, name) {
            name = name || 'Value';
            if (typeof value !== 'number') {
                throw new Error(name + ' is not a number.');
            }
        },
        checkIfNumberOrString: function (value, name) {
            name = name || 'Value';
            if (typeof value !== 'number' && typeof value !== 'string') {
                throw new Error(name + ' is not a number or string.');
            }
        },
        checkIfValidArray: function (value, name) {
            name = name || 'Value';
            var i,
                len;
            if (!Array.isArray(value)) {
                throw new Error(name + ' is not an array.');
            }
            //if (value.length == 0) {
            //    throw new Error(name + ' is an empty array.');
            //}

            for (i = 0, len = value.length; i < len; i += 1) {
                validator.checkIfUndefined(value[i], name);
                validator.checkIfNull(value, name);
                validator.checkIfNumberOrString(value[i], name);
            }
        }
    };

    return function (element, contents) {
        validator.checkIfUndefined(element, 'Id or dom element');
        validator.checkIfUndefined(contents, 'Content');
        validator.checkIfValidArray(contents, 'Content');
        var i, len,
            domElement,
            div,
            docFragment,
            divToBeAdded;

        if (typeof element === 'string') {
            domElement = document.querySelector('#' + element);
        } else if (typeof element === 'object' && element instanceof HTMLElement) {
            domElement = element;
        } else {
            throw new Error('Invalid element provided.');
        }

        validator.checkIfUndefined(domElement, 'Dom element');
        validator.checkIfNull(domElement, 'Dom element');

        div = document.createElement('div');
        docFragment = document.createDocumentFragment();

        for (i = 0, len = contents.length; i < len; i += 1) {
            divToBeAdded = div.cloneNode(true);
            divToBeAdded.innerHTML = contents[i];
            docFragment.appendChild(divToBeAdded);
        }

        domElement.innerHTML = '';
        domElement.appendChild(docFragment);
    };
}

//document.body.innerHTML = '<div id="root"><h1>Tests</h1></div>';
//var result = solve();
//var count = 15,
//    contents = Array.apply(null, { length: count })
//        .map(function (_, index) {
//            return 'Content #' + index;
//        }),
//    selector = 'root';
//result(selector, contents);

module.exports = solve;


