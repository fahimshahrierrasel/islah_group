CREATE PROCEDURE SP_GetADeposit
(
  @DepositId int
)
AS
BEGIN

  SELECT
    DepositId
   ,DepositDate
   ,Amount
   ,Note
  FROM MemberDeposit
  WHERE DepositId = @DepositId;

END
GO