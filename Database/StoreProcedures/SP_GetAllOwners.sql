ALTER PROCEDURE dbo.SP_GetAllOwners
AS
BEGIN
SET NOCOUNT ON;
SELECT
  MemberId
 ,FullName
 ,DateOfBirth
 ,MobileNo
 ,MemberAmount.Amount AS Amount
FROM IGMember
    ,MemberAmount
WHERE IGMember.MemberId = IGMember_MemberId;
END
GO