class MathUtils {
    static add(a = 0, b = 0) {
        return a + b;
    }

    static subtract(a = 0, b = 0) {
        return a - b;
    }

    static multiply(a = 1, b = 1) {
        return a * b;
    }
}

console.log(MathUtils.add(20));
console.log(MathUtils.subtract(12));
console.log(MathUtils.multiply(10));
console.log(MathUtils.multiply());


