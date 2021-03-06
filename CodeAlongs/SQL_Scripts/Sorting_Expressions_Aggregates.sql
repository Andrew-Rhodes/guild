USE SWCCorp
GO

SELECT LastName, FirstName
FROM Employee
--ORDER BY LastName -- A to Z
ORDER BY LastName DESC -- Z to A

SELECT LastName, FirstName, HireDate, City
FROM Employee
	INNER JOIN Location 
		ON Employee.LocationID = Location.LocationID
ORDER BY City, HireDate DESC

SELECT *
FROM Employee
WHERE [Status] IS NOT NULL
ORDER BY [Status] DESC

-- EXPRESSIONS
SELECT ProductName, RetailPrice, Round((RetailPrice * 1.07), 2) AS PriceWithTax
FROM CurrentProducts

SELECT FirstName + ' ' + LastName AS [Employee Name],
	HireDate,
	CONVERT(NVARCHAR, HireDate, 101) AS 'MM/ DD/ YYYY',
	CONVERT(NVARCHAR, HireDate, 103) AS 'DD/ MM/ YYYY',
	CONVERT(NVARCHAR, HireDate, 106) AS 'European Letter',
	CONVERT(NVARCHAR, HireDate, 107) AS 'Business Letter',
	CONVERT(NVARCHAR, HireDate, 110) AS 'MM-DD-YYYY'
FROM Employee
ORDER BY HireDate DESC

SELECT ProductName, RetailPrice, Round((RetailPrice * 1.07), 2) AS PriceWithTax
FROM CurrentProducts
ORDER BY PriceWithTax DESC

-- AGGREGATES
SELECT EmpID, 
	SUM(Amount) AS TotalGrantAmount,
	COUNT(Amount) AS NumberOfGrants
FROM [Grant]
WHERE EmpID IS NOT NULL
GROUP BY EmpID
ORDER BY NumberOfGrants DESC

SELECT 
	SUM(Amount) AS TotalGrantAmount,
	COUNT(Amount) AS NumberOfGrants,
	Max(Amount) AS MaxGrant
FROM [Grant]
WHERE EmpID IS NOT NULL

SELECT e.EmpID, e.FirstName, e.LastName, Max(Amount) AS MaxAmount
FROM [Grant] g
	INNER JOIN Employee e
		ON g.EmpID = e.EmpID
GROUP BY e.EmpID, e.FirstName, e.LastName
ORDER BY e.LastName

SELECT COUNT(*) FROM [Grant]
SELECT COUNT(EmpID) FROM [Grant]

SELECT COUNT(*) - COUNT(EmpID) AS GrantsWithoutEmployee
FROM [Grant]

SELECT e.EmpID, e.FirstName, e.LastName, Max(Amount) AS MaxAmount
FROM [Grant] g
	INNER JOIN Employee e
		ON g.EmpID = e.EmpID
GROUP BY e.EmpID, e.FirstName, e.LastName
HAVING MAX(Amount) > 20000
ORDER BY e.LastName

-- ORder of execution
SELECT l.City, COUNT(EmpID) AS TotalEmployees	-- 6
FROM Employee e									-- 1 
	INNER JOIN Location l
		ON e.LocationID = l.LocationID
WHERE city <> 'Boston'							-- 2
GROUP BY City									-- 3
HAVING COUNT(EmpID) > 2							-- 4
ORDER BY TotalEmployees							-- 5

