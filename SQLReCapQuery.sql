CREATE TABLE Brands(

BrandId INT PRIMARY KEY IDENTITY(1,1),
BrandName NVARCHAR(25) NOT NULL
)

CREATE TABLE Colors(
ColorId INT PRIMARY KEY IDENTITY(1,1),
ColorName NVARCHAR(25) NOT NULL
)

CREATE TABLE Cars(
CarId INT PRIMARY KEY IDENTITY(1,1),
BrandId INT,
ColorId INT,
ModelYear INT,
DailyPrice DECIMAL,
[Description] NVARCHAR(200),
FOREIGN KEY (BrandId) REFERENCES Brands(BrandId),
FOREIGN KEY (ColorId) REFERENCES Colors(ColorId)
)

CREATE TABLE Users(
Id INT PRIMARY KEY IDENTITY(1,1),
FirstName NVARCHAR(50) NOT NULL,
LastName NVARCHAR(50) NOT NULL,
Email NVARCHAR(100) NOT NULL,
PasswordHash VARBINARY(500) NOT NULL,
PasswordSalt VARBINARY(500) NOT NULL,
[Status] BIT NOT NULL,
)

CREATE TABLE Customers(
CustomerId INT PRIMARY KEY IDENTITY(1,1),
Id INT NOT NULL,
CompanyName NVARCHAR(100) NOT NULL,
FOREIGN KEY (Id) REFERENCES Users(Id),
)

CREATE TABLE Rentals(
RentalId INT PRIMARY KEY IDENTITY(1,1),
CarId INT NOT NULL,
CustomerId INT NOT NULL,
RentDate DATETIME NOT NULL,
ReturnDate DATETIME,
FOREIGN KEY (CarId) REFERENCES Cars(CarId),
)

CREATE TABLE CarImages(
CarImageId INT PRIMARY KEY IDENTITY(1,1),
CarId INT NOT NULL,
ImagePath NVARCHAR(250),
DateCreated DATE,
FOREIGN KEY (CarId) REFERENCES Cars(CarId),
)

CREATE TABLE OperationClaims(
Id INT PRIMARY KEY IDENTITY(1,1),
Name VARCHAR(250) NOT NULL,
)

CREATE TABLE UserOperationClaims(
Id INT PRIMARY KEY IDENTITY(1,1),
UserId INT NOT NULL,
OperationClaimId INT NOT NULL,
FOREIGN KEY (UserId) REFERENCES Users(Id),
FOREIGN KEY (OperationClaimId) REFERENCES OperationClaims(Id),
)

---------------------------------------------------------------------------------------------

INSERT INTO [Brands] (BrandName)
VALUES

	('Audi A3'),
	('Lamborghini Aventador'),
	('Audi R8'),
	('BMW X6'),
	('BMW M4'),
	('Kia Stinger'),
	('Volvo XC60'),
	('Land Rover Defender'),
	('Ferrari Roma'),
	('Bugatti Chiron');


INSERT INTO [Colors] (ColorName)
VALUES

	('Green'),
	('Sand'),
	('Pearl'),
	('Orange'),
	('Purple'),
	('Red'),
	('Bronze'),
	('Pink'),
	('Beige'),
	('Silver');


INSERT INTO [Cars] (BrandId, ColorId, ModelYear, DailyPrice, [Description])
VALUES

	('1022', '1016', '2015', '800', 'Automatic'),
	('1023', '1015', '2019', '5000', 'Manual'),
	('1024', '1021', '2018', '2800', 'Manual'),
	('1025', '1018', '2020', '3000', 'Automatic'),
	('1026', '1012', '2017', '3200', 'Automatic'),
	('1027', '1014', '2019', '3600', 'Manual'),
	('1028', '1020', '2018', '1400', 'Automatic'),
	('1029', '1013', '2020', '4200', 'Manual'),
	('1030', '1017', '2019', '6800', 'Manual'),
	('1031', '1019', '2018', '7000', 'Manual');
	

INSERT INTO [Users] (FirstName, LastName, Email, PasswordHash, PasswordSalt, [Status])
VALUES

	('Olivia', 'Jay', 'o.jay@trees.com', 00100110, 01001101, 1 ),
	('Thomas', 'Rose', 't.rose@yard.com', 10011100, 00010010, 1),
	('Lenny', 'Orange', 'lennor@breeze.com', 00010110, 10101111, 1),
	('Gillian', 'River', 'gillriver@blue.com', 10101011, 00011001, 1),
	('Amber', 'Dust', 'a.dust@square.com', 00100001, 01010011, 1);


INSERT INTO [Customers] (Id, CompanyName)
VALUES

	(1, 'Trees'),
	(2, 'Rose'),
	(3,'Breeze'),
	(4, 'Blue'),
	(5, 'Square');

INSERT INTO [Rentals] (CarId, CustomerId, RentDate, ReturnDate)
VALUES

	(1, 1, CAST('01-20-2021 02:40:00' AS DATETIME), CAST('01-20-2021 09:30:00' AS DATETIME)),
	(2, 2, CAST('02-19-2021 09:30:00' AS DATETIME), CAST('02-28-2021 02:00:00' AS DATETIME)),
	(3, 3, CAST('03-02-2021 06:00:00' AS DATETIME), NULL),
	(4, 4, CAST('03-08-2021 08:00:00' AS DATETIME), NULL),
	(5, 5, CAST('03-15-2021 10:40:00' AS DATETIME), NULL);


	

INSERT INTO [CarImages] (CarId, ImagePath, DateCreated)
VALUES

	('1', '915f6bf2-6bd8-4272-8f23-8b3a62759f38', CAST('2020-02-19' AS DATE)),
	('2', '9f00bcc0-c77e-4387-91db-a17008559533', CAST('2020-08-16' AS DATE)),	
	('3', '538a4df3-6a50-4e11-9b25-a31448d8870d', CAST('2020-02-19' AS DATE)),
	('4', '0dd8019a-7a66-4807-8ca1-d61c22cb87a0', CAST('2020-08-16' AS DATE)),
	('5', 'e73b3d43-d89b-42c2-b19b-42851ffac1a9', CAST('2020-08-16' AS DATE)),
	('6', '8de2a954-f174-452b-b6ca-82fde1ea62f8', CAST('2020-02-19' AS DATE)),
	('7', 'b7c2252e-2444-4d68-bc6d-115b344d722e', CAST('2020-08-16' AS DATE)),
	('8', '5d8312ad-4a14-4af4-8b7a-73639be1ae18', CAST('2020-02-19' AS DATE)),
	('9', 'fef628a1-9f04-49b4-badf-5464983cdab6', CAST('2020-02-19' AS DATE)),
	('10', '82e733e6-ecad-4ac8-a252-21976083e5fd', CAST('2020-08-16' AS DATE));
	



