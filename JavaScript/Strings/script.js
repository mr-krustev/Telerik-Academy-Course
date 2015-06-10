/*
 Problem 1. Reverse string

 Write a JavaScript function that reverses a string and returns it.
 */

function reverseString(text) {
    var i, temp,
        allChars = text.split(''),
        len = allChars.length;

    for (i = 0; i < len / 2; i += 1) {
        temp = allChars[len - 1 - i];
        allChars[len - 1 - i] = allChars[i];
        allChars[i] = temp;
    }

    return allChars.join('');
}

console.log(reverseString('sample'));
console.log(reverseString('Gosho'));
console.log(reverseString('Salam, stoi si tam!'));

/*
 Problem 2. Correct brackets

 Write a JavaScript function to check if in a given expression the brackets are put correctly.

 Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
 */

function checkCorrectBrackets(expression) {

    var i,
        openBrackets = 0,
        closeBrackets = 0,
        allChars = expression.split(''),
        len = allChars.length;

    for (i = 0; i < len; i += 1) {
        if (allChars[i] == ')' && !openBrackets) {
            return false;
        }

        if (allChars[i] == ')') {
            closeBrackets += 1;
        } else if (allChars[i] == '(') {
            openBrackets += 1;
        }

        if (closeBrackets > openBrackets) {
            return false;
        }
    }

    if (openBrackets - closeBrackets != 0) {
        return false;
    }

    return true;
}
console.log('--------------------');
console.log('Is ((a+b)/5-d) correct? ' + checkCorrectBrackets('((a+b)/5-d)'));
console.log('Is )(a+b)) correct? ' + checkCorrectBrackets(')(a+b))'));

/*
 Problem 3. Sub-string in text

 Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).
 Example:

 The target sub-string is in

 The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

 The result is: 9
 */

function checkForSubstring(text, searchedString) {
    var i, count = 0, len = text.length, substrLength = searchedString.length;

    for (i = 0; i < len; i += 1) {
        if (text.substr(i, substrLength).toLowerCase() == searchedString.toLowerCase()) {
            count += 1;
        }
    }

    return count;
}

var exampleText = 'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.';
var testCaseSensitive = 'In the age of smart phones we are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.';

console.log('--------------------');
console.log('Example result: ' + checkForSubstring(exampleText, 'in'));
console.log('Test case sensitive result: ' + checkForSubstring(testCaseSensitive, 'in'));


/*
 Problem 4. Parse tags

 You are given a text. Write a function that changes the text in all regions:

 <upcase>text</upcase> to uppercase.
 <lowcase>text</lowcase> to lowercase
 <mixcase>text</mixcase> to mix casing(random)
 Example: We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.

 The expected result:
 We are LiVinG in a YELLOW SUBMARINE. We dOn'T have anything else.

 Note: Regions can be nested.
 */

function parseTags(text) {
    var i,
        result = '',
        textToChange,
        lastOpened,
        lastCommand,
        currCommand,
        unclosedCommands = [],
        len = text.length;

    function mixCaseFunc(text) {
        var i,
            newText = '',
            len = text.length,
            random;

        for (i = 0; i < len; i += 1) {
            random = ((Math.random() * 10) | 0) - 5;
            if (random > 0) {
                newText += text[i].toUpperCase();
            } else {
                newText += text[i].toLowerCase();
            }
        }

        return newText;
    }


    for (i = 0; i < len; i += 1) {
        if (text[i] == '<' && text[i + 1] != '/') {
            currCommand = text.substring(i, text.indexOf('>', i) + 1);
            i = text.indexOf('>', i);
            unclosedCommands.push([currCommand, i + 1]);
            continue;
        } else if (text[i] == '<' && text[i + 1] == '/') {
            lastOpened = unclosedCommands.pop();
            lastCommand = lastOpened[0];
            textToChange = text.substring(lastOpened[1], i);

            switch (lastOpened[0]) {
                case '<mixcase>':
                    var newText = mixCaseFunc(textToChange);
                    result = result.replace(textToChange, newText);
                    break;
                case '<upcase>':
                    var newText = textToChange.toUpperCase();
                    result = result.replace(textToChange, textToChange.toUpperCase());
                    break;
                case '<lowcase>':
                    var newText = textToChange.toLowerCase();
                    result = result.replace(textToChange, textToChange.toLowerCase());
                    break;
            }

            i = text.indexOf('>', i);
            continue;
        }

        result += text[i];

    }
    return result;
}

var exampleTest = 'We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don\'t</mixcase> have <lowcase>anything</lowcase> else.';

console.log('--------------------');
console.log(parseTags(exampleTest));


/*
 Problem 5. nbsp

 Write a function that replaces non breaking white-spaces in a text with &nbsp;
 */

// Thanks to dentia.
function replaceAll(text, toReplace, replacement) {
    var regex = new RegExp(toReplace, 'gi');    // This is the RegEx constructor using ('what to replace', 'active flags')
    return text.replace(regex, replacement);        // In this case : the regex can look like    /[ ]/gi
}

var text = 'We are   living in a yellow submarine. We don\'t have anything   else.';
console.log('--------------------');
console.log(replaceAll(text, ' ', '&nbsp;'));

/*
 Problem 6. Extract text from HTML

 Write a function that extracts the content of a html page given as text.
 The function should return anything that is in a tag, without the tags.
 */

