CREATE DATABASE MechanicDB

create table a
(
	aId int primary key,
	[name]  varchar(2) not null
);

insert into a(aId , name) values (1 , 'l');

select * from a;