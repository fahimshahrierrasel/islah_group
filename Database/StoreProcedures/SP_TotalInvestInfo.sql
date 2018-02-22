CREATE PROCEDURE SP_TotalInvestInfo (@InvestorId INT)
AS
BEGIN

  SELECT
  InvestType.Type
  ,SUM(Invest.Amount) AS Total
  FROM dbo.InvestType
  FULL OUTER JOIN dbo.Invest
    ON InvestType.Type = Invest.InvestType_Type
  WHERE Invest.Investor_InvId = @InvestorId
  GROUP BY InvestType.Type

END
GO