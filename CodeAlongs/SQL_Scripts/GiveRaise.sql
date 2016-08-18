-- Requirement: Give Sally's Employees a raise
-- give $1000 raise
-- Tables to target: Employee, PayRates

SELECT * 
FROM Employee e
	INNER JOIN PayRates pr
		ON e.EmpID = pr.EmpID
WHERE ManagerID = 11

UPDATE pr
SET YearlySalary = YearlySalary + 1000
FROM Employee e
	INNER JOIN PayRates pr
		ON e.EmpID = pr.EmpID
WHERE ManagerID = 11 
-- more appropriate to add 
AND YearlySalary IS NOT NULL

