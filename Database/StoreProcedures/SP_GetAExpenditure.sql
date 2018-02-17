CREATE PROCEDURE SP_GetAExpenditure
(
  @ExpnId INT
)
AS
BEGIN
  SELECT
    ExpnDate
   ,ExpnNote
   ,ExpnAmount
   ,ExpenType_Type AS ExpnType
  FROM Expenditure
  WHERE ExpnId = @ExpnId
END
GO