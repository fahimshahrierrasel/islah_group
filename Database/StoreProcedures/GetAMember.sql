CREATE PROCEDURE GetAMember
(
	@Member_Id Int
)
AS
BEGIN
	 SELECT MemberId
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
	  FROM IGMember, Nominee, MemberAmount
	  WHERE MemberId = @Member_Id
	  AND Nominee.IGMember_MemberId = @Member_Id
	  AND MemberAmount.IGMember_MemberId = @Member_Id;
END
GO