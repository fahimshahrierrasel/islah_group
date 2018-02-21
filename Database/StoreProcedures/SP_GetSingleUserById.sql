CREATE PROCEDURE SP_GetSingleUserById
(
  @UserId INT
)
AS
BEGIN
  SELECT
    UserId
   ,AName
   ,Email
   ,AUsername
   ,APassword
   ,UserType_UsrType AS UserType
  FROM IGUser
  WHERE UserId = @UserId
END
GO