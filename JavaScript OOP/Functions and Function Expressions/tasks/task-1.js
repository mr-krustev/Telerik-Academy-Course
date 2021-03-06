/* Task Description */
/* 
 Write a function that sums an array of numbers:
 numbers must be always of type Number
 returns `null` if the array is empty
 throws Error if the parameter is not passed (undefined)
 throws if any of the elements is not convertible to Number

 */

function solve () {

    return function (arr) {
        var i, sum, len;


        if(arr === 'undefined'){
            throw new Error();
        }

        if(arr.length === 0){
            return null;
        }

        sum = 0;

        for(i = 0, len = arr.length; i < len; i+=1){
            if(isNaN(arr[i])){
                throw new Error();
            }
            sum += +arr[i];
        }
        return sum;
    }

}

module.exports = sum;