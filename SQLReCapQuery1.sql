CREATE TABLE [dbo].[Cars]
(
	[Id] INT NOT NULL PRIMARY KEY, 
	[BrandId] INT NOT NULL, 
	[ColorId] INT NOT NULL,
	[ModelYear] INT NOT NULL, 
	[DailyPrice] DECIMAL NOT NULL, 
	[Description] NVARCHAR(50) NOT NULL, 
	FOREIGN KEY (ColorId) REFERENCES [Colors](ColorId), 
	FOREIGN KEY (BrandId) REFERENCES [Brands](BrandId)
)


CREATE TABLE [dbo].[Brands]
(
	[BrandId] INT NOT NULL PRIMARY KEY, 
	[BrandName] NCHAR(10) NOT NULL
)

CREATE TABLE [dbo].[Colors]
(
	[ColorId] INT NOT NULL PRIMARY KEY, 
	[ColorName] NCHAR(10) NOT NULL
)



INSERT INTO [Cars] (Id, BrandId, ColorId, ModelYear, DailyPrice, Description)
VALUES

	 ('1', '1', '2', '2021', '120', 'Coupe, 5.2L V10 Gas'),
	 ('2', '2', '1', '2019', '180', 'SUV, Turbocharged'),
	 ('3', '3', '3', '2020', '220', 'Sedan, All wheel drive'),
	 ('4', '3', '2', '2017', '200', 'SUV, Twin turbocharged'),
	 ('5', '1', '1', '2018', '170', 'Sedan, S Tronic');


INSERT INTO [Brands] (BrandId, BrandName)
VALUES

	('1', 'Audi'),
	('2', 'BMW'),
	('3', 'Mercedes');	

INSERT INTO [Colors] (ColorId, ColorName)
VALUES

	('1', 'Green'),
	('2', 'Sand'),
	('3', 'Pearl');

SELECT * FROM [Cars];