USE master 
GO 

IF EXISTS( SELECT * FROM sys.sysdatabases WHERE [name] = 'MovieCatalogue') 
DROP DATABASE MovieCatalogue 
GO 

CREATE DATABASE MovieCatalogue 
GO 

USE MovieCatalogue 
GO 
CREATE TABLE Movie 
( 
	MovieID INT IDENTITY(1,1) PRIMARY KEY, 
	Title VARCHAR(30) NOT NULL, 
	Runtime INT, 
	Rating VARCHAR(5)
) 
GO 

INSERT INTO Movie VALUES 
	('A-List Explorers', 96,'PG-13'), 
	('Bonker Bonzo', 75,'G'), 
	('Chumps to Champs', 75,'PG-13'), 
	('Dare or Die', 110,'R'), 
	('EeeeGhads', 88,'G')
