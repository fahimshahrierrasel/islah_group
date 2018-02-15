CREATE PROCEDURE SP_GetCurrentCapital
AS
BEGIN
  SELECT CapitalId, CapitalGroup, CurrentAmount, TotalDeposit, TotalWithdraw FROM Capital
END
GO