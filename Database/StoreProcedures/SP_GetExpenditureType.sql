﻿ALTER PROCEDURE dbo.SP_GetExpenditureType
AS
BEGIN
SELECT
  Type
FROM ExpenType;
END
GO