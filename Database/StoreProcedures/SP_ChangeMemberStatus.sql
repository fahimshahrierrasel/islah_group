CREATE PROCEDURE SP_ChangeMemberStatus
(
  @MemberId INT,
  @Status VARCHAR(5)
)
AS
BEGIN
  UPDATE MemberStatus
    SET Status = @Status
    WHERE IGMember_MemberId = @MemberId;
END
GO