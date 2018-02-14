ALTER PROCEDURE dbo.SP_InsertNewExpenditure
(
  @ExpnDate DATE,
  @ExpnNote VARCHAR(300),
  @ExpnAmount DECIMAL(15,2),
  @ExpnType VARCHAR(20),
  @UserId INT
)
AS
BEGIN
  DECLARE @CurrentCapital DECIMAL(15,2);
  DECLARE @UpdatedCapital DECIMAL(15,2);
  DECLARE @TotalDeposit DECIMAL(16,2);
  DECLARE @UpdatedTDeposit DECIMAL(16,2);
  DECLARE @TotalWithdraw DECIMAL(16,2);
  DECLARE @UpdatedTWithdraw DECIMAL(16,2);
  DECLARE @CapitalId INT;
SET @CapitalId = 1;

SELECT
  @CurrentCapital = c.CurrentAmount
 ,@TotalDeposit = c.TotalDeposit
 ,@TotalWithdraw = c.TotalWithdraw
FROM Capital c
WHERE c.CapitalId = @CapitalId;

SET @UpdatedTDeposit = @TotalDeposit;
SET @UpdatedTWithdraw = @TotalWithdraw;

INSERT INTO Expenditure (ExpnDate, ExpnNote, ExpnAmount, ExpenType_Type, IGUser_UserId)
  VALUES (@ExpnDate, @ExpnNote, @ExpnAmount, @ExpnType, @UserId);

IF @ExpnType = 'Earn'
BEGIN
SET @UpdatedCapital = @CurrentCapital + @ExpnAmount;
SET @UpdatedTDeposit = @TotalDeposit + @ExpnAmount;
    END
  ELSE
    BEGIN
      IF @ExpnAmount < @CurrentCapital
        BEGIN
SET @UpdatedCapital = @CurrentCapital - @ExpnAmount;
SET @UpdatedTWithdraw = @TotalWithdraw + @ExpnAmount;
        END
    END

UPDATE Capital
SET CurrentAmount = @UpdatedCapital
   ,TotalDeposit = @UpdatedTDeposit
   ,TotalWithdraw = @UpdatedTWithdraw
WHERE CapitalId = @CapitalId;

END
GO