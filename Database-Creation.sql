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
	[status] BIT NOT NULL,	--Takes 1 if the car is serviced and requires no further intervention, takes 0 if car is required/expected to come back to be serviced.
	laborHours SMALLINT NOT NULL,
	partsUsed NVARCHAR(300) NOT NULL,
	totalCost SMALLMONEY NOT NULL,
	serviceId INT NOT NULL CONSTRAINT sr_sId_fk FOREIGN KEY(serviceId) REFERENCES [service](serviceId),
	customerId INT NOT NULL CONSTRAINT sr_csId_fk FOREIGN KEY(customerId) REFERENCES customer(customerId),
	mechanicId INT NOT NULL CONSTRAINT sr_mchId_fk FOREIGN KEY(mechanicId) REFERENCES mechanic(mechanicId)
);
--One service could contain many service records
--One customer could contain many service records
--One mechanic could contain many service records


--EXEC sp_rename 'service.serviceDescription' , 'serviceName' , 'COLUMN';
--Needed to alter column name in table service during construction of tables




--INSERTS For testing the database connection and values to backend
INSERT INTO mechanic (firstName , lastName , salary , contactNumber , email) VALUES ('John' , 'Stone' , '32000' , '+356 79340519' , 'johnStone@gmail.com'); --Always test Insert first

INSERT INTO mechanic (firstName , lastName , salary , contactNumber , email) VALUES ('Isaac' , 'Micallef' , '27000' , '+356 99019267' , 'MicallefI21@gmail.com'),
																					('Mark' , 'Farrugia' , '46000' , '+356 79129943' , 'FarrugiaMark@gmail.com'),
																					('Matthew' , 'Attard' , '21000' , '+356 79008246' , 'MatthewAttard@gmail.com');


SELECT * FROM mechanic;



INSERT INTO [service] (serviceName , mechanicId) VALUES ('Routine Maintenance' , 4);

INSERT INTO [service] (serviceName , mechanicId) VALUES ('Engine Repairs' , 3),
														('Transmission Services' , 2),
														('Tire Services' , 4),
														('Diagnostic Services' , 1),
														('Electrical System Reparis' , 1),
														('Exhaust System Repairs' , 2),
														('Diagnostic Services' , 3);


SELECT * FROM [service];

INSERT INTO customer (firstName , lastName , contactNumber , email , [address]) VALUES ('Laura' , 'Brincat' , '+356 79210567' , 'LB@gmail.com' , 'Zebbug, Triq il-Mithna, Ta filep');

INSERT INTO customer (firstName , lastName , contactNumber , email , [address]) VALUES ('Jeffrey' , 'Vella' , '+356 79002785' , 'VellaJeffrey@gmail.com' , 'Qormi, Side Street, SweetCorn'),
																					   ('Brian' , 'Montebello' , '+356 99827466' , 'MontebelloB@hotMail.com' , 'Mosta, Triq Dun Karm, Wallflower flat 3'),
																					   ('Adrian' , 'Attard' , '+356 79026758' , 'AttardADrian@gmail.com' , 'Zebbug , Triq ta taht, Pupil 5'),
																					   ('Enya' , 'Mali' , '+977 18958270' , 'EnyaMali@gmail.com' , 'Sliema , Honda Street , L-Ahrax flat 12'),
																					   ('Mathias' , 'Abela' , '+356 79028512' , 'AbelaMathis@gmail.com' , 'Qormi , Triq De Rohan , Nahal 6'),
																					   ('Neil' , 'Azzoppardi' , '+356 99894672' , 'AzzoppardiNeil@gmail.com' , 'Mellieha, End Street , Melh 2');




SELECT * FROM customer;


INSERT INTO vehicle (brand , model , [year] , plate , customerId) VALUES ('Toyota' , 'camry' , '2024' , 'ALK 938' , 1);

INSERT INTO vehicle (brand , model , [year] , plate , customerId) VALUES ('Toyota' , 'corolla' , '2011' , 'JDI 839' , 2),
																		 ('Hyundai' , 'Getz' , '2008' , 'LCN 698' , 3),
																		 ('Nissan' , 'March' , '2014' , 'HAJ 152' , 4),
																		 ('Volvo' , 'V90 cross country' , '2019' , 'Greedy' , 5),
																		 ('Citroen' , 'Berlingo' , '2014' , 'AHN 291' , 5),
																		 ('Hyundai' , 'Getz' , '2011' , 'HNV 920' , 6),
																		 ('Mazda' , 'Demio' , '2022' , 'DA 466RO' , 7);


SELECT * FROM vehicle;


select * from service;
select * from customer;

INSERT INTO serviceRecord (serviceDate , [description] , [status] , laborHours , partsUsed , totalCost , serviceId , customerId , mechanicId) VALUES
						  ('2023-09-12' , '' , 1 , 3 , 'No parts used' , 70 , 1 , 1 , 4);

INSERT INTO serviceRecord (serviceDate , [description] , [status] , laborHours , partsUsed , totalCost , serviceId , customerId , mechanicId) VALUES
						  ('2023-09-15', '', 1 , 3 , 'Clutches and breaks' , 210 , 3 , 2 , 2),
						  ('2023-08-11' , '' , 0 , 5 , 'No parts used' , 190 , 6 , 3 , 1),
						  ('2023-09-02' , 'Handed parts to customer was asked' , 1 , 7 , 'Manifold and Oxygen sensors' , 350 , 7 , 4 , 2),
						  ('2024-01-16' , '' , 1 , 2 , 'No parts used' , 60 , 8 , 5 , 3),
						  ('2023-11-05' , '' , 1 , 1 , 'Tires' , 75 , 4 , 6 , 4),
						  ('2023-10-18' , 'Customer must return with vehicle as engine is prone to coolant leaks' , 0 , 12 , 'Water pump,Rubber Grommets,Main seal, Oil pump and Head Gasket' , 1120 , 2 , 7 ,3);

						  

SELECT * FROM serviceRecord;

--Needed to update status bit data type to 0 instead of -1
--UPDATE serviceRecord
--SET [status] = 0
--WHERE recordId = 3

--UPDATE serviceRecord
--SET [status] = 0
--WHERE recordId = 7




--The below are views which will be implemented in database,and use them in backend.
--This is due to that fact that I think a mechanic would find these queries helpful

--Show all Customers with their respective important vehicle information
CREATE VIEW customerVehicleInfo AS
select CONCAT(firstName , ' ' , lastName) AS 'Name' , c.contactNumber ,
	   v.brand , v.model , v.[year], v.plate 
FROM customer c
JOIN vehicle v 
ON v.customerId = c.customerId

SELECT * FROM customerVehicleInfo;


--Show all customers that need to return to garage
CREATE VIEW customerReturns AS
SELECT c.firstName , c.lastName , c.contactNumber ,sr.[status] , sr.[description] 
FROM customer c
JOIN serviceRecord sr
ON sr.customerId = c.customerId
WHERE sr.[status] = 0

SELECT * FROM customerReturns;

--show all mechanics and their services


select * from [service]
select * from mechanic;

select  s.serviceName , CONCAT(firstName ,' ', lastName) AS 'Name' 
from mechanic m
right join [service] s
on m.mechanicId = s.serviceId
GROUP BY serviceName,firstName,lastName


--I had the thought of stored procedures, although they are more encapsulating and centralized.
--My research on how to implement procedures into the backend takes much more code to execute anyway.
--Thus I will stick with simple inserts.

