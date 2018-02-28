USE islahgro_admin
GO

ALTER PROCEDURE dbo.SP_InsertNewExpenditure (@ExpnDate DATE,
@ExpnNote VARCHAR(300),
@ExpnAmount DECIMAL(15, 2),
@ExpnType VARCHAR(20),
@UserId INT)
AS
BEGIN

  DECLARE @CurrentCapital DECIMAL(15, 2);
  DECLARE @UpdatedCapital DECIMAL(15, 2);
  DECLARE @CapitalId INT;
  SET @CapitalId = 1;

  SELECT
    @CurrentCapital = c.CurrentAmount
  FROM Capital c
  WHERE c.CapitalId = @CapitalId;

  IF @ExpnType = 'Earn'
    SET @UpdatedCapital = @CurrentCapital + @ExpnAmount;
  ELSE
    BEGIN
      IF @ExpnAmount < @CurrentCapital
        SET @UpdatedCapital = @CurrentCapital - @ExpnAmount
      ELSE
        RETURN 0
    END
    
  INSERT INTO Expenditure (ExpnDate, ExpnNote, ExpnAmount, ExpenType_Type, IGUser_UserId)
    VALUES (@ExpnDate, @ExpnNote, @ExpnAmount, @ExpnType, @UserId);

  UPDATE Capital
  SET CurrentAmount = @UpdatedCapital
  WHERE CapitalId = @CapitalId;

END
GO