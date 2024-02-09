Create database LaptopsDb
use LaptopsDb

Create Table GamingLaptop(
	Id int Primary Key,
	Name Nvarchar(50),
	Description Nvarchar(MAX),
	Price Float 
	)
Create Table StudentLaptop(
	Id int Primary Key,
	Name Nvarchar(50),
	Description Nvarchar(MAX),
	Price Float 
	)
Create Table ThinLightLaptop(
	Id int primary key,
	Name Nvarchar(50),
	Description Nvarchar(MAX),
	Price Float 
	)
	select * from StudentLaptop