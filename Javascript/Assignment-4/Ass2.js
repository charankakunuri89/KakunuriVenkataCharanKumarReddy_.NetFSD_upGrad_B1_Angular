let students = [
  { name: "Akhil", marks: 85 },
  { name: "Priya", marks: 72 },
  { name: "Ravi", marks: 90 },
  { name: "Meena", marks: 45 },
  { name: "Karan", marks: 30 }
];

let passedStudentsList = students.filter(student => student.marks >= 40);
console.log(passedStudentsList);

let distinctionStudentsList = students.filter(student => student.marks >= 85);
console.log(distinctionStudentsList);

// let sum = students.reduce((sum, student) => {
//     return (sum + student.marks);
// }, 0);
// console.log(sum);
let sum = students.reduce((total, student) => total + student.marks, 0);
console.log(sum);
let average = sum / students.length;
console.log("Class Average: ", average);

// let average = students.reduce((sum, student) => sum + student.marks , 0) / students.length;
// console.log("Class Average: ", average);


let topper = students.reduce((prev, current) => {
  return current.marks > prev.marks ? current : prev;
});
console.log("Topper: ", topper.name, topper.marks);

// let topper = students.reduce((a, b) => a.marks > b.marks ? a : b);
// console.log(topper);

let failedStudentsCount = students.reduce((count, student) => (student.marks < 35 ? count + 1: count), 0);
console.log(failedStudentsCount);

// let failedStudentsCount = students.filter(student => student.marks < 35).length;
// console.log(failedStudentsCount);

let grades = students.map(student => {
  let grade ;
  if (student.marks >= 90) grade = "A";
  else if (student.marks >= 75) grade = "B";
  else if (student.marks >= 35) grade = "C";
  else grade = "Fail";
  return {...student, grade : grade};
})

console.log(grades);

//Bonus 
//Add rank to each student
let sortedStudents = [...students].sort((a, b) => b.marks - a.marks);

let rankedStudents = sortedStudents.map((student, index) => ({
  ...student,
  rank : index + 1
}));
console.log(rankedStudents);

let updatedStudentsAfterRemovingLowestScorer = [...students].sort((a, b) => a.marks - b.marks).slice(1);
console.log(updatedStudentsAfterRemovingLowestScorer);

let leaderBoard = [...students].sort((a, b) => b.marks - a.marks).map((student, index) => ({rank : index + 1, ...student}));
console.log(leaderBoard);
