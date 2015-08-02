/* globals $ */

function solve() {

    return function (selector) {
        var template =
            '<div class="container">' +
                '<h1>Animals</h1>' +
                '<ul>' +
                '{{#each animals}}' +
                    '<li class="{{name}}">' +
                        '{{#if url}}' +
                        '<a href="{{url}}">See a {{name}}</a>' +
                        '{{else}}' +
                        '<a href="http://goo.gl/Eww2qu">No link for {{name}}, here is Batman!</a>' +
                        '{{/if}}' +
                    '</li>' +
                '{{/each}}' +
                '</ul>' +
            '</div>';
        document.querySelector(selector).innerHTML = template;
        //$(selector).html(template);
    };
}

//module.exports = solve;

var result = solve();
result('#template');
var data = {
    animals: [{
        name: 'Lion',
        url: 'https://susanmcmovies.files.wordpress.com/2014/12/the-lion-king-wallpaper-the-lion-king-2-simbas-pride-4685023-1024-768.jpg"'
    }, {
        name: 'Turtle',
        url: 'http://www.enkivillage.com/s/upload/images/a231e4349b9e3f28c740d802d4565eaf.jpg'
    }, {
        name: 'Dog'
    }, {
        name: 'Cat',
        url: 'http://i.imgur.com/Ruuef.jpg'
    }, {
        name: 'Dog Again'
    }]
};

var templateFunc = Handlebars.compile(document.getElementById('template').innerHTML);

var output = templateFunc(data);

document.body.innerHTML = output;