/* globals $ */

/*
 Create a function that takes a selector and COUNT, then generates inside a UL with COUNT LIs:
 * The UL must have a class `items-list`
 * Each of the LIs must:
 * have a class `list-item`
 * content "List item #INDEX"
 * The indices are zero-based
 * If the provided selector does not selects anything, do nothing
 * Throws if
 * COUNT is a `Number`, but is less than 1
 * COUNT is **missing**, or **not convertible** to `Number`
 * _Example:_
 * Valid COUNT values:
 * 1, 2, 3, '1', '4', '1123'
 * Invalid COUNT values:
 * '123px' 'John', {}, []
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
        checkIfValidSelector: function(value,name){
            validator.checkIfNull(value,name);
            validator.checkIfUndefined(value,name);
            if(typeof value !== 'string'){
                throw new Error(name + ' must be a string.');
            }
        },
        checkIfValidCount: function(value,name){
            validator.checkIfUndefined(value, name);
            validator.checkIfNull(value, name);
            value = +value;
            if(isNaN(value)){
                throw new Error(name + ' must be a number.');
            }

            if(value < 1){
                throw new Error(name + ' must be 1 or more.')
            }
        }
    };

    return function (selector, count) {
        validator.checkIfValidSelector(selector, 'Selector');
        validator.checkIfValidCount(count, 'Count');

        var domElement,
            i,
            ul,
            li;

        domElement = $(selector);

        if(domElement == null || domElement == undefined){
            return;
        }

        ul = $('<ul/>').addClass('items-list');

        for(i=0; i < count; i+=1){
            li = $('<li/>').addClass('list-item').html('List item #' + i);
            li.appendTo(ul);
        }

        domElement.html(ul);
    };
}

//document.body.innerHTML = '<div id="root"></div>';
//result('#root', count);

module.exports = solve;