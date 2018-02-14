ALTER PROCEDURE dbo.SP_GetAllInvestors
AS
BEGIN

SELECT
  Investor.InvId
 ,Investor.InvFullName
 ,Investor.InvMobileNo
 ,(SELECT
      SUM(Invest.Amount) AS InvInvest
    FROM dbo.Invest
    WHERE Invest.Investor_InvId = InvId)
  AS InvInvest
FROM dbo.Investor

END
GO