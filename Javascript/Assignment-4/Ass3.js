let cart = [
  { id: 1, product: "Laptop", price: 60000, qty: 1 },
  { id: 2, product: "Headphones", price: 2000, qty: 2 },
  { id: 3, product: "Mouse", price: 800, qty: 1 }
];

let totalCart = cart.reduce((total, item) => total + item.price * item.qty , 0);
console.log(totalCart);

// let increaseQuantity = cart.map(item => {
//     if (item.id === 1) {
//         return {...item, qty : item.qty + 1};
//     }
//     return item;
// });

let increasedId = 3;
let increaseQuantity = cart.map(item => item.id ===  increasedId? 
    {...item, qty : item.qty + 1} : item);
console.log(increaseQuantity);

let removedIndex = 2;
let removeProduct = cart.filter(item => item.id !== removedIndex);
console.log(removeProduct);

// let discountedProducts = cart.map(item =>{
//     if (item.price >= 10000) {
//     return {...item, price : item.price * 0.9}; 
//     }
//     return item;
// });
// console.log(discountedProducts);

let discounted = cart.map(item => item.price >= 10000 ?
    {...item, price : item.price * 0.9} : item);
console.log(discounted);

let sortedProducts = [...cart].sort((a, b) => (b.price * b.qty) - (a.price * a.qty) );
console.log(sortedProducts);

let productsAbove50000 = cart.filter(item => item.price > 50000);
console.log(productsAbove50000);

let allItemsInStock = cart.every(item => item.qty > 0);
console.log(allItemsInStock);

//Bonus
//cart into invoice format
let invoiceFormat = cart.map(item => ` ${item.product} | Price: ₹${item.price} | Qty: ${item.qty} | Total: ₹${item.price * item.qty} `);
console.log(invoiceFormat);

//most expensive product
// let expensiveProduct = cart.reduce((max, item) => item.price > max.price ? item : max);
// console.log(expensiveProduct);

let expensiveProduct = cart.reduce((max, item) => (item.price * item.qty > max.price * max.qty) ? item : max);
console.log(expensiveProduct);

// let totalGST = cart.reduce((total, item) => total + (item.price * item.qty), 0) * 1.18;
// console.log(totalGST);

let total= cart.reduce((total, item) => total + (item.price * item.qty), 0);
let gst = total * 0.18;
let finalAmount = total + gst;
console.log(finalAmount);
