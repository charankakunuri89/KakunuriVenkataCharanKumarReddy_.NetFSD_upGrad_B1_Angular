// class User {
//     #_password

//     constructor (password) {
//         this.setPassword(password);
//     }
//     getPassword() {
//         return this.#_password;
//     }

//     setPassword(password) {
//         if (password.length >= 6) {
//             this.#_password = password;
//         }
//         else {
//             console.log("Password must atleast 6 characters long.");
//         }
//     }
// }
// let pass = new User("Charan@123");
// console.log(pass.getPassword());

class User {
    #_password;

    constructor(password) {
        this.password = password;
    }

    get password() {
        return this.#_password;
    }

    set password(value) {
        if (value.length >= 6) {
            this.#_password = value;
        } else {
            console.log("Password must be at least 6 characters.")
        }
    }
}

let user = new User("Charan@89");
console.log(user.password);
