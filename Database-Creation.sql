--Since I created DB manually, uncomment below line to create DB via script

--CREATE DATABASE MechanicDB



CREATE TABLE mechanic
(
	mechanicId INT PRIMARY KEY IDENTITY(1,1),	--Auto incrementing
	firstName NVARCHAR(25) NOT NULL,
	lastName NVARCHAR(25) NOT NULL,
	salary SMALLMONEY NOT NULL,
	contactNumber VARCHAR(25) NOT NULL, --Catering for international long numbers
	email NVARCHAR(40) NOT NULL,
);


CREATE TABLE [service]
(
	serviceId INT PRIMARY KEY IDENTITY(1,1),
	serviceName NVARCHAR(300) NOT NULL,
	mechanicId INT NOT NULL CONSTRAINT sr_mcId_fk FOREIGN KEY(mechanicId) REFERENCES mechanic(mechanicId)
);
--One mechanic could contain many services


CREATE TABLE customer
(
	customerId INT PRIMARY KEY IDENTITY(1,1),
	firstName NVARCHAR(25) NOT NULL,
	lastName NVARCHAR(25) NOT NULL,
	contactNumber VARCHAR(25) NOT NULL,
	email NVARCHAR(40) NOT NULL,
	[address] NVARCHAR(80) NOT NULL,
);

CREATE TABLE vehicle
(
	vehicleId INT PRIMARY KEY IDENTITY(1,1),
	brand NVARCHAR(30) NOT NULL,
	model NVARCHAR(30) NOT NULL,
	[year] DATE NOT NULL,
	plate NVARCHAR(30) NOT NULL,	--Also catering for international and custom number plates
	customerId INT NOT NULL CONSTRAINT vh_cId_fk FOREIGN KEY(customerId) REFERENCES customer(customerId)
);
--One customer could contain many vehicles


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
	customerId INT NOT NULL CONSTRAINT sr_csId_fk FOREIGN KEY(customerId) REFERENCES customer(customerId),
	mechanicId INT NOT NULL CONSTRAINT sr_mcId_fk FOREIGN KEY(mechanicId) REFERENCES mechanic(mechanicId)
);
--One service could contain many service records
--One customer could contain many service records
--One mechanic could contain many service records


--EXEC sp_rename 'service.serviceDescription' , 'serviceName' , 'COLUMN';
--Needed to alter column name in table service during construction of DB




--INSERTS For testing the database connection and values to backend
INSERT INTO [service] (serviceName) VALUES ('Routine Maintenance') , ('Diagnostic Services'),
										   ('Engine Repairs') , ('Transmission Services'),
										   ('Electrical System Repairs') , ('Tire Services'),
										   ('Exhaust System Repairs') , ('Routine Maintenance'); 

SELECT * FROM [service];


INSERT INTO mechanic (firstName , lastName , salary , contactNumber , email , serviceId	) VALUES ('John' , 'Stone' , '32000' , '+356 79340519' , 'johnStone@gmail.com' , 1)


