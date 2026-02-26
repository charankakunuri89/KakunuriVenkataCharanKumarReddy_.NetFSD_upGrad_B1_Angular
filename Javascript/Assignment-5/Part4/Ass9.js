class Product {

    // constructor with Destructuring + Default Parameter
    constructor({ name, price, category = "General", tags = [] }) {
        this.name = name;
        this.price = price;
        this.category = category;
        this.tags = [...tags];//spread operator
    }

    //Arrow function inside class
    getDetails = () => {
        return `Product: ${this.name} | Price: ${this.price} | Category: ${this.category}`;
    }

    //Default parameter Method
    applyDiscount(discount = 10) {
        this.price -= this.price * (discount / 100);
        return `After ${discount}% dicount, price is ₹${this.price}`;
    }

    //spread operator Method
    addTags(...newTags) {
        this.tags = [...this.tags, ...newTags];
        return this.tags;
    }
}

// creating object using destructuring format
const product1 = new Product({
    name : "Laptop",
    price : 50000,
    category : "Electronics",
    tags : ["Tech", "Portable"]
});
console.log(product1.getDetails());
console.log(product1.applyDiscount());
console.log(product1.addTags("New", "Trending"));


