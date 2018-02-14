ALTER PROCEDURE dbo.SP_GetSingleOwner (@MemberId INT)
AS
BEGIN
SELECT
  MemberId
 ,MembershipId
 ,MemberType
 ,ShareNo
 ,NID
 ,FullName
 ,FatherName
 ,MotherName
 ,HusbWifeName
 ,PresentAddress
 ,ParmanentAddress
 ,DateOfBirth
 ,Education
 ,Profession
 ,Nationality
 ,Gender
 ,BloodGroup
 ,MobileNo
 ,Email
 ,ImageUrl
 ,RegistrationDate
 ,MemberType
 ,Nominee.NomineeId
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
 ,MemberAmount.MemAmountId
 ,MemberAmount.Amount
 ,MemberAmount.Profit
 ,MemberStatus.Status
FROM IGMember
    ,Nominee
    ,MemberAmount
    ,MemberStatus
WHERE MemberId = @MemberId
AND Nominee.IGMember_MemberId = @MemberId
AND MemberAmount.IGMember_MemberId = @MemberId
AND MemberStatus.IGMember_MemberId = @MemberId;
END
GO