create database School

use School

create table Student
(
StudentId int primary key,
StudentName varchar(30),
Address varchar(100),
)

select * from Student

create table Class
(
Classid int primary key,
ClassName varchar(5)
)

create table subject
(
SubjectId int primary key,
SubjectName varchar(50),
classId int
)


alter table Student
add Classid int foreign key references Class(classid)

insert into Class values(1,'X A')
insert into Class values(2,'X B')
insert into Class values(3,'X E')
insert into Class values(4,'X C')
insert into Class values(5,'X D')

insert into subject values(111,'Sanskrit',100)
insert into subject values(222,'English',200)
insert into subject values(333,'maths',300)
insert into subject values(444,'science',400)
insert into subject values(555,'social',500)

insert into Student values(1,'Shravya','Pandeshwara, Sasthan',2)
insert into Student values(2,'Bhargavi','Poranki, Vijayawada',2),
(3,'Mayuri','Manya, Mandarthi',1),
(4,'Shailaja','Sasthana, Udupi',1),
(5,'Ramya','Manoor, Kota',3),
(6,'Prasad','Balebettu, Udupi',3),
(7,'Sheena','Saligrama, Kundapura',4),
(8,'Radha','Thekkatte, Kundapura',4),
(9,'Archana','Malleshwaram, bangalore',5),
(10,'Sharadhi','Basaweshwar Nagar, Bangalore',5)




select * from subject
Select * from Class
Select*  from Student