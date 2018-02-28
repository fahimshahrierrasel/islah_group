USE islahgro_admin
GO

ALTER PROCEDURE dbo.SP_DeleteExpenditure (@ExpnId INT)
AS
BEGIN

  DECLARE @CurrentCapital DECIMAL(15, 2);
  DECLARE @UpdatedCapital DECIMAL(15, 2);
  DECLARE @OldExpnAmount DECIMAL(15, 2);
  DECLARE @CapitalId INT;
  DECLARE @ExpnType VARCHAR(20);
  SET @CapitalId = 1;

  SELECT
    @CurrentCapital = c.CurrentAmount
  FROM Capital c
  WHERE c.CapitalId = @CapitalId;

  SELECT
    @OldExpnAmount = ExpnAmount
   ,@ExpnType = ExpenType_Type
  FROM Expenditure
  WHERE ExpnId = @ExpnId;

  IF @ExpnType = 'Earn'
    SET @UpdatedCapital = @CurrentCapital - @OldExpnAmount;
  ELSE
    SET @UpdatedCapital = @CurrentCapital + @OldExpnAmount;

  DELETE FROM Expenditure
  WHERE ExpnId = @ExpnId;

  UPDATE Capital
  SET CurrentAmount = @UpdatedCapital
  WHERE CapitalId = @CapitalId;

END
GO