/* Task description */
/*
 Write a function a function that finds all the prime numbers in a range
 1) it should return the prime numbers in an array
 2) it must throw an Error if any on the range params is not convertible to `number`
 3) it must throw an Error if any of the range params is missing
 */

function solve () {

    return function (from, to) {
        var i,divisor,maxDivisor,isPrime,
            primes = [];

        from *=1;
        to *=1;

        if(isNaN(from) || isNaN(to)){
            throw new Error();
        }

        for(i = from; i <= to; i+=1){
            maxDivisor = Math.sqrt(i);
            isPrime = true;
            if(i <= 1 ){
                continue;
            }
            for(divisor = 2; divisor <= maxDivisor; divisor+=1){
                if(!(i % divisor)){
                    isPrime = false;
                }
            }
            if(isPrime){
                primes.push(i);
            }
        }

        return primes;
    }

}

module.exports = findPrimes;