create database store
use store
--drop table orders;
--drop table customers;
---------------------------------------------Level-1--------------------------------------------
---------------------------------------------Problem 1------------------------------------------
create table customers (
customer_id int primary key identity (1, 1),
first_name varchar(20) ,
last_name varchar(15),
email varchar(20) unique not null,
phone decimal(10) check (len(phone) =10)
);

create table orders (
order_id int primary key identity (100, 1),
customer_id int ,
order_date date,
order_status varchar(20) check( order_status in ('pending', 'completed')),
FOREIGN KEY (customer_id) references customers(customer_id)
);

select * from customers
select * from orders 


insert into customers (first_name, last_name, email, phone) 
values ('charan', 'kumar', 'charan89@gmail.com' , 8519865290),
('aditya','vardhan', 'aditya123@gmail.com', 9949641820),
('ganesh', 'reddy','ganesh143@gmail.com', 8519849036),
('sumanth', 'pujari', 'sumanth456@gmail.com', 9876543120)


insert into orders(customer_id, order_date, order_status)
values (2, '2026-12-01', 'completed'),
(1, '2026-11-19', 'pending'),
(4, '2025-12-07', 'completed'),
(2, '2024-11-20', 'pending'),
(3, '2026-01-01', 'completed')

--combination of all
select c.first_name, c.last_name , o.order_id, o.order_date, o.order_status from customers c inner join orders o on c.customer_id = o.customer_id where o.order_status in ('pending', 'completed') order by order_date desc;
--1. 
select c.first_name, c.last_name , o.order_id, o.order_date, o.order_status from customers c inner join orders o on c.customer_id = o.customer_id;

--2. 
select * from orders where order_status in ('completed');
select * from orders where order_status in ('pending');

--3. 
select * from orders order by order_date desc;


---------------------------------------------Problem 2------------------------------------------

--drop table products;
create table categories (
category_id int primary key identity (1,1),
category_name varchar(40) not null
);

create table brands (
brand_id int primary key identity (1,1),
brand_name varchar(50) not null
);

create table products (
product_id int primary key identity(1, 1),
product_name varchar(20) not null,
brand_id int ,
category_id int,
model_year int,
list_price decimal(10,2),
FOREIGN KEY (brand_id) references brands(brand_id),
FOREIGN KEY (category_id) references categories(category_id)
);

select * from categories

insert into categories 
(category_name) values ('commercial'),
('special'),('daily-use')

select * from brands 

insert into brands 
(brand_name) values ('johnson baby'),
('nike'),('us-polo'),('nvidia')

select * from products 

insert into products 
(product_name, brand_id, category_id, model_year,list_price) 
values ('shoes', 2, 3, 2018, 1994.25),
('shirt', 3, 3, 2016, 996.25),
('graphic-card', 4, 2, 2014, 9999.56)

update products set product_name = 'soaps' , brand_id = 1, category_id = 1, list_price = 234 where product_id = 4
update products set product_name = 'pants' , brand_id = 1, category_id = 1, list_price = 678 where product_id = 3

--1. 
select p.product_name,b.brand_name,c.category_name,p.model_year,p.list_price from products p inner join brands b on p.brand_id = b.brand_id inner join categories c on  p.category_id = c.category_id;

--2. 
select * from products where list_price > 500;

--3. 
select * from products order by list_price

--combination of all
select p.product_name,b.brand_name,c.category_name,p.model_year,p.list_price from products p inner join brands b on p.brand_id = b.brand_id inner join categories c on  p.category_id = c.category_id where list_price > 500 order by list_price;


----------------------------------Level-2--------------------------------------------------
----------------------------------Problem 1------------------------------------------------
--stores table creation
create table stores 
(store_id int primary key identity(1000, 1),
store_name varchar(25),
phone decimal(10) check(len(phone) = 10),
email varchar(45) unique not null,
street varchar(15) ,
city varchar(15),
state varchar(15),
zip_code varchar(10)
);

-- checking the stores table
select * from stores

-- orderings table creation
create table orderings (
order_id int primary key identity(100, 1),
customer_id int,
order_status varchar(10) check (order_status in ('completed', 'not delivered' )),
order_date date,
required_date date,
shipped_date date,
store_id int,
staff_id int,

FOREIGN KEY (customer_id) references customers (customer_id),
FOREIGN KEY (store_id) references stores (store_id)
);

-- check the orderings table
select * from orderings;

--alter the order_status length
alter table orderings 
alter column order_status varchar(20);

--creation of order_items
create table order_items (
order_id int,
item_id int,
product_id int,
quantity int,
list_price int,
discount decimal (2, 1)
FOREIGN KEY (order_id) references orderings(order_id),
FOREIGN KEY (product_id) references products(product_id)
);

--check the order_items
select * from order_items;
--check the products
select * from products

-- creation of stock table
create table stock (
store_id int,
product_id int,
quantity int,
FOREIGN KEY (store_id) references stores (store_id),
FOREIGN KEY (product_id) references products (product_id)
);

-- checking of stock table
select * from stock

--insertions start here 

--before insertion of stores
select * from stores 
-- insert stores data
insert into stores (store_name, phone, email, street, city, state, zip_code)
values ('kakunuris', 8519865290, 'charankakunuri89@gmail.com', 'sivalayam', 'Mundlapadu', 'Andhra pradesh', 523367),
('Vittapus', 9949641820, 'adityavittapu123@gmail.com', 'Brahmin Bazar', 'Giddalur','Karnataka', 523357),
('Nandyalas', 8519849036, 'ganeshnandyala162@gmail.com', 'Main Road', 'Nandyala', 'Telangana', 143289)
--after insertion of stores
select * from stores 

--before insertion of orderings
select * from orderings
--insert orderings data
insert into orderings (customer_id, order_status, order_date, required_date, shipped_date,store_id, staff_id)
values (3, 'not delivered','2025-11-04', '2025-11-06', '2025-11-05', 1003, 16),
(4, 'completed', '2026-01-01', '2026-01-02', '2026-01-06', 1002, 22),
(1, 'completed', '2026-02-28', '2026-03-01', '2026-03-05', 1001, 143)
--after insertion of orderings
select * from orderings

--before insertion of order_items
select * from order_items
--insert order_items data
insert into order_items (order_id, item_id, product_id, quantity,list_price,discount)
values (106, 23, 1, 2, 188.4, 7),
(105, 24, 3, 1, 999.45, 2),
(107, 43, 5, 2, 99999.56,2)
--after insertion of order_items
select * from order_items

--before insertion of stock
select * from stock
--insert stock data
insert into stock (store_id, product_id, quantity)
values (1001, 5, 3),
(1003, 3, 2),
(1002, 2, 5)
--after insertion of stock
select * from stock

--operations start here 

select s.store_name , 
sum(oi.quantity * oi.list_price * (1 - (oi.discount * 0.1))) 
as total_sales from stores s 
inner join orderings o 
on s.store_id = o.store_id 
inner join order_items oi 
on o.order_id = oi.order_id 
where o.order_status = 'completed'
group by s.store_name
order by total_sales desc;

-------------------------------------Problem 2-----------------------------------
select 
p.product_name, 
s.store_name,
st.quantity as stock_quantity,
SUM(oi.quantity) as total_quantity_sold 
from stock st
inner join products p  
on st.product_id = p.product_id
inner join stores s 
on st.store_id = s.store_id 
left join order_items oi 
on st.product_id = oi.product_id 
group by p.product_name,s.store_name, st.quantity
order by product_name;