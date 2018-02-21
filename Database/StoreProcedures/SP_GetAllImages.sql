CREATE PROCEDURE SP_GetAllImages
AS
BEGIN

  SELECT ImageId, ImageText, UploadDate, ImageUrl, Status FROM Images

END
GO