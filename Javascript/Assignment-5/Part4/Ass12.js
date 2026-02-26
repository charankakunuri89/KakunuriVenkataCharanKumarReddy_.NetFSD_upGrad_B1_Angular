class Wallet {
    #balance

    constructor(balance) {
        this.#balance = balance;
    }

    addMoney(value) {
        if (value > 0) { 
            this.#balance += value;
        }
        else {
            console.log("Invalid amount");
        }
    }

    spendMoney(value) {
        if (value <= this.#balance) {
            this.#balance -= value;
        }
        else {
            console.log("Insufficient balance.");
        }
    }

    getBalance() {
        return `Current Balance is : ${this.#balance}`;
    }
}

let bal = new Wallet(1000);
bal.addMoney(200);
bal.spendMoney(230);
console.log(bal.getBalance());