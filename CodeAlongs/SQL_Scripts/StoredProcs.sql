--Insert a region
CREATE PROCEDURE RegionInsert(
	@RegionDescription nchar(50),
	@RegionId int output
) AS
BEGIN
	INSERT INTO REGION (RegionDescription)
	VALUES (@RegionDescription);

	SET @RegionId = SCOPE_IDENTITY(); --will set the RegionId to the new id
END

-- declare our output varaible and execute the Stored Proc
DECLARE @Id int
EXEC RegionInsert 'NorthEast', @Id output -- note: output is used on output param
SELECT @Id -- return just the id
SELECT * FROM Region -- return the whole table

GO 

--update a region
CREATE PROCEDURE RegionUpdate(
	@RegionDescription nchar(50),
	@RegionId int
) AS
BEGIN
	UPDATE Region
	SET RegionDescription = @RegionDescription
	WHERE RegionID = @RegionId
END

-- execute the statement, nothing special just pass params
EXEC RegionUpdate 'Bobs Barn', 5
SELECT * FROM Region

GO 

CREATE PROCEDURE RegionDelete(
	@RegionId int 
) AS
BEGIN
	DELETE Region
	WHERE RegionID = @RegionId;
END

EXEC RegionDelete 5
SELECT * FROM Region