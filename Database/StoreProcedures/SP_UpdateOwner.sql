CREATE PROCEDURE SP_UpdateOwner (	--Members parameter
@OwnerId INT,
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
@Designation VARCHAR(30)
)
AS
BEGIN

UPDATE IGMember 
  SET
  ShareNo = @ShareNo,
  NID = @NID,
  FullName = @FullName,
  FatherName = @FatherName,
  MotherName = @MotherName,
  HusbWifeName = @HusbWifeName,
  PresentAddress = PresentAddress,
  ParmanentAddress = @ParmanentAddress,
  DateOfBirth = @DateOfBirth,
  Education = @Education,
  Profession = @Profession,
  Nationality = @Nationality,
  Gender = @Gender,
  BloodGroup = @BloodGroup,
  MobileNo = @MobileNo,
  Email = @Email,
  ImageUrl = @ImageUrl,
  RegistrationDate = @RegistrationDate,
  Designation = @Designation
WHERE MemberId = @OwnerId

Update Nominee
  SET
  NomineeNidNo = @NomineeNidNo,
  NomineeName = @NomineeName,
  NomineeFatherHusbandName = @NomineeFatherHusbandName,
  NomineeMotherName = @MotherName,
  NomineeAddress = @NomineeAddress,
  NomineeDateOfBirth = @NomineeDateOfBirth,
  NomineeRelation = @NomineeRelation,
  NomineeProfession = @NomineeProfession,
  NomineeMobileNo = @NomineeMobileNo,
  NomineeImageUrl = @NomineeImageUrl
  WHERE IGMember_MemberId = @OwnerId
END
GO