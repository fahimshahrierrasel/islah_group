CREATE PROCEDURE SP_NewInvestType
(
  @Type VARCHAR(20)
)
AS
BEGIN
  INSERT InvestType (Type) VALUES (@Type);
END
GO