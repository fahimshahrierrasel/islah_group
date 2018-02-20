CREATE PROCEDURE SP_UpdateInvest
(
  @InvestId INT,
  @InvestDate DATE,
  @Amount DECIMAL(10, 2),
  @Profit DECIMAL(5, 2),
  @Note VARCHAR(400)
)
AS
BEGIN

  UPDATE Invest
    SET InvestDate = @InvestDate,
      Amount = @Amount,
      Profit = @Profit,
      Note = @Note
  WHERE @InvestId = @InvestId

END
GO