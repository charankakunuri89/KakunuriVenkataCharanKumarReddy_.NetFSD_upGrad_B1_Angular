---1. Triggers Assignments
--Assignment 1 - Audit Trigger for students
--step 1 - create audit table
create table StudentAudit 
(
AuditID INT identity(1, 1) primary key,
StudentID INT,
ActionTYPE Varchar(50),
ActionDate DateTime,
);
--drop table StudentAudit
--step 2- create trigger 
create trigger trg_StudentInsertAudit
on students
After insert
as
begin 
insert into StudentAudit (StudentID, ActionTYPE, ActionDate)
	select student_id, 'insert', GETDATE() from inserted
end;
--delete from students where student_id in(128, 129, 130, 131);
select * from students
exec sp_help StudentAudit;

--Tasks
--1.insert a student
insert into students values ('Charan','Kakunuri','2002-04-02',
'M', 4, '2024-06-01')
--2.chcek audit table
select * from StudentAudit;
--3.insert multiple students
insert into students values ('Rahul','Sharma','2001-05-10', 
'M', 3, '2023-01-03'),
('Priya', 'Reddy', '2002-09-04', 'F',1, '2022-08-10'),
('Arjun', 'Goud', '2003-02-28', 'M', 5, '2020-12-11');


---Assignment 2 - Prevent Deleting Students
create trigger trg_PreventStudentDelete
on students
Instead of Delete
as
begin 
if exists (
select 1 from enrollments e join deleted d
on e.student_id = d.student_id
)
begin
raiserror ('student has course enrollments and cannot be deleted', 16, 1);
rollback transaction;
return;
end
delete from students
where student_id in (select student_id from deleted);
end;

--Tasks
--1.delete students with enrollments
delete from students where student_id = 103;
--2.delete students without enrollments
delete from students where student_id = 132;
select * from enrollments;
select * from students;

--Assignment 3 - Update Marks trigger
create table MarksAudit
(
AuditID int primary key identity(1,1),
StudentID int,
ExamID int,
OldMarks int,
NewMarks int,
UpdatedDate DateTime
);
exec sp_help MarksAudit

select * from marks

create trigger trg_UpdateMarksAudit
on marks
after update
as
begin
--select * from inserted
--select * from deleted
insert into MarksAudit(StudentID, ExamID, OldMarks, NewMarks, UpdatedDate)

select 
d.student_id,
d.exam_id,
d.marks_obtained,
i.marks_obtained,
GETDATE()

from deleted d 
join inserted i
on d.student_id = i.student_id
and d.exam_id = i.exam_id;
end

--Tasks
--1.update marks
update marks
set marks_obtained = 99
where student_id = 120
--2.verify audit table
select * from MarksAudit



-----2.Exception Handling Assignments
----Assignment 1 -Insert Student Procedure with Exception handling
select * from students

--create stored procedure
Create Procedure sp_AddStudent 
@FirstName varchar(50), 
@LastName varchar(50), 
@DepartmnetID int, 
@Gender char(1), 
@AdmissionDate dateTime

as 
begin
	begin try
		insert into students (first_name, last_name, department_id, gender, admission_date)
		values 
		(@FirstName, @LastName, @DepartmnetID, @Gender, @AdmissionDate);

		print 'student inserted successfully';
	end try
	begin catch
		print 'Error occured while inserting student';
		print error_message();
	end catch
end

--tasks
--1. Insert valid students
exec sp_AddStudent 'Vennala', 'Kishore', 4, 'M', '2020-08-13';
--2.insert invalid student using departmentid
exec sp_AddStudent 'Vennala', 'Kishore', 6, 'M', '2020-08-13';
 select * from students;


 ---Assignment 2 - Marks Validation Procedure
 --create stored procedure

 create procedure spInsertmarks
 @StudentID int,
 @ExamID int,
 @MarksObtained int

 as
 begin
 begin try
	if @MarksObtained < 0 or @MarksObtained > 100
	begin
		raiserror('invalid marks', 16, 1);
		return;
	end

	insert into marks (student_id, exam_id, marks_obtained)
	values (@StudentID, @ExamID, @MarksObtained);

	print 'Marks inserted successfully';
 end try
 begin catch
	print error_message();
 end catch
 end

 select * from exams
 select * from marks
 ---tasks
 ---1. insert valid marks
 exec spInsertmarks 113, 100002, 78
 ---2.insert marks greater than 100
 exec spInsertmarks 114, 100000, 101

 ----Assignment 3 - Safe Delete Procedure\
 --created stored procedure
 create procedure sp_DeleteStudent
 @StudentID int
 as
 begin
	begin try
		delete from students where student_id = @StudentID;
		print 'Successfully deleted student record';
	end try

	begin catch
		print 'Error deleting student';
		print error_message();
	end catch
