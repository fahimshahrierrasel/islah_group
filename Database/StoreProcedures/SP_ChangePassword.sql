CREATE PROCEDURE SP_ChangePassword
(
  @UserId INT,
  @Password VARCHAR(30)
)
AS
BEGIN

  UPDATE IGUser
    SET APassword = @Password
    WHERE UserId = @UserId;

END
GO