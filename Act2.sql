create database edp;
use edp;
select abs(10);
select mod(15,3) as remainder;
select sqrt(144);
select greatest(1, 2, 3, 4, 5);
select least(1, 2, 3, 4, 5);
select truncate(22.12345, 2);
select round(22.897, 1);

# tables

create table students
(stu_id int primary key,
stu_name varchar(25),
age int, gender char(1), doa date, city varchar(20));

# insert

insert into students values
(01, "Menchie", 20, "f", "2020-06-01", "Tabaco");

select * from students; 
select stu_name, age, city from students;
select * from students where city = 'Tabaco';
select * from students where age > 18 and gender = 'f';
# select * from students where age > 18 or gender = 'f';

# groupby
select city, count(stu_id) as total_students
from students group by city;

select city, count(stu_id) as total_students
from students group by city
having count(stu_id) > 0;

select * from students order by city desc;

# string functions

 



