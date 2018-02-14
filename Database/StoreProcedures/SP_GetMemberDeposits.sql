ALTER PROCEDURE dbo.SP_GetMemberDeposits
(
  @MemberId int
)
AS
BEGIN

SELECT
  DepositDate
 ,Amount
 ,Note
FROM MemberDeposit
WHERE IGMember_MemberId = @MemberId;

END
GO