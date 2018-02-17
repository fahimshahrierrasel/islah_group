ALTER PROCEDURE dbo.SP_GetAllExpenditure
AS
BEGIN
SELECT
  ExpnId
 ,ExpnDate
 ,ExpnNote
 ,ExpnAmount
 ,ExpenType_Type AS ExpnType
FROM Expenditure
END
GO