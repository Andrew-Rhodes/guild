SELECT *
	, RANK() OVER(ORDER BY TotalGrants DESC) AS [RANK]
	, DENSE_RANK() OVER(ORDER BY TotalGrants DESC) AS [DENSE RANK]
	, ROW_NUMBER() OVER(ORDER BY TotalGrants DESC) AS [ROW NUMBER]
	, NTILE(3) OVER(ORDER BY TotalGrants DESC) AS [TILE]
FROM (
	SELECT e.LastName, e.FirstName
		, SUM(g.Amount) AS TotalGrants
	FROM [Grant] g
		LEFT JOIN Employee e
		ON g.EmpID = e.EmpID
	GROUP BY e.LastName, e.FirstName
	) AS BASETABLE

	
WITH BASETABLE AS (
	SELECT e.LastName, e.FirstName
		, SUM(g.Amount) AS TotalGrants
	FROM [Grant] g
		LEFT JOIN Employee e
		ON g.EmpID = e.EmpID
	GROUP BY e.LastName, e.FirstName
)

SELECT *
	, RANK() OVER(ORDER BY TotalGrants DESC) AS [RANK]
	, DENSE_RANK() OVER(ORDER BY TotalGrants DESC) AS [DENSE RANK]
	, ROW_NUMBER() OVER(ORDER BY TotalGrants DESC) AS [ROW NUMBER]
	, NTILE(3) OVER(ORDER BY TotalGrants DESC) AS [TILE]
FROM BASETABLE