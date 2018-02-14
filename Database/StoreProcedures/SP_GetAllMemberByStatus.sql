ALTER PROCEDURE dbo.SP_GetAllMemberByStatus (@Status VARCHAR(5))
AS
BEGIN
SELECT
  IGMember.MemberId
 ,IGMember.MembershipId
 ,IGMember.FullName
 ,IGMember.RegistrationDate
FROM dbo.IGMember
INNER JOIN dbo.MemberStatus
  ON IGMember.MemberId = MemberStatus.IGMember_MemberId
WHERE MemberStatus.Status = @Status AND IGMember.MemberType = 'Member';
END
GO