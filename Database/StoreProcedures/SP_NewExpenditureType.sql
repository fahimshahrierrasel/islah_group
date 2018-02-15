CREATE PROCEDURE SP_NewExpenditureType
(
  @Type VARCHAR(20)
)
AS
BEGIN
  INSERT ExpenType (Type) VALUES (@Type);
END
GO