CREATE PROCEDURE dbo.SP_GetInvestById(
  @InvestId INT
)
AS
BEGIN

SELECT
  Amount
 ,Profit
 ,InvestDate
 ,Note
 ,InvestType_Type AS Type
FROM Invest
WHERE InvestId = @InvestId;

END
GO