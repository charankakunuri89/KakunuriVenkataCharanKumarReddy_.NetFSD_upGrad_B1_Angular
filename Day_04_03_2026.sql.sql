create database assignment_database
use assignment_database

create table Worker (
worker_id int primary key identity(1,1),
first_name varchar(25),
last_name varchar(25),
salary int,
joining_date datetime,
department char(25)
);

create table Bonus (
worker_ref_id int,
bonus_amount int,
bonus_date datetime,
foreign key (worker_ref_id) references worker (worker_id)
on delete cascade
);

create table title (
worker_ref_id int,
worker_title char(25),
affected_from datetime,
foreign key (worker_ref_id) references worker(worker_id)
on delete cascade
);

insert into Worker 
(first_name, last_name, salary, joining_date, department) 
values 
('Monika', 'Arora', 100000, '2014-02-20 09:00:00','HR'),
('Niharika', 'Verma', 80000, '2014-06-11 09:00:00','Admin'),
('Vishal', 'Singhal', 300000, '2014-02-20 09:00:00','HR'),
('Amitabh', 'Singh', 500000, '2014-02-20 09:00:00','Admin'),
('Vivek', 'Bhati', 500000, '2014-06-11 09:00:00','Admin'),
('Vipul', 'Diwan', 200000, '2014-06-11 09:00:00','Account'),
('Satish', 'Kumar', 75000, '2014-01-20 09:00:00','Account'),
('Geetika', 'Chauhan', 90000, '2014-01-20 09:00:00','Admin');

select * from Worker

--drop table Bonus

--drop table title

--drop table Worker

insert into Bonus 
(worker_ref_id, bonus_date, bonus_amount )
values (1, '2016-02-20 00:00:00' , 5000),
(2, '2016-06-11 00:00:00', 3000),
(3, '2016-02-20 00:00:00', 4000),
(2, '2016-02-20 00:00:00', 4500),
(1, '2016-06-11 00:00:00', 3500);

select * from Bonus;

insert into title
(worker_ref_id, worker_title, affected_from)
values 
(1, 'Manager', '2016-02-20 00:00:00'),
(2, 'Executive', '2016-06-11 00:00:00'),
(8, 'Executive', '2016-06-11 00:00:00'),
(5, 'Manager', '2016-06-11 00:00:00'),
(4, 'Asst.Manager', '2016-06-11 00:00:00'),
(7, 'Executive', '2016-06-11 00:00:00'),
(6, 'Lead', '2016-06-11 00:00:00'),
(3, 'Lead', '2016-06-11 00:00:00');

select * from title;

-- (or)select first_name as WORKER_NAME from Worker; 
select first_name as 'WORKER_NAME' from Worker; 

select UPPER(first_name) from Worker;

select distinct department from worker;

select SUBSTRING(first_name,0, 4) from worker;

select CHARINDEX('b',first_name) from worker where first_name = 'Amitabh';

select RTRIM(first_name) from worker;

select LTRIM(department) from worker;

select distinct(department) from worker;

select REPLACE(first_name, 'a' , 'A') from worker;

select CONCAT(first_name,' ',last_name) as 'COMPLETE_NAME'  from worker;

select * from worker order by first_name;

select * from worker order by first_name asc ,department desc;

select * from worker where first_name in ('satish', 'vipul');

--select * from worker where first_name <> 'satish'and first_name <>  'vipul';

select * from worker where department = 'Admin';

select * from worker where first_name like '%a%';

select * from worker where first_name like '%a';

select * from worker where first_name like '%h' and len(first_name) = 6;

select * from worker where salary between 100000 and 500000;

select * from worker where joining_date >='2014-02-01' and joining_date < '2014-03-01';

select first_name, last_name, salary from worker where salary >= 50000 and salary <= 100000;

select department , count(*) from worker group by department order by department desc;

--select department , count(*) as workersCount from worker group by department order by workersCount desc;

select * from worker 

select * from title
select w.first_name, w.last_name, t.worker_title
from Worker w 
inner join title t 
	on t.worker_ref_id = w.worker_id 
where t.worker_title = 'Manager';

-- current date and time 
SELECT GETDATE() AS CurrentDateTime;

SELECT SYSDATETIME() AS CurrentDateTime;

--select top(5)* from worker order by salary desc;
select top(3)* from worker;