let books = [
    { id: 1, title: "JavaScript Basics", price: 450, stock: 10 },
    { id: 2, title: "React Guide", price: 650, stock: 5 },
    { id: 3, title: "Node.js Mastery", price: 550, stock: 8 },
    { id: 4, title: "CSS Complete", price: 300, stock: 12 }
];

let titles = books.map(book => book.title);
console.log(titles);

let total = books.reduce((sum, book) => {
    return sum + (book.price * book.stock);
}, 0);

console.log(`total inventory value: ${total}`);

let Above500 = books.filter(book => (book.price > 500));
console.log(Above500);

let increasedPrice = books.map(book => {
    return {
        ...book,
        price : book.price * 1.05
    };
});
console.log(increasedPrice);

let sortedBooks = [...books].sort((a, b) => a.price - b.price);
console.log(sortedBooks);

let removedID = 2;
let remainingBooks = books.filter(book => book.id !== removedID);
console.log(remainingBooks);

let outOfStock = books.some(book => book.stock === 0);
console.log("Any book out of stock?", outOfStock);

//Bonus 
//Group books by price range
let grouped = books.reduce((acc,book) => {
    if (book.price <= 500) {
        acc["Under 500"].push(book);
    } else {
        acc["Above 500"].push(book);
    }
    return acc;
}, { "Under 500" : [], "Above 500" : []});
console.log(grouped);

//Add discount only for books above ₹ 600
let discountedBooks = books.map(book => {
    if (book.price > 600) {
        return {
            ...book,
            price: book.price * 0.9
        };
    }
    return book;
});
console.log(discountedBooks);

//Generate invoice string using join()
let invoice = books.map(book => `${book.title} - ₹${book.price}`).join("\n");
console.log("Invoice:" + invoice);

