CREATE PROCEDURE SP_GetAllIGUser
AS
BEGIN
  SELECT UserId
    , AName AS Name
    , AUsername AS Username
    , Email AS Email
    , UserType_UsrType AS Type
  FROM IGUser
END
GO