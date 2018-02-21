CREATE PROCEDURE SP_UpdateUser
(
  @UserId INT,
  @FullName VARCHAR(60),
  @Email VARCHAR(60),
  @Username VARCHAR(30),
  @Password VARCHAR(30),
  @Type VARCHAR(20)
)
AS
BEGIN

  UPDATE IGUser
    SET AName = @FullName,
      Email = @Email,
      AUsername = @Username,
      APassword = @Password,
      UserType_UsrType = @Type
    WHERE UserId = @UserId;

END
GO