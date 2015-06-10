function solve(args) {
   var currentDir,
       rowsAndCols = args[0].split(' '),
       rows = rowsAndCols[0], cols = rowsAndCols[1],
       deltaDirections = {
           1: [-2,1],
           2: [-1,2],
           3: [1,2],
           4: [2,1],
           5: [2,-1],
           6: [1,-2],
           7: [-1,-2],
           8: [-2,-1]
       },
       weeds = 0,
       numberOfJumpsMade = 0,
       row = rows- 1, col = cols- 1,
       matrix = args.splice(1).map(function (line) {
           return line.split('');
       });

    while(1){
        if(row >= rows || col >= cols || row < 0 || col < 0){
            console.log('Go go Horsy! Collected ' + weeds + ' weeds');
            break;
        }

        if(matrix[row][col] == 'visited'){
            console.log('Sadly the horse is doomed in ' + numberOfJumpsMade + ' jumps');
            break;
        }

        weeds += (1<< row) - col;
        currentDir = deltaDirections[matrix[row][col]];

        matrix[row][col] = 'visited';

        row+= currentDir[0];
        col+= currentDir[1];

        numberOfJumpsMade+=1;
    }
}


var tests = [
    [
        '3 5',
        '54561',
        '43328',
        '52388'
    ],
    [
        '20 5',
        '54361',
        '43326',
        '52188',
        '54361',
        '43326',
        '52188',
        '54361',
        '43326',
        '52188',
        '54361',
        '43326',
        '52188',
        '54361',
        '43326',
        '52188',
        '54361',
        '52188',
        '52188',
        '52188',
        '52188'
    ]
];

var start = new Date().getTime();
console.log(solve(tests[0]));
var end = new Date().getTime();
console.log(end- start);
console.log('------------');
start = new Date().getTime();
console.log(solve(tests[1]));
end = new Date().getTime();
console.log(end- start);