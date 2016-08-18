DECLARE @MinAmount SMALLMONEY
DECLARE @MaxAmount SMALLMONEY

SET @MinAmount = 0
SET @MaxAmount = 24000

SELECT * 
FROM [Grant]
WHERE Amount BETWEEN @MinAmount AND @MaxAmount