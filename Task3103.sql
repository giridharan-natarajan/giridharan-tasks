use task
go
create table Registrationform
(
SNo int identity(1,1),
firstName varchar(20),
Lastname varchar(20),
age int constraint chk_age check(age >22),
dob varchar(20),
gender char(1) constraint ck_gen check (gender in ('M','F')),
Collegename char(25),
streetname varchar(35),
locality varchar(20),
pincode int,
District char(10),
Country char(10),
Phonenumber int,
backlogs varchar(1) constraint ck_backlogs check (backlogs < 3),
Sslcmark int,
hscmark int,
Collegecgpa int,
RegDate date default getdate()
)
insert Registrationform values ('Giri','dharan','23','22061999','M','CIT','ABCDEF','JHIGK','123456','CEHNNAI','INDIA','1234567890','2','89','76','72',getdate())
insert Registrationform values ('john','ricky','23','22061999','M','CIT','ABCDEF','JHIGK','123456','CEHNNAI','INDIA','1234567890','2','89','76','72',getdate())
insert Registrationform values ('sid','thala','24','22061999','M','CIT','ABCDEF','JHIGK','123456','CEHNNAI','INDIA','1234567890','2','89','76','72',getdate())
insert Registrationform values ('aanand','kumar','24','22061999','M','CIT','ABCDEF','JHIGK','123456','CEHNNAI','INDIA','1234567890','2','89','76','72',getdate())
select* from Registrationform