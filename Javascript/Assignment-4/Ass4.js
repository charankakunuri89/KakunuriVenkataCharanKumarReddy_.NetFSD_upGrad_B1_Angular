let employees = [
 { id:1, name:"Ravi", dept:"IT", salary:70000 },
 { id:2, name:"Anita", dept:"HR", salary:50000 },
 { id:3, name:"Karan", dept:"IT", salary:80000 },
 { id:4, name:"Meena", dept:"Finance", salary:60000 }
];

let totalExpense = employees.reduce((total, emp) => total + emp.salary , 0);
console.log(totalExpense);

let sortedSalaries = [...employees].sort((a, b) => b.salary - a.salary);
console.log("Highest Paid Employee: " + sortedSalaries[0].name);
console.log("Lowest Paid Employee: " + sortedSalaries[sortedSalaries.length - 1].name);

let ItSalaryIncrement = employees.map(emp => {
    if (emp.dept === "IT") {
        emp.salary = emp.salary * 1.15;
    }
    return emp;
})

console.log(ItSalaryIncrement);

let groupedByDept = employees.reduce((acc, emp) => {
    if (!acc[emp.dept]) {
        acc[emp.dept] = [];
    }
    acc[emp.dept].push(emp);
    return acc;
}, {});
console.log(groupedByDept);

// department wise average salary
let averageSalaryOfDepartment = employees.reduce((acc, emp) => {
    if (!acc[emp.dept]) {
        acc[emp.dept] = { total: 0, count: 0};
    }
    acc[emp.dept].total += emp.salary;
    acc[emp.dept].count += 1;
    return acc;
}, {});

for (let dept in averageSalaryOfDepartment) {
    averageSalaryOfDepartment[dept] = averageSalaryOfDepartment[dept].total / averageSalaryOfDepartment[dept].count;
}
console.log(averageSalaryOfDepartment)

//sort employees by salary descending

let sortedEmployees = [...employees].sort((a, b) => b.salary - a.salary);
console.log(sortedEmployees);

//tax deduction 
let AfterDeductionSalaries = employees.map(emp => emp.salary * 0.9);
console.log(AfterDeductionSalaries);

// employees earning above average salary
let TotalSalaries = employees.reduce((total, emp) => total + emp.salary, 0);
console.log(TotalSalaries);

let averageSalaries = TotalSalaries / employees.length;
console.log(averageSalaries);

let EmployeesAboveAvg = employees.filter(emp => emp.salary > averageSalaries);
console.log(EmployeesAboveAvg);



let tbody = document.querySelector('#empTable tbody');

employees.forEach(emp => {
    let row = `
    <tr>
        <td>${emp.id}</td>
        <td>${emp.name}</td>
        <td>${emp.dept}</td>
        <td>${emp.salary}</td>
    `;
    tbody.innerHTML += row;
})