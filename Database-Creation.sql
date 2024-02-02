--Since I created DB manually, uncomment below line to create DB via script

--CREATE DATABASE MechanicDB


CREATE TABLE [service]
(
	serviceId INT PRIMARY KEY IDENTITY(1,1),
	serviceDescription NVARCHAR(300) NOT NULL,
);

CREATE TABLE serviceRecord
(
	recordId INT PRIMARY KEY IDENTITY(1,1),
	serviceDate DATE NOT NULL,
	[description] NVARCHAR(300),	--Descriptions are not always needed
	[status] BIT NOT NULL,	--Takes 1 if the car is serviced and requires no further intervention, takes -1 if car is required/expected to come back to be serviced.
	laborHours SMALLINT NOT NULL,
	partsUsed NVARCHAR(300) NOT NULL,
	totalCost SMALLMONEY NOT NULL,
	serviceId INT NOT NULL CONSTRAINT sr_sId_fk FOREIGN KEY(serviceId) REFERENCES [service](serviceId),
	vehicleID INT NOT NULL CONSTRAINT sr_vId_fk FOREIGN KEY(vehicleId) REFERENCES vehicle(vehicleId)
);
--One service record could contain many services
--One record could contain many vehicles

CREATE TABLE mechanic
(
	mechanicId INT PRIMARY KEY IDENTITY(1,1),	--Auto incrementing
	firstName NVARCHAR(25) NOT NULL,
	lastName NVARCHAR(25) NOT NULL,
	salary SMALLMONEY NOT NULL,
	contactNumber VARCHAR(25) NOT NULL, --Catering for international long numbers
	email NVARCHAR(40) NOT NULL,
	serviceId INT NOT NULL CONSTRAINT mh_sId_fk FOREIGN KEY(serviceId) REFERENCES [service](serviceId),
	recordId INT NOT NULL CONSTRAINT mh_srId_fk FOREIGN KEY(recordId) REFERENCES serviceRecord(recordId)
);
--One mechanic could contain many services
--One mechanic could contain many service records

CREATE TABLE customer
(
	customerId INT PRIMARY KEY IDENTITY(1,1),
	firstName NVARCHAR(25) NOT NULL,
	lastName NVARCHAR(25) NOT NULL,
	contactNumber VARCHAR(25) NOT NULL,
	email NVARCHAR(40) NOT NULL,
	[address] NVARCHAR(80) NOT NULL,
	mechanicId INT NOT NULL CONSTRAINT cu_mId_fk FOREIGN KEY(mechanicId) REFERENCES mechanic(mechanicId),
	recordId INT NOT NULL CONSTRAINT ct_srId_fk FOREIGN KEY(recordId) REFERENCES serviceRecord(recordId)
);
--One customer could contain many mechanics
--One customer could contain many serviceRecords

CREATE TABLE vehicle
(
	vehicleId INT PRIMARY KEY IDENTITY(1,1),
	brand NVARCHAR(30) NOT NULL,
	model NVARCHAR(30) NOT NULL,
	[year] DATE NOT NULL,
	plate NVARCHAR(30) NOT NULL,	--Also catering for international and custom number plates
	customerId INT NOT NULL CONSTRAINT vh_cId_fk FOREIGN KEY(customerId) REFERENCES customer(customerId),
);
--One customer could contain many vehicles




select * from vehicle

select * from service

select * from serviceRecord

select * from customer

select * from mechanic