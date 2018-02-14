ALTER PROCEDURE dbo.SP_GetSingleInvestor
(
  @InvestorId INT
)
AS 
BEGIN

SELECT
  Investor.InvNID
 ,Investor.InvFullName
 ,Investor.InvFatherName
 ,Investor.InvMotherName
 ,Investor.InvHusbWifeName
 ,Investor.InvPresentAddress
 ,Investor.InvParmanentAddress
 ,Investor.InvDateOfBirth
 ,Investor.InvProfession
 ,Investor.InvGender
 ,Investor.InvMobileNo
 ,(SELECT
      SUM(Invest.Amount) AS InvInvest
    FROM dbo.Invest
    WHERE Invest.Investor_InvId = @InvestorId)
  AS InvInvest
FROM dbo.Investor
WHERE Investor.InvId = @InvestorId

END
GO