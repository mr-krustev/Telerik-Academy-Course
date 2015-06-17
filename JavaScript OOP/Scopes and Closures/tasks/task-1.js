/* Task Description */
/* 
 *	Create a module for working with books
 *	The module must provide the following functionalities:
 *	Add a new book to category
 *	Each book has unique title, author and ISBN
 *	It must return the newly created book with assigned ID
 *	If the category is missing, it must be automatically created
 *	List all books
 *	Books are sorted by ID
 *	This can be done by author, by category or all
 *	List all categories
 *	Categories are sorted by ID

 *	Each book/category has a unique identifier (ID) that is a number greater than or equal to 1
 *	When adding a book/category, the ID is generated automatically

 *	Add validation everywhere, where possible
 *	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
 *	Author is any non-empty string
 *	Unique params are Book title and Book ISBN
 *	Book ISBN is an unique code that contains either 10 or 13 digits
 *	If something is not valid - throw Error
 */
function solve() {
    var library = (function () {
        var books = [];
        var categories = [];

        function checkUniqueISBN(tempISBN) {
            var i, len;
            if (tempISBN.length != 10 && tempISBN.length != 13) {
                return true;
            }

            for (i = 0, len = books.length; i < len; i += 1) {
                if (books[i].isbn === tempISBN) {
                    return true;
                }
            }
            return false;
        }

        function checkUniqueTitle(title) {
            var i, len;
            if (!(title.length > 2 && title.length < 101)) {
                return true;
            }
            for (i = 0, len = books.length; i < len; i += 1) {
                if (books[i].title === title) {
                    return true;
                }
            }
            return false;
        }

        function addBook(book) {
            book.ID = books.length + 1;
            if (!(book.author.length > 0)) {
                throw new Error('Expected author name!');
            }
            var tempISBN = book.isbn;
            if (checkUniqueISBN(tempISBN)) {
                throw new Error('Expected unique ISBN!');
            }
            if (checkUniqueTitle(book.title)) {
                throw new Error('Expected unique title!');
            }
            books.push(book);
            if (!(categories.indexOf(book.category) > -1)) {
                var category = book.category;
                category.ID = categories.length + 1;
                categories.push(category);
            }
            return book;
        }

        function listBooks(bookProperty) {
            // check if empty array
            if (books.length === 0) {
                return books;
            }
            if (bookProperty !== undefined) {
                // check if sorting by category
                if (bookProperty.category !== undefined) {
                    return books.filter(function (book) {
                        if (book.category === bookProperty.category) {
                            return book;
                        }
                    }).sort(function (book, nextBook) {
                        return book.category >= nextBook.category;
                    });
                }
                // check if sorting by author
                if (bookProperty.author !== undefined) {
                    return books.filter(function (book) {
                        if (book.author === bookProperty.author) {
                            return book;
                        }
                    }).sort(function (book, nextBook) {
                        return book.author >= nextBook.author;
                    });
                }
                // check if sorting by all
                if (bookProperty.category !== undefined) {
                    return books;
                }
            }
            return books;
        }

        function listCategories() {
            return categories;
        }

        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    }());
    return library;
}
module.exports = solve;