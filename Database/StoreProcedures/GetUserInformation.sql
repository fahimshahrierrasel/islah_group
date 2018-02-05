CREATE PROCEDURE GetUserInformation
(
	@Username varchar(30),
	@Password varchar(30)
)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT UserId, AName, Email, AUsername, APassword, UserType_UsrType AS UserType
	FROM IGUser
	WHERE AUsername = @Username AND APassword = @Password
END