end;

select * from students;

--tasks
--1.students having enrollments
exec sp_DeleteStudent 121;
--2.student without enrollments
exec sp_DeleteStudent 133;



----3. Cursor Assignments
---Assignment 1 - Display Student names
create procedure sp_DisplayStudentsCursor
as
begin
declare @StudentID int
declare @StudentName varchar(100)
declare sp_DisplayStudentsCursor cursor forward_only
for 
select student_id, concat(first_name, ' ', last_name) as studentName from students;

open sp_DisplayStudentsCursor

fetch next from sp_DisplayStudentsCursor
into @StudentID, @StudentName

while @@FETCH_STATUS = 0
begin
print 'Student_id:' + cast(@StudentID as varchar) + ' '+ @StudentName 
fetch next from sp_DisplayStudentsCursor
into @StudentID, @StudentName
end

close sp_DisplayStudentsCursor
deallocate sp_DisplayStudentsCursor;
end;

exec sp_DisplayStudentsCursor;

---Assignment 2 - Calculate Total Marks Per Student
create procedure sp_CalculateStudentTotalMarks
as 
begin
declare @StudentID int
declare @StudentName varchar(100)
declare @TotalMarks int

declare student_cursor cursor
for 
select student_id, concat(first_name, ' ' , last_name) from students;
open student_cursor

fetch next from student_cursor
into @StudentID, @StudentName

while @@FETCH_STATUS = 0
begin

select @TotalMarks = Sum(marks_obtained) from marks where student_id = @StudentID;

print 'Studentname: ' + @StudentName +
' Total marks: ' + cast(isnull(@TotalMarks, 0) as varchar)

fetch next from student_cursor
into @StudentID, @StudentName

end

close student_cursor
deallocate student_cursor

end;
exec sp_CalculateStudentTotalMarks;



---Assignment 3 -Update Course Credits
create procedure sp_UpdateCourseCredits 
as
begin

declare @CourseID int
declare @Credits int

declare course_cursor cursor
for 
select course_id, course_credits from courses where course_credits < 3;

open course_cursor

fetch next from course_cursor
into @CourseID, @Credits

while @@FETCH_STATUS = 0
begin
update courses 
set course_credits = @Credits + 1
where course_id = @CourseID;

fetch next from course_cursor
into @CourseID, @credits

end

close course_cursor
deallocate course_cursor

end;

exec sp_UpdateCourseCredits;

select * from courses;








-----4. Transactions Assignments--------
----Assignment 1- Student Enrollment Transaction
--create stored procedure
create procedure sp_EnrollStudentTransaction
@StudentID int,
@CourseID int
as
begin
begin try
begin transaction
insert into enrollments (student_id, course_id)
values (@StudentID, @CourseID)
commit transaction
print 'Student enrollment successfully';
end try

begin catch
rollback transaction

print 'Enrollment failed'
print error_message()
end catch

end;

--Tasks
--1.Enroll student in course
exec sp_EnrollStudentTransaction 104, 1011
select * from enrollments

--2. Test failure scenario
exec sp_EnrollStudentTransaction 999, 1;
select * from enrollments


------Assignment 2 - Exam Marks Transaction
--create stored procedure
create procedure sp_RecordExamMarks
@StudentID int,
@ExamID int,
@MarksObtained int
as
begin
begin try
begin transaction
insert into marks(student_id, exam_id,marks_obtained)
values (@StudentID, @ExamID, @MarksObtained);

update exams
set exam_date = GETDATE()
where exam_id = @ExamID;

commit transaction

print 'Exam marks recorded successfully';
end try

begin catch

rollback transaction

print 'Transaction Failed';
print error_message();

end catch

end

exec sp_RecordExamMarks 113, 100004, 85;

select * from marks;
select * from exams;


---Department Transfer Transaction
create procedure sp_TransferStudentDepartment
@StudentID int,
@Department int

as
begin
begin try
	begin transaction 

	if not exists (
	select 1 from departments
	where department_id = @Department
	)

	begin 
		raiserror('Department does not exist', 16, 1);
		rollback transaction;
		return;
	end

	update students 
	set department_id = @Department
	where student_id = @StudentID;

	commit transaction

	print 'Student department transferred successfully'
end try


begin catch
	rollback transaction

	print 'Transfer failed'
	print error_message()

end catch

end

exec sp_TransferStudentDepartment 120, 3;

select student_id, department_id from students where student_id = 120;

exec sp_TransferStudentDepartment 120, 999;