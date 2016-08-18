SELECT *
	, RANK() OVER(ORDER BY TotalPrice DESC) AS [RANK]
	, DENSE_RANK() OVER(ORDER BY TotalPrice DESC) AS [DENSE RANK]
	, ROW_NUMBER() OVER(ORDER BY TotalPrice DESC) AS [ROW NUMBER]
	, NTILE(3) OVER(ORDER BY TotalPrice DESC) AS [TILE]
FROM
(SELECT e.EmployeeID, e.FirstName, e.LastName
		, ROUND(SUM((od.UnitPrice * od.Quantity) * (1 - od.Discount)), 2) AS TotalPrice
FROM Employees e
	LEFT JOIN Orders o
		ON e.EmployeeID = o.EmployeeID
	INNER JOIN [Order Details] od
		ON o.OrderID = od.OrderID
GROUP BY e.EmployeeID, FirstName, LastName) AS DATA
