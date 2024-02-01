--Since I created DB manually, uncomment below line to create DB via script
--CREATE DATABASE MechanicDB


CREATE TABLE customer
(
	customerId INT PRIMARY KEY IDENTITY(1,1),
	firstName NVARCHAR(25) NOT NULL,
	lastName NVARCHAR(25) NOT NULL,
	contactNumber VARCHAR(25) NOT NULL,
	email NVARCHAR(40) NOT NULL,
	address NVARCHAR(80) NOT NULL,
	mechanicId INT NOT NULL CONSTRAINT cs_mId_fk REFERENCES mechanic(mechanicId)
);


CREATE TABLE mechanic
(
	mechanicId INT PRIMARY KEY IDENTITY(1,1),	--Auto incrementing
	firstName NVARCHAR(25) NOT NULL,
	lastName NVARCHAR(25) NOT NULL,
	salary SMALLMONEY NOT NULL,
	contactNumber VARCHAR(25) NOT NULL, --Catering for international long numbers
	email NVARCHAR(40) NOT NULL
);
--One customer can have one mechanic

CREATE TABLE [service]
(
	serviceId INT PRIMARY KEY IDENTITY(1,1),
	serviceDate DATE NOT NULL,
	[description] NVARCHAR(300),	--Descriptions are not always needed
	[status] BIT NOT NULL,	--Takes 1 if the car is serviced and requires no further intervention, takes -1 if car is required/expected to come back to be serviced.
	mechanicId INT NOT NULL CONSTRAINT se_mId_fk REFERENCES mechanic(mechanicId)
);
--One mechanic can perform one service





