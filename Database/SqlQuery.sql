--use SchoolManagementSystem

--Create Table
Create table Student(
RecordId int identity(1,1) primary key not null,
Name nvarchar(50) not null,
[Address] nvarchar(100) not null,
PhoneNo nvarchar(10) null,
JoinedDate datetime null,
RelatedDepartment int not null 
)

--drop table Student

Create table Department(
RecordId int identity(1,1) primary key not null,
Name nvarchar(50),
HODName nvarchar(100)
)

alter table Student
Add constraint Fk_Student_Department Foreign key(RelatedDepartment)
references Department(RecordId)


Insert into Department(Name,HODName) values ('Civil','Saroj')

select *  from Department where Name='Civil'

insert into Student (Name,[Address],PhoneNo,RelatedDepartment,JoinedDate) values
('sudip','nepalgunj','987689902',3,GETDATE())

select * from Student where Name='sudip'

