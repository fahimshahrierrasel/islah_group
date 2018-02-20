CREATE PROCEDURE SP_DeleteDeposit 
(
  @DepositId INT,
  @MemberId INT
)
AS
BEGIN

  DECLARE @CurrentMemberAmount DECIMAL(10, 2);
  DECLARE @UpdatedMemberAmount DECIMAL(10, 2);
  DECLARE @CurrentCapital DECIMAL(12, 2);
  DECLARE @UpdatedCapital DECIMAL(12, 2);
  DECLARE @CurrentAmount DECIMAL(10,2);

SELECT
  @CurrentAmount = Amount
FROM MemberDeposit
WHERE DepositId = @DepositId;

SELECT
  @CurrentMemberAmount = MemberAmount.Amount
FROM MemberAmount
WHERE MemberAmount.IGMember_MemberId = @MemberId;

SELECT
  @CurrentCapital = Capital.CurrentAmount
FROM Capital
WHERE Capital.CapitalId = 1;

SET @UpdatedMemberAmount = @CurrentMemberAmount - @CurrentAmount;
SET @UpdatedCapital = @CurrentCapital - @CurrentAmount;

UPDATE MemberAmount
SET Amount = @UpdatedMemberAmount
WHERE IGMember_MemberId = @MemberId;

UPDATE Capital
SET CurrentAmount = @UpdatedCapital
WHERE CapitalId = 1;

DELETE FROM MemberDeposit
Where MemberDeposit.DepositId = @DepositId;

END
GO