ALTER PROCEDURE dbo.SP_GetExpenditureInfo
AS
BEGIN

SELECT
  ExpenType.Type
 ,SUM(Expenditure.ExpnAmount) AS Total
FROM dbo.Expenditure
FULL OUTER JOIN ExpenType
  ON Expenditure.ExpenType_Type = ExpenType.Type
GROUP BY ExpenType.Type
ORDER BY ExpenType.Type

END
GO