/*
-- create a new database named 'moviecatalog'
CREATE DATABASE MovieCatalog
GO

USE MovieCatalog
-- create a single table to hold movie data
CREATE TABLE Movie
(
	MovieID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Title VARCHAR(50) NOT NULL,
	RunTime INT NULL,
	Rating VARCHAR(5) NULL,
	ReleaseDate DATE NULL
)
*/

-- Query our table (no results)
SELECT * 
FROM Movie

-- lets add something to the table
INSERT INTO Movie (Title, RunTime, Rating, ReleaseDate)
VALUES ('Caddyshack', 98, 'R', '7-25-1980')

-- inserted a null value for one of the columns
INSERT INTO Movie (Title, RunTime, Rating, ReleaseDate)
VALUES ('Ghostbusters', NULL, 'PG', '06/08/1984')

-- insert and skip a couple columns
INSERT INTO Movie (Title, Rating)
VALUES ('Groundhog Day', 'PG')

-- insert multiple row and skip columns
INSERT INTO Movie (Title, RunTime, Rating)
VALUES ('The Lion King', 89, 'G'),
('Beauty and the Beast', 84, 'G'),
('Aladdin', 90, 'G')

SELECT * FROM Movie

-- will set every row to 107 ---- CRAP!!!! Don't do it... 
UPDATE Movie
SET RunTime = 107

--DELETE BYE BYE EVERYTHING!
DELETE FROM Movie

-- put some data back into the table
INSERT INTO Movie (Title, RunTime, Rating)
VALUES
	('A-List Explorers', 96, 'PG-13'),
	('Bonker Bonzo', 75, 'G'),
	('Chumps to Champs', 75, 'PG-13'),
	('Dare or Die', 110, 'R'),
	('EeeeGhads', 88, 'G')

SELECT * FROM Movie

-- delete two fo the row
DELETE Movie
WHERE RunTime > 90



