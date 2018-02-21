CREATE PROCEDURE SP_UploadImage
(
  @Text VARCHAR(300),
  @ImageUrl VARCHAR(300)
)
AS
BEGIN

  INSERT INTO Images (ImageText, UploadDate, ImageUrl, Status) VALUES (@Text, GETDATE(), @ImageUrl, 'ACT');

END
GO