function solve(params) {
    var s = params[0], c1 = params[1], c2 = params[2], c3 = params[3];
    var answer = 0;
    var firstCakes, secondCakes, thirdCakes, moneySpent;

    for (firstCakes = 0; firstCakes <= s / c1; firstCakes += 1) {
        for (secondCakes = 0; secondCakes <= s / c2; secondCakes += 1) {
            for (thirdCakes = 0; thirdCakes <= s / c3; thirdCakes += 1) {
                moneySpent = firstCakes * c1 + secondCakes * c2 + thirdCakes * c3;
                if (moneySpent <= s && moneySpent > answer) {
                    answer = moneySpent;
                } else if (moneySpent > s) {
                    break;
                }
            }
        }
    }
    console.log(answer);
}


var tests = [
    ['7000',
        '1',
        '2',
        '3'
    ],
    [
        '20',
        '11',
        '200',
        '300'
    ],
    [
        '110',
        '19',
        '29',
        '39'
    ]
];

solve(tests[0]);
console.log('------------');
solve(tests[1]);