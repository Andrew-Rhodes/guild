USE Northwind
GO 

CREATE VIEW EmployeesAndManagers
AS

SELECT emp.EmployeeID, emp.LastName, emp.FirstName, emp.Title,
	mgr.LastName AS ManagerLastName, mgr.Title AS ManagerTitle
FROM Employees emp
	INNER JOIN Employees mgr
		ON emp.ReportsTo = mgr.EmployeeID

GO

SELECT * FROM EmployeesAndManagers
