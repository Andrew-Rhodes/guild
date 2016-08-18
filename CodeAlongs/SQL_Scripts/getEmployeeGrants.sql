-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE spGetEmployeeGrants 
	-- Add the parameters for the stored procedure here
AS
BEGIN
    -- Insert statements for procedure here
	SELECT e.EmpID, e.FirstName, e.LastName,
		g.GrantID, g.GrantName, g.Amount
	FROM Employee e
		INNER JOIN [Grant] g
			ON e.EmpID = g.EmpID
	ORDER BY e.EmpID, g.GrantID
END
GO
