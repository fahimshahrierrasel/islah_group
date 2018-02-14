ALTER PROCEDURE dbo.SP_InsertNewInvestor
(
  @InvNID VARCHAR(30),
  @InvFullName VARCHAR(100),
  @InvFatherName VARCHAR(100),
  @InvMotherName VARCHAR(100),
  @InvHusbWifeName VARCHAR(100),
  @InvPresentAddress VARCHAR(400),
  @InvParmanentAddress VARCHAR(400),
  @InvDateOfBirth DATE,
  @InvProfession VARCHAR(100),
  @InvGender VARCHAR(6),
  @InvMobileNo VARCHAR(15),
  @UserId int
)
AS
BEGIN

INSERT Investor (InvNID, InvFullName, InvFatherName, InvMotherName, InvHusbWifeName, InvPresentAddress, InvParmanentAddress, InvDateOfBirth, InvProfession, InvGender, InvMobileNo, IGUser_UserId)
  VALUES (@InvNID, @InvFullName, @InvFatherName, @InvMotherName, @InvHusbWifeName, @InvPresentAddress, @InvParmanentAddress, @InvDateOfBirth, @InvProfession, @InvGender, @InvMobileNo, @UserId);

END
GO