function extractTextFromHTML(html) {
    // Let's assume it comes as an array. Or not.
    if (!(html instanceof Array)) {
        html = html.split('\n');
    }

    html = html.map(function (line) {
        return line.split('');
    });

    var i, j,
        result = '',
        lenTotal = html.length;

    for (i = 0; i < lenTotal; i += 1) {
        for (j = 0; j < html[i].length; j += 1) {

            if (html[i][j] == '<') {
                j += html[i].indexOf('>', j);
                continue;
            }

            result += html[i][j];
        }
    }
    return result;
}


var test = [
    '<html>',
    '<head>',
    '<title>Sample site</title>',
    '</head>',
    '<body>',
    '<div>text',
    '<div>more text</div>',
    'and more...',
    '</div>',
    'in body',
    '</body>',
    '</html>'
];

console.log('--------------------');
console.log(extractTextFromHTML(test));


/*
 Problem 7. Parse URL

 Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
 Return the elements in a JSON object.
 */

function parseURL(url) {

    var result,
        resource,
        protocolIndex = url.indexOf(':'),
        protocol = url.substring(0, protocolIndex),
        serverIndex = url.indexOf('/', protocolIndex + 3),
        server = url.substring(protocolIndex + 3, serverIndex);

    if (url.substring(serverIndex).length > 1) {
        resource = url.substring(serverIndex);
    }

    result = {
        'protocol': protocol,
        'server': server,
        'resource': resource ? resource : 'No resource used.'
    };
    return result;
}

console.log('--------------------');
console.log(parseURL('http://telerikacademy.com/Courses/Courses/Details/239'));

/*
 Problem 9. Extract e-mails

 Write a function for extracting all email addresses from given text.
 All sub-strings that match the format @… should be recognized as emails.
 Return the emails as array of strings.
 */

function extractEmails(emails) {
    var i,
        inputArray = emails.split(' '),
        arrayLength = inputArray.length,
        regExpression = /^([\w-]+(?:\.[\w-]+)*)@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)$/i,
        result = [];
    for (i = 0; i < arrayLength; i++) {
        if (regExpression.test(inputArray[i])) {
            result.push(inputArray[i]);
        }
    }
    return result.join(', ');
}

var testEmails = 'My email is: gosho@abv.bg but my friend\'s email is: ivan.petkan@gmail.com but we both use: salamBaraban@hotmail.com';

console.log('--------------------');
console.log(extractEmails(testEmails));

/*
 Problem 10. Find palindromes

 Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
 */

function findPalindromes(text) {
    var i,
        j,
        inputArray,
        arrayLenght,
        stringLenght,
        currentString,
        currentStringLenght,
        isPalindrome = true,
        inputString = text,
        result = [];
    inputString = inputString.replace(/[\.,-\/#!$%\^&\*;:{}=\-_`~()]/g,"");
    inputArray = inputString.split(' ');
    arrayLenght = inputArray.length;

    for (i = 0; i < arrayLenght; i++) {
        if (inputArray[i].length > 1) {
            currentString = inputArray[i];
            currentStringLenght = currentString.length;
            stringLenght = currentStringLenght / 2;
            stringLenght = stringLenght | 0;
            for (j = 0; j < stringLenght; j++) {
                if (currentString[j] != currentString[currentStringLenght - 1 - j]) {
                    isPalindrome = false;
                    break;
                }
            }
            if (isPalindrome) {
                result.push(currentString);
            }
            isPalindrome = true
        }
    }
    return result.join(', ');
}

var testPalindromes = 'I always loved to listen to ABBA or dance in the moonlight but since i found WOW exe i lost all contact with the world.';

console.log('--------------------');
console.log(findPalindromes(testPalindromes));

/*
 Problem 11. String format

 Write a function that formats a string using placeholders.
 The function should work with up to 30 placeholders and all types.
 */

function stringFormat() {
    var i,
        stringToFormat,
        args,
        argsLength,
        stringToBeReplaced,
        index,
        currentIndex;
    args = [].slice.apply(arguments);
    stringToFormat = args.shift();
    argsLength = args.length;

    for (i = 0; i < argsLength; i++) {
        stringToBeReplaced = '{' + i + '}';
        index = 0;
        currentIndex = stringToFormat.indexOf(stringToBeReplaced, index);
        while (currentIndex >= 0) {
            stringToFormat = stringToFormat.replace(stringToBeReplaced, args[i]);
            index = currentIndex;
            currentIndex = stringToFormat.indexOf(stringToBeReplaced, index);
        }
    }
    return stringToFormat;
}

var str = stringFormat('Hello {0}!', 'Peter');
console.log(str);

var format = '{0}, {1}, {0} text {2}';
var str2 = stringFormat(format, 1, 'Pesho', 'Gosho');
console.log(str2);

/*
 Problem 12. Generate list

 Write a function that creates a HTML <ul> using a template for every HTML <li>.
 The source of the list should be an array of elements.
 Replace all placeholders marked with –{…}– with the value of the corresponding property of the object.
 */

function generateList(arrayOfObjects) {
    var i,
        currentItem,
        thisObject,
        thisPropertyToReplace,
        result = '<ul>',
        arrayLenght = arrayOfObjects.length,
        tmpl = document.getElementById('listItem').innerHTML;
    for (i = 0; i < arrayLenght; i++) {
        thisObject = arrayOfObjects[i];
        currentItem = tmpl;
        for (prop in thisObject) {
            thisPropertyToReplace = '-{' + prop + '}-';
            currentItem = currentItem.replace(thisPropertyToReplace, thisObject[prop]);
        }
        currentItem = '<li>' + currentItem + '</li>'
        result += currentItem;
    }
    document.getElementById('listItem').innerHTML = result + '</ul>';
}