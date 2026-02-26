class Vehicle {
    #brand;
    #speed;

    constructor(brand, speed) {
        this.#brand = brand;
        this.#speed = speed;
    }
    start() {
        console.log(`${this.#brand} Vehicle Engine Starts with ${this.#speed} `);
    }
}

class Car extends Vehicle {
    #fuelType

    constructor(brand, speed, fuelType) {
        super(brand, speed);
        this.#fuelType = fuelType;
    }
    showDetails() {
        console.log(`Fuel Type: ${this.#fuelType}`)
    }
}

let car = new Car("Audi", 250, "Petrol");
car.start();
car.showDetails();
