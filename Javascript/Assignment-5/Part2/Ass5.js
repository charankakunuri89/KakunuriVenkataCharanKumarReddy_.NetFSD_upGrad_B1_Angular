class Employee {
    #name
    #salary

    constructor(name, salary) {
        this.#name = name;
        this.#salary = salary;
    }

    getSalary() {
        return this.#salary;
    }

    getName() {
        return this.#name;
    }

    getDetails() {
        console.log(`Name of Employee is ${this.#name} and salary is ${this.#salary}`);
    }
}

class Manager extends Employee {
    #bonus
    constructor(name, salary, bonus) {
        super(name, salary)
        this.#bonus = bonus;
    }

    getBonus() {
        return this.#bonus;
    }

    calculateTotalSalary() {
        return this.getSalary() + this.#bonus;
    }

    getTotalSalary() {
        console.log(`Total (Salary + bonus) of Employee is : ${this.calculateTotalSalary()}` );
    }
}

class Director extends Manager {
    #stockOptions 
    constructor (name, salary, bonus, stockOptions) {
        super(name, salary, bonus)
        this.#stockOptions = stockOptions;
    }

    getFullCompensation() {
        let fullComp = this.calculateTotalSalary() + this.#stockOptions;
        console.log(`Full Compensation (Salary + Bonus + Stock): ${fullComp}`);
    }
}

let director = new Director("Charan", 30000, 2000,100);
director.getDetails();
director.getTotalSalary();
director.getFullCompensation();