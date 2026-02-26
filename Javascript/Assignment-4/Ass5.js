let numbers = [70, 10, 20, 30, 10, 40, 50, 60, 60];
let set = new Set(numbers)
console.log(set);

let secondLargest = [...new Set(numbers)].sort((a, b) => (b - a));
console.log(secondLargest[1]);

let frequency = numbers.reduce((acc, num) => {
    acc[num] = (acc[num] || 0) + 1;
    return acc;
}, {});

console.log(frequency);

let firstNonRepeating = numbers.filter(num => frequency[num] === 1)[0];
console.log(firstNonRepeating);

let k = 2;
let rotatedLeft= numbers.slice(k).concat(numbers.slice(0,k))
console.log(rotatedLeft);
let rotatedRight = numbers.slice(-k).concat(numbers.slice(0, -k))
console.log(rotatedRight);

let FlattenNestedArray = [1,2,[3,4,[5]]];
let flatten = FlattenNestedArray.flat(Infinity);
console.log(flatten);

let numb = [1,2,3,5,6,4,7];
let n = numb.length + 1;
let total = numb.reduce((total, n) => total + n, 0);
let missing = (n * (n + 1)) / 2 - total;
console.log(missing);


