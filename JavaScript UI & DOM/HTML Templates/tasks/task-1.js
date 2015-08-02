/* globals jquery $ */

function solve() {

    return function (selector) {
        var template = '' +
            '<table class="items-table">' +
                '{{#if headers}}' +
                '<thead>' +
                    '<tr>' +
                        '<th>#</th>' +
                        '{{#each headers}}' +
                        '<th>{{this}}</th>' +
                        '{{/each}}' +
                    '</tr>' +
                '</thead>' +
                '{{/if}}' +
                '{{#if items}}' +
                '<tbody>' +
                    '{{#each items}}' +
                    '<tr>' +
                        '<td>{{@key}}</td>' +
                        '<td>{{col1}}</td>' +
                        '<td>{{col2}}</td>' +
                        '<td>{{col3}}</td>' +
                    '</tr>' +
                    '{{/each}}' +
                '</tbody>' +
                '{{/if}}' +
            '</table>';
        document.getElementById('template').innerHTML = template;
        //$(selector).html(template);
    };
}
var test = solve();
document.body.innerHTML = '<script id="template"></script>';
test('#template');

var data = data = {
    headers : ['Vendor', 'Model', 'OS'],
    items : [{
        col1: 'Nokia',
        col2: 'Lumia 920',
        col3: 'Windows Phone'
    }, {
        col1: 'LG',
        col2: 'Nexus 5',
        col3: 'Android'
    }, {
        col1: 'Apple',
        col2: 'iPhone 6',
        col3: 'iOS'
    }]
    };
var template = Handlebars.compile(document.getElementById('template').innerHTML);
var compiledHTML = template(data);
document.body.innerHTML = compiledHTML;
//module.exports = solve;