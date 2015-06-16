/* Task Description */
/* 
 Write a function that sums an array of numbers:
 numbers must be always of type Number
 returns `null` if the array is empty
 throws Error if the parameter is not passed (undefined)
 throws if any of the elements is not convertible to Number

 */

function sum(numbers) {
    var i, len, temp,
        result = 0;

    if (numbers.length === 'undefined') {
        throw new Error();
    }

    if (numbers.length == 0) {
        return null;
    }

    for (i = 0, len = numbers.length; i < len; i += 1) {
        temp = +numbers[i];
        if (isNaN(temp)) {
            throw new Error();
        }
        result += temp;
    }
    return result;
}

module.exports = sum;