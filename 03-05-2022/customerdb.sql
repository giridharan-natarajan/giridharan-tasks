create table Customer(
CustomerID int,
CustomerName varchar(20),
EmailId varchar(20),
MobileNo varchar(20),
Constraint PK_CustId Primary key (CustomerID)
)
create proc GetAllCustomers
as
select CustomerID,CustomerName,EmailId,MobileNo 
from dbo.Customer
exec GetAllCustomers
 drop procedure NewCustomer
 create proc NewCustomer
 @Id int,
 @cname Varchar(20),
 @email varchar(35),
 @mob varchar(10)
 as
 insert into Customer(CustomerID,CustomerName,EmailId,MobileNo)
 values(@Id,@cname,@email,@mob)
 exec NewCustomer 6,'Diijbhj','bhjvhfnj','1234512345'
 select * from [dbo].[Customer]