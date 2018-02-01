CREATE PROCEDURE GetAMember
(
	@Memeber_Id Int
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
	  FROM IGMember
	  WHERE MemberId = @Memeber_Id;
END