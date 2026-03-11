-------1.Views Assignment----------------
---Assignment 1 - Student Department View 
use education_domain
select * from students;
select * from departments;
--1.create the view.
create view vw_StudentDepartment
as
select s.student_id, concat(s.first_name, ' ' , s.last_name) as full_name,
d.department_name, s.admission_date from students s inner join 
departments d on s.department_id= d.department_id;

--2.Retrieve all records from the view
select * from vw_StudentDepartment

--3.Filter students from CSE using the view 
select * from vw_StudentDepartment where department_name = 'CSE';

-- View the views
sp_helptext vw_StudentDepartment

--4. Drop the view.
drop view vw_StudentDepartment


--Assignment 2 - Student Course Enrollment View 
alter view vw_StudentCourses
as 
select s.student_id, CONCAT(s.first_name, ' ', s.last_name) as full_name , c.course_name, e.enrollment from students s inner join enrollments e on s.student_id = e.student_id
inner join courses c on e.course_id = c.course_id

select * from vw_StudentCourses where student_id = 122;

select full_name, count(course_name) as TotalCourses from vw_StudentCourses group by full_name;

select * from vw_StudentCourses where enrollment > '2024-01-01';


--Assignment 3 - Student Course Enrollment View 
create view vw_ExamResults
as 
select Concat(s.first_name,' ', s.last_name) as StudentName, c.course_name, e.exam_type, m.marks_obtained from students s inner join marks m on s.student_id = m.student_id inner join exams e on m.exam_id = e.exam_id inner join courses c on e.course_id = c.course_id;
go

select * from vw_ExamResults where marks_obtained > 80;

select * from vw_ExamResults v where marks_obtained in (select max(marks_obtained) from marks m inner join exams e on m.exam_id = e.exam_id where e.exam_type = v.exam_type);

select * from vw_ExamResults where marks_obtained < 35;

--Assignment 4 - Aggregate View
create view vw_DepartmentStudentCount
as
select d.department_name, count(*) as count_students from departments d inner join students s on d.department_id = s.department_id group by d.department_name;
Go

select * from vw_DepartmentStudentCount where count_students > 10;
select * from vw_DepartmentStudentCount order by count_students desc;


----------2. Stored Procedures Assignments------
---Assignment 1 - Insert Student Procedures-------
alter Procedure sp_InsertStudent
@FirstName varchar(50),
@LastName varchar(50),
@Gender char(1),
@DepartmentID int,
@AdmissionDate date
As
Begin
insert into students (first_name, last_name, gender, department_id,admission_date)
values (@FirstName, @LastName, @Gender, @DepartmentID, @AdmissionDate)
end

--delete from students where student_id = 122
exec sp_InsertStudent 'Sravanthi','lingalagari', 'F', 3, '2024-08-29';

select * from students

---Assignment 2 -Get Students By Department
create Procedure sp_GetStudentsByDepartment @DepartmentID int
As 
Begin

Select student_id, first_name, last_name , admission_date from students where department_id = @DepartmentID;
end

exec sp_GetStudentsByDepartment 2

exec sp_GetStudentsByDepartment 3 


---Assignment 3 - Course Enrollment Procedure
create procedure sp_EnrollStudent
@StudentID int,
@CourseID int
As
Begin

insert into enrollments (student_id , course_id, enrollment)
values (@StudentID, @CourseID, GETDATE());
End

exec sp_EnrollStudent 122, 1011

select * from enrollments


---Assignment 4 - Student Marks Procedure-------
create procedure sp_GetStudentMarks 
@StudentID int
As 
Begin

select CONCAT(s.first_name,' ', s.last_name) as StudentName, c.course_name, e.exam_type, m.marks_obtained from students s inner join marks m on s.student_id = m.student_id inner join exams e on m.exam_id = e.exam_id inner join courses c on e.course_id = c.course_id where s.student_id = @StudentID;

end

exec sp_GetStudentMarks 111

---Assignment 5 - Update Student Marks ------------
create procedure sp_UpdateMarks
@MarkID int,
@NewMarks int
As
Begin
update marks 
set marks_obtained = @NewMarks 
where marks_id = @MarkID
end

select * from marks
exec sp_UpdateMarks 511, 89


---Assignment 6 - Delete Enrollment
create procedure sp_DeleteEnrollment
@EnrollmentID int
As
Begin
delete enrollments where enrollment_id = @EnrollmentID
End

select * from enrollments

exec sp_DeleteEnrollment 10011

select * from enrollments

----3.User Defined Functions Assignments------
---Assignment 1 - Calculate Grade(Scalar Function)-------
create Function fn_GetGrade(@MarksObtained Int)
Returns Varchar(5)
As
Begin
Declare @Grade varchar(5)

if @MarksObtained >= 90 
set @Grade = 'A'
else if @MarksObtained >= 75
set @Grade = 'B'
else if @MarksObtained >= 60
set @Grade = 'C'
else 
set @Grade = 'Fail'

return @Grade

end 
go


select student_id, marks_obtained, dbo.fn_GetGrade(marks_obtained) As grade
 From marks;

 ---Assignment - 2 - Student Age Function------
 Create function fn_GetStudentAge(@DateOfBirth DATE) 
 returns int
 As
 Begin 
 Declare @Age int
 set @Age = DATEDIFF(year,@DateOfBirth,getDate());
 return @Age
 end 
 go 
 select * from students
 select student_id,dbo.fn_GetStudentAge(dateOfBirth) as Age 
 from students;

 --Assignment 3 - Total Marks Function-----
 Create function fn_GetTotalMarks(@StudentID int)
 returns int
 As
 Begin
 Declare @Total int

 select @Total = sum(marks_obtained) from marks where student_id = @StudentID;

 return @Total;
 end 
 go 

 select distinct student_id, dbo.fn_GetTotalMarks(student_id) as Total_marks from marks;

 ---Assignment 4 - Student Courses Function
 create function fn_GetStudentCourses(@StudentID int)
 returns table
 As
 Return 
 (
 select c.course_name, e.enrollment 
 from enrollments e inner join 
 courses c on e.course_id = c.course_id 
 where e.student_id = @StudentID
 );
 go

 select * from enrollments

 select * from dbo.fn_GetStudentCourses(105);

 ---Assignment 5 - Department Students Function 
 create function fn_GetDepartmentStudents(@DepartmentID int)
 returns table 
 as
 return (
 select student_id, first_name, last_name, admission_date from students where department_id = @DepartmentID);
 go

 --select * from dbo.fn_GetDepartmentStudents(departments.department_id);

 select d.department_id, s.student_id,s.first_name,
 s.last_name, s.admission_date from departments d 
 cross apply dbo.fn_GetDepartmentStudents(d.department_id) s;

 select * from dbo.fn_GetDepartmentStudents(1);