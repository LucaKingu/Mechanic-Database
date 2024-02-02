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
	mechanicId INT NOT NULL CONSTRAINT sr_mchId_fk FOREIGN KEY(mechanicId) REFERENCES mechanic(mechanicId)
);
--One service could contain many service records
--One customer could contain many service records
--One mechanic could contain many service records


--EXEC sp_rename 'service.serviceDescription' , 'serviceName' , 'COLUMN';
--Needed to alter column name in table service during construction of DB




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