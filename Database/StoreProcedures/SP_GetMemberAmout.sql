ALTER PROCEDURE dbo.SP_GetMemberAmout
(
  @MemberId int
)
AS
BEGIN

SELECT
  Amount
 ,Profit
FROM MemberAmount
WHERE IGMember_MemberId = @MemberId;

END
GO