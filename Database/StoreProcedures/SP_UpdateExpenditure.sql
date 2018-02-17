ALTER PROCEDURE dbo.SP_UpdateExpenditure
(
  @ExpnId INT,
  @ExpnNote VARCHAR(300),
  @ExpnAmount DECIMAL(15,2),
  @ExpnType VARCHAR(20)
)
AS
BEGIN

  DECLARE @CurrentCapital DECIMAL(15,2);
  DECLARE @UpdatedCapital DECIMAL(15,2);
  DECLARE @OldExpnAmount DECIMAL(15,2);
  DECLARE @CapitalId INT;
SET @CapitalId = 1;

SELECT
  @CurrentCapital = c.CurrentAmount
FROM Capital c
WHERE c.CapitalId = @CapitalId;

SELECT
  @OldExpnAmount = ExpnAmount
FROM Expenditure
WHERE ExpnId = @ExpnId;

UPDATE Expenditure
SET ExpnNote = @ExpnNote
   ,ExpnAmount = @ExpnAmount
WHERE ExpnId = @ExpnId;

IF @ExpnType = 'Earn'
SET @UpdatedCapital = @CurrentCapital - @OldExpnAmount + @ExpnAmount;
ELSE
IF @ExpnAmount < @CurrentCapital
SET @UpdatedCapital = @CurrentCapital + @OldExpnAmount - @ExpnAmount;

UPDATE Capital
SET CurrentAmount = @UpdatedCapital
WHERE CapitalId = @CapitalId;

END
GO