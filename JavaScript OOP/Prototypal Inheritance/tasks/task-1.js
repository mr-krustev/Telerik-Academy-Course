/* Task Description */
/*
 * Create an object domElement, that has the following properties and methods:
 * use prototype inheritance, without function constructors
 * method init() that gets the domElement type
 * i.e. `Object.create(domElement).init('div')`

 !* property type that is the type of the domElement
 * a valid type is any non-empty string that contains only Latin letters and digits

 !* property innerHTML of type string
 * gets the domElement, parsed as valid HTML
 * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>

 !* property content of type string
 * sets the content of the element
 * works only if there are no children

 !* property attributes
 * each attribute has name and value
 * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)

 !* property children
 * each child is a domElement or a string

 !* property parent
 * parent is a domElement

 !* method appendChild(domElement / string)
 * appends to the end of children list

 !* method addAttribute(name, value)
 * throw Error if type is not valid

 !* method removeAttribute(attribute)
 * throw Error if attribute does not exist in the domElement
 */

function solve() {
    var domElement = (function () {
        function checkIfValidType(value) {
            var regExp = new RegExp('[^A-Za-z0-9]');

            if (typeof value !== 'string') {
                return false;
            }

            if (value == '' || regExp.test(value)) {
                return false;
            }
            return true;
        }

        function checkIfValidAttribute(value) {
            var regExp = new RegExp('[^A-Za-z0-9-]');

            if (typeof value !== 'string') {
                return false;
            }

            if (value == '' || regExp.test(value)) {
                return false;
            }
            return true;
        }

        function parseHTML(domElement) {
            var i, len,
                elementAttributes = domElement.attributes.sort(function (a, b) {
                    return a.name.localeCompare(b.name);
                }),
                result = '<' + domElement.type;

            for (i = 0, len = elementAttributes.length; i < len; i += 1) {
                result += ' ' + elementAttributes[i].name + '="' + elementAttributes[i].value + '"';
            }
            result += '>';

            if (domElement.children.length > 0) {
                for (i = 0, len = domElement.children.length; i < len; i += 1) {
                    if (typeof domElement.children[i] === 'string') {
                        result += domElement.children[i];
                        continue;
                    }
                    result += domElement.children[i].innerHTML;
                }
            } else if(domElement.content) {
                result += domElement.content;
            }

            result += '</' + domElement.type + '>';
            return result;
        }


        var domElement = {

            get type() {
                return this._type;
            },
            set type(value) {
                if (!checkIfValidType(value)) {
                    throw new Error('Invalid type!');
                }
                return this._type = value;
            },
            get innerHTML() {
                var result = parseHTML(this);
                return result;
            },
            get content() {
                return this._content;
            },
            set content(value) {
                return this._content = value;
            },
            get attributes() {
                return this._attributes;
            },
            set attributes(value) {
                return this._attributes = value;
            },
            get children() {
                return this._children;
            },
            set children(value) {
                return this._children = value;
            },
            get parent() {
                return this._parent;
            },
            set parent(value) {
                return this._parent = value;
            },

            init: function (type) {
                this.type = type;
                this.content;
                this.attributes = [];
                this.children = [];
                this.parent;

                return this;
            },

            appendChild: function (child) {
                this.children.push(child);
                child.parent = this;
                return this;
            },
            addAttribute: function (name, value) {
                var i, len;

                if (!checkIfValidAttribute(name)) {
                    throw new Error('Invalid attribute!')
                }

                for (i = 0, len = this._attributes.length; i < len; i += 1) {
                    if (this._attributes[i].name == name) {
                        this._attributes[i].value = value;
                        return this;
                    }
                }

                this.attributes.push({name: name, value: value});
                return this;
            },
            removeAttribute: function (name) {
                var i, len;
                for (i = 0, len = this._attributes.length; i < len; i += 1) {
                    if (this._attributes[i].name == name) {
                        this._attributes.splice(i, 1);
                        return this;
                    }
                }
                throw new Error('Cannot find attribute with name: "' + name + '"');
            }
        };
        return domElement;
    }());
    return domElement;
}

module.exports = solve;


/* Example

 var meta = Object.create(domElement)
 .init('meta')
 .addAttribute('charset', 'utf-8');

 var head = Object.create(domElement)
 .init('head')
 .appendChild(meta)

 var div = Object.create(domElement)
 .init('div')
 .addAttribute('style', 'font-size: 42px');

 div.content = 'Hello, world!';

 var body = Object.create(domElement)
 .init('body')
 .appendChild(div)
 .addAttribute('id', 'cuki')
 .addAttribute('bgcolor', '#012345');

 var root = Object.create(domElement)
 .init('html')
 .appendChild(head)
 .appendChild(body);

 console.log(root.innerHTML);
 Outputs:
 <html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
 */