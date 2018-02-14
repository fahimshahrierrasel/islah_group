CREATE PROCEDURE dbo.SP_GetSingleOwnerByEmail (@Email VARCHAR(60))
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
   ,MemberStatus.Status
  FROM dbo.IGUser,dbo.IGMember,dbo.Nominee,dbo.MemberAmount,dbo.MemberStatus
  WHERE IGUser.Email = IGMember.Email
  AND IGMember.MemberId = Nominee.IGMember_MemberId
  AND IGMember.MemberId = MemberAmount.IGMember_MemberId
  AND IGMember.MemberId = MemberStatus.IGMember_MemberId
  AND IGUser.Email = @Email;
END
GO