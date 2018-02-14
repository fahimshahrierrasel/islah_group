ALTER PROCEDURE dbo.SP_GetSingleMember
(
	@MemberId int
)
AS 
BEGIN
SELECT
  IGMember.MemberId
 ,IGMember.MembershipId
 ,IGMember.ShareNo
 ,IGMember.MemberType
 ,IGMember.NID
 ,IGMember.FullName
 ,IGMember.FatherName
 ,IGMember.MotherName
 ,IGMember.HusbWifeName
 ,IGMember.PresentAddress
 ,IGMember.ParmanentAddress
 ,IGMember.DateOfBirth
 ,IGMember.Education
 ,IGMember.Profession
 ,IGMember.Nationality
 ,IGMember.Gender
 ,IGMember.BloodGroup
 ,IGMember.MobileNo
 ,IGMember.Email
 ,IGMember.ImageUrl
 ,IGMember.RegistrationDate
 ,IGMember.Designation
 ,Nominee.NomineeNidNo
 ,Nominee.NomineeName
 ,Nominee.NomineeFatherHusbandName
 ,Nominee.NomineeMotherName
 ,Nominee.NomineeAddress
 ,Nominee.NomineeDateOfBirth
 ,Nominee.NomineeRelation
 ,Nominee.NomineeProfession
 ,Nominee.NomineeMobileNo
 ,Nominee.NomineeImageUrl
 ,MemberAmount.Amount
 ,MemberAmount.Profit
 ,Intorducer.IntroMembershipId
 ,MemberStatus.Status
FROM IGMember
INNER JOIN Nominee
  ON IGMember.MemberId = Nominee.IGMember_MemberId
INNER JOIN Intorducer
  ON IGMember.MemberId = Intorducer.IGMember_MemberId
INNER JOIN MemberStatus
  ON IGMember.MemberId = MemberStatus.IGMember_MemberId
INNER JOIN MemberAmount
  ON IGMember.MemberId = MemberAmount.IGMember_MemberId
WHERE IGMember.MemberId = @MemberId;
END
GO
