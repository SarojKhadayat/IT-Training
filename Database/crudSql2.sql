Create  Table tblStudent(
RecordId int primary key identity(1,1) not null,
Name nvarchar(50),
[Address] nvarchar(50),
PhoneNo nvarchar(10),
JoinedDate datetime,
DepartmentId int 
)


Create Table tblDepartment(
RecordId int primary key identity(1,1) not null,
Dep_Name nvarchar(50),
Dep_Head nvarchar(50),
Dep_Phone nvarchar(10)
)


Alter table TblDepartment
Add  HodId int 


create table tblHodDetails
(
RecordId int primary key identity(1,1) not null,
HodName nvarchar(50),
HodAddress nvarchar(50),
PhoneNo nvarchar(10)
)



Alter  table tblStudent Add constraint FK_Student_Department foreign key (DepartmentId) references
tblDepartment(RecordId)

Alter table tblDepartment Add constraint Fk_Department_Hod foreign key (hodId) references 
tblHodDetails(RecordId)
y

 select * from tblDepartment

 Insert into tblDepartment (Dep_Name,Dep_Head,Dep_Phone) values ('Electrical','Dev','123456789')
select * from tblDepartment

insert into tblStudent (Name,[Address],PhoneNo,JoinedDate,DepartmentId) 
values('test4','test','9867009002','2014-12-01',4)

insert into tblStudent (Name,[Address],PhoneNo,JoinedDate,DepartmentId) 
values('test','test','987654321','2016-05-03',4)



update Student set [Address]='Hetauda' where RecordId in 
(select RecordId from Student where [Address]='lalitpur')


select * from tblStudent as st 
inner join tblDepartment as td on st.DepartmentId=3
inner join tblHodDetails as dd on td.hodId=dd.RecordId
where dd.HodName='Rabindra'