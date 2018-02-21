CREATE PROCEDURE SP_GetAllVideos
AS
BEGIN

  SELECT VideoId, VideoText, UploadDate, VideoUrl, Status FROM Videos

END
GO