--Since I created DB manually, uncomment below line to create DB via script
--CREATE DATABASE MechanicDB

CREATE TABLE mechanic
(
	mechanicId int primary key IDENTITY(1,1),	--Auto incrementing
	firstName NVARCHAR(25) NOT NULL,
	lastName NVARCHAR(25) NOT NULL,
	salary SMALLMONEY NOT NULL,
	contactNumber varchar(25) NOT NULL, --Catering for international long numbers
	email NVARCHAR(40) NOT NULL
);