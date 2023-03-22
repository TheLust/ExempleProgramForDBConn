CREATE DATABASE EXEMPLUBD;

GO

USE EXEMPLUBD;

GO

CREATE TABLE ExempluTabel (
	id int identity(1,1) primary key,
	ceva varchar(50) not null,
	altceva varchar(50) not null
);