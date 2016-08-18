USE RankingData
GO

CREATE TABLE Players(
	PlayerId int not null identity(1,1) primary key,
	Name varchar(20) not null,
	PointsPerGame decimal(5,2) not null default(0)	--max val 999.99
)

GO

INSERT INTO Players (Name, PointsPerGame)
VALUES ('Jane', 9.9),
('Joe', 9.7),
('Mary', 10.8),
('George', 10.8),
('Todd', 11.2),
('Heather', 12.3)

SELECT * FROM Players

SELECT Name,
	RANK() OVER(ORDER BY PointsPerGame DESC) AS [RANK],
	DENSE_RANK() OVER(ORDER BY PointsPerGame DESC) AS [DENSE_RANK],
	ROW_NUMBER() OVER(ORDER BY PointsPerGame DESC) AS [ROW_NUMBER],
	NTILE(3) OVER(ORDER BY PointsPerGame DESC) AS [NTILE]
FROM Players

SELECT * FROM (
SELECT Name,
	RANK() OVER(ORDER BY PointsPerGame DESC) AS [RANK],
	DENSE_RANK() OVER(ORDER BY PointsPerGame DESC) AS [DENSE_RANK]
FROM Players) AS RankedPlayers
WHERE [RANK] <= 3
