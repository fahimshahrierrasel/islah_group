﻿ALTER PROCEDURE dbo.SP_GetUserTypes
AS
BEGIN
SELECT
  UsrType AS Type
FROM UserType;
END
GO