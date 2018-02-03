CREATE PROCEDURE InsertMember
(	--Members parameter
	@ShareNo varchar(30),
	@NID varchar(30),
	@FullName varchar(100),
	@FatherName varchar(100),
	@MotherName varchar(100),
	@HusbWifeName varchar(100),
	@PresentAddress text,
	@ParmanentAddress text,
	@DateOfBirth date,
	@Education varchar(100),
	@Profession varchar(100),
	@Nationality varchar(30),
	@Gender varchar(6),
	@BloodGroup varchar(3),
	@MobileNo varchar(15),
	@Email varchar(50),
	@ImageUrl varchar(200) ,
	@RegistrationDate date,
	--IntroducersParameter
    @IntroducerName varchar(100),
    @Introducers_ShareNo varchar(30),
	--NomineeParameter
    @NomineeNidNo varchar(30),
    @NomineeName varchar(100),
    @NomineeFatherHusbandName varchar(100),
    @NomineeMotherName varchar(100),
    @NomineeAddress text,
    @NomineeDateOfBirth date,
    @NomineeRelation varchar(50),
    @NomineeProfession varchar(30),
    @NomineeMobileNo varchar(15),
    @NomineeImageUrl varchar(200)
)
AS
BEGIN

DECLARE @Member_Id INT;
SET @Member_Id = NEXT VALUE FOR Seq_Member;

INSERT INTO IGMember
(
	MemberId,
	ShareNo,
	NID,
	FullName,
	FatherName,
	MotherName,
	HusbWifeName,
	PresentAddress,
	ParmanentAddress,
	DateOfBirth,
	Education ,
	Profession,
	Nationality ,
	Gender ,
	BloodGroup,
	MobileNo,
	Email,
	ImageUrl,
	RegistrationDate ,
	MemberType
) 
VALUES
(
	@Member_Id,
	@ShareNo,
	@NID,
	@FullName,
	@FatherName,
	@MotherName,
	@HusbWifeName,
	@PresentAddress,
	@ParmanentAddress,
	@DateOfBirth,
	@Education,
	@Profession,
	@Nationality,
	@Gender,
	@BloodGroup,
	@MobileNo,
	@Email,
	@ImageUrl ,
	@RegistrationDate,
	'Member'
)

INSERT INTO Intorducer
(
    IGMember_MemberId,
    IntroducerName,
    ShareNo
) 
VALUES
(
    @Member_Id,
    @IntroducerName,
    @ShareNo
)
INSERT INTO Nominee
(
    IGMember_MemberId ,
    NomineeNidNo ,
    NomineeName,
    NomineeFatherHusbandName,
    NomineeMotherName,
    NomineeAddress,
    NomineeDateOfBirth ,
    NomineeRelation,
    NomineeProfession ,
    NomineeMobileNo,
    NomineeImageUrl
) 
VALUES
(
	@Member_Id,
    @NomineeNidNo,
    @NomineeName,
    @NomineeFatherHusbandName,
    @NomineeMotherName,
    @NomineeAddress,
    @NomineeDateOfBirth,
    @NomineeRelation ,
    @NomineeProfession ,
    @NomineeMobileNo ,
    @NomineeImageUrl 
)
END