use IslahGroup
Create Procedure InsertDeposit
(
	@DepositDate Date,
	@Amount decimal(10,2),
	@Note varchar(300),
	@MemberId int,
	@UserId int
)
AS
BEGIN
INSERT INTO MemberDeposit
(
	DipositDate,
	Amount,
	Note,
	IGMember_MemberId,
	IGUser_UserId
)
VALUES
(
	@DepositDate,
	@Amount,
	@Note,
	@MemberId,
	@UserId
)
DECLARE @CurrentMemberAmount decimal(10,2);
DECLARE @UpdatedMemberAmount decimal(10,2);
DECLARE @CurrentCapital decimal(12,2);
DECLARE @UpdatedCapital decimal(12,2);
DECLARE @CurrentTotalDeposit decimal(14,2);
DECLARE @UpdatedTotalDeposit decimal(14,2);

SELECT @CurrentMemberAmount = MemberAmount.Amount FROM MemberAmount
WHERE MemberAmount.IGMember_MemberId = @MemberId;

SELECT @CurrentCapital = Capital.CurrentAmount, @CurrentTotalDeposit = Capital.TotalDeposit FROM Capital
WHERE Capital.CapitalId = 1;

SET @UpdatedMemberAmount = @CurrentMemberAmount + @Amount;
SET @UpdatedCapital = @CurrentCapital + @Amount;
SET @UpdatedTotalDeposit = @CurrentTotalDeposit + @Amount;

UPDATE MemberAmount SET Amount = @UpdatedMemberAmount WHERE IGMember_MemberId = @MemberId;
UPDATE Capital SET CurrentAmount = @UpdatedCapital, TotalDeposit = @UpdatedTotalDeposit
WHERE CapitalId = 1;

END
GO

