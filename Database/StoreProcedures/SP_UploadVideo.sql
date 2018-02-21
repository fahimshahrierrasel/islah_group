CREATE PROCEDURE SP_UploadVideo
(
  @Text VARCHAR(300),
  @VideoUrl VARCHAR(300)
)
AS
BEGIN

  INSERT INTO Videos (VideoText, UploadDate, VideoUrl, Status) VALUES (@Text, GETDATE(), @VideoUrl, 'ACT');

END
GO