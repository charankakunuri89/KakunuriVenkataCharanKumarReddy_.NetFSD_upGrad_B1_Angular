class Animal {
    makeSound(){
        console.log(`It is Common for Each and Every animal`);
    }
}

class Dog extends Animal {
    makeSound() {
        console.log(`It makes a sound like Bow... Bow...`);
    }
}

class Cat extends Animal {
    makeSound() {
        console.log(`It makes a sound like Meow... Meow...`);
    }
}

class Cow extends Animal {
    makeSound() {
        console.log(`It makes a sound like Ambaaa... Ambaaa...`);
    }
}

let animals = [
    new Dog(),
    new Cat(),
    new Cow()
]

animals.forEach(a => a.makeSound());