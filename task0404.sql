use AdventureWorks2019
go


--task7
select FirstName,LastName
from Person.Person
select name
from Sales.SalesTerritory sst
join Sales.SalesPerson sp
on sp.TerritoryID=sst.TerritoryID
select max(SalesLastYear) as sales,Name
from Sales.SalesTerritory
group by Name
select *
from Sales.SalesPerson

--task2
go
create function fn_RupeesC(@amount as Nvarchar(50))
returns Nvarchar(50)
as 
begin
return (N'₹'+@amount)
end
select BusinessEntityID,dbo.fn_RupeesC(rate) as Dollar 
from HumanResources.EmployeePayHistory
--task1
select  COUNT(+[StandardCost]) Totalnoofrows
from [Production].[ProductCostHistory]
--USING SUM()
select SUM([StandardCost]) SumCost
from [Production].[ProductCostHistory]
--USING DATEDIFF()
select DATEDIFF(YY,StartDate,EndDate) datedifference
from [Production].[ProductCostHistory]
--USING ADDDATE()
SELECT DATEADD(year, 3, '2017/08/25') AS DateAdd
--USING CONVERT()
SELECT CONVERT(int,88.77);
--USING LEFT()
SELECT LEFT('giri', 3) AS ExtractString;
--USING LEN()
select LEN('HARI')
--USING REVERSE()
select REVERSE('giri Dharan')
--task6
select[Name]
from[Production].[Product]
where  name like '%all%'  or name like '%any%' or name like '%some%'

select max([Weight]) as Maxweight,[ProductModelID]
from  [Production].[Product]
GRoup By [ProductModelID]
--task5
select name, DaysToManufacture
from Production.Product 
where name = ('blade')(select b.Name,b.DaysToManufacture from Production.Product b
where b.DaysToManufacture like('1'))
--task3
create table tbl_student1
(
Sno int,
StuName varchar(20),
StuAge int
)
alter table tbl_student1
add Gender char(1)
select * from tbl_student1
alter table tbl_student1
add MobileNO int
insert into tbl_student1 values(1,'giri',19,'M',1234512345)
alter table tbl_student1
alter column MobileNO char(10)
create view taskthree
as
select [Sno],[StuName],[StuAge]
from [dbo].[tbl_student1]
go
select *from taskthree
insert into tbl_student1 values(2,'dharan',19,'M',6789106789)
--task4
select * from dbo.tbl_just

create proc taskIns_sp
@name varchar(50),
@gender char(1)
as
insert into tbl_just(name,gender)
values(@name,@gender)

taskIns_sp 'giri','N'
create proc taskup_sp
@sno int,
@age int,
@name varchar(50)
as
update tbl_just set sno=@sno,age=@age where name = @name

task1_sp 1,19,'giri'
create proc taskDel_sp
@sno int
as
delete from tbl_just where sno = @sno

taskDel_sp 1