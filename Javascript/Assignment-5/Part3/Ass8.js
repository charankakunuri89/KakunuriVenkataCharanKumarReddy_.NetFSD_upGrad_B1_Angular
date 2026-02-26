class Payment {
    pay(amount) {
        console.log("Basic Payment for all Types")
    }
}

class CreditCardPayment extends Payment {
    pay(amount) {
        console.log("Credit Card Payment: "  + amount);
    }
}

class UPIPayment extends Payment {
    pay(amount) {
        console.log(`UPI payment: ${amount}`)
    }
}

class CashPayment extends Payment {
    pay(amount) {
        console.log('CashPayment is: ' + amount);
    }
}

let payments = [
    new CreditCardPayment(),
    new UPIPayment(),
    new CashPayment()
]

payments.forEach(element => {
    element.pay(1000)
});