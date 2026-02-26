class Student {
    constructor(name, marks) {
        this.name = name;
        this.marks = marks;
    }

    addMark(mark) {
        this.marks.push(mark);
    }

    getAverage() {
        let sum = 0;
        for (let i = 0; i < this.marks.length; i++) {
            sum += this.marks[i];
        }
        return sum / this.marks.length;
    }

    getGrade() {
        if (this.marks >= 90) return "A";
        else if (this.marks >= 75) return "B";
        else if (this.marks >= 50) return "C";
        else return "Fail";
    }
}

let student = new Student("Charan", [75,45,35,98]);
student.addMark(67);
console.log(student.getAverage());
console.log(student.getGrade());
