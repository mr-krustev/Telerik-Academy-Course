/* globals $ */

/*
 Create a function that takes a selector and:
 * Finds all elements with class `button` or `content` within the provided element
 * Change the content of all `.button` elements with "hide"
 * When a `.button` is clicked:
 * Find the topmost `.content` element, that is before another `.button` and:
 * If the `.content` is visible:
 * Hide the `.content`
 * Change the content of the `.button` to "show"
 * If the `.content` is hidden:
 * Show the `.content`
 * Change the content of the `.button` to "hide"
 * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
 * Throws if:
 * The provided ID is not a **jQuery object** or a `string`

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
        checkIfValidSelector: function (value, name) {
            validator.checkIfNull(value, name);
            validator.checkIfUndefined(value, name);
            if (typeof value !== 'string') {
                throw new Error(name + ' must be a string.');
            }
        }
    };

    function buttonEvent() {
        var $this = $(this);

        if ($this.hasClass('content')) {
            return;
        }

        $this.html('hide');
        $this.on('click', function () {
            var $this = $(this);
            var $next = $this.next();

            while (!$next.hasClass('content')) {
                if ($next.hasClass('button')) {
                    return;
                }
                $next = $next.next();
            }

            if ($this.html() == 'hide') {
                $this.html('show');
                $next.css('display', 'none');
            } else {
                $this.html('hide');
                $next.css('display', '');
            }
        });
    }

    return function (selector) {
        validator.checkIfValidSelector(selector, 'Selector');

        var $element = $(selector);
        if($element.length == 0){
            throw new Error('No element found with selector : ' + selector);
        }

        $element.children('.button, .content')
            .each(buttonEvent);
    };
}

module.exports = solve;