ALTER PROCEDURE dbo.SP_GetSingleUser (@Email VARCHAR(30),
@Password VARCHAR(30))
AS
BEGIN
SET NOCOUNT ON;
SELECT TOP 1
  UserId
 ,AName
 ,Email
 ,AUsername
 ,APassword
 ,UserType_UsrType AS UserType
FROM IGUser
WHERE Email = @Email
AND APassword = @Password
END
GO