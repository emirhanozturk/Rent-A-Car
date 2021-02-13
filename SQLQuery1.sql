CREATE TABLE Cars(
	CarId INT PRIMARY KEY IDENTITY(1,1),
	BrandId int,
	ColorId int,
	ModelYear int,
	DailyPrice decimal,
	Descriptions varchar(50)
);

CREATE TABLE Colors(
	
	ColorId INT PRIMARY KEY IDENTITY(1,1),
	ColorName varchar(50)
);

CREATE TABLE Brands(
	BrandId INT PRIMARY KEY IDENTITY(1,1),
	BrandName varchar(50)
);

INSERT INTO Cars(BrandID,ColorID,ModelYear,DailyPrice,Descriptions)
VALUES
	('1','2','2012','100','Manuel Benzin'),
	('1','3','2015','150','Otomatik Dizel'),
	('2','1','2017','200','Otomatik Hybrid'),
	('3','3','2014','125','Manuel Dizel');