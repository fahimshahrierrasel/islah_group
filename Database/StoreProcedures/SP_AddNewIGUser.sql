CREATE PROCEDURE SP_AddNewIGUser
(
  @Name VARCHAR(60),
  @Username VARCHAR(30),
  @Email VARCHAR(60),
  @Password VARCHAR(30),
  @Type VARCHAR(20)
)
AS
BEGIN
  INSERT IGUser (AName, Email, AUsername, APassword, UserType_UsrType) VALUES (@Name, @Email, @Username, @Password, @Type);
END
GO