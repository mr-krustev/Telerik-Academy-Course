/* Task description */
/*
 Write a function a function that finds all the prime numbers in a range
 1) it should return the prime numbers in an array
 2) it must throw an Error if any on the range params is not convertible to `number`
 3) it must throw an Error if any of the range params is missing
 */

function findPrimes(from, to) {
    if (arguments.length < 2) {
        throw 'Error! Pass 2 arguments!';
    } else if (isNaN(arguments[0]) || isNaN(arguments[1])) {
        throw 'Error! Arguments must be convertible to numbers.';
    }
    var i, isPrime,
        divisor,
        maxDivisor,
        result = [];
    from *= 1;
    to *= 1;

    for (i = from; i <= to; i += 1) {
        isPrime = true;
        if (i < 2) {
            continue;
        }
        maxDivisor = Math.sqrt(i);
        for (divisor = 2; divisor <= maxDivisor; divisor += 1) {
            if (!(i % divisor)) {
                isPrime = false;
                break;
            }
        }
        if (isPrime) {
            result.push(i);
        }
    }
    return result;
}

module.exports = findPrimes;