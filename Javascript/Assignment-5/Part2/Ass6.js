class Shape {
    calculateArea() {
        console.log("Area calculation not defined for Shape");
    }
}

class Circle extends Shape {
    constructor(radius) {
        super();
        this.radius = radius;
    }

    calculateAreaOfCircle() {
        return Math.PI * this.radius * this.radius;
    }
    calculateArea() {
        // console.log(`Area of Circle: ${this.calculateAreaOfCircle()}`);
        console.log(`Area of Circle: ${this.calculateAreaOfCircle().toFixed(2)}`);
    }
}

class Rectangle extends Shape {
    constructor(length, breadth) {
        super();
        this.length = length;
        this.breadth = breadth;
    }
    calculateAreaOfRectangle() {
        return this.length * this.breadth;
    }
    calculateArea(){
        console.log(`Area of Rectangle is: ${this.calculateAreaOfRectangle()}`)
    }
}

class Triangle extends Shape {
    constructor(base, height) {
        super();
        this.base = base;
        this.height = height;
    }

    calculateAreaOfTriangle() {
        return 0.5 * this.base * this.height;
    }
    calculateArea() {
        console.log(`Area of Triangle is : ${this.calculateAreaOfTriangle()}`);
    }
}

let shapes = [ 
    new Circle(10),
    new Rectangle(2, 5),
    new Triangle(20, 5)
]

for (let shape of shapes) {
    shape.calculateArea();
}
