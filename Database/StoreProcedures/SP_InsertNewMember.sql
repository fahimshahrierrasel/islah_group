ALTER PROCEDURE dbo.SP_InsertNewMember (
@ShareNo VARCHAR(30),
@NID VARCHAR(30),
@FullName VARCHAR(100),
@FatherName VARCHAR(100),
@MotherName VARCHAR(100),
@HusbWifeName VARCHAR(100),
@PresentAddress TEXT,
@ParmanentAddress TEXT,
@DateOfBirth DATE,
@Education VARCHAR(100),
@Profession VARCHAR(100),
@Nationality VARCHAR(30),
@Gender VARCHAR(6),
@BloodGroup VARCHAR(3),
@MobileNo VARCHAR(15),
@Email VARCHAR(50),
@Designation VARCHAR(30),
@ImageUrl VARCHAR(200),
@RegistrationDate DATE,
--NomineeParameter
@NomineeNidNo VARCHAR(30),
@NomineeName VARCHAR(100),
@NomineeFatherHusbandName VARCHAR(100),
@NomineeMotherName VARCHAR(100),
@NomineeAddress TEXT,
@NomineeDateOfBirth DATE,
@NomineeRelation VARCHAR(50),
@NomineeProfession VARCHAR(30),
@NomineeMobileNo VARCHAR(15),
@NomineeImageUrl VARCHAR(200),
--IntroducerParameter
@IntroMembershipId VARCHAR(17))
AS
BEGIN

  DECLARE @MemberType VARCHAR(10);
  DECLARE @Member_Id INT;
  DECLARE @MembershipId VARCHAR(17);
  SET @MemberType = 'Member';
  SET @Member_Id = NEXT VALUE FOR Seq_Member;
  SET @MembershipId = dbo.udf_GetUniqueId('MEM', @Member_Id);

INSERT INTO IGMember (MemberId,
MembershipId,
ShareNo,
NID,
FullName,
FatherName,
MotherName,
HusbWifeName,
PresentAddress,
ParmanentAddress,
DateOfBirth,
Education,
Profession,
Nationality,
Gender,
BloodGroup,
MobileNo,
Email,
ImageUrl,
RegistrationDate,
Designation,
MemberType)
  VALUES (@Member_Id, @MembershipId, @ShareNo, @NID, @FullName, @FatherName, @MotherName, @HusbWifeName, @PresentAddress, @ParmanentAddress, @DateOfBirth, @Education, @Profession, @Nationality, @Gender, @BloodGroup, @MobileNo, @Email, @ImageUrl, @RegistrationDate, @Designation, @MemberType)

INSERT INTO MemberAmount (Amount,
Profit,
IGMember_MemberId)
  VALUES (0.00, 0.00, @Member_Id)

INSERT INTO Nominee (IGMember_MemberId,
NomineeNidNo,
NomineeName,
NomineeFatherHusbandName,
NomineeMotherName,
NomineeAddress,
NomineeDateOfBirth,
NomineeRelation,
NomineeProfession,
NomineeMobileNo,
NomineeImageUrl)
  VALUES (@Member_Id, @NomineeNidNo, @NomineeName, @NomineeFatherHusbandName, @NomineeMotherName, @NomineeAddress, @NomineeDateOfBirth, @NomineeRelation, @NomineeProfession, @NomineeMobileNo, @NomineeImageUrl)

INSERT INTO Intorducer (IGMember_MemberId, IntroMembershipId)
  VALUES (@Member_Id, @IntroMembershipId);
INSERT INTO MemberStatus (IGMember_MemberId, Status)
  VALUES (@Member_Id, 'REQ');

END
GO