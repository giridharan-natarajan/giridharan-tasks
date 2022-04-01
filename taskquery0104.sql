use AdventureWorks2019
go
--task1
select FirstName,LastName
from Person.Person
where Title is not null
--task2
select FirstName,LastName
from Person.Person
where FirstName like '%a%' or LastName like '%a%'
--task7
select distinct GroupName
from HumanResources.Department
--task8
select pp.StandardCost
from Production.ProductCostHistory pc
join Production.Product pp
on pc.StandardCost=pp.StandardCost
select sum(listprice) sumoflistprice from Production.Product
--task11
select max(TaxRate) maximumtaxrate
from Sales.SalesTaxRate
--task12
select hdh.BusinessEntityID,dept.DepartmentID,ShiftID
from HumanResources.Employee He
join HumanResources.EmployeeDepartmentHistory hdh
on he.BusinessEntityID=hdh.BusinessEntityID
join HumanResources.Department dept
on dept.DepartmentID=hdh.DepartmentID
Select BirthDate,getdate() as CurrentDate, datediff(YY,BirthDate,getdate()) as age 
from HumanResources.Employee
--task13
go
create view ages
as
select  datediff(YY,BirthDate,getdate()) as age 
from HumanResources.Employee
select * from ages
--task14
SELECT count(*)
FROM [HumanResources].[Department],[HumanResources].[Employee],[HumanResources].[EmployeeDepartmentHistory],[HumanResources].[EmployeePayHistory],[HumanResources].[Shift]
--task16
select FirstName,MiddleName,Title,dhis.BusinessEntityID
from Person.BusinessEntityAddress dhis
left outer join Person.Person pp
on pp.BusinessEntityID=dhis.BusinessEntityID
where title is not null
--task18
select p1.LocationID,Shelf,Name
from Production.ProductInventory ppi
join Production.Location p1
on ppi.LocationID=p1.LocationID
--task6
select B.BusinessEntityID, Addresstypeid, H.DepartmentID
from HumanResources.Department H
join HumanResources.EmployeeDepartmentHistory E
on  H.DepartmentID = E.DepartmentID
join Person.BusinessEntityAddress B
on E.BusinessEntityID = B.BusinessEntityID
--task19
select AddressID,AddressLine1,AddressLine2, pa.StateProvinceID,StateProvinceCode,CountryRegionCode
from Person.StateProvince psp
join Person.Address pa
on psp.StateProvinceID=pa.StateProvinceID
--task20
select sum([SubTotal]) columnA,sum([TaxAmt]) columnb
from [Sales].[CountryRegionCurrency] crc
join [Sales].[SalesTerritory] st
on crc.[CountryRegionCode]=st.[CountryRegionCode]
join [Sales].[SalesOrderHeader] soh
on st.[TerritoryID]=soh.[TerritoryID]
group by st.[TerritoryID]
--task3
select salary.Name as [CurrencyCode],[Name]
from [Sales].[Currency] salary
join [Sales].[CountryRegionCurrency] salcrcy
on salary.[CurrencyCode]=salcrcy.[CurrencyCode]
create view vw_table
as
select [CurrencyCode],[Name]
from [Sales].[Currency]
go
select * from vw_table

--task4

--task5
create table task5
(
Sno int identity(1,1),
FName varchar(50),
LName varchar(50),
Gender char,
ModifiedDate date default getdate()
)
select * from task5
insert into task5(Fname,LName,Gender) 
values('giri','S','M')
insert into task5(Fname,LName,Gender) 
values('abdul','Z','M')
insert into task5(Fname,LName,Gender) 
values('haris','S','M')
insert into task5(Fname,LName,Gender) 
values('sidthegreat','I','M')
insert into task5(Fname,LName,Gender) 
values('jarvis','L','M')
insert into task5(Fname,LName,Gender) 
values('dilli','S','M')
insert into task5(Fname,LName,Gender) 
values('jony','O','M')
insert into task5(Fname,LName,Gender) 
values('anand','A','M')
insert into task5(Fname,LName,Gender) 
values('anand','F','M')
insert into task5(Fname,LName,Gender) 
values('yuwaraj','C','M')
insert into task5(Fname,LName,Gender) 
values('chiuaua','Q','M')
insert into task5(Fname,LName,Gender) 
values('ghafbc','I','M')
insert into task5(Fname,LName,Gender) 
values('hari','P','M')
insert into task5(Fname,LName,Gender) 
values('krish','Z','M')
insert into task5(Fname,LName,Gender) 
values('hjoy','O','M')
insert into task5(Fname,LName,Gender) 
values('jjroy','T','M')
insert into task5(Fname,LName,Gender) 
values('mac','F','M')
insert into task5(Fname,LName,Gender) 
values('steve','D','M')
insert into task5(Fname,LName,Gender) 
values('jobs','D','M')
insert into task5(Fname,LName,Gender) 
values('MUTHU','G','M')

--task17
select ProductID,LocationID,Shelf
from Production.ProductInventory
where ProductID>300 and ProductID<=350 and LocationID=50 
---
select ProductID,LocationID,Shelf
from Production.ProductInventory
where ProductID>300 and ProductID<=350 and Shelf='E'
--task9
select DATEDIFF (YY,StartDate,EndDate) as Yearsonage
from HumanResources.EmployeeDepartmentHistory

--task10
select sum(SalesQuota)
 from Sales.SalesPersonQuotaHistory
 where SalesQuota>5000 and salesquota<100000
 group by SalesQuota

 --task15
 select max(rate) as MaxSalary,Name
from HumanResources.EmployeePayHistory payee
join HumanResources.EmployeeDepartmentHistory dh
on payee.BusinessEntityID = dh.BusinessEntityID
join HumanResources.Department dept
on dept.DepartmentID = dh.DepartmentID
GRoup By name