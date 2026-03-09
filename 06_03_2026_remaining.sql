use education_domain

--Assignment 8- subqueries
select * from students
select * from courses
select * from departments
select * from enrollments
select * from marks
select * from exams
select * from teachers

--1.
select s.first_name, s.last_name, m.marks_obtained from students s join 
marks m on s.student_id = m.student_id 
where m.marks_obtained > (select avg(marks_obtained) from marks); 

--2.
select * from courses where course_credits in (select MAX(course_credits) from courses);

--3.
select s.first_name, s.last_name ,count (e.course_id) as total_courses from students s inner join enrollments e on s.student_id = e.student_id group by s.student_id, s.first_name, s.last_name having count(e.course_id)> 2;

--4.
select * from teachers where department_id in (select department_id from teachers where teacher_name = 'charan');

--5.
select s.*, m.marks_id, m.marks_obtained from students s 
join marks m on 
s.student_id = m.student_id where m.marks_obtained 
in (select max(marks_obtained) from marks) 

--6.

SELECT d.department_name, COUNT(s.student_id) AS total_students
FROM departments d
JOIN students s ON d.department_id = s.department_id
GROUP BY d.department_id, d.department_name
HAVING COUNT(s.student_id) = ANY
(
    SELECT MAX(student_count)
    FROM (
        SELECT COUNT(student_id) AS student_count
        FROM students
        GROUP BY department_id
    ) t
);

SELECT d.department_name, COUNT(s.student_id) AS total_students
FROM departments d
JOIN students s ON d.department_id = s.department_id
GROUP BY d.department_id, d.department_name
HAVING COUNT(s.student_id) IN
(
    SELECT MAX(student_count)
    FROM (
        SELECT COUNT(student_id) AS student_count
        FROM students
        GROUP BY department_id
    ) t
);


SELECT d.department_name, COUNT(s.student_id) AS total_students
FROM departments d
JOIN students s ON d.department_id = s.department_id
GROUP BY d.department_id, d.department_name
HAVING COUNT(s.student_id) =
(
    SELECT MAX(student_count)
    FROM (
        SELECT COUNT(student_id) AS student_count
        FROM students
        GROUP BY department_id
    ) t
);

----Assignment 10 - indexes--------
create index idx_student_lastname on students(last_name);

create index idx_teacher_email on teachers(email);

create index idx_enrollments_student_course on enrollments (student_id, course_id);

create unique index idx_department_name on departments(department_name);

drop  index idx_student_lastname on students;

exec sp_helpindex students;
exec sp_helpindex teachers;
exec sp_helpindex enrollments;
exec sp_helpindex departments;


---Assignment 9 - views---------
--view 1
use education_domain
create view vw_student_department 
as 
select s.student_id, CONCAT(s.first_name,s.last_name) as fullName, d.department_name from students s join departments d
on s.department_id = d.department_id
Go

select * from vw_student_department
--view 2
create view vw_student_course_enrollment
as
select concat(s.first_name, s.last_name) as full_name, c.course_name , e.enrollment from students s inner join enrollments e on s.student_id = e.student_id
inner join courses c on  e.course_id = c.course_id
Go

select * from enrollments
select * from courses
select * from students


select * from vw_student_course_enrollment

--view 3
create view vw_student_course_exam_marks
as 
select concat(s.first_name, s.last_name) as studentName, c.course_name, e.exam_type, m.marks_obtained from students s inner join marks m on s.student_id = m.student_id
inner join exams e on m.exam_id = e.exam_id inner join courses c on e.course_id = c.course_id
Go

select * from vw_student_course_exam_marks

--update the views
update vw_student_course_enrollment
set course_name = 'DSA' 
where enrollment = '2022-04-17'

--drop the views
drop view vw_student_department;
sp_helptext vw_student_course_exam_marks
drop view vw_student_course_exam_marks

