CREATE PROCEDURE GetUserInformation
(
	@Username varchar(30),
	@Password varchar(30)
)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT UserId, AName, Email, AUsername, APassword, UserType.Type AS UserType
	FROM IGUser, UserType
	WHERE IGUser.UserType_TypeID = UserType.TypeID AND AUsername = @Username AND APassword = @Password
END