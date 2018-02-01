CREATE PROCEDURE GetMembers
AS
BEGIN
	SET NOCOUNT ON;
	SELECT MemberId,ShareNo,FullName,MobileNo,Email
	FROM IGMember;
END