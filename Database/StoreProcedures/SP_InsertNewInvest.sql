USE islahgro_admin
GO

ALTER PROCEDURE dbo.SP_InsertNewInvest (@InvestorId INT,
@UserId INT,
@InvestDate DATE,
@Amount DECIMAL(10, 2),
@Profit DECIMAL(5, 2),
@Note VARCHAR(400),
@Type VARCHAR(30))
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

  IF @Type = 'Returned'
    BEGIN
      IF @Amount < @CurrentCapital
        SET @UpdatedCapital = @CurrentCapital - @Amount;
      ELSE
        RETURN 0
    END
  ELSE
    SET @UpdatedCapital = @CurrentCapital + @Amount;

  
  INSERT INTO Invest (Amount, Profit, InvestDate, Note, InvestType_Type, Investor_InvId, IGUser_UserId)
    VALUES (@Amount, @Profit, @InvestDate, @Note, @Type, @InvestorId, @UserId);

  UPDATE Capital
  SET CurrentAmount = @UpdatedCapital
  WHERE CapitalId = @CapitalId;

END
GO