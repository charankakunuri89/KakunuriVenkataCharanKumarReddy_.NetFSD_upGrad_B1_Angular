class BankAccount {
    constructor (accountHolder, balance) {
        this.accountHolder = accountHolder;
        this.balance = balance;
    }

    deposit(amount) {
        this.balance += amount;
    }

    withdraw(amount) {
        if (this.balance > amount) this.balance -= amount;
        else console.log("withdraw not possible");
    }

    checkBalance() {
        console.log("Current Balance: " + this.balance);
    }
}

let transaction = new BankAccount("Charan", 5000);
transaction.deposit(1000);
transaction.withdraw(7000);
transaction.checkBalance();