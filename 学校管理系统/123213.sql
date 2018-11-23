use master
go
create database Depts
go
create table Dept
(
  DeptId int primary key identity(1,1),
  DeptName nvarchar(20)

)
go
create table EMP
(
 EmpNo int primary key identity(1001,1),
 eName  nvarchar(20),
 Salary money,
 deptId int foreign key references Dept(DeptId),
 Mgr  int
)
go
insert into Dept
values('���²�'),
values('���²�'),
values('�г���'),

Select emp.Name,dept.Name,emp.Salary From emp
Join dept On emp.deptno=dept..deptno
Join (Select deptno,Avg(Salary) as AvgSalary From emp
           Group By deptno) As Temp
On emp.deptno=Temp.deptno
And emp.Salary>Temp.AvgSalary
