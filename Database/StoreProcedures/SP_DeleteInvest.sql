CREATE PROCEDURE SP_DeleteInvest
(
  @InvestId INT
)
AS
BEGIN

  DELETE FROM Invest
  WHERE InvestId = @InvestId;

END
GO