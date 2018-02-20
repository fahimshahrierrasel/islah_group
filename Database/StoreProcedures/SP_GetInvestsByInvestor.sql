CREATE PROCEDURE SP_GetInvestsByInvestor
(
  @InvestorId INT
)
AS
BEGIN

  SELECT InvestId, Amount, Profit, InvestDate, Note, InvestType_Type AS Type
  FROM Invest
  WHERE Investor_InvId = @InvestorId;

END
GO